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
    internal class NetworkVirtualApplianceOperationSource : IOperationSource<NetworkVirtualAppliance>
    {
        private readonly ArmClient _client;

        internal NetworkVirtualApplianceOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkVirtualAppliance IOperationSource<NetworkVirtualAppliance>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkVirtualApplianceData.DeserializeNetworkVirtualApplianceData(document.RootElement);
            return new NetworkVirtualAppliance(_client, data);
        }

        async ValueTask<NetworkVirtualAppliance> IOperationSource<NetworkVirtualAppliance>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkVirtualApplianceData.DeserializeNetworkVirtualApplianceData(document.RootElement);
            return new NetworkVirtualAppliance(_client, data);
        }
    }
}
