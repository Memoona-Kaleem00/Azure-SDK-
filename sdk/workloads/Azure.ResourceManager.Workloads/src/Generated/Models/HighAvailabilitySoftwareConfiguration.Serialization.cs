// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class HighAvailabilitySoftwareConfiguration : IUtf8JsonSerializable, IJsonModel<HighAvailabilitySoftwareConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HighAvailabilitySoftwareConfiguration>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<HighAvailabilitySoftwareConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<HighAvailabilitySoftwareConfiguration>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<HighAvailabilitySoftwareConfiguration>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("fencingClientId"u8);
            writer.WriteStringValue(FencingClientId);
            writer.WritePropertyName("fencingClientPassword"u8);
            writer.WriteStringValue(FencingClientPassword);
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        HighAvailabilitySoftwareConfiguration IJsonModel<HighAvailabilitySoftwareConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HighAvailabilitySoftwareConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHighAvailabilitySoftwareConfiguration(document.RootElement, options);
        }

        internal static HighAvailabilitySoftwareConfiguration DeserializeHighAvailabilitySoftwareConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fencingClientId = default;
            string fencingClientPassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fencingClientId"u8))
                {
                    fencingClientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fencingClientPassword"u8))
                {
                    fencingClientPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HighAvailabilitySoftwareConfiguration(fencingClientId, fencingClientPassword, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HighAvailabilitySoftwareConfiguration>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HighAvailabilitySoftwareConfiguration)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HighAvailabilitySoftwareConfiguration IPersistableModel<HighAvailabilitySoftwareConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HighAvailabilitySoftwareConfiguration)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHighAvailabilitySoftwareConfiguration(document.RootElement, options);
        }

        string IPersistableModel<HighAvailabilitySoftwareConfiguration>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
