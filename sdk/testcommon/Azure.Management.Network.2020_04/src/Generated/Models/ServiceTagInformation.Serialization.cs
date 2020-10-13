// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ServiceTagInformation
    {
        internal static ServiceTagInformation DeserializeServiceTagInformation(JsonElement element)
        {
            Optional<ServiceTagInformationPropertiesFormat> properties = default;
            Optional<string> name = default;
            Optional<string> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    properties = ServiceTagInformationPropertiesFormat.DeserializeServiceTagInformationPropertiesFormat(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceTagInformation(properties.Value, name.Value, id.Value);
        }
    }
}
