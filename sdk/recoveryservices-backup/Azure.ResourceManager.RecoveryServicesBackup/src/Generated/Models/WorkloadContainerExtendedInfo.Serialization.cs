// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class WorkloadContainerExtendedInfo : IUtf8JsonSerializable, IJsonModel<WorkloadContainerExtendedInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadContainerExtendedInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkloadContainerExtendedInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadContainerExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadContainerExtendedInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(HostServerName))
            {
                writer.WritePropertyName("hostServerName"u8);
                writer.WriteStringValue(HostServerName);
            }
            if (Optional.IsDefined(InquiryInfo))
            {
                writer.WritePropertyName("inquiryInfo"u8);
                writer.WriteObjectValue<WorkloadContainerInquiryInfo>(InquiryInfo, options);
            }
            if (Optional.IsCollectionDefined(NodesList))
            {
                writer.WritePropertyName("nodesList"u8);
                writer.WriteStartArray();
                foreach (var item in NodesList)
                {
                    writer.WriteObjectValue<DistributedNodesInfo>(item, options);
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

        WorkloadContainerExtendedInfo IJsonModel<WorkloadContainerExtendedInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadContainerExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadContainerExtendedInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadContainerExtendedInfo(document.RootElement, options);
        }

        internal static WorkloadContainerExtendedInfo DeserializeWorkloadContainerExtendedInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string hostServerName = default;
            WorkloadContainerInquiryInfo inquiryInfo = default;
            IList<DistributedNodesInfo> nodesList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostServerName"u8))
                {
                    hostServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inquiryInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inquiryInfo = WorkloadContainerInquiryInfo.DeserializeWorkloadContainerInquiryInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("nodesList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DistributedNodesInfo> array = new List<DistributedNodesInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DistributedNodesInfo.DeserializeDistributedNodesInfo(item, options));
                    }
                    nodesList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WorkloadContainerExtendedInfo(hostServerName, inquiryInfo, nodesList ?? new ChangeTrackingList<DistributedNodesInfo>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WorkloadContainerExtendedInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadContainerExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadContainerExtendedInfo)} does not support writing '{options.Format}' format.");
            }
        }

        WorkloadContainerExtendedInfo IPersistableModel<WorkloadContainerExtendedInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadContainerExtendedInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWorkloadContainerExtendedInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WorkloadContainerExtendedInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadContainerExtendedInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
