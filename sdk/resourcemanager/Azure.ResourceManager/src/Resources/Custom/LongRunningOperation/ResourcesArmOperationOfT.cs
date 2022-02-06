﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Resources
{
#pragma warning disable SA1649 // File name should match first type name
    internal class ResourcesArmOperation<T> : ArmOperation<T>
#pragma warning restore SA1649 // File name should match first type name
    {
        private readonly OperationOrResponseInternals<T> _operation;

        /// <summary> Initializes a new instance of GenericResourceCreateOrUpdateOperation for mocking. </summary>
        protected ResourcesArmOperation()
        {
        }

        internal ResourcesArmOperation(Response<T> response)
        {
            _operation = new OperationOrResponseInternals<T>(response);
        }

        internal ResourcesArmOperation(IOperationSource<T> source, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response, OperationFinalStateVia finalStateVia)
        {
            _operation = new OperationOrResponseInternals<T>(source, clientDiagnostics, pipeline, request, response, finalStateVia, "GenericResourceCreateOrUpdateOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override T Value => _operation.Value;

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
        public override ValueTask<Response<T>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<T>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
