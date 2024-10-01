// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class AutoscaleSettingData : IUtf8JsonSerializable, IJsonModel<AutoscaleSettingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoscaleSettingData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AutoscaleSettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleSettingData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("profiles"u8);
            writer.WriteStartArray();
            foreach (var item in Profiles)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Notifications))
            {
                if (Notifications != null)
                {
                    writer.WritePropertyName("notifications"u8);
                    writer.WriteStartArray();
                    foreach (var item in Notifications)
                    {
                        writer.WriteObjectValue(item, options);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("notifications");
                }
            }
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(PredictiveAutoscalePolicy))
            {
                if (PredictiveAutoscalePolicy != null)
                {
                    writer.WritePropertyName("predictiveAutoscalePolicy"u8);
                    writer.WriteObjectValue(PredictiveAutoscalePolicy, options);
                }
                else
                {
                    writer.WriteNull("predictiveAutoscalePolicy");
                }
            }
            if (Optional.IsDefined(AutoscaleSettingName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(AutoscaleSettingName);
            }
            if (Optional.IsDefined(TargetResourceId))
            {
                writer.WritePropertyName("targetResourceUri"u8);
                writer.WriteStringValue(TargetResourceId);
            }
            if (Optional.IsDefined(TargetResourceLocation))
            {
                writer.WritePropertyName("targetResourceLocation"u8);
                writer.WriteStringValue(TargetResourceLocation.Value);
            }
            writer.WriteEndObject();
        }

        AutoscaleSettingData IJsonModel<AutoscaleSettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleSettingData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoscaleSettingData(document.RootElement, options);
        }

        internal static AutoscaleSettingData DeserializeAutoscaleSettingData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IList<AutoscaleProfile> profiles = default;
            IList<AutoscaleNotification> notifications = default;
            bool? enabled = default;
            PredictiveAutoscalePolicy predictiveAutoscalePolicy = default;
            string name0 = default;
            ResourceIdentifier targetResourceUri = default;
            AzureLocation? targetResourceLocation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("profiles"u8))
                        {
                            List<AutoscaleProfile> array = new List<AutoscaleProfile>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutoscaleProfile.DeserializeAutoscaleProfile(item, options));
                            }
                            profiles = array;
                            continue;
                        }
                        if (property0.NameEquals("notifications"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                notifications = null;
                                continue;
                            }
                            List<AutoscaleNotification> array = new List<AutoscaleNotification>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutoscaleNotification.DeserializeAutoscaleNotification(item, options));
                            }
                            notifications = array;
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("predictiveAutoscalePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                predictiveAutoscalePolicy = null;
                                continue;
                            }
                            predictiveAutoscalePolicy = PredictiveAutoscalePolicy.DeserializePredictiveAutoscalePolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResourceUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceUri = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetResourceLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AutoscaleSettingData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                profiles,
                notifications ?? new ChangeTrackingList<AutoscaleNotification>(),
                enabled,
                predictiveAutoscalePolicy,
                name0,
                targetResourceUri,
                targetResourceLocation,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoscaleSettingData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoscaleSettingData)} does not support writing '{options.Format}' format.");
            }
        }

        AutoscaleSettingData IPersistableModel<AutoscaleSettingData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoscaleSettingData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoscaleSettingData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoscaleSettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
