// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Update sharing profile of a gallery. </summary>
    public partial class GallerySharingProfileUpdateOperation : Operation<SharingUpdate>, IOperationSource<SharingUpdate>
    {
        private readonly OperationInternals<SharingUpdate> _operation;

        /// <summary> Initializes a new instance of GallerySharingProfileUpdateOperation for mocking. </summary>
        protected GallerySharingProfileUpdateOperation()
        {
        }

        internal GallerySharingProfileUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SharingUpdate>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "GallerySharingProfileUpdateOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SharingUpdate Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SharingUpdate>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SharingUpdate>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SharingUpdate IOperationSource<SharingUpdate>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return SharingUpdate.DeserializeSharingUpdate(document.RootElement);
        }

        async ValueTask<SharingUpdate> IOperationSource<SharingUpdate>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return SharingUpdate.DeserializeSharingUpdate(document.RootElement);
        }
    }
}
