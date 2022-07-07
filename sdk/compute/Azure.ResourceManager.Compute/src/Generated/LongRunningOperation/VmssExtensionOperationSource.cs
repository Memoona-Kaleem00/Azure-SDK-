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
    internal class VmssExtensionOperationSource : IOperationSource<VmssExtensionResource>
    {
        private readonly ArmClient _client;

        internal VmssExtensionOperationSource(ArmClient client)
        {
            _client = client;
        }

        VmssExtensionResource IOperationSource<VmssExtensionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VmssExtensionData.DeserializeVmssExtensionData(document.RootElement);
            return new VmssExtensionResource(_client, data);
        }

        async ValueTask<VmssExtensionResource> IOperationSource<VmssExtensionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VmssExtensionData.DeserializeVmssExtensionData(document.RootElement);
            return new VmssExtensionResource(_client, data);
        }
    }
}
