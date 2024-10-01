// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerHttpGet : IUtf8JsonSerializable, IJsonModel<ContainerHttpGet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerHttpGet>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerHttpGet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerHttpGet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerHttpGet)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            writer.WritePropertyName("port"u8);
            writer.WriteNumberValue(Port);
            if (Optional.IsDefined(Scheme))
            {
                writer.WritePropertyName("scheme"u8);
                writer.WriteStringValue(Scheme.Value.ToString());
            }
            if (Optional.IsCollectionDefined(HttpHeaders))
            {
                writer.WritePropertyName("httpHeaders"u8);
                writer.WriteStartArray();
                foreach (var item in HttpHeaders)
                {
                    writer.WriteObjectValue(item, options);
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
        }

        ContainerHttpGet IJsonModel<ContainerHttpGet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerHttpGet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerHttpGet)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerHttpGet(document.RootElement, options);
        }

        internal static ContainerHttpGet DeserializeContainerHttpGet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string path = default;
            int port = default;
            ContainerHttpGetScheme? scheme = default;
            IList<ContainerHttpHeader> httpHeaders = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scheme"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheme = new ContainerHttpGetScheme(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("httpHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerHttpHeader> array = new List<ContainerHttpHeader>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerHttpHeader.DeserializeContainerHttpHeader(item, options));
                    }
                    httpHeaders = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerHttpGet(path, port, scheme, httpHeaders ?? new ChangeTrackingList<ContainerHttpHeader>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerHttpGet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerHttpGet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerHttpGet)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerHttpGet IPersistableModel<ContainerHttpGet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerHttpGet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerHttpGet(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerHttpGet)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerHttpGet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
