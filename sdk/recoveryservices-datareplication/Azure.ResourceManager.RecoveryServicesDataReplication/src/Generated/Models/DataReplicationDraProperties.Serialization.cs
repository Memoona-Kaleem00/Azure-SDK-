// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class DataReplicationDraProperties : IUtf8JsonSerializable, IJsonModel<DataReplicationDraProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataReplicationDraProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataReplicationDraProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationDraProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataReplicationDraProperties)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            writer.WritePropertyName("machineId"u8);
            writer.WriteStringValue(MachineId);
            writer.WritePropertyName("machineName"u8);
            writer.WriteStringValue(MachineName);
            writer.WritePropertyName("authenticationIdentity"u8);
            writer.WriteObjectValue(AuthenticationIdentity, options);
            writer.WritePropertyName("resourceAccessIdentity"u8);
            writer.WriteObjectValue(ResourceAccessIdentity, options);
            if (options.Format != "W" && Optional.IsDefined(IsResponsive))
            {
                writer.WritePropertyName("isResponsive"u8);
                writer.WriteBooleanValue(IsResponsive.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(LastHeartbeatOn))
            {
                writer.WritePropertyName("lastHeartbeat"u8);
                writer.WriteStringValue(LastHeartbeatOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(VersionNumber))
            {
                writer.WritePropertyName("versionNumber"u8);
                writer.WriteStringValue(VersionNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(HealthErrors))
            {
                writer.WritePropertyName("healthErrors"u8);
                writer.WriteStartArray();
                foreach (var item in HealthErrors)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("customProperties"u8);
            writer.WriteObjectValue(CustomProperties, options);
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

        DataReplicationDraProperties IJsonModel<DataReplicationDraProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationDraProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataReplicationDraProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataReplicationDraProperties(document.RootElement, options);
        }

        internal static DataReplicationDraProperties DeserializeDataReplicationDraProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string correlationId = default;
            string machineId = default;
            string machineName = default;
            DataReplicationIdentity authenticationIdentity = default;
            DataReplicationIdentity resourceAccessIdentity = default;
            bool? isResponsive = default;
            DateTimeOffset? lastHeartbeat = default;
            string versionNumber = default;
            DataReplicationProvisioningState? provisioningState = default;
            IReadOnlyList<DataReplicationHealthErrorInfo> healthErrors = default;
            DraModelCustomProperties customProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineId"u8))
                {
                    machineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationIdentity"u8))
                {
                    authenticationIdentity = DataReplicationIdentity.DeserializeDataReplicationIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceAccessIdentity"u8))
                {
                    resourceAccessIdentity = DataReplicationIdentity.DeserializeDataReplicationIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isResponsive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isResponsive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastHeartbeat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHeartbeat = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("versionNumber"u8))
                {
                    versionNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new DataReplicationProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataReplicationHealthErrorInfo> array = new List<DataReplicationHealthErrorInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataReplicationHealthErrorInfo.DeserializeDataReplicationHealthErrorInfo(item, options));
                    }
                    healthErrors = array;
                    continue;
                }
                if (property.NameEquals("customProperties"u8))
                {
                    customProperties = DraModelCustomProperties.DeserializeDraModelCustomProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataReplicationDraProperties(
                correlationId,
                machineId,
                machineName,
                authenticationIdentity,
                resourceAccessIdentity,
                isResponsive,
                lastHeartbeat,
                versionNumber,
                provisioningState,
                healthErrors ?? new ChangeTrackingList<DataReplicationHealthErrorInfo>(),
                customProperties,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataReplicationDraProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationDraProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataReplicationDraProperties)} does not support writing '{options.Format}' format.");
            }
        }

        DataReplicationDraProperties IPersistableModel<DataReplicationDraProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataReplicationDraProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataReplicationDraProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataReplicationDraProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataReplicationDraProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
