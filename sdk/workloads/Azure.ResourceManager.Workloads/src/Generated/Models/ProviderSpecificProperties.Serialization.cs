// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    [PersistableModelProxy(typeof(UnknownProviderSpecificProperties))]
    public partial class ProviderSpecificProperties : IUtf8JsonSerializable, IJsonModel<ProviderSpecificProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProviderSpecificProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ProviderSpecificProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ProviderSpecificProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ProviderSpecificProperties>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("providerType"u8);
            writer.WriteStringValue(ProviderType);
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

        ProviderSpecificProperties IJsonModel<ProviderSpecificProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProviderSpecificProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderSpecificProperties(document.RootElement, options);
        }

        internal static ProviderSpecificProperties DeserializeProviderSpecificProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("providerType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Db2": return DB2ProviderInstanceProperties.DeserializeDB2ProviderInstanceProperties(element);
                    case "MsSqlServer": return MsSqlServerProviderInstanceProperties.DeserializeMsSqlServerProviderInstanceProperties(element);
                    case "PrometheusHaCluster": return PrometheusHAClusterProviderInstanceProperties.DeserializePrometheusHAClusterProviderInstanceProperties(element);
                    case "PrometheusOS": return PrometheusOSProviderInstanceProperties.DeserializePrometheusOSProviderInstanceProperties(element);
                    case "SapHana": return HanaDBProviderInstanceProperties.DeserializeHanaDBProviderInstanceProperties(element);
                    case "SapNetWeaver": return SapNetWeaverProviderInstanceProperties.DeserializeSapNetWeaverProviderInstanceProperties(element);
                }
            }
            return UnknownProviderSpecificProperties.DeserializeUnknownProviderSpecificProperties(element);
        }

        BinaryData IPersistableModel<ProviderSpecificProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProviderSpecificProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ProviderSpecificProperties IPersistableModel<ProviderSpecificProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ProviderSpecificProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeProviderSpecificProperties(document.RootElement, options);
        }

        string IPersistableModel<ProviderSpecificProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
