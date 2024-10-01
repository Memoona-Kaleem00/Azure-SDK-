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

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseLibraryData : IUtf8JsonSerializable, IJsonModel<SynapseLibraryData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseLibraryData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SynapseLibraryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseLibraryData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseLibraryData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(NamePropertiesName))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(NamePropertiesName);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (Optional.IsDefined(UploadedOn))
            {
                writer.WritePropertyName("uploadedTimestamp"u8);
                writer.WriteStringValue(UploadedOn.Value, "O");
            }
            if (Optional.IsDefined(TypePropertiesType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(TypePropertiesType);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningStatus))
            {
                writer.WritePropertyName("provisioningStatus"u8);
                writer.WriteStringValue(ProvisioningStatus);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatorId))
            {
                writer.WritePropertyName("creatorId"u8);
                writer.WriteStringValue(CreatorId);
            }
            writer.WriteEndObject();
        }

        SynapseLibraryData IJsonModel<SynapseLibraryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseLibraryData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseLibraryData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseLibraryData(document.RootElement, options);
        }

        internal static SynapseLibraryData DeserializeSynapseLibraryData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string name0 = default;
            string path = default;
            string containerName = default;
            DateTimeOffset? uploadedTimestamp = default;
            string type0 = default;
            string provisioningStatus = default;
            string creatorId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("name"u8))
                        {
                            name0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("path"u8))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerName"u8))
                        {
                            containerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uploadedTimestamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uploadedTimestamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            type0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningStatus"u8))
                        {
                            provisioningStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creatorId"u8))
                        {
                            creatorId = property0.Value.GetString();
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
            return new SynapseLibraryData(
                id,
                name,
                type,
                systemData,
                name0,
                path,
                containerName,
                uploadedTimestamp,
                type0,
                provisioningStatus,
                creatorId,
                etag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SynapseLibraryData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseLibraryData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseLibraryData)} does not support writing '{options.Format}' format.");
            }
        }

        SynapseLibraryData IPersistableModel<SynapseLibraryData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseLibraryData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseLibraryData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseLibraryData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseLibraryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
