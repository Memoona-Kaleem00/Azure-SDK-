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
    public partial class AccessRoleBindingListResult : IUtf8JsonSerializable, IJsonModel<AccessRoleBindingListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AccessRoleBindingListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AccessRoleBindingListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessRoleBindingListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessRoleBindingListResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteObjectValue<ConfluentListMetadata>(Metadata, options);
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    writer.WriteObjectValue<AccessRoleBindingRecord>(item, options);
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

        AccessRoleBindingListResult IJsonModel<AccessRoleBindingListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessRoleBindingListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AccessRoleBindingListResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAccessRoleBindingListResult(document.RootElement, options);
        }

        internal static AccessRoleBindingListResult DeserializeAccessRoleBindingListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ConfluentListMetadata metadata = default;
            IReadOnlyList<AccessRoleBindingRecord> data = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = ConfluentListMetadata.DeserializeConfluentListMetadata(property.Value, options);
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AccessRoleBindingRecord> array = new List<AccessRoleBindingRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AccessRoleBindingRecord.DeserializeAccessRoleBindingRecord(item, options));
                    }
                    data = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AccessRoleBindingListResult(kind, metadata, data ?? new ChangeTrackingList<AccessRoleBindingRecord>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AccessRoleBindingListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessRoleBindingListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AccessRoleBindingListResult)} does not support writing '{options.Format}' format.");
            }
        }

        AccessRoleBindingListResult IPersistableModel<AccessRoleBindingListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AccessRoleBindingListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAccessRoleBindingListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AccessRoleBindingListResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AccessRoleBindingListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
