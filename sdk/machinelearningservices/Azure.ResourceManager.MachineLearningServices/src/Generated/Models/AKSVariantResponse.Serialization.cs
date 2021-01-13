// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class AKSVariantResponse : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsDefault))
            {
                writer.WritePropertyName("isDefault");
                writer.WriteBooleanValue(IsDefault.Value);
            }
            if (Optional.IsDefined(TrafficPercentile))
            {
                writer.WritePropertyName("trafficPercentile");
                writer.WriteNumberValue(TrafficPercentile.Value);
            }
            if (Optional.IsDefined(Type))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(KvTags))
            {
                writer.WritePropertyName("kvTags");
                writer.WriteStartObject();
                foreach (var item in KvTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("computeType");
            writer.WriteStringValue(ComputeType.ToString());
            if (Optional.IsDefined(DeploymentType))
            {
                writer.WritePropertyName("deploymentType");
                writer.WriteStringValue(DeploymentType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AKSVariantResponse DeserializeAKSVariantResponse(JsonElement element)
        {
            if (element.TryGetProperty("computeType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AKS": return AKSServiceResponse.DeserializeAKSServiceResponse(element);
                }
            }
            Optional<bool> isDefault = default;
            Optional<float> trafficPercentile = default;
            Optional<VariantType> type = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> kvTags = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<WebServiceState> state = default;
            Optional<ErrorResponse> error = default;
            ComputeEnvironmentType computeType = default;
            Optional<DeploymentType> deploymentType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isDefault"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("trafficPercentile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    trafficPercentile = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new VariantType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kvTags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    kvTags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    state = new WebServiceState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    error = ErrorResponse.DeserializeErrorResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("computeType"))
                {
                    computeType = new ComputeEnvironmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deploymentType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deploymentType = new DeploymentType(property.Value.GetString());
                    continue;
                }
            }
            return new AKSVariantResponse(description.Value, Optional.ToDictionary(kvTags), Optional.ToDictionary(properties), Optional.ToNullable(state), error.Value, computeType, Optional.ToNullable(deploymentType), Optional.ToNullable(isDefault), Optional.ToNullable(trafficPercentile), Optional.ToNullable(type));
        }
    }
}
