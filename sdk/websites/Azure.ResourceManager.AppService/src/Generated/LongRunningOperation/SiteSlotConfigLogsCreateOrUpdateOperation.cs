// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Updates the logging configuration of an app. </summary>
    public partial class SiteSlotConfigLogsCreateOrUpdateOperation : Operation<SiteSlotConfigLogs>
    {
        private readonly OperationOrResponseInternals<SiteSlotConfigLogs> _operation;

        /// <summary> Initializes a new instance of SiteSlotConfigLogsCreateOrUpdateOperation for mocking. </summary>
        protected SiteSlotConfigLogsCreateOrUpdateOperation()
        {
        }

        internal SiteSlotConfigLogsCreateOrUpdateOperation(ArmClient armClient, Response<SiteLogsConfigData> response)
        {
            _operation = new OperationOrResponseInternals<SiteSlotConfigLogs>(Response.FromValue(new SiteSlotConfigLogs(armClient, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SiteSlotConfigLogs Value => _operation.Value;

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
        public override ValueTask<Response<SiteSlotConfigLogs>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SiteSlotConfigLogs>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
