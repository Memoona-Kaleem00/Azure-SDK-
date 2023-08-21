// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal class EffectiveRouteListResultOperationSource : Core.IOperationSource<EffectiveRouteListResult>
    {
        EffectiveRouteListResult Core.IOperationSource<EffectiveRouteListResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return EffectiveRouteListResult.DeserializeEffectiveRouteListResult(document.RootElement);
        }

        async ValueTask<EffectiveRouteListResult> Core.IOperationSource<EffectiveRouteListResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return EffectiveRouteListResult.DeserializeEffectiveRouteListResult(document.RootElement);
        }
    }
}
