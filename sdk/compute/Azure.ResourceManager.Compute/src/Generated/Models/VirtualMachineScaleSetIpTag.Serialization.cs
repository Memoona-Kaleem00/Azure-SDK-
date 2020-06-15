// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetIpTag : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (IpTagType != null)
            {
                writer.WritePropertyName("ipTagType");
                writer.WriteStringValue(IpTagType);
            }
            if (Tag != null)
            {
                writer.WritePropertyName("tag");
                writer.WriteStringValue(Tag);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetIpTag DeserializeVirtualMachineScaleSetIpTag(JsonElement element)
        {
            string ipTagType = default;
            string tag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipTagType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipTagType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tag = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualMachineScaleSetIpTag(ipTagType, tag);
        }
    }
}
