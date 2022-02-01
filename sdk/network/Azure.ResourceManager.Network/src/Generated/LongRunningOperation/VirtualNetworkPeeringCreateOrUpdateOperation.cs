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
using Azure.ResourceManager;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Creates or updates a peering in the specified virtual network. </summary>
    public partial class VirtualNetworkPeeringCreateOrUpdateOperation : Operation<VirtualNetworkPeering>, IOperationSource<VirtualNetworkPeering>
    {
        private readonly OperationInternals<VirtualNetworkPeering> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of VirtualNetworkPeeringCreateOrUpdateOperation for mocking. </summary>
        protected VirtualNetworkPeeringCreateOrUpdateOperation()
        {
        }

        internal VirtualNetworkPeeringCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualNetworkPeering>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "VirtualNetworkPeeringCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualNetworkPeering Value => _operation.Value;

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
        public override ValueTask<Response<VirtualNetworkPeering>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualNetworkPeering>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualNetworkPeering IOperationSource<VirtualNetworkPeering>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualNetworkPeeringData.DeserializeVirtualNetworkPeeringData(document.RootElement);
            return new VirtualNetworkPeering(_armClient, data);
        }

        async ValueTask<VirtualNetworkPeering> IOperationSource<VirtualNetworkPeering>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualNetworkPeeringData.DeserializeVirtualNetworkPeeringData(document.RootElement);
            return new VirtualNetworkPeering(_armClient, data);
        }
    }
}
