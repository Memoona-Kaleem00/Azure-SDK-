// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    internal class ResourceGroupExportResultOperationSource : IOperationSource<ResourceGroupExportResult>
    {
        ResourceGroupExportResult IOperationSource<ResourceGroupExportResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ResourceGroupExportResult.DeserializeResourceGroupExportResult(document.RootElement);
        }

        async ValueTask<ResourceGroupExportResult> IOperationSource<ResourceGroupExportResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ResourceGroupExportResult.DeserializeResourceGroupExportResult(document.RootElement);
        }
    }
}
