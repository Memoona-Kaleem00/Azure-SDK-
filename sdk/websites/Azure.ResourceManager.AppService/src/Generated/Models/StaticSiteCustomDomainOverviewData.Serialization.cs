// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class StaticSiteCustomDomainOverviewData : IUtf8JsonSerializable, IModelJsonSerializable<StaticSiteCustomDomainOverviewData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StaticSiteCustomDomainOverviewData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StaticSiteCustomDomainOverviewData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StaticSiteCustomDomainOverviewData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static StaticSiteCustomDomainOverviewData DeserializeStaticSiteCustomDomainOverviewData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> domainName = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<CustomDomainStatus> status = default;
            Optional<string> validationToken = default;
            Optional<string> errorMessage = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                        if (property0.NameEquals("domainName"u8))
                        {
                            domainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new CustomDomainStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("validationToken"u8))
                        {
                            validationToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"u8))
                        {
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StaticSiteCustomDomainOverviewData(id, name, type, systemData.Value, domainName.Value, Optional.ToNullable(createdOn), Optional.ToNullable(status), validationToken.Value, errorMessage.Value, kind.Value, rawData);
        }

        StaticSiteCustomDomainOverviewData IModelJsonSerializable<StaticSiteCustomDomainOverviewData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StaticSiteCustomDomainOverviewData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticSiteCustomDomainOverviewData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StaticSiteCustomDomainOverviewData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StaticSiteCustomDomainOverviewData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StaticSiteCustomDomainOverviewData IModelSerializable<StaticSiteCustomDomainOverviewData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StaticSiteCustomDomainOverviewData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStaticSiteCustomDomainOverviewData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StaticSiteCustomDomainOverviewData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StaticSiteCustomDomainOverviewData"/> to convert. </param>
        public static implicit operator RequestContent(StaticSiteCustomDomainOverviewData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StaticSiteCustomDomainOverviewData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StaticSiteCustomDomainOverviewData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStaticSiteCustomDomainOverviewData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
