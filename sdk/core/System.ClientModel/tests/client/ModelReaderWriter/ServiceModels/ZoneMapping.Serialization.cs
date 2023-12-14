// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using ClientModel.Tests.Client.Shared;
using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace ClientModel.Tests.Client.Models.ResourceManager.Resources
{
    public partial class ZoneMapping : IJsonModel<ZoneMapping>
    {
        internal static ZoneMapping DeserializeZoneMapping(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterHelper.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OptionalProperty<string> location = default;
            OptionalProperty<IReadOnlyList<string>> zones = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
            }
            return new ZoneMapping(location, OptionalProperty.ToList(zones));
        }

        void IJsonModel<ZoneMapping>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (OptionalProperty.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location);
            }
            if (OptionalProperty.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        private struct ZoneMappingProperties
        {
            public OptionalProperty<string> Location { get; set; }
            public OptionalProperty<IReadOnlyList<string>> Zones { get; set; }
        }

        ZoneMapping IJsonModel<ZoneMapping>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeZoneMapping(doc.RootElement, options);
        }

        ZoneMapping IPersistableModel<ZoneMapping>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeZoneMapping(doc.RootElement, options);
        }

        BinaryData IPersistableModel<ZoneMapping>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        string IPersistableModel<ZoneMapping>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
