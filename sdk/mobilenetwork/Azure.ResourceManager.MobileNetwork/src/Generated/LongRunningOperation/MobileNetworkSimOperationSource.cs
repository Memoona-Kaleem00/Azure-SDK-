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

namespace Azure.ResourceManager.MobileNetwork
{
    internal class MobileNetworkSimOperationSource : Core.IOperationSource<MobileNetworkSimResource>
    {
        private readonly ArmClient _client;

        internal MobileNetworkSimOperationSource(ArmClient client)
        {
            _client = client;
        }

        MobileNetworkSimResource Core.IOperationSource<MobileNetworkSimResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MobileNetworkSimData.DeserializeMobileNetworkSimData(document.RootElement);
            return new MobileNetworkSimResource(_client, data);
        }

        async ValueTask<MobileNetworkSimResource> Core.IOperationSource<MobileNetworkSimResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MobileNetworkSimData.DeserializeMobileNetworkSimData(document.RootElement);
            return new MobileNetworkSimResource(_client, data);
        }
    }
}
