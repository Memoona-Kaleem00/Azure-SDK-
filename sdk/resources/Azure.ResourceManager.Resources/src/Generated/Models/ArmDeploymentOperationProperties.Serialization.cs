// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmDeploymentOperationProperties : IUtf8JsonSerializable, IJsonModel<ArmDeploymentOperationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmDeploymentOperationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArmDeploymentOperationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentOperationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmDeploymentOperationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningOperation.HasValue)
            {
                writer.WritePropertyName("provisioningOperation"u8);
                writer.WriteStringValue(ProvisioningOperation.Value.ToSerialString());
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (options.Format != "W" && Timestamp.HasValue)
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (options.Format != "W" && Duration.HasValue)
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "P");
            }
            if (options.Format != "W" && ServiceRequestId != null)
            {
                writer.WritePropertyName("serviceRequestId"u8);
                writer.WriteStringValue(ServiceRequestId);
            }
            if (options.Format != "W" && StatusCode != null)
            {
                writer.WritePropertyName("statusCode"u8);
                writer.WriteStringValue(StatusCode);
            }
            if (options.Format != "W" && StatusMessage != null)
            {
                if (StatusMessage != null)
                {
                    writer.WritePropertyName("statusMessage"u8);
                    writer.WriteObjectValue(StatusMessage);
                }
                else
                {
                    writer.WriteNull("statusMessage");
                }
            }
            if (options.Format != "W" && TargetResource != null)
            {
                writer.WritePropertyName("targetResource"u8);
                writer.WriteObjectValue(TargetResource);
            }
            if (options.Format != "W" && Request != null)
            {
                writer.WritePropertyName("request"u8);
                writer.WriteObjectValue(Request);
            }
            if (options.Format != "W" && Response != null)
            {
                writer.WritePropertyName("response"u8);
                writer.WriteObjectValue(Response);
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

        ArmDeploymentOperationProperties IJsonModel<ArmDeploymentOperationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentOperationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmDeploymentOperationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmDeploymentOperationProperties(document.RootElement, options);
        }

        internal static ArmDeploymentOperationProperties DeserializeArmDeploymentOperationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProvisioningOperationKind? provisioningOperation = default;
            string provisioningState = default;
            DateTimeOffset? timestamp = default;
            TimeSpan? duration = default;
            string serviceRequestId = default;
            string statusCode = default;
            StatusMessage statusMessage = default;
            TargetResource targetResource = default;
            HttpMessage request = default;
            HttpMessage response = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningOperation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningOperation = property.Value.GetString().ToProvisioningOperationKind();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("serviceRequestId"u8))
                {
                    serviceRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusCode"u8))
                {
                    statusCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusMessage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        statusMessage = null;
                        continue;
                    }
                    statusMessage = StatusMessage.DeserializeStatusMessage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetResource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetResource = TargetResource.DeserializeTargetResource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("request"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    request = HttpMessage.DeserializeHttpMessage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("response"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    response = HttpMessage.DeserializeHttpMessage(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArmDeploymentOperationProperties(
                provisioningOperation,
                provisioningState,
                timestamp,
                duration,
                serviceRequestId,
                statusCode,
                statusMessage,
                targetResource,
                request,
                response,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArmDeploymentOperationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentOperationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArmDeploymentOperationProperties)} does not support '{options.Format}' format.");
            }
        }

        ArmDeploymentOperationProperties IPersistableModel<ArmDeploymentOperationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmDeploymentOperationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmDeploymentOperationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmDeploymentOperationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmDeploymentOperationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
