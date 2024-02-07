// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceEndpointDependency : IUtf8JsonSerializable, IJsonModel<ManagedInstanceEndpointDependency>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstanceEndpointDependency>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedInstanceEndpointDependency>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceEndpointDependency)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(EndpointDetails))
            {
                writer.WritePropertyName("endpointDetails"u8);
                writer.WriteStartArray();
                foreach (var item in EndpointDetails)
                {
                    writer.WriteObjectValue(item);
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

        ManagedInstanceEndpointDependency IJsonModel<ManagedInstanceEndpointDependency>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedInstanceEndpointDependency)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceEndpointDependency(document.RootElement, options);
        }

        internal static ManagedInstanceEndpointDependency DeserializeManagedInstanceEndpointDependency(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> domainName = default;
            Optional<IReadOnlyList<ManagedInstanceEndpointDetail>> endpointDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedInstanceEndpointDetail> array = new List<ManagedInstanceEndpointDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstanceEndpointDetail.DeserializeManagedInstanceEndpointDetail(item));
                    }
                    endpointDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedInstanceEndpointDependency(domainName.Value, Optional.ToList(endpointDetails), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(DomainName))
            {
                builder.Append("  domainName:");
                if (DomainName.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{DomainName}'''");
                }
                else
                {
                    builder.AppendLine($" '{DomainName}'");
                }
            }

            if (Optional.IsCollectionDefined(EndpointDetails))
            {
                if (EndpointDetails.Any())
                {
                    builder.Append("  endpointDetails:");
                    builder.AppendLine(" [");
                    foreach (var item in EndpointDetails)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
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

        BinaryData IPersistableModel<ManagedInstanceEndpointDependency>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceEndpointDependency)} does not support '{options.Format}' format.");
            }
        }

        ManagedInstanceEndpointDependency IPersistableModel<ManagedInstanceEndpointDependency>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedInstanceEndpointDependency>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedInstanceEndpointDependency(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ManagedInstanceEndpointDependency)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedInstanceEndpointDependency>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
