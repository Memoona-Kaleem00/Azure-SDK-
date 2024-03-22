// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class AccessRoleBindingRecord : IUtf8JsonSerializable, IJsonModel<AccessRoleBindingRecord>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AccessRoleBindingRecord>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AccessRoleBindingRecord>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessRoleBindingRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessRoleBindingRecord)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue<MetadataEntity>(Metadata, options);
            }
            if (Optional.IsDefined(Principal))
            {
                writer.WritePropertyName("principal"u8);
                writer.WriteStringValue(Principal);
            }
            if (Optional.IsDefined(RoleName))
            {
                writer.WritePropertyName("role_name"u8);
                writer.WriteStringValue(RoleName);
            }
            if (Optional.IsDefined(CrnPattern))
            {
                writer.WritePropertyName("crn_pattern"u8);
                writer.WriteStringValue(CrnPattern);
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

        AccessRoleBindingRecord IJsonModel<AccessRoleBindingRecord>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessRoleBindingRecord>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessRoleBindingRecord)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAccessRoleBindingRecord(document.RootElement, options);
        }

        internal static AccessRoleBindingRecord DeserializeAccessRoleBindingRecord(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            string id = default;
            MetadataEntity metadata = default;
            string principal = default;
            string roleName = default;
            string crnPattern = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = MetadataEntity.DeserializeMetadataEntity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("principal"u8))
                {
                    principal = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("role_name"u8))
                {
                    roleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("crn_pattern"u8))
                {
                    crnPattern = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AccessRoleBindingRecord(
                kind,
                id,
                metadata,
                principal,
                roleName,
                crnPattern,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AccessRoleBindingRecord>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessRoleBindingRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AccessRoleBindingRecord)} does not support writing '{options.Format}' format.");
            }
        }

        AccessRoleBindingRecord IPersistableModel<AccessRoleBindingRecord>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessRoleBindingRecord>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAccessRoleBindingRecord(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AccessRoleBindingRecord)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AccessRoleBindingRecord>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
