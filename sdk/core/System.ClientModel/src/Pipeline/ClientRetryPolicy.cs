﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Internal;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.ClientModel.Primitives;

/// <summary>
/// A <see cref="PipelinePolicy"/> used by a <see cref="ClientPipeline"/> to
/// decide whether or not to retry a <see cref="PipelineRequest"/>.
/// </summary>
public class ClientRetryPolicy : PipelinePolicy
{
    /// <summary>
    /// The <see cref="ClientRetryPolicy"/> instance used by a default
    /// <see cref="ClientPipeline"/>.
    /// </summary>
    public static ClientRetryPolicy Default { get; } = new ClientRetryPolicy();

    private const int DefaultMaxRetries = 3;
    private static readonly TimeSpan DefaultInitialDelay = TimeSpan.FromSeconds(0.8);
    private static readonly TimeSpan DefaultMaxDelay = TimeSpan.FromMinutes(1);

    private readonly int _maxRetries;
    private readonly TimeSpan _initialDelay;
    private readonly TimeSpan _maxDelay;

    private readonly bool _enabled;

    /// <summary>
    /// Creates a new instance of the <see cref="ClientRetryPolicy"/> class.
    /// </summary>
    /// <param name="maxRetries">The maximum number of retries to attempt.</param>
    public ClientRetryPolicy(int maxRetries = DefaultMaxRetries)
    {
        _maxRetries = maxRetries;
        _initialDelay = DefaultInitialDelay;
    }

    /// <summary>
    /// Creates a new instance of the <see cref="ClientRetryPolicy"/> class.
    /// </summary>
    /// <param name="options">Options used to construct the
    /// <see cref="ClientRetryPolicy"/>.</param>
    public ClientRetryPolicy(ClientRetryOptions options)
    {
        AssertVersion(options);

        bool disableRetries = options.DisableRetries.HasValue && options.DisableRetries.Value;
        _enabled = !disableRetries;

        _maxRetries = options.MaxRetries ?? DefaultMaxRetries;
        _maxDelay = options.MaxDelay ?? DefaultMaxDelay;
    }

    private void AssertVersion(ClientRetryOptions options)
    {
        // if ("highest version set by user" > "highest version known to target type")
        //    throw new NotSupportedException();

        bool isDerivedType = GetType() != Default.GetType();
        ClientRetryOptionsVersion supportedVersion = ClientRetryOptionsVersion.V1_2_0;

        if (isDerivedType)
        {
            supportedVersion = SupportedOptionsVersion ?? ClientRetryOptionsVersion.V1_1_0;
        }

        ClientRetryOptionsVersion highestSetOptionVersion = GetHighestSetOptionVersion(options);

        if (highestSetOptionVersion > supportedVersion)
        {
            throw new NotSupportedException($"Custom retry policy of type '{GetType()}' does " +
                $"not support ClientRetryOptions version {highestSetOptionVersion}. " +
                $"Highest options version this policy supports is {supportedVersion}.");
        }
    }

