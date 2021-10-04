// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Creates an authorization rule for a queue. </summary>
    public partial class QueueAuthorizationRuleCreateOrUpdateOperation : Operation<SBAuthorizationRuleQueue>
    {
        private readonly OperationOrResponseInternals<SBAuthorizationRuleQueue> _operation;

        /// <summary> Initializes a new instance of QueueAuthorizationRuleCreateOrUpdateOperation for mocking. </summary>
        protected QueueAuthorizationRuleCreateOrUpdateOperation()
        {
        }

        internal QueueAuthorizationRuleCreateOrUpdateOperation(ArmResource operationsBase, Response<SBAuthorizationRuleData> response)
        {
            _operation = new OperationOrResponseInternals<SBAuthorizationRuleQueue>(Response.FromValue(new SBAuthorizationRuleQueue(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SBAuthorizationRuleQueue Value => _operation.Value;

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
        public override ValueTask<Response<SBAuthorizationRuleQueue>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SBAuthorizationRuleQueue>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
