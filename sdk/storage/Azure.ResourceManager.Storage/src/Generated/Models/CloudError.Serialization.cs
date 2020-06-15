// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    internal partial class CloudError
    {
        internal static CloudError DeserializeCloudError(JsonElement element)
        {
            CloudErrorBody error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = CloudErrorBody.DeserializeCloudErrorBody(property.Value);
                    continue;
                }
            }
            return new CloudError(error);
        }
    }
}
