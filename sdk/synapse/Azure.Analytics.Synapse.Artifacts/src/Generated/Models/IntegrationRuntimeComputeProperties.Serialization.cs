// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class IntegrationRuntimeComputeProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Optional.IsDefined(NodeSize))
            {
                writer.WritePropertyName("nodeSize");
                writer.WriteStringValue(NodeSize);
            }
            if (Optional.IsDefined(NumberOfNodes))
            {
                writer.WritePropertyName("numberOfNodes");
                writer.WriteNumberValue(NumberOfNodes.Value);
            }
            if (Optional.IsDefined(MaxParallelExecutionsPerNode))
            {
                writer.WritePropertyName("maxParallelExecutionsPerNode");
                writer.WriteNumberValue(MaxParallelExecutionsPerNode.Value);
            }
            if (Optional.IsDefined(DataFlowProperties))
            {
                writer.WritePropertyName("dataFlowProperties");
                writer.WriteObjectValue(DataFlowProperties);
            }
            if (Optional.IsDefined(VNetProperties))
            {
                writer.WritePropertyName("vNetProperties");
                writer.WriteObjectValue(VNetProperties);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static IntegrationRuntimeComputeProperties DeserializeIntegrationRuntimeComputeProperties(JsonElement element)
        {
            Optional<string> location = default;
            Optional<string> nodeSize = default;
            Optional<int> numberOfNodes = default;
            Optional<int> maxParallelExecutionsPerNode = default;
            Optional<IntegrationRuntimeDataFlowProperties> dataFlowProperties = default;
            Optional<IntegrationRuntimeVNetProperties> vNetProperties = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeSize"))
                {
                    nodeSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfNodes"))
                {
                    numberOfNodes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxParallelExecutionsPerNode"))
                {
                    maxParallelExecutionsPerNode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataFlowProperties"))
                {
                    dataFlowProperties = IntegrationRuntimeDataFlowProperties.DeserializeIntegrationRuntimeDataFlowProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("vNetProperties"))
                {
                    vNetProperties = IntegrationRuntimeVNetProperties.DeserializeIntegrationRuntimeVNetProperties(property.Value);
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IntegrationRuntimeComputeProperties(location.Value, nodeSize.Value, Optional.ToNullable(numberOfNodes), Optional.ToNullable(maxParallelExecutionsPerNode), dataFlowProperties.Value, vNetProperties.Value, additionalProperties);
        }
    }
}
