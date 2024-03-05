// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UserCreatedStorageAccount : IUtf8JsonSerializable, IJsonModel<UserCreatedStorageAccount>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UserCreatedStorageAccount>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UserCreatedStorageAccount>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserCreatedStorageAccount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserCreatedStorageAccount)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ArmResourceIdentifier))
            {
                if (ArmResourceIdentifier != null)
                {
                    writer.WritePropertyName("armResourceId"u8);
                    writer.WriteObjectValue(ArmResourceIdentifier);
                }
                else
                {
                    writer.WriteNull("armResourceId");
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

        UserCreatedStorageAccount IJsonModel<UserCreatedStorageAccount>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserCreatedStorageAccount>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UserCreatedStorageAccount)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUserCreatedStorageAccount(document.RootElement, options);
        }

        internal static UserCreatedStorageAccount DeserializeUserCreatedStorageAccount(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ArmResourceId armResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("armResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        armResourceId = null;
                        continue;
                    }
                    armResourceId = Models.ArmResourceId.DeserializeArmResourceId(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UserCreatedStorageAccount(armResourceId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UserCreatedStorageAccount>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserCreatedStorageAccount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UserCreatedStorageAccount)} does not support '{options.Format}' format.");
            }
        }

        UserCreatedStorageAccount IPersistableModel<UserCreatedStorageAccount>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UserCreatedStorageAccount>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUserCreatedStorageAccount(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UserCreatedStorageAccount)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UserCreatedStorageAccount>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
