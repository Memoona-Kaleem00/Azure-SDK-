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
    public partial class ResourceProviderManifest : IUtf8JsonSerializable, IJsonModel<ResourceProviderManifest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceProviderManifest>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceProviderManifest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManifest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceProviderManifest)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProviderAuthentication))
            {
                writer.WritePropertyName("providerAuthentication"u8);
                writer.WriteObjectValue<ResourceProviderAuthentication>(ProviderAuthentication, options);
            }
            if (Optional.IsCollectionDefined(ProviderAuthorizations))
            {
                writer.WritePropertyName("providerAuthorizations"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderAuthorizations)
                {
                    writer.WriteObjectValue<ResourceProviderAuthorization>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Namespace))
            {
                writer.WritePropertyName("namespace"u8);
                writer.WriteStringValue(Namespace);
            }
            if (Optional.IsDefined(ProviderVersion))
            {
                writer.WritePropertyName("providerVersion"u8);
                writer.WriteStringValue(ProviderVersion);
            }
            if (Optional.IsDefined(ProviderType))
            {
                writer.WritePropertyName("providerType"u8);
                writer.WriteStringValue(ProviderType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RequiredFeatures))
            {
                writer.WritePropertyName("requiredFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(FeaturesRule))
            {
                writer.WritePropertyName("featuresRule"u8);
                writer.WriteObjectValue<FeaturesRule>(FeaturesRule, options);
            }
            if (Optional.IsDefined(RequestHeaderOptions))
            {
                writer.WritePropertyName("requestHeaderOptions"u8);
                writer.WriteObjectValue<RequestHeaderOptions>(RequestHeaderOptions, options);
            }
            if (Optional.IsCollectionDefined(ResourceTypes))
            {
                writer.WritePropertyName("resourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceTypes)
                {
                    writer.WriteObjectValue<ProviderResourceType>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Management))
            {
                writer.WritePropertyName("management"u8);
                writer.WriteObjectValue<ResourceProviderManagement>(Management, options);
            }
            if (Optional.IsCollectionDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue<ResourceProviderCapabilities>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                using (JsonDocument document = JsonDocument.Parse(Metadata))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Optional.IsCollectionDefined(GlobalNotificationEndpoints))
            {
                writer.WritePropertyName("globalNotificationEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in GlobalNotificationEndpoints)
                {
                    writer.WriteObjectValue<ResourceProviderEndpoint>(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ReRegisterSubscriptionMetadata))
            {
                writer.WritePropertyName("reRegisterSubscriptionMetadata"u8);
                writer.WriteObjectValue<ReRegisterSubscriptionMetadata>(ReRegisterSubscriptionMetadata, options);
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

        ResourceProviderManifest IJsonModel<ResourceProviderManifest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManifest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceProviderManifest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceProviderManifest(document.RootElement, options);
        }

        internal static ResourceProviderManifest DeserializeResourceProviderManifest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceProviderAuthentication providerAuthentication = default;
            IReadOnlyList<ResourceProviderAuthorization> providerAuthorizations = default;
            string @namespace = default;
            string providerVersion = default;
            ResourceProviderType? providerType = default;
            IReadOnlyList<string> requiredFeatures = default;
            FeaturesRule featuresRule = default;
            RequestHeaderOptions requestHeaderOptions = default;
            IReadOnlyList<ProviderResourceType> resourceTypes = default;
            ResourceProviderManagement management = default;
            IReadOnlyList<ResourceProviderCapabilities> capabilities = default;
            BinaryData metadata = default;
            IReadOnlyList<ResourceProviderEndpoint> globalNotificationEndpoints = default;
            ReRegisterSubscriptionMetadata reRegisterSubscriptionMetadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerAuthentication = ResourceProviderAuthentication.DeserializeResourceProviderAuthentication(property.Value, options);
                    continue;
                }
                if (property.NameEquals("providerAuthorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderAuthorization> array = new List<ResourceProviderAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderAuthorization.DeserializeResourceProviderAuthorization(item, options));
                    }
                    providerAuthorizations = array;
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerVersion"u8))
                {
                    providerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("providerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerType = new ResourceProviderType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requiredFeatures"u8))
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
                    requiredFeatures = array;
                    continue;
                }
                if (property.NameEquals("featuresRule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featuresRule = FeaturesRule.DeserializeFeaturesRule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("requestHeaderOptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestHeaderOptions = RequestHeaderOptions.DeserializeRequestHeaderOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderResourceType> array = new List<ProviderResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderResourceType.DeserializeProviderResourceType(item, options));
                    }
                    resourceTypes = array;
                    continue;
                }
                if (property.NameEquals("management"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    management = ResourceProviderManagement.DeserializeResourceProviderManagement(property.Value, options);
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderCapabilities> array = new List<ResourceProviderCapabilities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderCapabilities.DeserializeResourceProviderCapabilities(item, options));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    metadata = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("globalNotificationEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderEndpoint> array = new List<ResourceProviderEndpoint>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderEndpoint.DeserializeResourceProviderEndpoint(item, options));
                    }
                    globalNotificationEndpoints = array;
                    continue;
                }
                if (property.NameEquals("reRegisterSubscriptionMetadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reRegisterSubscriptionMetadata = ReRegisterSubscriptionMetadata.DeserializeReRegisterSubscriptionMetadata(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceProviderManifest(
                providerAuthentication,
                providerAuthorizations ?? new ChangeTrackingList<ResourceProviderAuthorization>(),
                @namespace,
                providerVersion,
                providerType,
                requiredFeatures ?? new ChangeTrackingList<string>(),
                featuresRule,
                requestHeaderOptions,
                resourceTypes ?? new ChangeTrackingList<ProviderResourceType>(),
                management,
                capabilities ?? new ChangeTrackingList<ResourceProviderCapabilities>(),
                metadata,
                globalNotificationEndpoints ?? new ChangeTrackingList<ResourceProviderEndpoint>(),
                reRegisterSubscriptionMetadata,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceProviderManifest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManifest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceProviderManifest)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceProviderManifest IPersistableModel<ResourceProviderManifest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceProviderManifest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceProviderManifest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceProviderManifest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceProviderManifest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
