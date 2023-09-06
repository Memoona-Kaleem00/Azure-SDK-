// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(ManagedVirtualNetworkSettingsConverter))]
    public partial class ManagedVirtualNetworkSettings : IUtf8JsonSerializable, IModelJsonSerializable<ManagedVirtualNetworkSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedVirtualNetworkSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedVirtualNetworkSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedVirtualNetworkSettings>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PreventDataExfiltration))
            {
                writer.WritePropertyName("preventDataExfiltration"u8);
                writer.WriteBooleanValue(PreventDataExfiltration.Value);
            }
            if (Optional.IsDefined(LinkedAccessCheckOnTargetResource))
            {
                writer.WritePropertyName("linkedAccessCheckOnTargetResource"u8);
                writer.WriteBooleanValue(LinkedAccessCheckOnTargetResource.Value);
            }
            if (Optional.IsCollectionDefined(AllowedAadTenantIdsForLinking))
            {
                writer.WritePropertyName("allowedAadTenantIdsForLinking"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedAadTenantIdsForLinking)
                {
                    writer.WriteStringValue(item);
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

        internal static ManagedVirtualNetworkSettings DeserializeManagedVirtualNetworkSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> preventDataExfiltration = default;
            Optional<bool> linkedAccessCheckOnTargetResource = default;
            Optional<IList<string>> allowedAadTenantIdsForLinking = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preventDataExfiltration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preventDataExfiltration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("linkedAccessCheckOnTargetResource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedAccessCheckOnTargetResource = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedAadTenantIdsForLinking"u8))
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
                    allowedAadTenantIdsForLinking = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedVirtualNetworkSettings(Optional.ToNullable(preventDataExfiltration), Optional.ToNullable(linkedAccessCheckOnTargetResource), Optional.ToList(allowedAadTenantIdsForLinking), rawData);
        }

        ManagedVirtualNetworkSettings IModelJsonSerializable<ManagedVirtualNetworkSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedVirtualNetworkSettings>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedVirtualNetworkSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedVirtualNetworkSettings>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedVirtualNetworkSettings>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedVirtualNetworkSettings IModelSerializable<ManagedVirtualNetworkSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedVirtualNetworkSettings>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedVirtualNetworkSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedVirtualNetworkSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedVirtualNetworkSettings"/> to convert. </param>
        public static implicit operator RequestContent(ManagedVirtualNetworkSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedVirtualNetworkSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedVirtualNetworkSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedVirtualNetworkSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class ManagedVirtualNetworkSettingsConverter : JsonConverter<ManagedVirtualNetworkSettings>
        {
            public override void Write(Utf8JsonWriter writer, ManagedVirtualNetworkSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ManagedVirtualNetworkSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeManagedVirtualNetworkSettings(document.RootElement);
            }
        }
    }
}
