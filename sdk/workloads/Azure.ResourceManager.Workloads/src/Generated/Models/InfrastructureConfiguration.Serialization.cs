// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class InfrastructureConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("deploymentType");
            writer.WriteStringValue(DeploymentType.ToString());
            writer.WritePropertyName("appResourceGroup");
            writer.WriteStringValue(AppResourceGroup);
            writer.WriteEndObject();
        }

        internal static InfrastructureConfiguration DeserializeInfrastructureConfiguration(JsonElement element)
        {
            if (element.TryGetProperty("deploymentType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "SingleServer": return SingleServerConfiguration.DeserializeSingleServerConfiguration(element);
                    case "ThreeTier": return ThreeTierConfiguration.DeserializeThreeTierConfiguration(element);
                }
            }
            SapDeploymentType deploymentType = default;
            string appResourceGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentType"))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appResourceGroup"))
                {
                    appResourceGroup = property.Value.GetString();
                    continue;
                }
            }
            return new InfrastructureConfiguration(deploymentType, appResourceGroup);
        }
    }
}
