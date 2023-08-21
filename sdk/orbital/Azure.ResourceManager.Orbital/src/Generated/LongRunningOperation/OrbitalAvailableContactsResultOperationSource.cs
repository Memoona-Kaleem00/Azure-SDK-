// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Orbital.Models;

namespace Azure.ResourceManager.Orbital
{
    internal class OrbitalAvailableContactsResultOperationSource : Core.IOperationSource<OrbitalAvailableContactsResult>
    {
        OrbitalAvailableContactsResult Core.IOperationSource<OrbitalAvailableContactsResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return OrbitalAvailableContactsResult.DeserializeOrbitalAvailableContactsResult(document.RootElement);
        }

        async ValueTask<OrbitalAvailableContactsResult> Core.IOperationSource<OrbitalAvailableContactsResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return OrbitalAvailableContactsResult.DeserializeOrbitalAvailableContactsResult(document.RootElement);
        }
    }
}
