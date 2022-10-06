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

namespace Azure.ResourceManager.ManagedNetwork
{
    internal class ManagedNetworkOperationSource : IOperationSource<ManagedNetworkResource>
    {
        private readonly ArmClient _client;

        internal ManagedNetworkOperationSource(ArmClient client)
        {
            _client = client;
        }

        ManagedNetworkResource IOperationSource<ManagedNetworkResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ManagedNetworkData.DeserializeManagedNetworkData(document.RootElement);
            return new ManagedNetworkResource(_client, data);
        }

        async ValueTask<ManagedNetworkResource> IOperationSource<ManagedNetworkResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ManagedNetworkData.DeserializeManagedNetworkData(document.RootElement);
            return new ManagedNetworkResource(_client, data);
        }
    }
}
