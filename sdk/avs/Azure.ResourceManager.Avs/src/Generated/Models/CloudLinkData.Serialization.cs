// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs
{
    public partial class CloudLinkData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedCloud))
            {
                writer.WritePropertyName("linkedCloud");
                writer.WriteStringValue(LinkedCloud);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CloudLinkData DeserializeCloudLinkData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<CloudLinkStatus> status = default;
            Optional<string> linkedCloud = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("status"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            status = new CloudLinkStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("linkedCloud"))
                        {
                            linkedCloud = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CloudLinkData(id, name, type, Optional.ToNullable(status), linkedCloud.Value);
        }
    }
}
