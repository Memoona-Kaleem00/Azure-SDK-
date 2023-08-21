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

namespace Azure.ResourceManager.NetApp
{
    internal class NetAppVolumeGroupOperationSource : Core.IOperationSource<NetAppVolumeGroupResource>
    {
        private readonly ArmClient _client;

        internal NetAppVolumeGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetAppVolumeGroupResource Core.IOperationSource<NetAppVolumeGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetAppVolumeGroupData.DeserializeNetAppVolumeGroupData(document.RootElement);
            return new NetAppVolumeGroupResource(_client, data);
        }

        async ValueTask<NetAppVolumeGroupResource> Core.IOperationSource<NetAppVolumeGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetAppVolumeGroupData.DeserializeNetAppVolumeGroupData(document.RootElement);
            return new NetAppVolumeGroupResource(_client, data);
        }
    }
}
