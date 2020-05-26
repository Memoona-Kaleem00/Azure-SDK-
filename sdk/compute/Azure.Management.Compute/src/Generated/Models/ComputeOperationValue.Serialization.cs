// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ComputeOperationValue
    {
        internal static ComputeOperationValue DeserializeComputeOperationValue(JsonElement element)
        {
            string origin = default;
            string name = default;
            string operation = default;
            string resource = default;
            string description = default;
            string provider = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("origin"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    origin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("display"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("operation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resource"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resource = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provider"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provider = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ComputeOperationValue(origin, name, operation, resource, description, provider);
        }
    }
}
