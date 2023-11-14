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

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class HttpExtension : IUtf8JsonSerializable, IJsonModel<HttpExtension>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HttpExtension>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<HttpExtension>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<HttpExtension>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<HttpExtension>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("endpoint"u8);
            writer.WriteObjectValue(Endpoint);
            writer.WritePropertyName("image"u8);
            writer.WriteObjectValue(Image);
            if (Optional.IsDefined(SamplingOptions))
            {
                writer.WritePropertyName("samplingOptions"u8);
                writer.WriteObjectValue(SamplingOptions);
            }
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        HttpExtension IJsonModel<HttpExtension>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HttpExtension)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHttpExtension(document.RootElement, options);
        }

        internal static HttpExtension DeserializeHttpExtension(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EndpointBase endpoint = default;
            ImageProperties image = default;
            Optional<SamplingOptions> samplingOptions = default;
            string type = default;
            string name = default;
            IList<NodeInput> inputs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = EndpointBase.DeserializeEndpointBase(property.Value);
                    continue;
                }
                if (property.NameEquals("image"u8))
                {
                    image = ImageProperties.DeserializeImageProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("samplingOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    samplingOptions = SamplingOptions.DeserializeSamplingOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<NodeInput> array = new List<NodeInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeInput.DeserializeNodeInput(item));
                    }
                    inputs = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HttpExtension(type, name, inputs, serializedAdditionalRawData, endpoint, image, samplingOptions.Value);
        }

        BinaryData IPersistableModel<HttpExtension>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HttpExtension)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        HttpExtension IPersistableModel<HttpExtension>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(HttpExtension)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeHttpExtension(document.RootElement, options);
        }

        string IPersistableModel<HttpExtension>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
