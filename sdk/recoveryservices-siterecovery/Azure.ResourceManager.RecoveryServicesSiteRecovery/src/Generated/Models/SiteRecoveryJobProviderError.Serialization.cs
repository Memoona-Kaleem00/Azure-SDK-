// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryJobProviderError : IUtf8JsonSerializable, IJsonModel<SiteRecoveryJobProviderError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryJobProviderError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryJobProviderError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobProviderError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryJobProviderError)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ErrorCode))
            {
                writer.WritePropertyName("errorCode"u8);
                writer.WriteNumberValue(ErrorCode.Value);
            }
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsDefined(ErrorId))
            {
                writer.WritePropertyName("errorId"u8);
                writer.WriteStringValue(ErrorId);
            }
            if (Optional.IsDefined(PossibleCauses))
            {
                writer.WritePropertyName("possibleCauses"u8);
                writer.WriteStringValue(PossibleCauses);
            }
            if (Optional.IsDefined(RecommendedAction))
            {
                writer.WritePropertyName("recommendedAction"u8);
                writer.WriteStringValue(RecommendedAction);
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

        SiteRecoveryJobProviderError IJsonModel<SiteRecoveryJobProviderError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobProviderError>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryJobProviderError)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryJobProviderError(document.RootElement, options);
        }

        internal static SiteRecoveryJobProviderError DeserializeSiteRecoveryJobProviderError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? errorCode = default;
            string errorMessage = default;
            string errorId = default;
            string possibleCauses = default;
            string recommendedAction = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorId"u8))
                {
                    errorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("possibleCauses"u8))
                {
                    possibleCauses = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedAction"u8))
                {
                    recommendedAction = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryJobProviderError(
                errorCode,
                errorMessage,
                errorId,
                possibleCauses,
                recommendedAction,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SiteRecoveryJobProviderError>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobProviderError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryJobProviderError)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryJobProviderError IPersistableModel<SiteRecoveryJobProviderError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryJobProviderError>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryJobProviderError(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryJobProviderError)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryJobProviderError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
