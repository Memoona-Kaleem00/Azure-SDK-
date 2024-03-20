// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    internal class BinaryDataOperationSource : IOperationSource<BinaryData>
    {
        BinaryData IOperationSource<BinaryData>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            return BinaryData.FromStream(response.ContentStream);
        }

        async ValueTask<BinaryData> IOperationSource<BinaryData>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            return await BinaryData.FromStreamAsync(response.ContentStream).ConfigureAwait(false);
        }
    }
}
