// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteGatewayPropertiesAutoScaleConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Bounds))
            {
                writer.WritePropertyName("bounds");
                writer.WriteObjectValue(Bounds);
            }
            writer.WriteEndObject();
        }

        internal static ExpressRouteGatewayPropertiesAutoScaleConfiguration DeserializeExpressRouteGatewayPropertiesAutoScaleConfiguration(JsonElement element)
        {
            Optional<ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds> bounds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bounds"))
                {
                    bounds = ExpressRouteGatewayPropertiesAutoScaleConfigurationBounds.DeserializeExpressRouteGatewayPropertiesAutoScaleConfigurationBounds(property.Value);
                    continue;
                }
            }
            return new ExpressRouteGatewayPropertiesAutoScaleConfiguration(bounds.Value);
        }
    }
}
