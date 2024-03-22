// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.ResourceManager.Models
{
    [JsonConverter(typeof(OperationStatusResultConverter))]
    public partial class OperationStatusResult : IUtf8JsonSerializable, IJsonModel<OperationStatusResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OperationStatusResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OperationStatusResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationStatusResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationStatusResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(PercentComplete))
            {
                writer.WritePropertyName("percentComplete"u8);
                writer.WriteNumberValue(PercentComplete.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndOn))
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Operations))
            {
                writer.WritePropertyName("operations"u8);
                writer.WriteStartArray();
                foreach (var item in Operations)
                {
                    writer.WriteObjectValue<OperationStatusResult>(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                JsonSerializer.Serialize(writer, Error);
            }
            writer.WriteEndObject();
        }

        OperationStatusResult IJsonModel<OperationStatusResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationStatusResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OperationStatusResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOperationStatusResult(document.RootElement, options);
        }

        internal static OperationStatusResult DeserializeOperationStatusResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            string status = default;
            float? percentComplete = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            IReadOnlyList<OperationStatusResult> operations = default;
            ResponseError error = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        array.Add(JsonSerializer.Deserialize<OperationStatusResult>(item.GetRawText()));
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
            }
            return new OperationStatusResult(
                id,
                name,
                status,
                percentComplete,
                startTime,
                endTime,
                operations ?? new ChangeTrackingList<OperationStatusResult>(),
                error);
        }

        BinaryData IPersistableModel<OperationStatusResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationStatusResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OperationStatusResult)} does not support writing '{options.Format}' format.");
            }
        }

        OperationStatusResult IPersistableModel<OperationStatusResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OperationStatusResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOperationStatusResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OperationStatusResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OperationStatusResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class OperationStatusResultConverter : JsonConverter<OperationStatusResult>
        {
            public override void Write(Utf8JsonWriter writer, OperationStatusResult model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue<OperationStatusResult>(model);
            }
            public override OperationStatusResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeOperationStatusResult(document.RootElement);
            }
        }
    }
}
