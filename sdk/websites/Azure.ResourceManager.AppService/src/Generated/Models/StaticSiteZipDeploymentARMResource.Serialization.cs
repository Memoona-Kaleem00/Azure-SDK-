// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StaticSiteZipDeploymentARMResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AppZipUrl))
            {
                writer.WritePropertyName("appZipUrl");
                writer.WriteStringValue(AppZipUrl);
            }
            if (Optional.IsDefined(ApiZipUrl))
            {
                writer.WritePropertyName("apiZipUrl");
                writer.WriteStringValue(ApiZipUrl);
            }
            if (Optional.IsDefined(DeploymentTitle))
            {
                writer.WritePropertyName("deploymentTitle");
                writer.WriteStringValue(DeploymentTitle);
            }
            if (Optional.IsDefined(Provider))
            {
                writer.WritePropertyName("provider");
                writer.WriteStringValue(Provider);
            }
            if (Optional.IsDefined(FunctionLanguage))
            {
                writer.WritePropertyName("functionLanguage");
                writer.WriteStringValue(FunctionLanguage);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static StaticSiteZipDeploymentARMResource DeserializeStaticSiteZipDeploymentARMResource(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> appZipUrl = default;
            Optional<string> apiZipUrl = default;
            Optional<string> deploymentTitle = default;
            Optional<string> provider = default;
            Optional<string> functionLanguage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("appZipUrl"))
                        {
                            appZipUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiZipUrl"))
                        {
                            apiZipUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deploymentTitle"))
                        {
                            deploymentTitle = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provider"))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("functionLanguage"))
                        {
                            functionLanguage = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new StaticSiteZipDeploymentARMResource(id, name, type, systemData, kind.Value, appZipUrl.Value, apiZipUrl.Value, deploymentTitle.Value, provider.Value, functionLanguage.Value);
        }
    }
}
