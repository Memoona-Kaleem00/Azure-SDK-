// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class NotificationRegistrationProperties : IUtf8JsonSerializable, IJsonModel<NotificationRegistrationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NotificationRegistrationProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NotificationRegistrationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationRegistrationProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(NotificationMode))
            {
                writer.WritePropertyName("notificationMode"u8);
                writer.WriteStringValue(NotificationMode.Value.ToString());
            }
            if (Optional.IsDefined(MessageScope))
            {
                writer.WritePropertyName("messageScope"u8);
                writer.WriteStringValue(MessageScope.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IncludedEvents))
            {
                writer.WritePropertyName("includedEvents"u8);
                writer.WriteStartArray();
                foreach (var item in IncludedEvents)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NotificationEndpoints))
            {
                writer.WritePropertyName("notificationEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in NotificationEndpoints)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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
        }

        NotificationRegistrationProperties IJsonModel<NotificationRegistrationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NotificationRegistrationProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationRegistrationProperties(document.RootElement, options);
        }

        internal static NotificationRegistrationProperties DeserializeNotificationRegistrationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NotificationMode? notificationMode = default;
            MessageScope? messageScope = default;
            IList<string> includedEvents = default;
            IList<NotificationEndpoint> notificationEndpoints = default;
            ProviderHubProvisioningState? provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notificationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    notificationMode = new NotificationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("messageScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messageScope = new MessageScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("includedEvents"u8))
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
                    includedEvents = array;
                    continue;
                }
                if (property.NameEquals("notificationEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NotificationEndpoint> array = new List<NotificationEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NotificationEndpoint.DeserializeNotificationEndpoint(item, options));
                    }
                    notificationEndpoints = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProviderHubProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NotificationRegistrationProperties(
                notificationMode,
                messageScope,
                includedEvents ?? new ChangeTrackingList<string>(),
                notificationEndpoints ?? new ChangeTrackingList<NotificationEndpoint>(),
                provisioningState,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NotificationRegistrationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NotificationRegistrationProperties)} does not support writing '{options.Format}' format.");
            }
        }

        NotificationRegistrationProperties IPersistableModel<NotificationRegistrationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NotificationRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNotificationRegistrationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NotificationRegistrationProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NotificationRegistrationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
