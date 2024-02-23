// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformConfigurationServiceGitReposValidationMessages : IUtf8JsonSerializable, IJsonModel<AppPlatformConfigurationServiceGitReposValidationMessages>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformConfigurationServiceGitReposValidationMessages>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformConfigurationServiceGitReposValidationMessages>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceGitReposValidationMessages>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceGitReposValidationMessages)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (!(Messages is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("messages"u8);
                writer.WriteStartArray();
                foreach (var item in Messages)
                {
                    writer.WriteStringValue(item);
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

        AppPlatformConfigurationServiceGitReposValidationMessages IJsonModel<AppPlatformConfigurationServiceGitReposValidationMessages>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceGitReposValidationMessages>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceGitReposValidationMessages)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformConfigurationServiceGitReposValidationMessages(document.RootElement, options);
        }

        internal static AppPlatformConfigurationServiceGitReposValidationMessages DeserializeAppPlatformConfigurationServiceGitReposValidationMessages(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<IReadOnlyList<string>> messages = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messages"u8))
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
                    messages = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformConfigurationServiceGitReposValidationMessages(name.Value, Optional.ToList(messages), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformConfigurationServiceGitReposValidationMessages>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceGitReposValidationMessages>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceGitReposValidationMessages)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformConfigurationServiceGitReposValidationMessages IPersistableModel<AppPlatformConfigurationServiceGitReposValidationMessages>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformConfigurationServiceGitReposValidationMessages>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformConfigurationServiceGitReposValidationMessages(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformConfigurationServiceGitReposValidationMessages)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformConfigurationServiceGitReposValidationMessages>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
