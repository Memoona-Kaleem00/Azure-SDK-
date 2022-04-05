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
using Microsoft.Azure.Management.HealthcareApis.Models;

namespace Microsoft.Azure.Management.HealthcareApis
{
    /// <summary> Patch workspace details. </summary>
    public partial class WorkspacesUpdateOperation : Operation<Workspace>, IOperationSource<Workspace>
    {
        private readonly ArmOperationHelpers<Workspace> _operation;
        internal WorkspacesUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<Workspace>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "WorkspacesUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override Workspace Value => _operation.Value;

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
        public override ValueTask<Response<Workspace>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<Workspace>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        Workspace IOperationSource<Workspace>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return Workspace.DeserializeWorkspace(document.RootElement);
        }

        async ValueTask<Workspace> IOperationSource<Workspace>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return Workspace.DeserializeWorkspace(document.RootElement);
        }
    }
}
