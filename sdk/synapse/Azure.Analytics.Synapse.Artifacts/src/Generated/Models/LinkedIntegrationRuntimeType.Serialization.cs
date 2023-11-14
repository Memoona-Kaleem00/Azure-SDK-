// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(LinkedIntegrationRuntimeTypeConverter))]
    public partial class LinkedIntegrationRuntimeType : IUtf8JsonSerializable, IJsonModel<LinkedIntegrationRuntimeType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkedIntegrationRuntimeType>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<LinkedIntegrationRuntimeType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<LinkedIntegrationRuntimeType>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<LinkedIntegrationRuntimeType>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("authorizationType"u8);
            writer.WriteStringValue(AuthorizationType);
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

        LinkedIntegrationRuntimeType IJsonModel<LinkedIntegrationRuntimeType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkedIntegrationRuntimeType)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkedIntegrationRuntimeType(document.RootElement, options);
        }

        internal static LinkedIntegrationRuntimeType DeserializeLinkedIntegrationRuntimeType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("authorizationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Key": return LinkedIntegrationRuntimeKeyAuthorization.DeserializeLinkedIntegrationRuntimeKeyAuthorization(element);
                    case "RBAC": return LinkedIntegrationRuntimeRbacAuthorization.DeserializeLinkedIntegrationRuntimeRbacAuthorization(element);
                }
            }
            return UnknownLinkedIntegrationRuntimeType.DeserializeUnknownLinkedIntegrationRuntimeType(element);
        }

        BinaryData IPersistableModel<LinkedIntegrationRuntimeType>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkedIntegrationRuntimeType)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LinkedIntegrationRuntimeType IPersistableModel<LinkedIntegrationRuntimeType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkedIntegrationRuntimeType)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLinkedIntegrationRuntimeType(document.RootElement, options);
        }

        string IPersistableModel<LinkedIntegrationRuntimeType>.GetWireFormat(ModelReaderWriterOptions options) => "J";

        internal partial class LinkedIntegrationRuntimeTypeConverter : JsonConverter<LinkedIntegrationRuntimeType>
        {
            public override void Write(Utf8JsonWriter writer, LinkedIntegrationRuntimeType model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override LinkedIntegrationRuntimeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeLinkedIntegrationRuntimeType(document.RootElement);
            }
        }
    }
}
