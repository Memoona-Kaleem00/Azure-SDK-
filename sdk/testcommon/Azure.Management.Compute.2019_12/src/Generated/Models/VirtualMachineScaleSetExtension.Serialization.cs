// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineScaleSetExtension : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (ForceUpdateTag != null)
            {
                writer.WritePropertyName("forceUpdateTag");
                writer.WriteStringValue(ForceUpdateTag);
            }
            if (Publisher != null)
            {
                writer.WritePropertyName("publisher");
                writer.WriteStringValue(Publisher);
            }
            if (TypePropertiesType != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(TypePropertiesType);
            }
            if (TypeHandlerVersion != null)
            {
                writer.WritePropertyName("typeHandlerVersion");
                writer.WriteStringValue(TypeHandlerVersion);
            }
            if (AutoUpgradeMinorVersion != null)
            {
                writer.WritePropertyName("autoUpgradeMinorVersion");
                writer.WriteBooleanValue(AutoUpgradeMinorVersion.Value);
            }
            if (Settings != null)
            {
                writer.WritePropertyName("settings");
                writer.WriteObjectValue(Settings);
            }
            if (ProtectedSettings != null)
            {
                writer.WritePropertyName("protectedSettings");
                writer.WriteObjectValue(ProtectedSettings);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState);
            }
            if (ProvisionAfterExtensions != null)
            {
                writer.WritePropertyName("provisionAfterExtensions");
                writer.WriteStartArray();
                foreach (var item in ProvisionAfterExtensions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetExtension DeserializeVirtualMachineScaleSetExtension(JsonElement element)
        {
            string name = default;
            string type = default;
            string id = default;
            string forceUpdateTag = default;
            string publisher = default;
            string type0 = default;
            string typeHandlerVersion = default;
            bool? autoUpgradeMinorVersion = default;
            object settings = default;
            object protectedSettings = default;
            string provisioningState = default;
            IList<string> provisionAfterExtensions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("forceUpdateTag"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            forceUpdateTag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisher"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("typeHandlerVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            typeHandlerVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoUpgradeMinorVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpgradeMinorVersion = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("settings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            settings = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("protectedSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protectedSettings = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisionAfterExtensions"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(item.GetString());
                                }
                            }
                            provisionAfterExtensions = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualMachineScaleSetExtension(id, name, type, forceUpdateTag, publisher, type0, typeHandlerVersion, autoUpgradeMinorVersion, settings, protectedSettings, provisioningState, provisionAfterExtensions);
        }
    }
}
