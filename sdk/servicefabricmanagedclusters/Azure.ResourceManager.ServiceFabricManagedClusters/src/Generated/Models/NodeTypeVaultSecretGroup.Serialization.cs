// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NodeTypeVaultSecretGroup : IUtf8JsonSerializable, IJsonModel<NodeTypeVaultSecretGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NodeTypeVaultSecretGroup>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NodeTypeVaultSecretGroup>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeVaultSecretGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeTypeVaultSecretGroup)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("sourceVault"u8);
            JsonSerializer.Serialize(writer, SourceVault);
            writer.WritePropertyName("vaultCertificates"u8);
            writer.WriteStartArray();
            foreach (var item in VaultCertificates)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        NodeTypeVaultSecretGroup IJsonModel<NodeTypeVaultSecretGroup>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeVaultSecretGroup>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeTypeVaultSecretGroup)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNodeTypeVaultSecretGroup(document.RootElement, options);
        }

        internal static NodeTypeVaultSecretGroup DeserializeNodeTypeVaultSecretGroup(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            WritableSubResource sourceVault = default;
            IList<NodeTypeVaultCertificate> vaultCertificates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVault"u8))
                {
                    sourceVault = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("vaultCertificates"u8))
                {
                    List<NodeTypeVaultCertificate> array = new List<NodeTypeVaultCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NodeTypeVaultCertificate.DeserializeNodeTypeVaultCertificate(item, options));
                    }
                    vaultCertificates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NodeTypeVaultSecretGroup(sourceVault, vaultCertificates, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NodeTypeVaultSecretGroup>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeVaultSecretGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NodeTypeVaultSecretGroup)} does not support '{options.Format}' format.");
            }
        }

        NodeTypeVaultSecretGroup IPersistableModel<NodeTypeVaultSecretGroup>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeVaultSecretGroup>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNodeTypeVaultSecretGroup(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NodeTypeVaultSecretGroup)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NodeTypeVaultSecretGroup>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
