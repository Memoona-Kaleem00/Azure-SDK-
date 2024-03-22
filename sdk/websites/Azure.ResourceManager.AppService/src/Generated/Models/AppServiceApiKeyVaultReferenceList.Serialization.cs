// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    internal partial class AppServiceApiKeyVaultReferenceList : IUtf8JsonSerializable, IJsonModel<AppServiceApiKeyVaultReferenceList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceApiKeyVaultReferenceList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceApiKeyVaultReferenceList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceApiKeyVaultReferenceList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceApiKeyVaultReferenceList)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue<ApiKeyVaultReferenceData>(item, options);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        AppServiceApiKeyVaultReferenceList IJsonModel<AppServiceApiKeyVaultReferenceList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceApiKeyVaultReferenceList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceApiKeyVaultReferenceList)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceApiKeyVaultReferenceList(document.RootElement, options);
        }

        internal static AppServiceApiKeyVaultReferenceList DeserializeAppServiceApiKeyVaultReferenceList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ApiKeyVaultReferenceData> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ApiKeyVaultReferenceData> array = new List<ApiKeyVaultReferenceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiKeyVaultReferenceData.DeserializeApiKeyVaultReferenceData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceApiKeyVaultReferenceList(value, nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceApiKeyVaultReferenceList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceApiKeyVaultReferenceList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceApiKeyVaultReferenceList)} does not support writing '{options.Format}' format.");
            }
        }

        AppServiceApiKeyVaultReferenceList IPersistableModel<AppServiceApiKeyVaultReferenceList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceApiKeyVaultReferenceList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceApiKeyVaultReferenceList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceApiKeyVaultReferenceList)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceApiKeyVaultReferenceList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
