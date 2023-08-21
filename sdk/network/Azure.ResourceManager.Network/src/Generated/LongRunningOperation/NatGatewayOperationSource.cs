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
    internal class NatGatewayOperationSource : Core.IOperationSource<NatGatewayResource>
    {
        private readonly ArmClient _client;

        internal NatGatewayOperationSource(ArmClient client)
        {
            _client = client;
        }

        NatGatewayResource Core.IOperationSource<NatGatewayResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NatGatewayData.DeserializeNatGatewayData(document.RootElement);
            return new NatGatewayResource(_client, data);
        }

        async ValueTask<NatGatewayResource> Core.IOperationSource<NatGatewayResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NatGatewayData.DeserializeNatGatewayData(document.RootElement);
            return new NatGatewayResource(_client, data);
        }
    }
}
