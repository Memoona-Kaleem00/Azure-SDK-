// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud
{
    internal class NetworkCloudVirtualMachineConsoleOperationSource : IOperationSource<NetworkCloudVirtualMachineConsoleResource>
    {
        private readonly ArmClient _client;

        internal NetworkCloudVirtualMachineConsoleOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkCloudVirtualMachineConsoleResource IOperationSource<NetworkCloudVirtualMachineConsoleResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkCloudVirtualMachineConsoleData.DeserializeNetworkCloudVirtualMachineConsoleData(document.RootElement);
            return new NetworkCloudVirtualMachineConsoleResource(_client, data);
        }

        async ValueTask<NetworkCloudVirtualMachineConsoleResource> IOperationSource<NetworkCloudVirtualMachineConsoleResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkCloudVirtualMachineConsoleData.DeserializeNetworkCloudVirtualMachineConsoleData(document.RootElement);
            return new NetworkCloudVirtualMachineConsoleResource(_client, data);
        }
    }
}
