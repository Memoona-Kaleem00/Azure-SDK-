// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal class InboundSecurityRuleOperationSource : Core.IOperationSource<InboundSecurityRule>
    {
        InboundSecurityRule Core.IOperationSource<InboundSecurityRule>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return InboundSecurityRule.DeserializeInboundSecurityRule(document.RootElement);
        }

        async ValueTask<InboundSecurityRule> Core.IOperationSource<InboundSecurityRule>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return InboundSecurityRule.DeserializeInboundSecurityRule(document.RootElement);
        }
    }
}
