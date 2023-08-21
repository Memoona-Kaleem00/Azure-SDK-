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

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    internal class PostgreSqlFlexibleServerDatabaseOperationSource : Core.IOperationSource<PostgreSqlFlexibleServerDatabaseResource>
    {
        private readonly ArmClient _client;

        internal PostgreSqlFlexibleServerDatabaseOperationSource(ArmClient client)
        {
            _client = client;
        }

        PostgreSqlFlexibleServerDatabaseResource Core.IOperationSource<PostgreSqlFlexibleServerDatabaseResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PostgreSqlFlexibleServerDatabaseData.DeserializePostgreSqlFlexibleServerDatabaseData(document.RootElement);
            return new PostgreSqlFlexibleServerDatabaseResource(_client, data);
        }

        async ValueTask<PostgreSqlFlexibleServerDatabaseResource> Core.IOperationSource<PostgreSqlFlexibleServerDatabaseResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PostgreSqlFlexibleServerDatabaseData.DeserializePostgreSqlFlexibleServerDatabaseData(document.RootElement);
            return new PostgreSqlFlexibleServerDatabaseResource(_client, data);
        }
    }
}
