// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    public partial class SupportTicketCommunicationData : IUtf8JsonSerializable, IJsonModel<SupportTicketCommunicationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SupportTicketCommunicationData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SupportTicketCommunicationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SupportTicketCommunicationData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SupportTicketCommunicationData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CommunicationType))
                {
                    writer.WritePropertyName("communicationType"u8);
                    writer.WriteStringValue(CommunicationType.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CommunicationDirection))
                {
                    writer.WritePropertyName("communicationDirection"u8);
                    writer.WriteStringValue(CommunicationDirection.Value.ToString());
                }
            }
            if (Optional.IsDefined(Sender))
            {
                writer.WritePropertyName("sender"u8);
                writer.WriteStringValue(Sender);
            }
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            if (Optional.IsDefined(Body))
            {
                writer.WritePropertyName("body"u8);
                writer.WriteStringValue(Body);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    writer.WritePropertyName("createdDate"u8);
                    writer.WriteStringValue(CreatedOn.Value, "O");
                }
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        SupportTicketCommunicationData IJsonModel<SupportTicketCommunicationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SupportTicketCommunicationData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSupportTicketCommunicationData(document.RootElement, options);
        }

        internal static SupportTicketCommunicationData DeserializeSupportTicketCommunicationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SupportTicketCommunicationType> communicationType = default;
            Optional<SupportTicketCommunicationDirection> communicationDirection = default;
            Optional<string> sender = default;
            Optional<string> subject = default;
            Optional<string> body = default;
            Optional<DateTimeOffset> createdDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("communicationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            communicationType = new SupportTicketCommunicationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("communicationDirection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            communicationDirection = new SupportTicketCommunicationDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sender"u8))
                        {
                            sender = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subject"u8))
                        {
                            subject = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("body"u8))
                        {
                            body = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SupportTicketCommunicationData(id, name, type, systemData.Value, Optional.ToNullable(communicationType), Optional.ToNullable(communicationDirection), sender.Value, subject.Value, body.Value, Optional.ToNullable(createdDate), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SupportTicketCommunicationData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SupportTicketCommunicationData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SupportTicketCommunicationData IPersistableModel<SupportTicketCommunicationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SupportTicketCommunicationData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSupportTicketCommunicationData(document.RootElement, options);
        }

        string IPersistableModel<SupportTicketCommunicationData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
