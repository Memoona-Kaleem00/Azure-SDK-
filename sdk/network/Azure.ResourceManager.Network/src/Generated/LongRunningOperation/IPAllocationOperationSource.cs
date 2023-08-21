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

namespace Azure.ResourceManager.Network
{
    internal class IPAllocationOperationSource : Core.IOperationSource<IPAllocationResource>
    {
        private readonly ArmClient _client;

        internal IPAllocationOperationSource(ArmClient client)
        {
            _client = client;
        }

        IPAllocationResource Core.IOperationSource<IPAllocationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = IPAllocationData.DeserializeIPAllocationData(document.RootElement);
            return new IPAllocationResource(_client, data);
        }

        async ValueTask<IPAllocationResource> Core.IOperationSource<IPAllocationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = IPAllocationData.DeserializeIPAllocationData(document.RootElement);
            return new IPAllocationResource(_client, data);
        }
    }
}
