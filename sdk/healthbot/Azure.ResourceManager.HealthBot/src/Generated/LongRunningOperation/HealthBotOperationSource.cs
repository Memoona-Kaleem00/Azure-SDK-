// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.HealthBot
{
    internal class HealthBotOperationSource : IOperationSource<HealthBotResource>
    {
        private readonly ArmClient _client;

        internal HealthBotOperationSource(ArmClient client)
        {
            _client = client;
        }

        HealthBotResource IOperationSource<HealthBotResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = HealthBotData.DeserializeHealthBotData(document.RootElement);
            return new HealthBotResource(_client, data);
        }

        async ValueTask<HealthBotResource> IOperationSource<HealthBotResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = HealthBotData.DeserializeHealthBotData(document.RootElement);
            return new HealthBotResource(_client, data);
        }
    }
}
