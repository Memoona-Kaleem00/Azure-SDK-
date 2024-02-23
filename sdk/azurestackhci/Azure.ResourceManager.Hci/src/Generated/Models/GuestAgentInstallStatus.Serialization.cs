// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class GuestAgentInstallStatus : IUtf8JsonSerializable, IJsonModel<GuestAgentInstallStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GuestAgentInstallStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GuestAgentInstallStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestAgentInstallStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestAgentInstallStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && VmUuid != null)
            {
                writer.WritePropertyName("vmUuid"u8);
                writer.WriteStringValue(VmUuid);
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && LastStatusChange.HasValue)
            {
                writer.WritePropertyName("lastStatusChange"u8);
                writer.WriteStringValue(LastStatusChange.Value, "O");
            }
            if (options.Format != "W" && AgentVersion != null)
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (options.Format != "W" && !(ErrorDetails is ChangeTrackingList<ResponseError> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("errorDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ErrorDetails)
                {
                    JsonSerializer.Serialize(writer, item);
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

        GuestAgentInstallStatus IJsonModel<GuestAgentInstallStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestAgentInstallStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GuestAgentInstallStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGuestAgentInstallStatus(document.RootElement, options);
        }

        internal static GuestAgentInstallStatus DeserializeGuestAgentInstallStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vmUuid = default;
            Optional<StatusType> status = default;
            Optional<DateTimeOffset> lastStatusChange = default;
            Optional<string> agentVersion = default;
            Optional<IReadOnlyList<ResponseError>> errorDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmUuid"u8))
                {
                    vmUuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new StatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastStatusChange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStatusChange = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResponseError> array = new List<ResponseError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<ResponseError>(item.GetRawText()));
                    }
                    errorDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GuestAgentInstallStatus(vmUuid.Value, Optional.ToNullable(status), Optional.ToNullable(lastStatusChange), agentVersion.Value, Optional.ToList(errorDetails), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GuestAgentInstallStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestAgentInstallStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GuestAgentInstallStatus)} does not support '{options.Format}' format.");
            }
        }

        GuestAgentInstallStatus IPersistableModel<GuestAgentInstallStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GuestAgentInstallStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGuestAgentInstallStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GuestAgentInstallStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GuestAgentInstallStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
