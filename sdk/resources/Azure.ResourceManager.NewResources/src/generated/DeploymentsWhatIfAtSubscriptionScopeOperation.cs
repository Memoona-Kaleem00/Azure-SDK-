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

namespace Azure.ResourceManager.NewResources
{
    /// <summary> Returns changes that will be made by the deployment if executed at the scope of the subscription. </summary>
    public partial class DeploymentsWhatIfAtSubscriptionScopeOperation : Operation<WhatIfOperationResult>, IOperationSource<WhatIfOperationResult>
    {
        private readonly OperationInternals<WhatIfOperationResult> _operation;

        /// <summary> Initializes a new instance of DeploymentsWhatIfAtSubscriptionScopeOperation for mocking. </summary>
        protected DeploymentsWhatIfAtSubscriptionScopeOperation()
        {
        }

        internal DeploymentsWhatIfAtSubscriptionScopeOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<WhatIfOperationResult>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DeploymentsWhatIfAtSubscriptionScopeOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override WhatIfOperationResult Value => _operation.Value;

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
        public override ValueTask<Response<WhatIfOperationResult>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<WhatIfOperationResult>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        WhatIfOperationResult IOperationSource<WhatIfOperationResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return WhatIfOperationResult.DeserializeWhatIfOperationResult(document.RootElement);
        }

        async ValueTask<WhatIfOperationResult> IOperationSource<WhatIfOperationResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return WhatIfOperationResult.DeserializeWhatIfOperationResult(document.RootElement);
        }
    }
}
