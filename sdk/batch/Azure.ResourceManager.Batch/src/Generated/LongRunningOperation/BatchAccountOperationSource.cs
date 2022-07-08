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

namespace Azure.ResourceManager.Batch
{
    internal class BatchAccountOperationSource : IOperationSource<BatchAccountResource>
    {
        private readonly ArmClient _client;

        internal BatchAccountOperationSource(ArmClient client)
        {
            _client = client;
        }

        BatchAccountResource IOperationSource<BatchAccountResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = BatchAccountData.DeserializeBatchAccountData(document.RootElement);
            return new BatchAccountResource(_client, data);
        }

        async ValueTask<BatchAccountResource> IOperationSource<BatchAccountResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = BatchAccountData.DeserializeBatchAccountData(document.RootElement);
            return new BatchAccountResource(_client, data);
        }
    }
}
