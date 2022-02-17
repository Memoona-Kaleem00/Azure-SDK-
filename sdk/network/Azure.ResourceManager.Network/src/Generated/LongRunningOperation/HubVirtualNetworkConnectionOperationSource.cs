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
    internal class HubVirtualNetworkConnectionOperationSource : IOperationSource<HubVirtualNetworkConnection>
    {
        private readonly ArmClient _client;

        internal HubVirtualNetworkConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        HubVirtualNetworkConnection IOperationSource<HubVirtualNetworkConnection>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = HubVirtualNetworkConnectionData.DeserializeHubVirtualNetworkConnectionData(document.RootElement);
            return new HubVirtualNetworkConnection(_client, data);
        }

        async ValueTask<HubVirtualNetworkConnection> IOperationSource<HubVirtualNetworkConnection>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = HubVirtualNetworkConnectionData.DeserializeHubVirtualNetworkConnectionData(document.RootElement);
            return new HubVirtualNetworkConnection(_client, data);
        }
    }
}
