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
    /// <summary> Create or update a cloud link in a private cloud. </summary>
    public partial class CloudLinkCreateOrUpdateOperation : Operation<CloudLink>, IOperationSource<CloudLink>
    {
        private readonly OperationInternals<CloudLink> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of CloudLinkCreateOrUpdateOperation for mocking. </summary>
        protected CloudLinkCreateOrUpdateOperation()
        {
        }

        internal CloudLinkCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<CloudLink>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "CloudLinkCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override CloudLink Value => _operation.Value;

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
        public override ValueTask<Response<CloudLink>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<CloudLink>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        CloudLink IOperationSource<CloudLink>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new CloudLink(_operationBase, CloudLinkData.DeserializeCloudLinkData(document.RootElement));
        }

        async ValueTask<CloudLink> IOperationSource<CloudLink>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new CloudLink(_operationBase, CloudLinkData.DeserializeCloudLinkData(document.RootElement));
        }
    }
}
