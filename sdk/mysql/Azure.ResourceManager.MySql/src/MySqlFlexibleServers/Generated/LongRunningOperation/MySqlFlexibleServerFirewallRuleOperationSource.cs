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

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    internal class MySqlFlexibleServerFirewallRuleOperationSource : Core.IOperationSource<MySqlFlexibleServerFirewallRuleResource>
    {
        private readonly ArmClient _client;

        internal MySqlFlexibleServerFirewallRuleOperationSource(ArmClient client)
        {
            _client = client;
        }

        MySqlFlexibleServerFirewallRuleResource Core.IOperationSource<MySqlFlexibleServerFirewallRuleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MySqlFlexibleServerFirewallRuleData.DeserializeMySqlFlexibleServerFirewallRuleData(document.RootElement);
            return new MySqlFlexibleServerFirewallRuleResource(_client, data);
        }

        async ValueTask<MySqlFlexibleServerFirewallRuleResource> Core.IOperationSource<MySqlFlexibleServerFirewallRuleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MySqlFlexibleServerFirewallRuleData.DeserializeMySqlFlexibleServerFirewallRuleData(document.RootElement);
            return new MySqlFlexibleServerFirewallRuleResource(_client, data);
        }
    }
}
