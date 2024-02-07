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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GcpDefenderForDatabasesArcAutoProvisioning : IUtf8JsonSerializable, IJsonModel<GcpDefenderForDatabasesArcAutoProvisioning>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GcpDefenderForDatabasesArcAutoProvisioning>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GcpDefenderForDatabasesArcAutoProvisioning>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpDefenderForDatabasesArcAutoProvisioning>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GcpDefenderForDatabasesArcAutoProvisioning)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceAccountEmailAddress))
            {
                writer.WritePropertyName("serviceAccountEmailAddress"u8);
                writer.WriteStringValue(ServiceAccountEmailAddress);
            }
            if (Optional.IsDefined(WorkloadIdentityProviderId))
            {
                writer.WritePropertyName("workloadIdentityProviderId"u8);
                writer.WriteStringValue(WorkloadIdentityProviderId);
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

        GcpDefenderForDatabasesArcAutoProvisioning IJsonModel<GcpDefenderForDatabasesArcAutoProvisioning>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpDefenderForDatabasesArcAutoProvisioning>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GcpDefenderForDatabasesArcAutoProvisioning)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGcpDefenderForDatabasesArcAutoProvisioning(document.RootElement, options);
        }

        internal static GcpDefenderForDatabasesArcAutoProvisioning DeserializeGcpDefenderForDatabasesArcAutoProvisioning(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serviceAccountEmailAddress = default;
            Optional<string> workloadIdentityProviderId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceAccountEmailAddress"u8))
                {
                    serviceAccountEmailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadIdentityProviderId"u8))
                {
                    workloadIdentityProviderId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GcpDefenderForDatabasesArcAutoProvisioning(serviceAccountEmailAddress.Value, workloadIdentityProviderId.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ServiceAccountEmailAddress))
            {
                builder.Append("  serviceAccountEmailAddress:");
                if (ServiceAccountEmailAddress.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{ServiceAccountEmailAddress}'''");
                }
                else
                {
                    builder.AppendLine($" '{ServiceAccountEmailAddress}'");
                }
            }

            if (Optional.IsDefined(WorkloadIdentityProviderId))
            {
                builder.Append("  workloadIdentityProviderId:");
                if (WorkloadIdentityProviderId.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{WorkloadIdentityProviderId}'''");
                }
                else
                {
                    builder.AppendLine($" '{WorkloadIdentityProviderId}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<GcpDefenderForDatabasesArcAutoProvisioning>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpDefenderForDatabasesArcAutoProvisioning>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(GcpDefenderForDatabasesArcAutoProvisioning)} does not support '{options.Format}' format.");
            }
        }

        GcpDefenderForDatabasesArcAutoProvisioning IPersistableModel<GcpDefenderForDatabasesArcAutoProvisioning>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GcpDefenderForDatabasesArcAutoProvisioning>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGcpDefenderForDatabasesArcAutoProvisioning(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(GcpDefenderForDatabasesArcAutoProvisioning)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GcpDefenderForDatabasesArcAutoProvisioning>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
