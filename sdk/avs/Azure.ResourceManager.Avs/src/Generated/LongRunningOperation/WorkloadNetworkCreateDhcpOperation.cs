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
using Azure.ResourceManager.Avs;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Create dhcp by id in a private cloud workload network. </summary>
    public partial class WorkloadNetworkCreateDhcpOperation : Operation<WorkloadNetworkDhcp>, IOperationSource<WorkloadNetworkDhcp>
    {
        private readonly OperationInternals<WorkloadNetworkDhcp> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of WorkloadNetworkCreateDhcpOperation for mocking. </summary>
        protected WorkloadNetworkCreateDhcpOperation()
        {
        }

        internal WorkloadNetworkCreateDhcpOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<WorkloadNetworkDhcp>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "WorkloadNetworkCreateDhcpOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override WorkloadNetworkDhcp Value => _operation.Value;

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
        public override ValueTask<Response<WorkloadNetworkDhcp>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<WorkloadNetworkDhcp>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        WorkloadNetworkDhcp IOperationSource<WorkloadNetworkDhcp>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = WorkloadNetworkDhcpData.DeserializeWorkloadNetworkDhcpData(document.RootElement);
            return new WorkloadNetworkDhcp(_operationBase, data);
        }

        async ValueTask<WorkloadNetworkDhcp> IOperationSource<WorkloadNetworkDhcp>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = WorkloadNetworkDhcpData.DeserializeWorkloadNetworkDhcpData(document.RootElement);
            return new WorkloadNetworkDhcp(_operationBase, data);
        }
    }
}
