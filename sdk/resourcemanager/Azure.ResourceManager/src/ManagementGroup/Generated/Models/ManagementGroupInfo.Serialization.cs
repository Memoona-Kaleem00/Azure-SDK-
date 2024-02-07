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

namespace Azure.ResourceManager.ManagementGroups.Models
{
    public partial class ManagementGroupInfo : IUtf8JsonSerializable, IJsonModel<ManagementGroupInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementGroupInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagementGroupInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementGroupInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteNumberValue(Version.Value);
            }
            if (Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedTime"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (Optional.IsDefined(UpdatedBy))
            {
                writer.WritePropertyName("updatedBy"u8);
                writer.WriteStringValue(UpdatedBy);
            }
            if (Optional.IsDefined(Parent))
            {
                writer.WritePropertyName("parent"u8);
                writer.WriteObjectValue(Parent);
            }
            if (Optional.IsCollectionDefined(Path))
            {
                if (Path != null)
                {
                    writer.WritePropertyName("path"u8);
                    writer.WriteStartArray();
                    foreach (var item in Path)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("path");
                }
            }
            if (Optional.IsCollectionDefined(ManagementGroupAncestors))
            {
                if (ManagementGroupAncestors != null)
                {
                    writer.WritePropertyName("managementGroupAncestors"u8);
                    writer.WriteStartArray();
                    foreach (var item in ManagementGroupAncestors)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("managementGroupAncestors");
                }
            }
            if (Optional.IsCollectionDefined(ManagementGroupAncestorChain))
            {
                if (ManagementGroupAncestorChain != null)
                {
                    writer.WritePropertyName("managementGroupAncestorsChain"u8);
                    writer.WriteStartArray();
                    foreach (var item in ManagementGroupAncestorChain)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("managementGroupAncestorsChain");
                }
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

        ManagementGroupInfo IJsonModel<ManagementGroupInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementGroupInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementGroupInfo(document.RootElement, options);
        }

        internal static ManagementGroupInfo DeserializeManagementGroupInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> version = default;
            Optional<DateTimeOffset> updatedTime = default;
            Optional<string> updatedBy = default;
            Optional<ParentManagementGroupInfo> parent = default;
            Optional<IReadOnlyList<ManagementGroupPathElement>> path = default;
            Optional<IReadOnlyList<string>> managementGroupAncestors = default;
            Optional<IReadOnlyList<ManagementGroupPathElement>> managementGroupAncestorsChain = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("updatedTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updatedTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("updatedBy"u8))
                {
                    updatedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parent = ParentManagementGroupInfo.DeserializeParentManagementGroupInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        path = null;
                        continue;
                    }
                    List<ManagementGroupPathElement> array = new List<ManagementGroupPathElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagementGroupPathElement.DeserializeManagementGroupPathElement(item));
                    }
                    path = array;
                    continue;
                }
                if (property.NameEquals("managementGroupAncestors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        managementGroupAncestors = null;
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    managementGroupAncestors = array;
                    continue;
                }
                if (property.NameEquals("managementGroupAncestorsChain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        managementGroupAncestorsChain = null;
                        continue;
                    }
                    List<ManagementGroupPathElement> array = new List<ManagementGroupPathElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagementGroupPathElement.DeserializeManagementGroupPathElement(item));
                    }
                    managementGroupAncestorsChain = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagementGroupInfo(Optional.ToNullable(version), Optional.ToNullable(updatedTime), updatedBy.Value, parent.Value, Optional.ToList(path), Optional.ToList(managementGroupAncestors), Optional.ToList(managementGroupAncestorsChain), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Version))
            {
                builder.Append("  version:");
                builder.AppendLine($" {Version.Value}");
            }

            if (Optional.IsDefined(UpdatedOn))
            {
                builder.Append("  updatedTime:");
                var formattedDateTimeString = TypeFormatters.ToString(UpdatedOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(UpdatedBy))
            {
                builder.Append("  updatedBy:");
                if (UpdatedBy.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{UpdatedBy}'''");
                }
                else
                {
                    builder.AppendLine($" '{UpdatedBy}'");
                }
            }

            if (Optional.IsDefined(Parent))
            {
                builder.Append("  parent:");
                AppendChildObject(builder, Parent, options, 2, false);
            }

            if (Optional.IsCollectionDefined(Path))
            {
                if (Path.Any())
                {
                    builder.Append("  path:");
                    builder.AppendLine(" [");
                    foreach (var item in Path)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(ManagementGroupAncestors))
            {
                if (ManagementGroupAncestors.Any())
                {
                    builder.Append("  managementGroupAncestors:");
                    builder.AppendLine(" [");
                    foreach (var item in ManagementGroupAncestors)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        if (item.Contains(Environment.NewLine))
                        {
                            builder.AppendLine("    '''");
                            builder.AppendLine($"{item}'''");
                        }
                        else
                        {
                            builder.AppendLine($"    '{item}'");
                        }
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(ManagementGroupAncestorChain))
            {
                if (ManagementGroupAncestorChain.Any())
                {
                    builder.Append("  managementGroupAncestorsChain:");
                    builder.AppendLine(" [");
                    foreach (var item in ManagementGroupAncestorChain)
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

        BinaryData IPersistableModel<ManagementGroupInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagementGroupInfo)} does not support '{options.Format}' format.");
            }
        }

        ManagementGroupInfo IPersistableModel<ManagementGroupInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementGroupInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementGroupInfo(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ManagementGroupInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementGroupInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
