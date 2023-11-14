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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StaticSiteTemplate : IUtf8JsonSerializable, IJsonModel<StaticSiteTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StaticSiteTemplate>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<StaticSiteTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<StaticSiteTemplate>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<StaticSiteTemplate>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TemplateRepositoryUri))
            {
                writer.WritePropertyName("templateRepositoryUrl"u8);
                writer.WriteStringValue(TemplateRepositoryUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Owner))
            {
                writer.WritePropertyName("owner"u8);
                writer.WriteStringValue(Owner);
            }
            if (Optional.IsDefined(RepositoryName))
            {
                writer.WritePropertyName("repositoryName"u8);
                writer.WriteStringValue(RepositoryName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(IsPrivate))
            {
                writer.WritePropertyName("isPrivate"u8);
                writer.WriteBooleanValue(IsPrivate.Value);
            }
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

        StaticSiteTemplate IJsonModel<StaticSiteTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StaticSiteTemplate)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticSiteTemplate(document.RootElement, options);
        }

        internal static StaticSiteTemplate DeserializeStaticSiteTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> templateRepositoryUrl = default;
            Optional<string> owner = default;
            Optional<string> repositoryName = default;
            Optional<string> description = default;
            Optional<bool> isPrivate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateRepositoryUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateRepositoryUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("owner"u8))
                {
                    owner = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repositoryName"u8))
                {
                    repositoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPrivate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrivate = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StaticSiteTemplate(templateRepositoryUrl.Value, owner.Value, repositoryName.Value, description.Value, Optional.ToNullable(isPrivate), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StaticSiteTemplate>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StaticSiteTemplate)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        StaticSiteTemplate IPersistableModel<StaticSiteTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StaticSiteTemplate)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeStaticSiteTemplate(document.RootElement, options);
        }

        string IPersistableModel<StaticSiteTemplate>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
