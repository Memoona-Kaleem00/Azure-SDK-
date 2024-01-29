﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Internal;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.ClientModel.Primitives;

public abstract class PipelineTransport : PipelinePolicy
{
    #region CreateMessage
    /// <summary>
    /// TBD: needed for inheritdoc.
    /// </summary>
    public PipelineMessage CreateMessage()
    {
        PipelineMessage message = CreateMessageCore();

        if (message.Request is null)
        {
            throw new InvalidOperationException("Request was not set on message.");
        }

        if (message.Response is not null)
        {
            throw new InvalidOperationException("Response should not be set before transport is invoked.");
        }

        return message;
    }

    protected abstract PipelineMessage CreateMessageCore();
    #endregion

    #region Process message
    /// <summary>
    /// TBD: needed for inheritdoc.
    /// </summary>
    /// <param name="message"></param>
    public void Process(PipelineMessage message)
        => ProcessSyncOrAsync(message, async: false).EnsureCompleted();

    /// <summary>
    /// TBD: needed for inheritdoc.
    /// </summary>
    /// <param name="message"></param>
    public async ValueTask ProcessAsync(PipelineMessage message)
        => await ProcessSyncOrAsync(message, async: true).ConfigureAwait(false);

    private async ValueTask ProcessSyncOrAsync(PipelineMessage message, bool async)
    {
        Debug.Assert(message.NetworkTimeout is not null);
        TimeSpan networkTimeout = (TimeSpan)message.NetworkTimeout!;

        CancellationToken userToken = message.CancellationToken;
        using CancellationTokenSource joinedTokenSource = CancellationTokenSource.CreateLinkedTokenSource(userToken);
        joinedTokenSource.CancelAfter(networkTimeout);
        message.CancellationToken = joinedTokenSource.Token;

        try
        {
            if (async)
            {
                await ProcessCoreAsync(message).ConfigureAwait(false);
            }
            else
            {
                ProcessCore(message);
            }
        }
        catch (OperationCanceledException ex)
        {
            ThrowIfCancellationRequestedOrTimeout(userToken, joinedTokenSource.Token, ex, networkTimeout);
            throw;
        }
        finally
        {
            message.CancellationToken = userToken;
            joinedTokenSource.CancelAfter(Timeout.Infinite);
        }

        if (message.Response is null)
        {
            throw new InvalidOperationException("Response was not set by transport.");
        }

        message.Response.SetIsError(ClassifyResponse(message));
        message.Response.NetworkTimeout = networkTimeout;

        if (async)
        {
            await BufferResponseAsync(message, networkTimeout, userToken, joinedTokenSource).ConfigureAwait(false);
        }
        else
        {
            BufferResponse(message, networkTimeout, userToken, joinedTokenSource);
        }
    }

    protected abstract void ProcessCore(PipelineMessage message);

    protected abstract ValueTask ProcessCoreAsync(PipelineMessage message);

    private static bool ClassifyResponse(PipelineMessage message)
    {
        if (!message.MessageClassifier.TryClassify(message, out bool isError))
        {
            bool classified = PipelineMessageClassifier.Default.TryClassify(message, out isError);

            Debug.Assert(classified);
        }

        return isError;
    }

    /// <summary>Throws a cancellation exception if cancellation has been requested via <paramref name="messageToken"/> or <paramref name="timeoutToken"/>.</summary>
    /// <param name="messageToken">The user-provided token.</param>
    /// <param name="timeoutToken">The linked token that is cancelled on timeout provided token.</param>
    /// <param name="innerException">The inner exception to use.</param>
    /// <param name="timeout">The timeout used for the operation.</param>
#pragma warning disable CA1068 // Cancellation token has to be the last parameter
    private static void ThrowIfCancellationRequestedOrTimeout(CancellationToken messageToken, CancellationToken timeoutToken, Exception? innerException, TimeSpan timeout)
#pragma warning restore CA1068
    {
        CancellationHelper.ThrowIfCancellationRequested(messageToken);

        if (timeoutToken.IsCancellationRequested)
        {
            throw CancellationHelper.CreateOperationCanceledException(
                innerException,
                timeoutToken,
                $"The operation was cancelled because it exceeded the configured timeout of {timeout:g}. ");
        }
    }

    private void BufferResponse(PipelineMessage message, TimeSpan networkTimeout, CancellationToken userToken, CancellationTokenSource joinedTokenSource)
        => BufferResponseSyncOrAsync(message, networkTimeout, userToken, joinedTokenSource, async: false).EnsureCompleted();

    private async Task BufferResponseAsync(PipelineMessage message, TimeSpan networkTimeout, CancellationToken userToken, CancellationTokenSource joinedTokenSource)
     => await BufferResponseSyncOrAsync(message, networkTimeout, userToken, joinedTokenSource, async: true).ConfigureAwait(false);

    private async Task BufferResponseSyncOrAsync(PipelineMessage message, TimeSpan networkTimeout, CancellationToken userToken, CancellationTokenSource joinedTokenSource, bool async)
    {
        if (message.Response!.ContentStream is not null)
        {
            // No need to buffer the response.
            return;
        }

        if (!message.BufferResponse)
        {
            // Don't buffer the response content, e.g. in order to return
            // the network stream to the end user of the client as part of
            // a streaming API. Wrap the content stream in a read-timeout
            // stream, to respect the client's network timeout setting.
            WrapNetworkStream(message, networkTimeout);
            return;
        }

        // If cancellation is possible (either due to network timeout or a user cancellation
        // token being cancelled), then register callback to dispose the stream on cancellation.
        if (networkTimeout != Timeout.InfiniteTimeSpan || userToken.CanBeCanceled)
        {
            joinedTokenSource.Token.Register(state => ((Stream?)state)?.Dispose(), message.Response!.ContentStream!);
        }

        try
        {
            if (async)
            {
                await message.Response.BufferContentAsync(networkTimeout, joinedTokenSource).ConfigureAwait(false);
            }
            else
            {
                message.Response.BufferContent(networkTimeout, joinedTokenSource);
            }
        }
        // We dispose stream on timeout or user cancellation so catch and check if cancellation token was cancelled
        catch (Exception ex) when (ex is ObjectDisposedException
                                      or IOException
                                      or OperationCanceledException
                                      or NotSupportedException)
        {
            ThrowIfCancellationRequestedOrTimeout(userToken, joinedTokenSource.Token, ex, networkTimeout);
            throw;
        }
    }

    private static void WrapNetworkStream(PipelineMessage message, TimeSpan networkTimeout)
    {
        if (networkTimeout != Timeout.InfiniteTimeSpan)
        {
            Stream contentStream = message.Response!.ContentStream!;
            message.Response!.ContentStream = new ReadTimeoutStream(contentStream, networkTimeout);
        }
    }

    #endregion

    #region PipelinePolicy.Process overrides
    // These methods from PipelinePolicy just say "you've reached the end
    // of the line", i.e. they stop the invocation of the policy chain.
    public sealed override void Process(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
    {
        Process(message);

        Debug.Assert(++currentIndex == pipeline.Count);
    }

    public sealed override async ValueTask ProcessAsync(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
    {
        await ProcessAsync(message).ConfigureAwait(false);

        Debug.Assert(++currentIndex == pipeline.Count);
    }
    #endregion
}
