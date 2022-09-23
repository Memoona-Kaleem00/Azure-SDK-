// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class ExtensionPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoUpgradeMinorVersion))
            {
                writer.WritePropertyName("autoUpgradeMinorVersion");
                writer.WriteBooleanValue(AutoUpgradeMinorVersion.Value);
            }
            if (Optional.IsDefined(ReleaseTrain))
            {
                writer.WritePropertyName("releaseTrain");
                writer.WriteStringValue(ReleaseTrain);
            }
            if (Optional.IsDefined(Version))
            {
                if (Version != null)
                {
                    writer.WritePropertyName("version");
                    writer.WriteStringValue(Version);
                }
                else
                {
                    writer.WriteNull("version");
                }
            }
            if (Optional.IsCollectionDefined(ConfigurationSettings))
            {
                if (ConfigurationSettings != null)
                {
                    writer.WritePropertyName("configurationSettings");
                    writer.WriteStartObject();
                    foreach (var item in ConfigurationSettings)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("configurationSettings");
                }
            }
            if (Optional.IsCollectionDefined(ConfigurationProtectedSettings))
            {
                if (ConfigurationProtectedSettings != null)
                {
                    writer.WritePropertyName("configurationProtectedSettings");
                    writer.WriteStartObject();
                    foreach (var item in ConfigurationProtectedSettings)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("configurationProtectedSettings");
                }
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
