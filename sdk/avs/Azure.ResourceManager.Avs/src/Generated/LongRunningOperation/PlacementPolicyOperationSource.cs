// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Avs
{
    internal class PlacementPolicyOperationSource : IOperationSource<PlacementPolicyResource>
    {
        private readonly ArmClient _client;

        internal PlacementPolicyOperationSource(ArmClient client)
        {
            _client = client;
        }

        PlacementPolicyResource IOperationSource<PlacementPolicyResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PlacementPolicyData.DeserializePlacementPolicyData(document.RootElement);
            return new PlacementPolicyResource(_client, data);
        }

        async ValueTask<PlacementPolicyResource> IOperationSource<PlacementPolicyResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PlacementPolicyData.DeserializePlacementPolicyData(document.RootElement);
            return new PlacementPolicyResource(_client, data);
        }
    }
}
