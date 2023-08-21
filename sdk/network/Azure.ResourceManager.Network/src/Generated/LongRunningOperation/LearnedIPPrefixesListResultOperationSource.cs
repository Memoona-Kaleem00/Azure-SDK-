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
    internal class LearnedIPPrefixesListResultOperationSource : Core.IOperationSource<LearnedIPPrefixesListResult>
    {
        LearnedIPPrefixesListResult Core.IOperationSource<LearnedIPPrefixesListResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return LearnedIPPrefixesListResult.DeserializeLearnedIPPrefixesListResult(document.RootElement);
        }

        async ValueTask<LearnedIPPrefixesListResult> Core.IOperationSource<LearnedIPPrefixesListResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return LearnedIPPrefixesListResult.DeserializeLearnedIPPrefixesListResult(document.RootElement);
        }
    }
}
