// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    public partial class InformaticaServerlessRuntimeProperties : IUtf8JsonSerializable, IJsonModel<InformaticaServerlessRuntimeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InformaticaServerlessRuntimeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<InformaticaServerlessRuntimeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaServerlessRuntimeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InformaticaServerlessRuntimeProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Platform))
            {
                writer.WritePropertyName("platform"u8);
                writer.WriteStringValue(Platform.Value.ToString());
            }
            if (Optional.IsDefined(ApplicationType))
            {
                writer.WritePropertyName("applicationType"u8);
                writer.WriteStringValue(ApplicationType.Value.ToString());
            }
            if (Optional.IsDefined(ComputeUnits))
            {
                writer.WritePropertyName("computeUnits"u8);
                writer.WriteStringValue(ComputeUnits);
            }
            if (Optional.IsDefined(ExecutionTimeout))
            {
                writer.WritePropertyName("executionTimeout"u8);
                writer.WriteStringValue(ExecutionTimeout);
            }
            writer.WritePropertyName("serverlessAccountLocation"u8);
            writer.WriteStringValue(ServerlessAccountLocation);
            if (Optional.IsDefined(ServerlessRuntimeNetworkProfile))
            {
                writer.WritePropertyName("serverlessRuntimeNetworkProfile"u8);
                writer.WriteObjectValue(ServerlessRuntimeNetworkProfile, options);
            }
            if (Optional.IsCollectionDefined(AdvancedCustomProperties))
            {
                writer.WritePropertyName("advancedCustomProperties"u8);
                writer.WriteStartArray();
                foreach (var item in AdvancedCustomProperties)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SupplementaryFileLocation))
            {
                writer.WritePropertyName("supplementaryFileLocation"u8);
                writer.WriteStringValue(SupplementaryFileLocation);
            }
            if (Optional.IsDefined(ServerlessRuntimeConfig))
            {
                writer.WritePropertyName("serverlessRuntimeConfig"u8);
                writer.WriteObjectValue(ServerlessRuntimeConfig, options);
            }
            if (Optional.IsCollectionDefined(ServerlessRuntimeTags))
            {
                writer.WritePropertyName("serverlessRuntimeTags"u8);
                writer.WriteStartArray();
                foreach (var item in ServerlessRuntimeTags)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ServerlessRuntimeUserContextProperties))
            {
                writer.WritePropertyName("serverlessRuntimeUserContextProperties"u8);
                writer.WriteObjectValue(ServerlessRuntimeUserContextProperties, options);
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

        InformaticaServerlessRuntimeProperties IJsonModel<InformaticaServerlessRuntimeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaServerlessRuntimeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InformaticaServerlessRuntimeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInformaticaServerlessRuntimeProperties(document.RootElement, options);
        }

        internal static InformaticaServerlessRuntimeProperties DeserializeInformaticaServerlessRuntimeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InformaticaProvisioningState? provisioningState = default;
            string description = default;
            InformaticaPlatformType? platform = default;
            InformaticaApplicationType? applicationType = default;
            string computeUnits = default;
            string executionTimeout = default;
            string serverlessAccountLocation = default;
            ServerlessRuntimeNetworkProfile serverlessRuntimeNetworkProfile = default;
            IList<AdvancedCustomProperties> advancedCustomProperties = default;
            string supplementaryFileLocation = default;
            ServerlessRuntimeConfigProperties serverlessRuntimeConfig = default;
            IList<ServerlessRuntimeTag> serverlessRuntimeTags = default;
            ServerlessRuntimeUserContextProperties serverlessRuntimeUserContextProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new InformaticaProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("platform"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    platform = new InformaticaPlatformType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationType = new InformaticaApplicationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("computeUnits"u8))
                {
                    computeUnits = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("executionTimeout"u8))
                {
                    executionTimeout = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverlessAccountLocation"u8))
                {
                    serverlessAccountLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverlessRuntimeNetworkProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverlessRuntimeNetworkProfile = ServerlessRuntimeNetworkProfile.DeserializeServerlessRuntimeNetworkProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("advancedCustomProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AdvancedCustomProperties> array = new List<AdvancedCustomProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.AdvancedCustomProperties.DeserializeAdvancedCustomProperties(item, options));
                    }
                    advancedCustomProperties = array;
                    continue;
                }
                if (property.NameEquals("supplementaryFileLocation"u8))
                {
                    supplementaryFileLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverlessRuntimeConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverlessRuntimeConfig = ServerlessRuntimeConfigProperties.DeserializeServerlessRuntimeConfigProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serverlessRuntimeTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServerlessRuntimeTag> array = new List<ServerlessRuntimeTag>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServerlessRuntimeTag.DeserializeServerlessRuntimeTag(item, options));
                    }
                    serverlessRuntimeTags = array;
                    continue;
                }
                if (property.NameEquals("serverlessRuntimeUserContextProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serverlessRuntimeUserContextProperties = ServerlessRuntimeUserContextProperties.DeserializeServerlessRuntimeUserContextProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InformaticaServerlessRuntimeProperties(
                provisioningState,
                description,
                platform,
                applicationType,
                computeUnits,
                executionTimeout,
                serverlessAccountLocation,
                serverlessRuntimeNetworkProfile,
                advancedCustomProperties ?? new ChangeTrackingList<AdvancedCustomProperties>(),
                supplementaryFileLocation,
                serverlessRuntimeConfig,
                serverlessRuntimeTags ?? new ChangeTrackingList<ServerlessRuntimeTag>(),
                serverlessRuntimeUserContextProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InformaticaServerlessRuntimeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaServerlessRuntimeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InformaticaServerlessRuntimeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        InformaticaServerlessRuntimeProperties IPersistableModel<InformaticaServerlessRuntimeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InformaticaServerlessRuntimeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInformaticaServerlessRuntimeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InformaticaServerlessRuntimeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InformaticaServerlessRuntimeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
