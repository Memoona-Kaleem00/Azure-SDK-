// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class GCPAuthModel : IUtf8JsonSerializable, IJsonModel<GCPAuthModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GCPAuthModel>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<GCPAuthModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GCPAuthModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GCPAuthModel)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("serviceAccountEmail"u8);
            writer.WriteStringValue(ServiceAccountEmail);
            writer.WritePropertyName("projectNumber"u8);
            writer.WriteStringValue(ProjectNumber);
            writer.WritePropertyName("workloadIdentityProviderId"u8);
            writer.WriteStringValue(WorkloadIdentityProviderId);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(AuthType.ToString());
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

        GCPAuthModel IJsonModel<GCPAuthModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GCPAuthModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GCPAuthModel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGCPAuthModel(document.RootElement, options);
        }

        internal static GCPAuthModel DeserializeGCPAuthModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serviceAccountEmail = default;
            string projectNumber = default;
            string workloadIdentityProviderId = default;
            CcpAuthType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceAccountEmail"u8))
                {
                    serviceAccountEmail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("projectNumber"u8))
                {
                    projectNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadIdentityProviderId"u8))
                {
                    workloadIdentityProviderId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new CcpAuthType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new GCPAuthModel(type, serializedAdditionalRawData, serviceAccountEmail, projectNumber, workloadIdentityProviderId);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServiceAccountEmail), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  serviceAccountEmail: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServiceAccountEmail))
                {
                    builder.Append("  serviceAccountEmail: ");
                    if (ServiceAccountEmail.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ServiceAccountEmail}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ServiceAccountEmail}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProjectNumber), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  projectNumber: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProjectNumber))
                {
                    builder.Append("  projectNumber: ");
                    if (ProjectNumber.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ProjectNumber}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ProjectNumber}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WorkloadIdentityProviderId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  workloadIdentityProviderId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(WorkloadIdentityProviderId))
                {
                    builder.Append("  workloadIdentityProviderId: ");
                    if (WorkloadIdentityProviderId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{WorkloadIdentityProviderId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{WorkloadIdentityProviderId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  type: ");
                builder.AppendLine($"'{AuthType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<GCPAuthModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GCPAuthModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(GCPAuthModel)} does not support writing '{options.Format}' format.");
            }
        }

        GCPAuthModel IPersistableModel<GCPAuthModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GCPAuthModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGCPAuthModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GCPAuthModel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<GCPAuthModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
