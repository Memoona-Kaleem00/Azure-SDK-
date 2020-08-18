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
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> Configures flow log and traffic analytics (optional) on a specified resource. </summary>
    public partial class NetworkWatchersSetFlowLogConfigurationOperation : Operation<FlowLogInformation>, IOperationSource<FlowLogInformation>
    {
        private readonly ArmOperationHelpers<FlowLogInformation> _operation;
        internal NetworkWatchersSetFlowLogConfigurationOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<FlowLogInformation>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "NetworkWatchersSetFlowLogConfigurationOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override FlowLogInformation Value => _operation.Value;

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
        public override ValueTask<Response<FlowLogInformation>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<FlowLogInformation>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        FlowLogInformation IOperationSource<FlowLogInformation>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return FlowLogInformation.DeserializeFlowLogInformation(document.RootElement);
        }

        async ValueTask<FlowLogInformation> IOperationSource<FlowLogInformation>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return FlowLogInformation.DeserializeFlowLogInformation(document.RootElement);
        }
    }
}
