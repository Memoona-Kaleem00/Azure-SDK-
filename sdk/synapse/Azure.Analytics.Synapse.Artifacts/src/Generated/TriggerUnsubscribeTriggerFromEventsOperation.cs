// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> Unsubscribe event trigger from events. </summary>
    public partial class TriggerUnsubscribeTriggerFromEventsOperation : Operation<TriggerSubscriptionOperationStatus>, IOperationSource<TriggerSubscriptionOperationStatus>
    {
        private readonly OperationInternal<TriggerSubscriptionOperationStatus> _operation;

        /// <summary> Initializes a new instance of TriggerUnsubscribeTriggerFromEventsOperation for mocking. </summary>
        protected TriggerUnsubscribeTriggerFromEventsOperation()
        {
        }

        internal TriggerUnsubscribeTriggerFromEventsOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            IOperation<TriggerSubscriptionOperationStatus> nextLinkOperation = NextLinkOperationImplementation.Create(this, pipeline, request.Method, request.Uri.ToUri(), response, OperationFinalStateVia.Location);
            _operation = new OperationInternal<TriggerSubscriptionOperationStatus>(nextLinkOperation, clientDiagnostics, response, "TriggerUnsubscribeTriggerFromEventsOperation");
        }

        /// <inheritdoc />
#pragma warning disable CA1822
        public override string Id => throw new NotImplementedException();
#pragma warning restore CA1822

        /// <inheritdoc />
        public override TriggerSubscriptionOperationStatus Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.RawResponse;

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override Response<TriggerSubscriptionOperationStatus> WaitForCompletion(CancellationToken cancellationToken = default) => _operation.WaitForCompletion(cancellationToken);

        /// <inheritdoc />
        public override Response<TriggerSubscriptionOperationStatus> WaitForCompletion(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletion(pollingInterval, cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<TriggerSubscriptionOperationStatus>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<TriggerSubscriptionOperationStatus>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        TriggerSubscriptionOperationStatus IOperationSource<TriggerSubscriptionOperationStatus>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return TriggerSubscriptionOperationStatus.DeserializeTriggerSubscriptionOperationStatus(document.RootElement);
        }

        async ValueTask<TriggerSubscriptionOperationStatus> IOperationSource<TriggerSubscriptionOperationStatus>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return TriggerSubscriptionOperationStatus.DeserializeTriggerSubscriptionOperationStatus(document.RootElement);
        }
    }
}
