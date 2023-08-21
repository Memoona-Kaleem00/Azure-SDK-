// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyExplicitProxy : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(EnableExplicitProxy))
            {
                if (EnableExplicitProxy != null)
                {
                    writer.WritePropertyName("enableExplicitProxy"u8);
                    writer.WriteBooleanValue(EnableExplicitProxy.Value);
                }
                else
                {
                    writer.WriteNull("enableExplicitProxy");
                }
            }
            if (Core.Optional.IsDefined(HttpPort))
            {
                writer.WritePropertyName("httpPort"u8);
                writer.WriteNumberValue(HttpPort.Value);
            }
            if (Core.Optional.IsDefined(HttpsPort))
            {
                writer.WritePropertyName("httpsPort"u8);
                writer.WriteNumberValue(HttpsPort.Value);
            }
            if (Core.Optional.IsDefined(EnablePacFile))
            {
                if (EnablePacFile != null)
                {
                    writer.WritePropertyName("enablePacFile"u8);
                    writer.WriteBooleanValue(EnablePacFile.Value);
                }
                else
                {
                    writer.WriteNull("enablePacFile");
                }
            }
            if (Core.Optional.IsDefined(PacFilePort))
            {
                writer.WritePropertyName("pacFilePort"u8);
                writer.WriteNumberValue(PacFilePort.Value);
            }
            if (Core.Optional.IsDefined(PacFile))
            {
                writer.WritePropertyName("pacFile"u8);
                writer.WriteStringValue(PacFile);
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyExplicitProxy DeserializeFirewallPolicyExplicitProxy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool?> enableExplicitProxy = default;
            Core.Optional<int> httpPort = default;
            Core.Optional<int> httpsPort = default;
            Core.Optional<bool?> enablePacFile = default;
            Core.Optional<int> pacFilePort = default;
            Core.Optional<string> pacFile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enableExplicitProxy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableExplicitProxy = null;
                        continue;
                    }
                    enableExplicitProxy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("httpPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpsPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpsPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enablePacFile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enablePacFile = null;
                        continue;
                    }
                    enablePacFile = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("pacFilePort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pacFilePort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pacFile"u8))
                {
                    pacFile = property.Value.GetString();
                    continue;
                }
            }
            return new FirewallPolicyExplicitProxy(Core.Optional.ToNullable(enableExplicitProxy), Core.Optional.ToNullable(httpPort), Core.Optional.ToNullable(httpsPort), Core.Optional.ToNullable(enablePacFile), Core.Optional.ToNullable(pacFilePort), pacFile.Value);
        }
    }
}
