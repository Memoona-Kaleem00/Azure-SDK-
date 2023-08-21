// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkSliceConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("slice"u8);
            JsonSerializer.Serialize(writer, Slice); writer.WritePropertyName("defaultDataNetwork"u8);
            JsonSerializer.Serialize(writer, DefaultDataNetwork); writer.WritePropertyName("dataNetworkConfigurations"u8);
            writer.WriteStartArray();
            foreach (var item in DataNetworkConfigurations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static MobileNetworkSliceConfiguration DeserializeMobileNetworkSliceConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource slice = default;
            WritableSubResource defaultDataNetwork = default;
            IList<DataNetworkConfiguration> dataNetworkConfigurations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("slice"u8))
                {
                    slice = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("defaultDataNetwork"u8))
                {
                    defaultDataNetwork = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("dataNetworkConfigurations"u8))
                {
                    List<DataNetworkConfiguration> array = new List<DataNetworkConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataNetworkConfiguration.DeserializeDataNetworkConfiguration(item));
                    }
                    dataNetworkConfigurations = array;
                    continue;
                }
            }
            return new MobileNetworkSliceConfiguration(slice, defaultDataNetwork, dataNetworkConfigurations);
        }
    }
}
