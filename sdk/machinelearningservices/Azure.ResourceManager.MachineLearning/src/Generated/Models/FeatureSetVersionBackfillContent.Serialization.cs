// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class FeatureSetVersionBackfillContent : IUtf8JsonSerializable, IJsonModel<FeatureSetVersionBackfillContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FeatureSetVersionBackfillContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FeatureSetVersionBackfillContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FeatureSetVersionBackfillContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FeatureSetVersionBackfillContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(FeatureWindow))
            {
                if (FeatureWindow != null)
                {
                    writer.WritePropertyName("featureWindow"u8);
                    writer.WriteObjectValue(FeatureWindow, options);
                }
                else
                {
                    writer.WriteNull("featureWindow");
                }
            }
            if (Optional.IsCollectionDefined(DataAvailabilityStatus))
            {
                writer.WritePropertyName("dataAvailabilityStatus"u8);
                writer.WriteStartArray();
                foreach (var item in DataAvailabilityStatus)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (Optional.IsCollectionDefined(Tags))
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
            if (Optional.IsDefined(Resource))
            {
                writer.WritePropertyName("resource"u8);
                writer.WriteObjectValue(Resource, options);
            }
            if (Optional.IsCollectionDefined(SparkConfiguration))
            {
                writer.WritePropertyName("sparkConfiguration"u8);
                writer.WriteStartObject();
                foreach (var item in SparkConfiguration)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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
        }

        FeatureSetVersionBackfillContent IJsonModel<FeatureSetVersionBackfillContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FeatureSetVersionBackfillContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FeatureSetVersionBackfillContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFeatureSetVersionBackfillContent(document.RootElement, options);
        }

        internal static FeatureSetVersionBackfillContent DeserializeFeatureSetVersionBackfillContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayName = default;
            string description = default;
            FeatureWindow featureWindow = default;
            IList<DataAvailabilityStatus> dataAvailabilityStatus = default;
            string jobId = default;
            IDictionary<string, string> tags = default;
            MaterializationComputeResource resource = default;
            IDictionary<string, string> sparkConfiguration = default;
            IDictionary<string, string> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("featureWindow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featureWindow = null;
                        continue;
                    }
                    featureWindow = FeatureWindow.DeserializeFeatureWindow(property.Value, options);
                    continue;
                }
                if (property.NameEquals("dataAvailabilityStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataAvailabilityStatus> array = new List<DataAvailabilityStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new DataAvailabilityStatus(item.GetString()));
                    }
                    dataAvailabilityStatus = array;
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
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
                if (property.NameEquals("resource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resource = MaterializationComputeResource.DeserializeMaterializationComputeResource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sparkConfiguration"u8))
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
                    sparkConfiguration = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
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
                    properties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FeatureSetVersionBackfillContent(
                displayName,
                description,
                featureWindow,
                dataAvailabilityStatus ?? new ChangeTrackingList<DataAvailabilityStatus>(),
                jobId,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                resource,
                sparkConfiguration ?? new ChangeTrackingDictionary<string, string>(),
                properties ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FeatureSetVersionBackfillContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FeatureSetVersionBackfillContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FeatureSetVersionBackfillContent)} does not support writing '{options.Format}' format.");
            }
        }

        FeatureSetVersionBackfillContent IPersistableModel<FeatureSetVersionBackfillContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FeatureSetVersionBackfillContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFeatureSetVersionBackfillContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FeatureSetVersionBackfillContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FeatureSetVersionBackfillContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
