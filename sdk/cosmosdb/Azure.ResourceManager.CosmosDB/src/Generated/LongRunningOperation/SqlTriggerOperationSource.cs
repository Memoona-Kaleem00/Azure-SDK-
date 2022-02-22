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

namespace Azure.ResourceManager.CosmosDB
{
    internal class SqlTriggerOperationSource : IOperationSource<SqlTrigger>
    {
        private readonly ArmClient _client;

        internal SqlTriggerOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlTrigger IOperationSource<SqlTrigger>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlTriggerData.DeserializeSqlTriggerData(document.RootElement);
            return new SqlTrigger(_client, data);
        }

        async ValueTask<SqlTrigger> IOperationSource<SqlTrigger>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlTriggerData.DeserializeSqlTriggerData(document.RootElement);
            return new SqlTrigger(_client, data);
        }
    }
}
