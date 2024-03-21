// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm
{
    internal class ScVmmCloudOperationSource : IOperationSource<ScVmmCloudResource>
    {
        private readonly ArmClient _client;

        internal ScVmmCloudOperationSource(ArmClient client)
        {
            _client = client;
        }

        ScVmmCloudResource IOperationSource<ScVmmCloudResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ScVmmCloudData.DeserializeScVmmCloudData(document.RootElement);
            return new ScVmmCloudResource(_client, data);
        }

        async ValueTask<ScVmmCloudResource> IOperationSource<ScVmmCloudResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ScVmmCloudData.DeserializeScVmmCloudData(document.RootElement);
            return new ScVmmCloudResource(_client, data);
        }
    }
}
