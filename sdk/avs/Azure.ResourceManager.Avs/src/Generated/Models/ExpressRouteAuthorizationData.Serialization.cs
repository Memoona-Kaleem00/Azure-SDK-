// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;

namespace Azure.ResourceManager.Avs
{
    public partial class ExpressRouteAuthorizationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ExpressRouteId))
            {
                writer.WritePropertyName("expressRouteId");
                writer.WriteStringValue(ExpressRouteId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteAuthorizationData DeserializeExpressRouteAuthorizationData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<ExpressRouteAuthorizationProvisioningState> provisioningState = default;
            Optional<string> expressRouteAuthorizationId = default;
            Optional<string> expressRouteAuthorizationKey = default;
            Optional<string> expressRouteId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
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
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ExpressRouteAuthorizationProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expressRouteAuthorizationId"))
                        {
                            expressRouteAuthorizationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("expressRouteAuthorizationKey"))
                        {
                            expressRouteAuthorizationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("expressRouteId"))
                        {
                            expressRouteId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteAuthorizationData(id, name, type, Optional.ToNullable(provisioningState), expressRouteAuthorizationId.Value, expressRouteAuthorizationKey.Value, expressRouteId.Value);
        }
    }
}
