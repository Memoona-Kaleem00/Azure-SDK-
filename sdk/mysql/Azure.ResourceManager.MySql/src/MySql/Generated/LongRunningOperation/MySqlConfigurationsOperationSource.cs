// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.MySql.Models;

namespace Azure.ResourceManager.MySql
{
    internal class MySqlConfigurationsOperationSource : Core.IOperationSource<MySqlConfigurations>
    {
        MySqlConfigurations Core.IOperationSource<MySqlConfigurations>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return MySqlConfigurations.DeserializeMySqlConfigurations(document.RootElement);
        }

        async ValueTask<MySqlConfigurations> Core.IOperationSource<MySqlConfigurations>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return MySqlConfigurations.DeserializeMySqlConfigurations(document.RootElement);
        }
    }
}
