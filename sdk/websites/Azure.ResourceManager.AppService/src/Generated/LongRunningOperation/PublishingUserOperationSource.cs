// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    internal class PublishingUserOperationSource : IOperationSource<PublishingUserResource>
    {
        private readonly ArmClient _client;

        internal PublishingUserOperationSource(ArmClient client)
        {
            _client = client;
        }

        PublishingUserResource IOperationSource<PublishingUserResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PublishingUserData.DeserializePublishingUserData(document.RootElement);
            return new PublishingUserResource(_client, data);
        }

        async ValueTask<PublishingUserResource> IOperationSource<PublishingUserResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PublishingUserData.DeserializePublishingUserData(document.RootElement);
            return new PublishingUserResource(_client, data);
        }
    }
}
