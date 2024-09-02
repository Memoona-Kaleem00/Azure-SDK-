// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningUsernamePasswordAuthTypeWorkspaceConnection : IUtf8JsonSerializable, IJsonModel<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningUsernamePasswordAuthTypeWorkspaceConnection)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials, options);
            }
            writer.WritePropertyName("authType"u8);
            writer.WriteStringValue(AuthType.ToString());
            if (Optional.IsDefined(Category))
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedByWorkspaceArmId))
            {
                writer.WritePropertyName("createdByWorkspaceArmId"u8);
                writer.WriteStringValue(CreatedByWorkspaceArmId);
            }
            if (Optional.IsDefined(ExpiryOn))
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpiryOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Group))
            {
                writer.WritePropertyName("group"u8);
                writer.WriteStringValue(Group.Value.ToString());
            }
            if (Optional.IsDefined(IsSharedToAll))
            {
                writer.WritePropertyName("isSharedToAll"u8);
                writer.WriteBooleanValue(IsSharedToAll.Value);
            }
            if (Optional.IsDefined(Target))
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(SharedUserList))
            {
                writer.WritePropertyName("sharedUserList"u8);
                writer.WriteStartArray();
                foreach (var item in SharedUserList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Optional.IsDefined(ValueFormat))
            {
                writer.WritePropertyName("valueFormat"u8);
                writer.WriteStringValue(ValueFormat.Value.ToString());
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

        MachineLearningUsernamePasswordAuthTypeWorkspaceConnection IJsonModel<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningUsernamePasswordAuthTypeWorkspaceConnection)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningUsernamePasswordAuthTypeWorkspaceConnection(document.RootElement, options);
        }

        internal static MachineLearningUsernamePasswordAuthTypeWorkspaceConnection DeserializeMachineLearningUsernamePasswordAuthTypeWorkspaceConnection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningWorkspaceConnectionUsernamePassword credentials = default;
            MachineLearningConnectionAuthType authType = default;
            MachineLearningConnectionCategory? category = default;
            ResourceIdentifier createdByWorkspaceArmId = default;
            DateTimeOffset? expiryTime = default;
            ConnectionGroup? group = default;
            bool? isSharedToAll = default;
            string target = default;
            IDictionary<string, string> metadata = default;
            IList<string> sharedUserList = default;
            string value = default;
            MachineLearningValueFormat? valueFormat = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("credentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    credentials = MachineLearningWorkspaceConnectionUsernamePassword.DeserializeMachineLearningWorkspaceConnectionUsernamePassword(property.Value, options);
                    continue;
                }
                if (property.NameEquals("authType"u8))
                {
                    authType = new MachineLearningConnectionAuthType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new MachineLearningConnectionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdByWorkspaceArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdByWorkspaceArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("group"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    group = new ConnectionGroup(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isSharedToAll"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSharedToAll = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    metadata = dictionary;
                    continue;
                }
                if (property.NameEquals("sharedUserList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sharedUserList = array;
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    valueFormat = new MachineLearningValueFormat(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningUsernamePasswordAuthTypeWorkspaceConnection(
                authType,
                category,
                createdByWorkspaceArmId,
                expiryTime,
                group,
                isSharedToAll,
                target,
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                sharedUserList ?? new ChangeTrackingList<string>(),
                value,
                valueFormat,
                serializedAdditionalRawData,
                credentials);
        }

        BinaryData IPersistableModel<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningUsernamePasswordAuthTypeWorkspaceConnection)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningUsernamePasswordAuthTypeWorkspaceConnection IPersistableModel<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningUsernamePasswordAuthTypeWorkspaceConnection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningUsernamePasswordAuthTypeWorkspaceConnection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningUsernamePasswordAuthTypeWorkspaceConnection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
