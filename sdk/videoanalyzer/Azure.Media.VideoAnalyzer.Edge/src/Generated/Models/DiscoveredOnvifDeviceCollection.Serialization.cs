// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Media.VideoAnalyzer.Edge;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class DiscoveredOnvifDeviceCollection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static DiscoveredOnvifDeviceCollection DeserializeDiscoveredOnvifDeviceCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DiscoveredOnvifDevice> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DiscoveredOnvifDevice> array = new List<DiscoveredOnvifDevice>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DiscoveredOnvifDevice.DeserializeDiscoveredOnvifDevice(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new DiscoveredOnvifDeviceCollection(value ?? new ChangeTrackingList<DiscoveredOnvifDevice>());
        }
    }
}
