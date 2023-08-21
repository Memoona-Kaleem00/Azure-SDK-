// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    internal class DdosProtectionPlanOperationSource : Core.IOperationSource<DdosProtectionPlanResource>
    {
        private readonly ArmClient _client;

        internal DdosProtectionPlanOperationSource(ArmClient client)
        {
            _client = client;
        }

        DdosProtectionPlanResource Core.IOperationSource<DdosProtectionPlanResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DdosProtectionPlanData.DeserializeDdosProtectionPlanData(document.RootElement);
            return new DdosProtectionPlanResource(_client, data);
        }

        async ValueTask<DdosProtectionPlanResource> Core.IOperationSource<DdosProtectionPlanResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DdosProtectionPlanData.DeserializeDdosProtectionPlanData(document.RootElement);
            return new DdosProtectionPlanResource(_client, data);
        }
    }
}
