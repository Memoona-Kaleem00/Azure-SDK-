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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> Updates a managed database&apos;s short term retention policy. </summary>
    public partial class ManagedBackupShortTermRetentionPoliciesUpdateOperation : Operation<ManagedBackupShortTermRetentionPolicy>, IOperationSource<ManagedBackupShortTermRetentionPolicy>
    {
        private readonly ArmOperationHelpers<ManagedBackupShortTermRetentionPolicy> _operation;
        internal ManagedBackupShortTermRetentionPoliciesUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<ManagedBackupShortTermRetentionPolicy>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ManagedBackupShortTermRetentionPoliciesUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ManagedBackupShortTermRetentionPolicy Value => _operation.Value;

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
        public override ValueTask<Response<ManagedBackupShortTermRetentionPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagedBackupShortTermRetentionPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ManagedBackupShortTermRetentionPolicy IOperationSource<ManagedBackupShortTermRetentionPolicy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ManagedBackupShortTermRetentionPolicy.DeserializeManagedBackupShortTermRetentionPolicy(document.RootElement);
        }

        async ValueTask<ManagedBackupShortTermRetentionPolicy> IOperationSource<ManagedBackupShortTermRetentionPolicy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ManagedBackupShortTermRetentionPolicy.DeserializeManagedBackupShortTermRetentionPolicy(document.RootElement);
        }
    }
}
