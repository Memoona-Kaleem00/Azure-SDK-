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

namespace Azure.ResourceManager.Compute
{
    internal class VmssOperationSource : IOperationSource<VmssResource>
    {
        private readonly ArmClient _client;

        internal VmssOperationSource(ArmClient client)
        {
            _client = client;
        }

        VmssResource IOperationSource<VmssResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VmssData.DeserializeVmssData(document.RootElement);
            return new VmssResource(_client, data);
        }

        async ValueTask<VmssResource> IOperationSource<VmssResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VmssData.DeserializeVmssData(document.RootElement);
            return new VmssResource(_client, data);
        }
    }
}
