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
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The operation to create or update the VMSS VM extension. </summary>
    public partial class VirtualMachineScaleSetVMExtensionCreateOrUpdateOperation : Operation<VirtualMachineScaleSetVMExtension>, IOperationSource<VirtualMachineScaleSetVMExtension>
    {
        private readonly OperationInternals<VirtualMachineScaleSetVMExtension> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMExtensionCreateOrUpdateOperation for mocking. </summary>
        protected VirtualMachineScaleSetVMExtensionCreateOrUpdateOperation()
        {
        }

        internal VirtualMachineScaleSetVMExtensionCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualMachineScaleSetVMExtension>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualMachineScaleSetVMExtensionCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualMachineScaleSetVMExtension Value => _operation.Value;

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
        public override ValueTask<Response<VirtualMachineScaleSetVMExtension>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualMachineScaleSetVMExtension>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualMachineScaleSetVMExtension IOperationSource<VirtualMachineScaleSetVMExtension>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new VirtualMachineScaleSetVMExtension(_operationBase, VirtualMachineScaleSetVMExtensionData.DeserializeVirtualMachineScaleSetVMExtensionData(document.RootElement));
        }

        async ValueTask<VirtualMachineScaleSetVMExtension> IOperationSource<VirtualMachineScaleSetVMExtension>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new VirtualMachineScaleSetVMExtension(_operationBase, VirtualMachineScaleSetVMExtensionData.DeserializeVirtualMachineScaleSetVMExtensionData(document.RootElement));
        }
    }
}
