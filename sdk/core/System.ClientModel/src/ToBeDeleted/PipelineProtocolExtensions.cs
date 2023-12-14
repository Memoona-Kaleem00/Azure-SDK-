// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;

namespace System.ClientModel.Internal.Remove;

// TODO: Delete this eventually.  I am keeping this as internal for now, to validate behavior and APIs I don't have
// tests for yet.
internal static class PipelineProtocolExtensions
{
    public static async ValueTask<PipelineResponse> ProcessMessageAsync(this ClientPipeline pipeline, PipelineMessage message, RequestOptions requestContext, CancellationToken cancellationToken = default)
    {
        await pipeline.SendAsync(message).ConfigureAwait(false);

        if (message.Response is null)
        {
            throw new InvalidOperationException("Failed to set message response.");
        }

        if (!message.Response.IsError || requestContext?.ErrorBehavior == ErrorBehavior.NoThrow)
        {
            return message.Response;
        }

        throw new ClientRequestException(message.Response);
    }

    public static PipelineResponse ProcessMessage(this ClientPipeline pipeline, PipelineMessage message, RequestOptions requestContext, CancellationToken cancellationToken = default)
    {
        pipeline.Send(message);

        if (message.Response is null)
        {
            throw new InvalidOperationException("Failed to set message response.");
        }

        if (!message.Response.IsError || requestContext?.ErrorBehavior == ErrorBehavior.NoThrow)
        {
            return message.Response;
        }

        throw new ClientRequestException(message.Response);
    }

    public static async ValueTask<OptionalClientResult<bool>> ProcessHeadAsBoolMessageAsync(this ClientPipeline pipeline, PipelineMessage message, RequestOptions requestContext)
    {
        PipelineResponse response = await pipeline.ProcessMessageAsync(message, requestContext).ConfigureAwait(false);
        switch (response.Status)
        {
            case >= 200 and < 300:
                return ClientResult.FromOptionalValue(true, response);
            case >= 400 and < 500:
                return ClientResult.FromOptionalValue(false, response);
            default:
                return new ErrorOutputMessage<bool>(response, new ClientRequestException(response));
        }
    }

    public static OptionalClientResult<bool> ProcessHeadAsBoolMessage(this ClientPipeline pipeline, PipelineMessage message, RequestOptions requestContext)
    {
        PipelineResponse response = pipeline.ProcessMessage(message, requestContext);
        switch (response.Status)
        {
            case >= 200 and < 300:
                return ClientResult.FromOptionalValue(true, response);
            case >= 400 and < 500:
                return ClientResult.FromOptionalValue(false, response);
            default:
                return new ErrorOutputMessage<bool>(response, new ClientRequestException(response));
        }
    }

}
