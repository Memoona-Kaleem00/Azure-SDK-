// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Kubernetes
{
    internal class ConnectedClusterOperationSource : IOperationSource<ConnectedClusterResource>
    {
        private readonly ArmClient _client;

        internal ConnectedClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        ConnectedClusterResource IOperationSource<ConnectedClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ConnectedClusterData.DeserializeConnectedClusterData(document.RootElement);
            return new ConnectedClusterResource(_client, data);
        }

        async ValueTask<ConnectedClusterResource> IOperationSource<ConnectedClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ConnectedClusterData.DeserializeConnectedClusterData(document.RootElement);
            return new ConnectedClusterResource(_client, data);
        }
    }
}
