// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql
{
    internal class PostgreSqlPrivateEndpointConnectionOperationSource : IOperationSource<PostgreSqlPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal PostgreSqlPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        PostgreSqlPrivateEndpointConnectionResource IOperationSource<PostgreSqlPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PostgreSqlPrivateEndpointConnectionData.DeserializePostgreSqlPrivateEndpointConnectionData(document.RootElement);
            return new PostgreSqlPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<PostgreSqlPrivateEndpointConnectionResource> IOperationSource<PostgreSqlPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PostgreSqlPrivateEndpointConnectionData.DeserializePostgreSqlPrivateEndpointConnectionData(document.RootElement);
            return new PostgreSqlPrivateEndpointConnectionResource(_client, data);
        }
    }
}
