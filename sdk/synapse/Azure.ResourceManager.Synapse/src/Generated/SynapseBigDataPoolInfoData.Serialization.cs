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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseBigDataPoolInfoData : IUtf8JsonSerializable, IJsonModel<SynapseBigDataPoolInfoData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseBigDataPoolInfoData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseBigDataPoolInfoData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseBigDataPoolInfoData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseBigDataPoolInfoData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(AutoScale))
            {
                writer.WritePropertyName("autoScale"u8);
                writer.WriteObjectValue(AutoScale, options);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(AutoPause))
            {
                writer.WritePropertyName("autoPause"u8);
                writer.WriteObjectValue(AutoPause, options);
            }
            if (Optional.IsDefined(IsComputeIsolationEnabled))
            {
                writer.WritePropertyName("isComputeIsolationEnabled"u8);
                writer.WriteBooleanValue(IsComputeIsolationEnabled.Value);
            }
            if (Optional.IsDefined(IsAutotuneEnabled))
            {
                writer.WritePropertyName("isAutotuneEnabled"u8);
                writer.WriteBooleanValue(IsAutotuneEnabled.Value);
            }
            if (Optional.IsDefined(IsSessionLevelPackagesEnabled))
            {
                writer.WritePropertyName("sessionLevelPackagesEnabled"u8);
                writer.WriteBooleanValue(IsSessionLevelPackagesEnabled.Value);
            }
            if (Optional.IsDefined(CacheSize))
            {
                writer.WritePropertyName("cacheSize"u8);
                writer.WriteNumberValue(CacheSize.Value);
            }
            if (Optional.IsDefined(DynamicExecutorAllocation))
            {
                writer.WritePropertyName("dynamicExecutorAllocation"u8);
                writer.WriteObjectValue(DynamicExecutorAllocation, options);
            }
            if (Optional.IsDefined(SparkEventsFolder))
            {
                writer.WritePropertyName("sparkEventsFolder"u8);
                writer.WriteStringValue(SparkEventsFolder);
            }
            if (Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (Optional.IsDefined(LibraryRequirements))
            {
                writer.WritePropertyName("libraryRequirements"u8);
                writer.WriteObjectValue(LibraryRequirements, options);
            }
            if (Optional.IsCollectionDefined(CustomLibraries))
            {
                writer.WritePropertyName("customLibraries"u8);
                writer.WriteStartArray();
                foreach (var item in CustomLibraries)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SparkConfigProperties))
            {
                writer.WritePropertyName("sparkConfigProperties"u8);
                writer.WriteObjectValue(SparkConfigProperties, options);
            }
            if (Optional.IsDefined(SparkVersion))
            {
                writer.WritePropertyName("sparkVersion"u8);
                writer.WriteStringValue(SparkVersion);
            }
            if (Optional.IsDefined(DefaultSparkLogFolder))
            {
                writer.WritePropertyName("defaultSparkLogFolder"u8);
                writer.WriteStringValue(DefaultSparkLogFolder);
            }
            if (Optional.IsDefined(NodeSize))
            {
                writer.WritePropertyName("nodeSize"u8);
                writer.WriteStringValue(NodeSize.Value.ToString());
            }
            if (Optional.IsDefined(NodeSizeFamily))
            {
                writer.WritePropertyName("nodeSizeFamily"u8);
                writer.WriteStringValue(NodeSizeFamily.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(LastSucceededOn))
            {
                writer.WritePropertyName("lastSucceededTimestamp"u8);
                writer.WriteStringValue(LastSucceededOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        SynapseBigDataPoolInfoData IJsonModel<SynapseBigDataPoolInfoData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseBigDataPoolInfoData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseBigDataPoolInfoData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseBigDataPoolInfoData(document.RootElement, options);
        }

        internal static SynapseBigDataPoolInfoData DeserializeSynapseBigDataPoolInfoData(JsonElement element, ModelReaderWriterOptions options = null)
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
            string provisioningState = default;
            BigDataPoolAutoScaleProperties autoScale = default;
            DateTimeOffset? creationDate = default;
            BigDataPoolAutoPauseProperties autoPause = default;
            bool? isComputeIsolationEnabled = default;
            bool? isAutotuneEnabled = default;
            bool? sessionLevelPackagesEnabled = default;
            int? cacheSize = default;
            SynapseDynamicExecutorAllocation dynamicExecutorAllocation = default;
            string sparkEventsFolder = default;
            int? nodeCount = default;
            BigDataPoolLibraryRequirements libraryRequirements = default;
            IList<BigDataPoolLibraryInfo> customLibraries = default;
            BigDataPoolSparkConfigProperties sparkConfigProperties = default;
            string sparkVersion = default;
            string defaultSparkLogFolder = default;
            BigDataPoolNodeSize? nodeSize = default;
            BigDataPoolNodeSizeFamily? nodeSizeFamily = default;
            DateTimeOffset? lastSucceededTimestamp = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoScale"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoScale = BigDataPoolAutoScaleProperties.DeserializeBigDataPoolAutoScaleProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("creationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("autoPause"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoPause = BigDataPoolAutoPauseProperties.DeserializeBigDataPoolAutoPauseProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("isComputeIsolationEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isComputeIsolationEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isAutotuneEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAutotuneEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("sessionLevelPackagesEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sessionLevelPackagesEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("cacheSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cacheSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dynamicExecutorAllocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dynamicExecutorAllocation = SynapseDynamicExecutorAllocation.DeserializeSynapseDynamicExecutorAllocation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sparkEventsFolder"u8))
                        {
                            sparkEventsFolder = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("libraryRequirements"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            libraryRequirements = BigDataPoolLibraryRequirements.DeserializeBigDataPoolLibraryRequirements(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("customLibraries"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<BigDataPoolLibraryInfo> array = new List<BigDataPoolLibraryInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BigDataPoolLibraryInfo.DeserializeBigDataPoolLibraryInfo(item, options));
                            }
                            customLibraries = array;
                            continue;
                        }
                        if (property0.NameEquals("sparkConfigProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sparkConfigProperties = BigDataPoolSparkConfigProperties.DeserializeBigDataPoolSparkConfigProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("sparkVersion"u8))
                        {
                            sparkVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultSparkLogFolder"u8))
                        {
                            defaultSparkLogFolder = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nodeSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeSize = new BigDataPoolNodeSize(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("nodeSizeFamily"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeSizeFamily = new BigDataPoolNodeSizeFamily(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("lastSucceededTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastSucceededTimestamp = property0.Value.GetDateTimeOffset("O");
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
            return new SynapseBigDataPoolInfoData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                provisioningState,
                autoScale,
                creationDate,
                autoPause,
                isComputeIsolationEnabled,
                isAutotuneEnabled,
                sessionLevelPackagesEnabled,
                cacheSize,
                dynamicExecutorAllocation,
                sparkEventsFolder,
                nodeCount,
                libraryRequirements,
                customLibraries ?? new ChangeTrackingList<BigDataPoolLibraryInfo>(),
                sparkConfigProperties,
                sparkVersion,
                defaultSparkLogFolder,
                nodeSize,
                nodeSizeFamily,
                lastSucceededTimestamp,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseBigDataPoolInfoData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseBigDataPoolInfoData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseBigDataPoolInfoData)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseBigDataPoolInfoData IPersistableModel<SynapseBigDataPoolInfoData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseBigDataPoolInfoData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseBigDataPoolInfoData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseBigDataPoolInfoData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseBigDataPoolInfoData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
