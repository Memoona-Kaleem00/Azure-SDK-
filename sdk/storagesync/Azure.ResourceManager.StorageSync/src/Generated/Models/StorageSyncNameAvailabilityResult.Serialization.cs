// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StorageSync;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class StorageSyncNameAvailabilityResult : IUtf8JsonSerializable, IJsonModel<StorageSyncNameAvailabilityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageSyncNameAvailabilityResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageSyncNameAvailabilityResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSyncNameAvailabilityResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(IsNameAvailable))
            {
                writer.WritePropertyName("nameAvailable"u8);
                writer.WriteBooleanValue(IsNameAvailable.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
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

        StorageSyncNameAvailabilityResult IJsonModel<StorageSyncNameAvailabilityResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSyncNameAvailabilityResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageSyncNameAvailabilityResult(document.RootElement, options);
        }

        internal static StorageSyncNameAvailabilityResult DeserializeStorageSyncNameAvailabilityResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? nameAvailable = default;
            StorageSyncNameUnavailableReason? reason = default;
            string message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reason = property.Value.GetString().ToStorageSyncNameUnavailableReason();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageSyncNameAvailabilityResult(nameAvailable, reason, message, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageSyncNameAvailabilityResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageSyncNameAvailabilityResult)} does not support '{options.Format}' format.");
            }
        }

        StorageSyncNameAvailabilityResult IPersistableModel<StorageSyncNameAvailabilityResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSyncNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageSyncNameAvailabilityResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageSyncNameAvailabilityResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageSyncNameAvailabilityResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
