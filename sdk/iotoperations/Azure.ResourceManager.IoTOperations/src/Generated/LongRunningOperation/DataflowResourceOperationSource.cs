// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.IoTOperations
{
    internal class DataflowResourceOperationSource : IOperationSource<DataflowResource>
    {
        private readonly ArmClient _client;

        internal DataflowResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataflowResource IOperationSource<DataflowResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataflowResourceData.DeserializeDataflowResourceData(document.RootElement);
            return new DataflowResource(_client, data);
        }

        async ValueTask<DataflowResource> IOperationSource<DataflowResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataflowResourceData.DeserializeDataflowResourceData(document.RootElement);
            return new DataflowResource(_client, data);
        }
    }
}
