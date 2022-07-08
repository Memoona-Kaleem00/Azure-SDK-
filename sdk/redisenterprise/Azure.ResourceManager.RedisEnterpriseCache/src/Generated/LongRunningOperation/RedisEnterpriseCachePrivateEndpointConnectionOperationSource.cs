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

namespace Azure.ResourceManager.RedisEnterpriseCache
{
    internal class RedisEnterpriseCachePrivateEndpointConnectionOperationSource : IOperationSource<RedisEnterpriseCachePrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal RedisEnterpriseCachePrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        RedisEnterpriseCachePrivateEndpointConnectionResource IOperationSource<RedisEnterpriseCachePrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RedisEnterpriseCachePrivateEndpointConnectionData.DeserializeRedisEnterpriseCachePrivateEndpointConnectionData(document.RootElement);
            return new RedisEnterpriseCachePrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<RedisEnterpriseCachePrivateEndpointConnectionResource> IOperationSource<RedisEnterpriseCachePrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RedisEnterpriseCachePrivateEndpointConnectionData.DeserializeRedisEnterpriseCachePrivateEndpointConnectionData(document.RootElement);
            return new RedisEnterpriseCachePrivateEndpointConnectionResource(_client, data);
        }
    }
}
