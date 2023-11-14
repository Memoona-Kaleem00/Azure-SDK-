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
    public partial class SharedStorageResourceNames : IUtf8JsonSerializable, IJsonModel<SharedStorageResourceNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SharedStorageResourceNames>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SharedStorageResourceNames>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SharedStorageResourceNames>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SharedStorageResourceNames>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SharedStorageAccountName))
            {
                writer.WritePropertyName("sharedStorageAccountName"u8);
                writer.WriteStringValue(SharedStorageAccountName);
            }
            if (Optional.IsDefined(SharedStorageAccountPrivateEndPointName))
            {
                writer.WritePropertyName("sharedStorageAccountPrivateEndPointName"u8);
                writer.WriteStringValue(SharedStorageAccountPrivateEndPointName);
            }
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

        SharedStorageResourceNames IJsonModel<SharedStorageResourceNames>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SharedStorageResourceNames)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSharedStorageResourceNames(document.RootElement, options);
        }

        internal static SharedStorageResourceNames DeserializeSharedStorageResourceNames(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> sharedStorageAccountName = default;
            Optional<string> sharedStorageAccountPrivateEndPointName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sharedStorageAccountName"u8))
                {
                    sharedStorageAccountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sharedStorageAccountPrivateEndPointName"u8))
                {
                    sharedStorageAccountPrivateEndPointName = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SharedStorageResourceNames(sharedStorageAccountName.Value, sharedStorageAccountPrivateEndPointName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SharedStorageResourceNames>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SharedStorageResourceNames)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SharedStorageResourceNames IPersistableModel<SharedStorageResourceNames>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SharedStorageResourceNames)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSharedStorageResourceNames(document.RootElement, options);
        }

        string IPersistableModel<SharedStorageResourceNames>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
