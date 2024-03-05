// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DevCenter;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class DevCenterOperationStatus : IUtf8JsonSerializable, IJsonModel<DevCenterOperationStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevCenterOperationStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevCenterOperationStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterOperationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterOperationStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (options.Format != "W" && Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Properties);
#else
                using (JsonDocument document = JsonDocument.Parse(Properties))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status);
            if (Optional.IsDefined(PercentComplete))
            {
                writer.WritePropertyName("percentComplete"u8);
                writer.WriteNumberValue(PercentComplete.Value);
            }
            if (Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(Operations))
            {
                writer.WritePropertyName("operations"u8);
                writer.WriteStartArray();
                foreach (var item in Operations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
            }
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

        DevCenterOperationStatus IJsonModel<DevCenterOperationStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterOperationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterOperationStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterOperationStatus(document.RootElement, options);
        }

        internal static DevCenterOperationStatus DeserializeDevCenterOperationStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier resourceId = default;
            BinaryData properties = default;
            ResourceIdentifier id = default;
            string name = default;
            string status = default;
            float? percentComplete = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            IReadOnlyList<OperationStatusResult> operations = default;
            ResponseError error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("percentComplete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    percentComplete = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("operations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OperationStatusResult> array = new List<OperationStatusResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(JsonSerializer.Deserialize<OperationStatusResult>(item.GetRawText()));
                        }
                    }
                    operations = array;
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevCenterOperationStatus(
                id,
                name,
                status,
                percentComplete,
                startTime,
                endTime,
                operations ?? new ChangeTrackingList<OperationStatusResult>(),
                error,
                resourceId,
                properties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevCenterOperationStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterOperationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevCenterOperationStatus)} does not support '{options.Format}' format.");
            }
        }

        DevCenterOperationStatus IPersistableModel<DevCenterOperationStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterOperationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevCenterOperationStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevCenterOperationStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevCenterOperationStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
