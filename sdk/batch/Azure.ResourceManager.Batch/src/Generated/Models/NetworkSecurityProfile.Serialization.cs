// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class NetworkSecurityProfile : IUtf8JsonSerializable, IJsonModel<NetworkSecurityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkSecurityProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NetworkSecurityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(AccessRulesVersion))
            {
                writer.WritePropertyName("accessRulesVersion"u8);
                writer.WriteNumberValue(AccessRulesVersion.Value);
            }
            if (Optional.IsCollectionDefined(AccessRules))
            {
                writer.WritePropertyName("accessRules"u8);
                writer.WriteStartArray();
                foreach (var item in AccessRules)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DiagnosticSettingsVersion))
            {
                writer.WritePropertyName("diagnosticSettingsVersion"u8);
                writer.WriteNumberValue(DiagnosticSettingsVersion.Value);
            }
            if (Optional.IsCollectionDefined(EnabledLogCategories))
            {
                writer.WritePropertyName("enabledLogCategories"u8);
                writer.WriteStartArray();
                foreach (var item in EnabledLogCategories)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        NetworkSecurityProfile IJsonModel<NetworkSecurityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkSecurityProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkSecurityProfile(document.RootElement, options);
        }

        internal static NetworkSecurityProfile DeserializeNetworkSecurityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            int? accessRulesVersion = default;
            IReadOnlyList<BatchAccessRule> accessRules = default;
            int? diagnosticSettingsVersion = default;
            IReadOnlyList<string> enabledLogCategories = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessRulesVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessRulesVersion = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("accessRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchAccessRule> array = new List<BatchAccessRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchAccessRule.DeserializeBatchAccessRule(item, options));
                    }
                    accessRules = array;
                    continue;
                }
                if (property.NameEquals("diagnosticSettingsVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diagnosticSettingsVersion = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enabledLogCategories"u8))
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
                    enabledLogCategories = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NetworkSecurityProfile(
                name,
                accessRulesVersion,
                accessRules ?? new ChangeTrackingList<BatchAccessRule>(),
                diagnosticSettingsVersion,
                enabledLogCategories ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkSecurityProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityProfile)} does not support writing '{options.Format}' format.");
            }
        }

        NetworkSecurityProfile IPersistableModel<NetworkSecurityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkSecurityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkSecurityProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkSecurityProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkSecurityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
