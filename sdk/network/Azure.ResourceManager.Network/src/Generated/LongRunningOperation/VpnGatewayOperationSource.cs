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
    internal class VpnGatewayOperationSource : Core.IOperationSource<VpnGatewayResource>
    {
        private readonly ArmClient _client;

        internal VpnGatewayOperationSource(ArmClient client)
        {
            _client = client;
        }

        VpnGatewayResource Core.IOperationSource<VpnGatewayResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VpnGatewayData.DeserializeVpnGatewayData(document.RootElement);
            return new VpnGatewayResource(_client, data);
        }

        async ValueTask<VpnGatewayResource> Core.IOperationSource<VpnGatewayResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VpnGatewayData.DeserializeVpnGatewayData(document.RootElement);
            return new VpnGatewayResource(_client, data);
        }
    }
}
