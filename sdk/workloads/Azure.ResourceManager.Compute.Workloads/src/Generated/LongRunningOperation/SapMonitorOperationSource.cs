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

namespace Azure.ResourceManager.Compute.Workloads
{
    internal class SapMonitorOperationSource : IOperationSource<SapMonitorResource>
    {
        private readonly ArmClient _client;

        internal SapMonitorOperationSource(ArmClient client)
        {
            _client = client;
        }

        SapMonitorResource IOperationSource<SapMonitorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SapMonitorData.DeserializeSapMonitorData(document.RootElement);
            return new SapMonitorResource(_client, data);
        }

        async ValueTask<SapMonitorResource> IOperationSource<SapMonitorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SapMonitorData.DeserializeSapMonitorData(document.RootElement);
            return new SapMonitorResource(_client, data);
        }
    }
}
