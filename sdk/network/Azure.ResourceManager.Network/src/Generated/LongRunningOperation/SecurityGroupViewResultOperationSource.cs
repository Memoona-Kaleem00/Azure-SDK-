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
    internal class SecurityGroupViewResultOperationSource : Core.IOperationSource<SecurityGroupViewResult>
    {
        SecurityGroupViewResult Core.IOperationSource<SecurityGroupViewResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return SecurityGroupViewResult.DeserializeSecurityGroupViewResult(document.RootElement);
        }

        async ValueTask<SecurityGroupViewResult> Core.IOperationSource<SecurityGroupViewResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return SecurityGroupViewResult.DeserializeSecurityGroupViewResult(document.RootElement);
        }
    }
}
