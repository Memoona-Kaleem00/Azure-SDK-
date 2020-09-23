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
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> Gets the sas url to get the connection health detail of P2S clients of the virtual wan P2SVpnGateway in the specified resource group. </summary>
    public partial class P2SVpnGatewaysGetP2SVpnConnectionHealthDetailedOperation : Operation<P2SVpnConnectionHealth>, IOperationSource<P2SVpnConnectionHealth>
    {
        private readonly ArmOperationHelpers<P2SVpnConnectionHealth> _operation;
        internal P2SVpnGatewaysGetP2SVpnConnectionHealthDetailedOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<P2SVpnConnectionHealth>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "P2SVpnGatewaysGetP2SVpnConnectionHealthDetailedOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override P2SVpnConnectionHealth Value => _operation.Value;

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
        public override ValueTask<Response<P2SVpnConnectionHealth>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<P2SVpnConnectionHealth>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        P2SVpnConnectionHealth IOperationSource<P2SVpnConnectionHealth>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return P2SVpnConnectionHealth.DeserializeP2SVpnConnectionHealth(document.RootElement);
        }

        async ValueTask<P2SVpnConnectionHealth> IOperationSource<P2SVpnConnectionHealth>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return P2SVpnConnectionHealth.DeserializeP2SVpnConnectionHealth(document.RootElement);
        }
    }
}
