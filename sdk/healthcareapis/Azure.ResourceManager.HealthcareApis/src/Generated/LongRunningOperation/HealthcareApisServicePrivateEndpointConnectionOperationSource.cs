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

namespace Azure.ResourceManager.HealthcareApis
{
    internal class HealthcareApisServicePrivateEndpointConnectionOperationSource : IOperationSource<HealthcareApisServicePrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal HealthcareApisServicePrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        HealthcareApisServicePrivateEndpointConnectionResource IOperationSource<HealthcareApisServicePrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = HealthcareApisPrivateEndpointConnectionData.DeserializeHealthcareApisPrivateEndpointConnectionData(document.RootElement);
            return new HealthcareApisServicePrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<HealthcareApisServicePrivateEndpointConnectionResource> IOperationSource<HealthcareApisServicePrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = HealthcareApisPrivateEndpointConnectionData.DeserializeHealthcareApisPrivateEndpointConnectionData(document.RootElement);
            return new HealthcareApisServicePrivateEndpointConnectionResource(_client, data);
        }
    }
}
