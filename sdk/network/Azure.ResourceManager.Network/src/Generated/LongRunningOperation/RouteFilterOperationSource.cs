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
    internal class RouteFilterOperationSource : Core.IOperationSource<RouteFilterResource>
    {
        private readonly ArmClient _client;

        internal RouteFilterOperationSource(ArmClient client)
        {
            _client = client;
        }

        RouteFilterResource Core.IOperationSource<RouteFilterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = RouteFilterData.DeserializeRouteFilterData(document.RootElement);
            return new RouteFilterResource(_client, data);
        }

        async ValueTask<RouteFilterResource> Core.IOperationSource<RouteFilterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = RouteFilterData.DeserializeRouteFilterData(document.RootElement);
            return new RouteFilterResource(_client, data);
        }
    }
}
