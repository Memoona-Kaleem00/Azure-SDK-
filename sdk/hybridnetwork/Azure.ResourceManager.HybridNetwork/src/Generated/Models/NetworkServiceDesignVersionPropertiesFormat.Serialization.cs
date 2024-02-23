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

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class NetworkServiceDesignVersionPropertiesFormat : IUtf8JsonSerializable, IJsonModel<NetworkServiceDesignVersionPropertiesFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkServiceDesignVersionPropertiesFormat>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkServiceDesignVersionPropertiesFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkServiceDesignVersionPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkServiceDesignVersionPropertiesFormat)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && VersionState.HasValue)
            {
                writer.WritePropertyName("versionState"u8);
                writer.WriteStringValue(VersionState.Value.ToString());
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(ConfigurationGroupSchemaReferences is ChangeTrackingDictionary<string, WritableSubResource> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("configurationGroupSchemaReferences"u8);
                writer.WriteStartObject();
                foreach (var item in ConfigurationGroupSchemaReferences)
                {
                    writer.WritePropertyName(item.Key);
                    JsonSerializer.Serialize(writer, item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(NfvisFromSite is ChangeTrackingDictionary<string, NfviDetails> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("nfvisFromSite"u8);
                writer.WriteStartObject();
                foreach (var item in NfvisFromSite)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(ResourceElementTemplates is ChangeTrackingList<ResourceElementTemplate> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("resourceElementTemplates"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceElementTemplates)
                {
                    writer.WriteObjectValue(item);
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

        NetworkServiceDesignVersionPropertiesFormat IJsonModel<NetworkServiceDesignVersionPropertiesFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkServiceDesignVersionPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkServiceDesignVersionPropertiesFormat)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkServiceDesignVersionPropertiesFormat(document.RootElement, options);
        }

        internal static NetworkServiceDesignVersionPropertiesFormat DeserializeNetworkServiceDesignVersionPropertiesFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<VersionState> versionState = default;
            Optional<string> description = default;
            Optional<IDictionary<string, WritableSubResource>> configurationGroupSchemaReferences = default;
            Optional<IDictionary<string, NfviDetails>> nfvisFromSite = default;
            Optional<IList<ResourceElementTemplate>> resourceElementTemplates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("versionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versionState = new VersionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationGroupSchemaReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, WritableSubResource> dictionary = new Dictionary<string, WritableSubResource>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText()));
                    }
                    configurationGroupSchemaReferences = dictionary;
                    continue;
                }
                if (property.NameEquals("nfvisFromSite"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, NfviDetails> dictionary = new Dictionary<string, NfviDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, NfviDetails.DeserializeNfviDetails(property0.Value, options));
                    }
                    nfvisFromSite = dictionary;
                    continue;
                }
                if (property.NameEquals("resourceElementTemplates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceElementTemplate> array = new List<ResourceElementTemplate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceElementTemplate.DeserializeResourceElementTemplate(item, options));
                    }
                    resourceElementTemplates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkServiceDesignVersionPropertiesFormat(Optional.ToNullable(provisioningState), Optional.ToNullable(versionState), description.Value, Optional.ToDictionary(configurationGroupSchemaReferences), Optional.ToDictionary(nfvisFromSite), Optional.ToList(resourceElementTemplates), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkServiceDesignVersionPropertiesFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkServiceDesignVersionPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkServiceDesignVersionPropertiesFormat)} does not support '{options.Format}' format.");
            }
        }

        NetworkServiceDesignVersionPropertiesFormat IPersistableModel<NetworkServiceDesignVersionPropertiesFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkServiceDesignVersionPropertiesFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkServiceDesignVersionPropertiesFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkServiceDesignVersionPropertiesFormat)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkServiceDesignVersionPropertiesFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
