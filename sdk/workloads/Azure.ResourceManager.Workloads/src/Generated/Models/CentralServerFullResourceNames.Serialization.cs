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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class CentralServerFullResourceNames : IUtf8JsonSerializable, IModelJsonSerializable<CentralServerFullResourceNames>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CentralServerFullResourceNames>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CentralServerFullResourceNames>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CentralServerFullResourceNames>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(VirtualMachines))
            {
                writer.WritePropertyName("virtualMachines"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualMachines)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<VirtualMachineResourceNames>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AvailabilitySetName))
            {
                writer.WritePropertyName("availabilitySetName"u8);
                writer.WriteStringValue(AvailabilitySetName);
            }
            if (Optional.IsDefined(LoadBalancer))
            {
                writer.WritePropertyName("loadBalancer"u8);
                if (LoadBalancer is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<LoadBalancerResourceNames>)LoadBalancer).Serialize(writer, options);
                }
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

        internal static CentralServerFullResourceNames DeserializeCentralServerFullResourceNames(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<VirtualMachineResourceNames>> virtualMachines = default;
            Optional<string> availabilitySetName = default;
            Optional<LoadBalancerResourceNames> loadBalancer = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VirtualMachineResourceNames> array = new List<VirtualMachineResourceNames>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineResourceNames.DeserializeVirtualMachineResourceNames(item));
                    }
                    virtualMachines = array;
                    continue;
                }
                if (property.NameEquals("availabilitySetName"u8))
                {
                    availabilitySetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loadBalancer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loadBalancer = LoadBalancerResourceNames.DeserializeLoadBalancerResourceNames(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CentralServerFullResourceNames(Optional.ToList(virtualMachines), availabilitySetName.Value, loadBalancer.Value, rawData);
        }

        CentralServerFullResourceNames IModelJsonSerializable<CentralServerFullResourceNames>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CentralServerFullResourceNames>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCentralServerFullResourceNames(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CentralServerFullResourceNames>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CentralServerFullResourceNames>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CentralServerFullResourceNames IModelSerializable<CentralServerFullResourceNames>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CentralServerFullResourceNames>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCentralServerFullResourceNames(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CentralServerFullResourceNames"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CentralServerFullResourceNames"/> to convert. </param>
        public static implicit operator RequestContent(CentralServerFullResourceNames model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CentralServerFullResourceNames"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CentralServerFullResourceNames(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCentralServerFullResourceNames(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
