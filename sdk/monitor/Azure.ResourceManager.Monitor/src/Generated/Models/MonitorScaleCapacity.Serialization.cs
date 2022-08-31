// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorScaleCapacity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("minimum");
            writer.WriteStringValue(Minimum);
            writer.WritePropertyName("maximum");
            writer.WriteStringValue(Maximum);
            writer.WritePropertyName("default");
            writer.WriteStringValue(Default);
            writer.WriteEndObject();
        }

        internal static MonitorScaleCapacity DeserializeMonitorScaleCapacity(JsonElement element)
        {
            string minimum = default;
            string maximum = default;
            string @default = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimum"))
                {
                    minimum = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maximum"))
                {
                    maximum = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("default"))
                {
                    @default = property.Value.GetString();
                    continue;
                }
            }
            return new MonitorScaleCapacity(minimum, maximum, @default);
        }
    }
}
