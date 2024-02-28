// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    public partial class ResourceQueryRequestOptions : IUtf8JsonSerializable, IJsonModel<ResourceQueryRequestOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceQueryRequestOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceQueryRequestOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQueryRequestOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceQueryRequestOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SkipToken != null)
            {
                writer.WritePropertyName("$skipToken"u8);
                writer.WriteStringValue(SkipToken);
            }
            if (Top.HasValue)
            {
                writer.WritePropertyName("$top"u8);
                writer.WriteNumberValue(Top.Value);
            }
            if (Skip.HasValue)
            {
                writer.WritePropertyName("$skip"u8);
                writer.WriteNumberValue(Skip.Value);
            }
            if (ResultFormat.HasValue)
            {
                writer.WritePropertyName("resultFormat"u8);
                writer.WriteStringValue(ResultFormat.Value.ToSerialString());
            }
            if (AllowPartialScopes.HasValue)
            {
                writer.WritePropertyName("allowPartialScopes"u8);
                writer.WriteBooleanValue(AllowPartialScopes.Value);
            }
            if (AuthorizationScopeFilter.HasValue)
            {
                writer.WritePropertyName("authorizationScopeFilter"u8);
                writer.WriteStringValue(AuthorizationScopeFilter.Value.ToSerialString());
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

        ResourceQueryRequestOptions IJsonModel<ResourceQueryRequestOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQueryRequestOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceQueryRequestOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceQueryRequestOptions(document.RootElement, options);
        }

        internal static ResourceQueryRequestOptions DeserializeResourceQueryRequestOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string skipToken = default;
            int? top = default;
            int? skip = default;
            ResultFormat? resultFormat = default;
            bool? allowPartialScopes = default;
            AuthorizationScopeFilter? authorizationScopeFilter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("$skipToken"u8))
                {
                    skipToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("$top"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    top = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("$skip"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skip = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("resultFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resultFormat = property.Value.GetString().ToResultFormat();
                    continue;
                }
                if (property.NameEquals("allowPartialScopes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowPartialScopes = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("authorizationScopeFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authorizationScopeFilter = property.Value.GetString().ToAuthorizationScopeFilter();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceQueryRequestOptions(
                skipToken,
                top,
                skip,
                resultFormat,
                allowPartialScopes,
                authorizationScopeFilter,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceQueryRequestOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQueryRequestOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceQueryRequestOptions)} does not support '{options.Format}' format.");
            }
        }

        ResourceQueryRequestOptions IPersistableModel<ResourceQueryRequestOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQueryRequestOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceQueryRequestOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceQueryRequestOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceQueryRequestOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
