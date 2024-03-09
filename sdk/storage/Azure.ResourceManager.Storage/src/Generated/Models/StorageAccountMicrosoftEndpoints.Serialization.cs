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
using Azure.ResourceManager;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountMicrosoftEndpoints : IUtf8JsonSerializable, IJsonModel<StorageAccountMicrosoftEndpoints>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountMicrosoftEndpoints>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageAccountMicrosoftEndpoints>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountMicrosoftEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountMicrosoftEndpoints)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(BlobUri))
            {
                writer.WritePropertyName("blob"u8);
                writer.WriteStringValue(BlobUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(QueueUri))
            {
                writer.WritePropertyName("queue"u8);
                writer.WriteStringValue(QueueUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(TableUri))
            {
                writer.WritePropertyName("table"u8);
                writer.WriteStringValue(TableUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(FileUri))
            {
                writer.WritePropertyName("file"u8);
                writer.WriteStringValue(FileUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(WebUri))
            {
                writer.WritePropertyName("web"u8);
                writer.WriteStringValue(WebUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(DfsUri))
            {
                writer.WritePropertyName("dfs"u8);
                writer.WriteStringValue(DfsUri.AbsoluteUri);
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

        StorageAccountMicrosoftEndpoints IJsonModel<StorageAccountMicrosoftEndpoints>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountMicrosoftEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageAccountMicrosoftEndpoints)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountMicrosoftEndpoints(document.RootElement, options);
        }

        internal static StorageAccountMicrosoftEndpoints DeserializeStorageAccountMicrosoftEndpoints(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri blob = default;
            Uri queue = default;
            Uri table = default;
            Uri file = default;
            Uri web = default;
            Uri dfs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blob = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queue = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("table"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    table = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("file"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    file = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("web"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    web = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dfs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dfs = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageAccountMicrosoftEndpoints(
                blob,
                queue,
                table,
                file,
                web,
                dfs,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.ParameterOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(BlobUri), out propertyOverride);
            if (Optional.IsDefined(BlobUri) || hasPropertyOverride)
            {
                builder.Append("  blob: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{BlobUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QueueUri), out propertyOverride);
            if (Optional.IsDefined(QueueUri) || hasPropertyOverride)
            {
                builder.Append("  queue: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{QueueUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TableUri), out propertyOverride);
            if (Optional.IsDefined(TableUri) || hasPropertyOverride)
            {
                builder.Append("  table: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{TableUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FileUri), out propertyOverride);
            if (Optional.IsDefined(FileUri) || hasPropertyOverride)
            {
                builder.Append("  file: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{FileUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WebUri), out propertyOverride);
            if (Optional.IsDefined(WebUri) || hasPropertyOverride)
            {
                builder.Append("  web: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{WebUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DfsUri), out propertyOverride);
            if (Optional.IsDefined(DfsUri) || hasPropertyOverride)
            {
                builder.Append("  dfs: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    builder.AppendLine($"'{DfsUri.AbsoluteUri}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine, string formattedPropertyName)
        {
            string indent = new string(' ', spaces);
            int emptyObjectLength = 2 + spaces + Environment.NewLine.Length + Environment.NewLine.Length;
            int length = stringBuilder.Length;
            bool inMultilineString = false;

            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
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
                    stringBuilder.AppendLine($"{line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
            if (stringBuilder.Length == length + emptyObjectLength)
            {
                stringBuilder.Length = stringBuilder.Length - emptyObjectLength - formattedPropertyName.Length;
            }
        }

        BinaryData IPersistableModel<StorageAccountMicrosoftEndpoints>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountMicrosoftEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StorageAccountMicrosoftEndpoints)} does not support '{options.Format}' format.");
            }
        }

        StorageAccountMicrosoftEndpoints IPersistableModel<StorageAccountMicrosoftEndpoints>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageAccountMicrosoftEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageAccountMicrosoftEndpoints(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(StorageAccountMicrosoftEndpoints)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageAccountMicrosoftEndpoints>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
