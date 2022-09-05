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

namespace Azure.ResourceManager.FrontDoor
{
    internal class FrontDoorWebApplicationFirewallPolicyOperationSource : IOperationSource<FrontDoorWebApplicationFirewallPolicyResource>
    {
        private readonly ArmClient _client;

        internal FrontDoorWebApplicationFirewallPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        FrontDoorWebApplicationFirewallPolicyResource IOperationSource<FrontDoorWebApplicationFirewallPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FrontDoorWebApplicationFirewallPolicyData.DeserializeFrontDoorWebApplicationFirewallPolicyData(document.RootElement);
            return new FrontDoorWebApplicationFirewallPolicyResource(_client, data);
        }

        async ValueTask<FrontDoorWebApplicationFirewallPolicyResource> IOperationSource<FrontDoorWebApplicationFirewallPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FrontDoorWebApplicationFirewallPolicyData.DeserializeFrontDoorWebApplicationFirewallPolicyData(document.RootElement);
            return new FrontDoorWebApplicationFirewallPolicyResource(_client, data);
        }
    }
}
