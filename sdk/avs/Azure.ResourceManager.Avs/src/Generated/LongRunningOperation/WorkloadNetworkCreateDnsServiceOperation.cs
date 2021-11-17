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

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Create a DNS service by id in a private cloud workload network. </summary>
    public partial class WorkloadNetworkCreateDnsServiceOperation : Operation<WorkloadNetworkDnsService>, IOperationSource<WorkloadNetworkDnsService>
    {
        private readonly OperationInternals<WorkloadNetworkDnsService> _operation;

        /// <summary> Initializes a new instance of WorkloadNetworkCreateDnsServiceOperation for mocking. </summary>
        protected WorkloadNetworkCreateDnsServiceOperation()
        {
        }

        internal WorkloadNetworkCreateDnsServiceOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<WorkloadNetworkDnsService>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "WorkloadNetworkCreateDnsServiceOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override WorkloadNetworkDnsService Value => _operation.Value;

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
        public override ValueTask<Response<WorkloadNetworkDnsService>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<WorkloadNetworkDnsService>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        WorkloadNetworkDnsService IOperationSource<WorkloadNetworkDnsService>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return WorkloadNetworkDnsService.DeserializeWorkloadNetworkDnsService(document.RootElement);
        }

        async ValueTask<WorkloadNetworkDnsService> IOperationSource<WorkloadNetworkDnsService>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return WorkloadNetworkDnsService.DeserializeWorkloadNetworkDnsService(document.RootElement);
        }
    }
}
