// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class CdnEndpointPatch : IUtf8JsonSerializable, IJsonModel<CdnEndpointPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CdnEndpointPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CdnEndpointPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnEndpointPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnEndpointPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (OriginPath != null)
            {
                writer.WritePropertyName("originPath"u8);
                writer.WriteStringValue(OriginPath);
            }
            if (!(ContentTypesToCompress is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("contentTypesToCompress"u8);
                writer.WriteStartArray();
                foreach (var item in ContentTypesToCompress)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (OriginHostHeader != null)
            {
                writer.WritePropertyName("originHostHeader"u8);
                writer.WriteStringValue(OriginHostHeader);
            }
            if (IsCompressionEnabled.HasValue)
            {
                writer.WritePropertyName("isCompressionEnabled"u8);
                writer.WriteBooleanValue(IsCompressionEnabled.Value);
            }
            if (IsHttpAllowed.HasValue)
            {
                writer.WritePropertyName("isHttpAllowed"u8);
                writer.WriteBooleanValue(IsHttpAllowed.Value);
            }
            if (IsHttpsAllowed.HasValue)
            {
                writer.WritePropertyName("isHttpsAllowed"u8);
                writer.WriteBooleanValue(IsHttpsAllowed.Value);
            }
            if (QueryStringCachingBehavior.HasValue)
            {
                writer.WritePropertyName("queryStringCachingBehavior"u8);
                writer.WriteStringValue(QueryStringCachingBehavior.Value.ToSerialString());
            }
            if (OptimizationType.HasValue)
            {
                if (OptimizationType != null)
                {
                    writer.WritePropertyName("optimizationType"u8);
                    writer.WriteStringValue(OptimizationType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("optimizationType");
                }
            }
            if (ProbePath != null)
            {
                writer.WritePropertyName("probePath"u8);
                writer.WriteStringValue(ProbePath);
            }
            if (!(GeoFilters is ChangeTrackingList<GeoFilter> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("geoFilters"u8);
                writer.WriteStartArray();
                foreach (var item in GeoFilters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultOriginGroup != null)
            {
                if (DefaultOriginGroup != null)
                {
                    writer.WritePropertyName("defaultOriginGroup"u8);
                    writer.WriteObjectValue(DefaultOriginGroup);
                }
                else
                {
                    writer.WriteNull("defaultOriginGroup");
                }
            }
            if (!(UriSigningKeys is ChangeTrackingList<UriSigningKey> collection2 && collection2.IsUndefined))
            {
                if (UriSigningKeys != null)
                {
                    writer.WritePropertyName("urlSigningKeys"u8);
                    writer.WriteStartArray();
                    foreach (var item in UriSigningKeys)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("urlSigningKeys");
                }
            }
            if (DeliveryPolicy != null)
            {
                if (DeliveryPolicy != null)
                {
                    writer.WritePropertyName("deliveryPolicy"u8);
                    writer.WriteObjectValue(DeliveryPolicy);
                }
                else
                {
                    writer.WriteNull("deliveryPolicy");
                }
            }
            if (WebApplicationFirewallPolicyLink != null)
            {
                if (WebApplicationFirewallPolicyLink != null)
                {
                    writer.WritePropertyName("webApplicationFirewallPolicyLink"u8);
                    writer.WriteObjectValue(WebApplicationFirewallPolicyLink);
                }
                else
                {
                    writer.WriteNull("webApplicationFirewallPolicyLink");
                }
            }
            writer.WriteEndObject();
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

        CdnEndpointPatch IJsonModel<CdnEndpointPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnEndpointPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CdnEndpointPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCdnEndpointPatch(document.RootElement, options);
        }

        internal static CdnEndpointPatch DeserializeCdnEndpointPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            Optional<string> originPath = default;
            IList<string> contentTypesToCompress = default;
            Optional<string> originHostHeader = default;
            Optional<bool> isCompressionEnabled = default;
            Optional<bool> isHttpAllowed = default;
            Optional<bool> isHttpsAllowed = default;
            Optional<QueryStringCachingBehavior> queryStringCachingBehavior = default;
            Optional<OptimizationType?> optimizationType = default;
            Optional<string> probePath = default;
            IList<GeoFilter> geoFilters = default;
            Optional<EndpointPropertiesUpdateParametersDefaultOriginGroup> defaultOriginGroup = default;
            IList<UriSigningKey> uriSigningKeys = default;
            Optional<EndpointDeliveryPolicy> deliveryPolicy = default;
            Optional<EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink> webApplicationFirewallPolicyLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("originPath"u8))
                        {
                            originPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contentTypesToCompress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            contentTypesToCompress = array;
                            continue;
                        }
                        if (property0.NameEquals("originHostHeader"u8))
                        {
                            originHostHeader = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isCompressionEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCompressionEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isHttpAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isHttpAllowed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isHttpsAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isHttpsAllowed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("queryStringCachingBehavior"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryStringCachingBehavior = property0.Value.GetString().ToQueryStringCachingBehavior();
                            continue;
                        }
                        if (property0.NameEquals("optimizationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                optimizationType = null;
                                continue;
                            }
                            optimizationType = new OptimizationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("probePath"u8))
                        {
                            probePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("geoFilters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<GeoFilter> array = new List<GeoFilter>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(GeoFilter.DeserializeGeoFilter(item, options));
                            }
                            geoFilters = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultOriginGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                defaultOriginGroup = null;
                                continue;
                            }
                            defaultOriginGroup = EndpointPropertiesUpdateParametersDefaultOriginGroup.DeserializeEndpointPropertiesUpdateParametersDefaultOriginGroup(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("urlSigningKeys"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                uriSigningKeys = null;
                                continue;
                            }
                            List<UriSigningKey> array = new List<UriSigningKey>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(UriSigningKey.DeserializeUriSigningKey(item, options));
                            }
                            uriSigningKeys = array;
                            continue;
                        }
                        if (property0.NameEquals("deliveryPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                deliveryPolicy = null;
                                continue;
                            }
                            deliveryPolicy = EndpointDeliveryPolicy.DeserializeEndpointDeliveryPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("webApplicationFirewallPolicyLink"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                webApplicationFirewallPolicyLink = null;
                                continue;
                            }
                            webApplicationFirewallPolicyLink = EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink.DeserializeEndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CdnEndpointPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                originPath.Value,
                contentTypesToCompress ?? new ChangeTrackingList<string>(),
                originHostHeader.Value,
                Optional.ToNullable(isCompressionEnabled),
                Optional.ToNullable(isHttpAllowed),
                Optional.ToNullable(isHttpsAllowed),
                Optional.ToNullable(queryStringCachingBehavior),
                Optional.ToNullable(optimizationType),
                probePath.Value,
                geoFilters ?? new ChangeTrackingList<GeoFilter>(),
                defaultOriginGroup.Value,
                uriSigningKeys ?? new ChangeTrackingList<UriSigningKey>(),
                deliveryPolicy.Value,
                webApplicationFirewallPolicyLink.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CdnEndpointPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnEndpointPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CdnEndpointPatch)} does not support '{options.Format}' format.");
            }
        }

        CdnEndpointPatch IPersistableModel<CdnEndpointPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CdnEndpointPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCdnEndpointPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CdnEndpointPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CdnEndpointPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
