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
    /// <summary> Create a port mirroring profile by id in a private cloud workload network. </summary>
    public partial class WorkloadNetworkCreatePortMirroringOperation : Operation<WorkloadNetworkPortMirroring>, IOperationSource<WorkloadNetworkPortMirroring>
    {
        private readonly OperationInternals<WorkloadNetworkPortMirroring> _operation;

        /// <summary> Initializes a new instance of WorkloadNetworkCreatePortMirroringOperation for mocking. </summary>
        protected WorkloadNetworkCreatePortMirroringOperation()
        {
        }

        internal WorkloadNetworkCreatePortMirroringOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<WorkloadNetworkPortMirroring>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "WorkloadNetworkCreatePortMirroringOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override WorkloadNetworkPortMirroring Value => _operation.Value;

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
        public override ValueTask<Response<WorkloadNetworkPortMirroring>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<WorkloadNetworkPortMirroring>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        WorkloadNetworkPortMirroring IOperationSource<WorkloadNetworkPortMirroring>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return WorkloadNetworkPortMirroring.DeserializeWorkloadNetworkPortMirroring(document.RootElement);
        }

        async ValueTask<WorkloadNetworkPortMirroring> IOperationSource<WorkloadNetworkPortMirroring>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return WorkloadNetworkPortMirroring.DeserializeWorkloadNetworkPortMirroring(document.RootElement);
        }
    }
}
