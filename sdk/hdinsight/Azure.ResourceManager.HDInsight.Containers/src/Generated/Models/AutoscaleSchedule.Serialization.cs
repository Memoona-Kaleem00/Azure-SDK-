// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class AutoscaleSchedule : IUtf8JsonSerializable, IJsonModel<AutoscaleSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoscaleSchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoscaleSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleSchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartOn, "O");
            writer.WritePropertyName("endTime"u8);
            writer.WriteStringValue(EndOn, "O");
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
            writer.WritePropertyName("days"u8);
            writer.WriteStartArray();
            foreach (var item in Days)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        AutoscaleSchedule IJsonModel<AutoscaleSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleSchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoscaleSchedule(document.RootElement, options);
        }

        internal static AutoscaleSchedule DeserializeAutoscaleSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            int count = default;
            IList<AutoscaleScheduleDay> days = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("days"u8))
                {
                    List<AutoscaleScheduleDay> array = new List<AutoscaleScheduleDay>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AutoscaleScheduleDay(item.GetString()));
                    }
                    days = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutoscaleSchedule(startTime, endTime, count, days, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoscaleSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoscaleSchedule)} does not support '{options.Format}' format.");
            }
        }

        AutoscaleSchedule IPersistableModel<AutoscaleSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoscaleSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoscaleSchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoscaleSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
