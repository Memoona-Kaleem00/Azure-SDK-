// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class AtlasTermAssignmentHeader : IUtf8JsonSerializable, IJsonModel<AtlasTermAssignmentHeader>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AtlasTermAssignmentHeader>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AtlasTermAssignmentHeader>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasTermAssignmentHeader>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasTermAssignmentHeader)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Confidence))
            {
                writer.WritePropertyName("confidence"u8);
                writer.WriteNumberValue(Confidence.Value);
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy"u8);
                writer.WriteStringValue(CreatedBy);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DisplayText))
            {
                writer.WritePropertyName("displayText"u8);
                writer.WriteStringValue(DisplayText);
            }
            if (Optional.IsDefined(Expression))
            {
                writer.WritePropertyName("expression"u8);
                writer.WriteStringValue(Expression);
            }
            if (Optional.IsDefined(RelationGuid))
            {
                writer.WritePropertyName("relationGuid"u8);
                writer.WriteStringValue(RelationGuid.Value);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Steward))
            {
                writer.WritePropertyName("steward"u8);
                writer.WriteStringValue(Steward);
            }
            if (Optional.IsDefined(TermGuid))
            {
                writer.WritePropertyName("termGuid"u8);
                writer.WriteStringValue(TermGuid.Value);
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

        AtlasTermAssignmentHeader IJsonModel<AtlasTermAssignmentHeader>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasTermAssignmentHeader>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasTermAssignmentHeader)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAtlasTermAssignmentHeader(document.RootElement, options);
        }

        internal static AtlasTermAssignmentHeader DeserializeAtlasTermAssignmentHeader(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? confidence = default;
            string createdBy = default;
            string description = default;
            string displayText = default;
            string expression = default;
            Guid? relationGuid = default;
            AtlasTermAssignmentStatus? status = default;
            string steward = default;
            Guid? termGuid = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("confidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidence = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("createdBy"u8))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayText"u8))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expression"u8))
                {
                    expression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relationGuid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relationGuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new AtlasTermAssignmentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("steward"u8))
                {
                    steward = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("termGuid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    termGuid = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AtlasTermAssignmentHeader(
                confidence,
                createdBy,
                description,
                displayText,
                expression,
                relationGuid,
                status,
                steward,
                termGuid,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AtlasTermAssignmentHeader>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasTermAssignmentHeader>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AtlasTermAssignmentHeader)} does not support '{options.Format}' format.");
            }
        }

        AtlasTermAssignmentHeader IPersistableModel<AtlasTermAssignmentHeader>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasTermAssignmentHeader>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAtlasTermAssignmentHeader(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AtlasTermAssignmentHeader)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AtlasTermAssignmentHeader>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AtlasTermAssignmentHeader FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAtlasTermAssignmentHeader(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
