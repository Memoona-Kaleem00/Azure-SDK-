// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApplicationInsights.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApplicationInsights
{
    public partial class WebTestData : IUtf8JsonSerializable, IJsonModel<WebTestData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebTestData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebTestData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebTestData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind.HasValue)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToSerialString());
            }
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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (SyntheticMonitorId != null)
            {
                writer.WritePropertyName("SyntheticMonitorId"u8);
                writer.WriteStringValue(SyntheticMonitorId);
            }
            if (WebTestName != null)
            {
                writer.WritePropertyName("Name"u8);
                writer.WriteStringValue(WebTestName);
            }
            if (Description != null)
            {
                writer.WritePropertyName("Description"u8);
                writer.WriteStringValue(Description);
            }
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("Enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (FrequencyInSeconds.HasValue)
            {
                writer.WritePropertyName("Frequency"u8);
                writer.WriteNumberValue(FrequencyInSeconds.Value);
            }
            if (TimeoutInSeconds.HasValue)
            {
                writer.WritePropertyName("Timeout"u8);
                writer.WriteNumberValue(TimeoutInSeconds.Value);
            }
            if (WebTestKind.HasValue)
            {
                writer.WritePropertyName("Kind"u8);
                writer.WriteStringValue(WebTestKind.Value.ToSerialString());
            }
            if (IsRetryEnabled.HasValue)
            {
                writer.WritePropertyName("RetryEnabled"u8);
                writer.WriteBooleanValue(IsRetryEnabled.Value);
            }
            if (!(Locations is ChangeTrackingList<WebTestGeolocation> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("Locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Configuration != null)
            {
                writer.WritePropertyName("Configuration"u8);
                writer.WriteObjectValue(Configuration);
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Request != null)
            {
                writer.WritePropertyName("Request"u8);
                writer.WriteObjectValue(Request);
            }
            if (ValidationRules != null)
            {
                writer.WritePropertyName("ValidationRules"u8);
                writer.WriteObjectValue(ValidationRules);
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

        WebTestData IJsonModel<WebTestData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebTestData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebTestData(document.RootElement, options);
        }

        internal static WebTestData DeserializeWebTestData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WebTestKind> kind = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> syntheticMonitorId = default;
            Optional<string> name0 = default;
            Optional<string> description = default;
            Optional<bool> enabled = default;
            Optional<int> frequency = default;
            Optional<int> timeout = default;
            Optional<WebTestKind> kind0 = default;
            Optional<bool> retryEnabled = default;
            IList<WebTestGeolocation> locations = default;
            Optional<WebTestPropertiesConfiguration> configuration = default;
            Optional<string> provisioningState = default;
            Optional<WebTestPropertiesRequest> request = default;
            Optional<WebTestPropertiesValidationRules> validationRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = property.Value.GetString().ToWebTestKind();
                    continue;
                }
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("SyntheticMonitorId"u8))
                        {
                            syntheticMonitorId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("Name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("Description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("Enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("Frequency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frequency = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("Timeout"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            timeout = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("Kind"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            kind0 = property0.Value.GetString().ToWebTestKind();
                            continue;
                        }
                        if (property0.NameEquals("RetryEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retryEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("Locations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WebTestGeolocation> array = new List<WebTestGeolocation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(WebTestGeolocation.DeserializeWebTestGeolocation(item, options));
                            }
                            locations = array;
                            continue;
                        }
                        if (property0.NameEquals("Configuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configuration = WebTestPropertiesConfiguration.DeserializeWebTestPropertiesConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("Request"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            request = WebTestPropertiesRequest.DeserializeWebTestPropertiesRequest(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("ValidationRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validationRules = WebTestPropertiesValidationRules.DeserializeWebTestPropertiesValidationRules(property0.Value, options);
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
            return new WebTestData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(kind), syntheticMonitorId.Value, name0.Value, description.Value, Optional.ToNullable(enabled), Optional.ToNullable(frequency), Optional.ToNullable(timeout), Optional.ToNullable(kind0), Optional.ToNullable(retryEnabled), locations ?? new ChangeTrackingList<WebTestGeolocation>(), configuration.Value, provisioningState.Value, request.Value, validationRules.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebTestData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebTestData)} does not support '{options.Format}' format.");
            }
        }

        WebTestData IPersistableModel<WebTestData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebTestData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebTestData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebTestData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebTestData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
