// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.StorageSync.Models;

namespace Azure.ResourceManager.StorageSync
{
    internal class CloudEndpointPostBackupResultOperationSource : IOperationSource<CloudEndpointPostBackupResult>
    {
        CloudEndpointPostBackupResult IOperationSource<CloudEndpointPostBackupResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return CloudEndpointPostBackupResult.DeserializeCloudEndpointPostBackupResult(document.RootElement);
        }

        async ValueTask<CloudEndpointPostBackupResult> IOperationSource<CloudEndpointPostBackupResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return CloudEndpointPostBackupResult.DeserializeCloudEndpointPostBackupResult(document.RootElement);
        }
    }
}
