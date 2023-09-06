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

namespace Azure.ResourceManager.StoragePool.Models
{
    public partial class OutboundEndpointDependency : IUtf8JsonSerializable, IModelJsonSerializable<OutboundEndpointDependency>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<OutboundEndpointDependency>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<OutboundEndpointDependency>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OutboundEndpointDependency>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (Optional.IsCollectionDefined(EndpointDetails))
            {
                writer.WritePropertyName("endpointDetails"u8);
                writer.WriteStartArray();
                foreach (var item in EndpointDetails)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<OutboundEndpointDetail>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
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

        internal static OutboundEndpointDependency DeserializeOutboundEndpointDependency(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> domainName = default;
            Optional<IReadOnlyList<OutboundEndpointDetail>> endpointDetails = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domainName"u8))
                {
                    domainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OutboundEndpointDetail> array = new List<OutboundEndpointDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutboundEndpointDetail.DeserializeOutboundEndpointDetail(item));
                    }
                    endpointDetails = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new OutboundEndpointDependency(domainName.Value, Optional.ToList(endpointDetails), rawData);
        }

        OutboundEndpointDependency IModelJsonSerializable<OutboundEndpointDependency>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OutboundEndpointDependency>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeOutboundEndpointDependency(doc.RootElement, options);
        }

        BinaryData IModelSerializable<OutboundEndpointDependency>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OutboundEndpointDependency>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        OutboundEndpointDependency IModelSerializable<OutboundEndpointDependency>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<OutboundEndpointDependency>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeOutboundEndpointDependency(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="OutboundEndpointDependency"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="OutboundEndpointDependency"/> to convert. </param>
        public static implicit operator RequestContent(OutboundEndpointDependency model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="OutboundEndpointDependency"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator OutboundEndpointDependency(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeOutboundEndpointDependency(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
