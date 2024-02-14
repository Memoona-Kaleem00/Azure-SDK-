// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.GuestConfiguration.Models
{
    public partial class AssignmentReportResourceInfo : IUtf8JsonSerializable, IJsonModel<AssignmentReportResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssignmentReportResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AssignmentReportResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentReportResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssignmentReportResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(ComplianceStatus))
            {
                writer.WritePropertyName("complianceStatus"u8);
                writer.WriteStringValue(ComplianceStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AssignmentResourceSettingName))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(AssignmentResourceSettingName);
            }
            if (Optional.IsCollectionDefined(Reasons))
            {
                writer.WritePropertyName("reasons"u8);
                writer.WriteStartArray();
                foreach (var item in Reasons)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Properties);
#else
                using (JsonDocument document = JsonDocument.Parse(Properties))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        AssignmentReportResourceInfo IJsonModel<AssignmentReportResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentReportResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssignmentReportResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssignmentReportResourceInfo(document.RootElement, options);
        }

        internal static AssignmentReportResourceInfo DeserializeAssignmentReportResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AssignedGuestConfigurationMachineComplianceStatus> complianceStatus = default;
            Optional<string> resourceId = default;
            Optional<IList<AssignmentReportResourceComplianceReason>> reasons = default;
            Optional<BinaryData> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = new AssignedGuestConfigurationMachineComplianceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reasons"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AssignmentReportResourceComplianceReason> array = new List<AssignmentReportResourceComplianceReason>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssignmentReportResourceComplianceReason.DeserializeAssignmentReportResourceComplianceReason(item, options));
                    }
                    reasons = array;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AssignmentReportResourceInfo(Optional.ToNullable(complianceStatus), resourceId.Value, Optional.ToList(reasons), properties.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AssignmentReportResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentReportResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssignmentReportResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        AssignmentReportResourceInfo IPersistableModel<AssignmentReportResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignmentReportResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssignmentReportResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssignmentReportResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssignmentReportResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
