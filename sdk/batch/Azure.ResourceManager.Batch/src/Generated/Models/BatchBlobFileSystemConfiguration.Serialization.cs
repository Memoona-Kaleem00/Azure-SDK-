// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchBlobFileSystemConfiguration : IUtf8JsonSerializable, IJsonModel<BatchBlobFileSystemConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchBlobFileSystemConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchBlobFileSystemConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchBlobFileSystemConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchBlobFileSystemConfiguration)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("accountName"u8);
            writer.WriteStringValue(AccountName);
            writer.WritePropertyName("containerName"u8);
            writer.WriteStringValue(ContainerName);
            if (Optional.IsDefined(AccountKey))
            {
                writer.WritePropertyName("accountKey"u8);
                writer.WriteStringValue(AccountKey);
            }
            if (Optional.IsDefined(SasKey))
            {
                writer.WritePropertyName("sasKey"u8);
                writer.WriteStringValue(SasKey);
            }
            if (Optional.IsDefined(BlobfuseOptions))
            {
                writer.WritePropertyName("blobfuseOptions"u8);
                writer.WriteStringValue(BlobfuseOptions);
            }
            writer.WritePropertyName("relativeMountPath"u8);
            writer.WriteStringValue(RelativeMountPath);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identityReference"u8);
                writer.WriteObjectValue(Identity, options);
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

        BatchBlobFileSystemConfiguration IJsonModel<BatchBlobFileSystemConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchBlobFileSystemConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchBlobFileSystemConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchBlobFileSystemConfiguration(document.RootElement, options);
        }

        internal static BatchBlobFileSystemConfiguration DeserializeBatchBlobFileSystemConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string accountName = default;
            string containerName = default;
            string accountKey = default;
            string sasKey = default;
            string blobfuseOptions = default;
            string relativeMountPath = default;
            ComputeNodeIdentityReference identityReference = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accountKey"u8))
                {
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasKey"u8))
                {
                    sasKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("blobfuseOptions"u8))
                {
                    blobfuseOptions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativeMountPath"u8))
                {
                    relativeMountPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identityReference = ComputeNodeIdentityReference.DeserializeComputeNodeIdentityReference(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchBlobFileSystemConfiguration(
                accountName,
                containerName,
                accountKey,
                sasKey,
                blobfuseOptions,
                relativeMountPath,
                identityReference,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchBlobFileSystemConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchBlobFileSystemConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchBlobFileSystemConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        BatchBlobFileSystemConfiguration IPersistableModel<BatchBlobFileSystemConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchBlobFileSystemConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchBlobFileSystemConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchBlobFileSystemConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchBlobFileSystemConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