    /// <inheritdoc/>
    public sealed override void Process(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
        => ProcessSyncOrAsync(message, pipeline, currentIndex, async: false).EnsureCompleted();

    /// <inheritdoc/>
    public sealed override async ValueTask ProcessAsync(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex)
        => await ProcessSyncOrAsync(message, pipeline, currentIndex, async: true).ConfigureAwait(false);

    private async ValueTask ProcessSyncOrAsync(PipelineMessage message, IReadOnlyList<PipelinePolicy> pipeline, int currentIndex, bool async)
    {
        // If retries were disabled via ClientRetryOptions, behave as a base
        // PipelinePolicy and simply pass the message on to the next policy.
        if (!_enabled)
        {
            if (async)
            {
                await ProcessNextAsync(message, pipeline, currentIndex).ConfigureAwait(false);
            }
            else
            {
                ProcessNext(message, pipeline, currentIndex);
            }

            return;
        }

        // Policy is enabled, implement retry logic.

        List<Exception>? allTryExceptions = null;

        while (true)
        {
            Exception? thisTryException = null;

            if (async)
            {
                await OnSendingRequestAsync(message).ConfigureAwait(false);
            }
            else
            {
                OnSendingRequest(message);
            }

            try
            {
                if (async)
                {
                    await ProcessNextAsync(message, pipeline, currentIndex).ConfigureAwait(false);
                }
                else
                {
                    ProcessNext(message, pipeline, currentIndex);
                }
            }
            catch (Exception ex)
            {
                allTryExceptions ??= new List<Exception>();
                allTryExceptions.Add(ex);

                thisTryException = ex;
            }

            if (async)
            {
                await OnRequestSentAsync(message).ConfigureAwait(false);
            }
            else
            {
                OnRequestSent(message);
            }

            bool shouldRetry = async ?
                await ShouldRetryInternalAsync(message, thisTryException).ConfigureAwait(false) :
                ShouldRetryInternal(message, thisTryException);

            if (shouldRetry)
            {
                TimeSpan delay = GetNextDelay(message, message.RetryCount);

                // Reset delay so it doesn't exceed the configured max delay.
                if (delay > _maxDelay)
                {
                    delay = _maxDelay;
                }

                if (delay > TimeSpan.Zero)
                {
                    if (async)
                    {
                        await WaitAsync(delay, message.CancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        Wait(delay, message.CancellationToken);
                    }
                }

                // Dispose the content stream to free up a connection if the request has any
                message.Response?.ContentStream?.Dispose();

                message.RetryCount++;
                OnTryComplete(message);

                continue;
            }

            if (thisTryException != null)
            {
                // Rethrow if there's only one exception.
                if (allTryExceptions!.Count == 1)
                {
                    ExceptionDispatchInfo.Capture(thisTryException).Throw();
                }

                throw new AggregateException($"Retry failed after {message.RetryCount + 1} tries.", allTryExceptions);
            }

            // ShouldRetry returned false this iteration and the last request
            // we sent didn't cause an exception to be thrown.
            // So, we're done.  Exit the while loop.
            break;
        }
    }

    /// <summary>
    /// A method that can be overridden by derived types to extend the default
    /// <see cref="ClientRetryPolicy"/> logic.  It is called from
    /// <see cref="Process(PipelineMessage, IReadOnlyList{PipelinePolicy}, int)"/>
    /// prior to passing control to the next policy in the pipeline.
    /// </summary>
    /// <param name="message">The <see cref="PipelineMessage"/> containing the
    /// <see cref="PipelineRequest"/> to be sent to the service.</param>
    protected virtual void OnSendingRequest(PipelineMessage message) { }

    /// <summary>
    /// A method that can be overridden by derived types to extend the default
    /// <see cref="ClientRetryPolicy"/> logic.  It is called from
    /// <see cref="Process(PipelineMessage, IReadOnlyList{PipelinePolicy}, int)"/>
    /// prior to passing control to the next policy in the pipeline.
    /// </summary>
    /// <param name="message">The <see cref="PipelineMessage"/> containing the
    /// <see cref="PipelineRequest"/> to be sent to the service.</param>
    protected virtual ValueTask OnSendingRequestAsync(PipelineMessage message) => default;

    /// <summary>
    /// A method that can be overridden by derived types to extend the default
    /// <see cref="ClientRetryPolicy"/> logic.  It is called from
    /// <see cref="Process(PipelineMessage, IReadOnlyList{PipelinePolicy}, int)"/>
    /// just after control has been returned from the policy at the position
    /// after the retry policy in the pipeline.
    /// </summary>
    /// <param name="message">The <see cref="PipelineMessage"/> containing the
    /// <see cref="PipelineResponse"/> that was received from the service.</param>
    protected virtual void OnRequestSent(PipelineMessage message) { }

    /// <summary>
    /// A method that can be overridden by derived types to extend the default
    /// <see cref="ClientRetryPolicy"/> logic.  It is called from
    /// <see cref="Process(PipelineMessage, IReadOnlyList{PipelinePolicy}, int)"/>
    /// just after control has been returned from the policy at the position
    /// after the retry policy in the pipeline.
    /// </summary>
    /// <param name="message">The <see cref="PipelineMessage"/> containing the
    /// <see cref="PipelineResponse"/> that was received from the service.</param>
    protected virtual ValueTask OnRequestSentAsync(PipelineMessage message) => default;

    /// <summary>
    /// A method that can be overridden by derived types to extend the default
    /// <see cref="ClientRetryPolicy"/> logic.  It is called from
    /// <see cref="Process(PipelineMessage, IReadOnlyList{PipelinePolicy}, int)"/>
    /// after the time interval for the current retry attempt has passed.
    /// </summary>
    /// <param name="message">The <see cref="PipelineMessage"/> for this
    /// pipeline invocation.</param>
    protected virtual void OnTryComplete(PipelineMessage message) { }

    internal bool ShouldRetryInternal(PipelineMessage message, Exception? exception)
        => ShouldRetryInternalSyncOrAsync(message, exception, async: false).EnsureCompleted();

    internal async ValueTask<bool> ShouldRetryInternalAsync(PipelineMessage message, Exception? exception)
        => await ShouldRetryInternalSyncOrAsync(message, exception, async: true).ConfigureAwait(false);

    private async ValueTask<bool> ShouldRetryInternalSyncOrAsync(PipelineMessage message, Exception? exception, bool async)
    {
        // If there was no exception and we got a success response, don't retry.
        if (exception is null && message.Response is not null && !message.Response.IsError)
        {
            return false;
        }

        if (async)
        {
            return await ShouldRetryAsync(message, exception).ConfigureAwait(false);
        }
        else
        {
            return ShouldRetry(message, exception);
        }
    }

    /// <summary>
    /// A method that can be overridden by derived types to customize the default
    /// <see cref="ClientRetryPolicy"/> logic. It is called from
    /// <see cref="Process(PipelineMessage, IReadOnlyList{PipelinePolicy}, int)"/>
    /// after control has been returned from the policy at the position
    /// after the retry policy in the pipeline.
    /// </summary>
    /// <param name="message">The <see cref="PipelineMessage"/> for this
    /// pipeline invocation.</param>
    /// <param name="exception">The exception, if any, that was thrown from
    /// a policy after the retry policy in the pipeline.</param>
    protected virtual bool ShouldRetry(PipelineMessage message, Exception? exception)
    {
        if (message.RetryCount >= _maxRetries)
        {
            // We've exceeded the maximum number of retries, so don't retry.
            return false;
        }

        if (!message.ResponseClassifier.TryClassify(message, exception, out bool isRetriable))
        {
            bool classified = PipelineMessageClassifier.Default.TryClassify(message, exception, out isRetriable);

            Debug.Assert(classified);
        }

        return isRetriable;
    }

    /// <summary>
    /// A method that can be overridden by derived types to customize the default
    /// <see cref="ClientRetryPolicy"/> logic. It is called from
    /// <see cref="Process(PipelineMessage, IReadOnlyList{PipelinePolicy}, int)"/>
    /// after control has been returned from the policy at the position
    /// after the retry policy in the pipeline.
    /// </summary>
    /// <param name="message">The <see cref="PipelineMessage"/> for this
    /// pipeline invocation.</param>
    /// <param name="exception">The exception, if any, that was thrown from
    /// a policy after the retry policy in the pipeline.</param>
    protected virtual ValueTask<bool> ShouldRetryAsync(PipelineMessage message, Exception? exception)
        => new(ShouldRetry(message, exception));

    /// <summary>
    /// A method that can be overridden by derived types to customize the default
    /// <see cref="ClientRetryPolicy"/> logic. It is called from
    /// <see cref="Process(PipelineMessage, IReadOnlyList{PipelinePolicy}, int)"/>
    /// to determine how long the policy should wait before re-sending the request.
    /// </summary>
    /// <param name="message">The <see cref="PipelineMessage"/> for this
    /// pipeline invocation.</param>
    /// <param name="tryCount">A number indicating how many times the policy has
    /// tried to send the request.</param>
    /// <returns>The amount of time to wait before the next retry attempt.
    /// </returns>
    protected virtual TimeSpan GetNextDelay(PipelineMessage message, int tryCount)
    {
        // Default implementation is exponential backoff, unless the response
        // has a retry-after header.
        double nextDelayMilliseconds = (1 << (tryCount - 1)) * _initialDelay.TotalMilliseconds;

        if (message.Response is not null &&
            PipelineResponseHeaders.TryGetRetryAfter(message.Response, out TimeSpan retryAfter) &&
            retryAfter.TotalMilliseconds > nextDelayMilliseconds)
        {
            return retryAfter;
        }

        return TimeSpan.FromMilliseconds(nextDelayMilliseconds);
    }

    /// <summary>
    /// A method that can be overridden by derived types to customize the default
    /// <see cref="ClientRetryPolicy"/> logic. It is called from
    /// <see cref="Process(PipelineMessage, IReadOnlyList{PipelinePolicy}, int)"/>
    /// to wait the time interval returned by <see cref="GetNextDelay(PipelineMessage, int)"/>.
    /// </summary>
    /// <param name="time">The amount of time to wait before trying to send the
    /// request again.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/> used
    /// to cancel the wait if needed.</param>
    /// <returns>A task that can be awaited to asynchronously delay before the
    /// next retry attempt.</returns>
    protected virtual async Task WaitAsync(TimeSpan time, CancellationToken cancellationToken)
    {
        await Task.Delay(time, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// A method that can be overridden by derived types to customize the default
    /// <see cref="ClientRetryPolicy"/> logic. It is called from
    /// <see cref="Process(PipelineMessage, IReadOnlyList{PipelinePolicy}, int)"/>
    /// to wait the time interval returned by <see cref="GetNextDelay(PipelineMessage, int)"/>.
    /// </summary>
    /// <param name="time">The amount of time to wait before trying to send the
    /// request again.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/> used
    /// to cancel the wait if needed.</param>
    protected virtual void Wait(TimeSpan time, CancellationToken cancellationToken)
    {
        if (cancellationToken.WaitHandle.WaitOne(time))
        {
            CancellationHelper.ThrowIfCancellationRequested(cancellationToken);
        }
    }

    /// <summary>
    /// Highest version supported by a derived type providing a customized
    /// implementation of <see cref="ClientRetryPolicy"/>.
    /// </summary>
    protected virtual ClientRetryOptionsVersion? SupportedOptionsVersion => default;

    /// <summary>
    /// Get the highest version corresponding to an option that is set on the
    /// options instance.  If an option is not set on the options instance, its
    /// version is not considered.
    /// </summary>
    /// <param name="options"></param>
    /// <returns></returns>
    private static ClientRetryOptionsVersion GetHighestSetOptionVersion(ClientRetryOptions options)
    {
        ClientRetryOptionsVersion maxVersionSet = ClientRetryOptionsVersion.V1_1_0;

        if (options.DisableRetries != null && ClientRetryOptionsVersion.V1_2_0 > maxVersionSet)
        {
            maxVersionSet = ClientRetryOptionsVersion.V1_2_0;
        }

        if (options.MaxDelay != null && ClientRetryOptionsVersion.V1_2_0 > maxVersionSet)
        {
            maxVersionSet = ClientRetryOptionsVersion.V1_2_0;
        }

        if (options.MaxRetries != null && ClientRetryOptionsVersion.V1_2_0 > maxVersionSet)
        {
            maxVersionSet = ClientRetryOptionsVersion.V1_2_0;
        }

        return maxVersionSet;
    }

    /// <summary>
    /// Mapping from option properties available in
    /// <see cref="ClientRetryOptions"/> to the version that that option was
    /// added to the options type.
    /// </summary>
    protected enum ClientRetryOptionsVersion
    {
        /// <summary>
        /// No ClientRetryOptions available in SCM 1.1.0.
        /// </summary>
        V1_1_0 = 1,

        /// <summary>
        /// Added DisableRetries, MaxDelay, MaxRetries options in SCM 1.2.0.
        /// </summary>
        V1_2_0 = 2,
    }
}
