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

namespace Azure.AI.DocumentIntelligence
{
    public partial class DocumentModelDetails : IUtf8JsonSerializable, IJsonModel<DocumentModelDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentModelDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DocumentModelDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentModelDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentModelDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("modelId"u8);
            writer.WriteStringValue(ModelId);
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("createdDateTime"u8);
            writer.WriteStringValue(CreatedDateTime, "O");
            if (ExpirationDateTime.HasValue)
            {
                writer.WritePropertyName("expirationDateTime"u8);
                writer.WriteStringValue(ExpirationDateTime.Value, "O");
            }
            if (ApiVersion != null)
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (BuildMode.HasValue)
            {
                writer.WritePropertyName("buildMode"u8);
                writer.WriteStringValue(BuildMode.Value.ToString());
            }
            if (AzureBlobSource != null)
            {
                writer.WritePropertyName("azureBlobSource"u8);
                writer.WriteObjectValue(AzureBlobSource);
            }
            if (AzureBlobFileListSource != null)
            {
                writer.WritePropertyName("azureBlobFileListSource"u8);
                writer.WriteObjectValue(AzureBlobFileListSource);
            }
            if (!(DocTypes is ChangeTrackingDictionary<string, DocumentTypeDetails> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("docTypes"u8);
                writer.WriteStartObject();
                foreach (var item in DocTypes)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        DocumentModelDetails IJsonModel<DocumentModelDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentModelDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentModelDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentModelDetails(document.RootElement, options);
        }

        internal static DocumentModelDetails DeserializeDocumentModelDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string modelId = default;
            Optional<string> description = default;
            DateTimeOffset createdDateTime = default;
            Optional<DateTimeOffset> expirationDateTime = default;
            Optional<string> apiVersion = default;
            IReadOnlyDictionary<string, string> tags = default;
            Optional<DocumentBuildMode> buildMode = default;
            Optional<AzureBlobContentSource> azureBlobSource = default;
            Optional<AzureBlobFileListContentSource> azureBlobFileListSource = default;
            IReadOnlyDictionary<string, DocumentTypeDetails> docTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelId"u8))
                {
                    modelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("buildMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    buildMode = new DocumentBuildMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureBlobSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobSource = AzureBlobContentSource.DeserializeAzureBlobContentSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("azureBlobFileListSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobFileListSource = AzureBlobFileListContentSource.DeserializeAzureBlobFileListContentSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("docTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, DocumentTypeDetails> dictionary = new Dictionary<string, DocumentTypeDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DocumentTypeDetails.DeserializeDocumentTypeDetails(property0.Value, options));
                    }
                    docTypes = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DocumentModelDetails(
                modelId,
                description.Value,
                createdDateTime,
                Optional.ToNullable(expirationDateTime),
                apiVersion.Value,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                Optional.ToNullable(buildMode),
                azureBlobSource.Value,
                azureBlobFileListSource.Value,
                docTypes ?? new ChangeTrackingDictionary<string, DocumentTypeDetails>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentModelDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentModelDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DocumentModelDetails)} does not support '{options.Format}' format.");
            }
        }

        DocumentModelDetails IPersistableModel<DocumentModelDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentModelDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDocumentModelDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentModelDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentModelDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentModelDetails FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDocumentModelDetails(document.RootElement);
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
