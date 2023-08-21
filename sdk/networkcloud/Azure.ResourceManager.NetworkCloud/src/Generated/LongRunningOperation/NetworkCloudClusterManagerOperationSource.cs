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

namespace Azure.ResourceManager.NetworkCloud
{
    internal class NetworkCloudClusterManagerOperationSource : Core.IOperationSource<NetworkCloudClusterManagerResource>
    {
        private readonly ArmClient _client;

        internal NetworkCloudClusterManagerOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkCloudClusterManagerResource Core.IOperationSource<NetworkCloudClusterManagerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkCloudClusterManagerData.DeserializeNetworkCloudClusterManagerData(document.RootElement);
            return new NetworkCloudClusterManagerResource(_client, data);
        }

        async ValueTask<NetworkCloudClusterManagerResource> Core.IOperationSource<NetworkCloudClusterManagerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkCloudClusterManagerData.DeserializeNetworkCloudClusterManagerData(document.RootElement);
            return new NetworkCloudClusterManagerResource(_client, data);
        }
    }
}
