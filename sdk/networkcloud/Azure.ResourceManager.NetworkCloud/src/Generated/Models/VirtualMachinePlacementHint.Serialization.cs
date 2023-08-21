// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class VirtualMachinePlacementHint : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("hintType"u8);
            writer.WriteStringValue(HintType.ToString());
            writer.WritePropertyName("resourceId"u8);
            writer.WriteStringValue(ResourceId);
            writer.WritePropertyName("schedulingExecution"u8);
            writer.WriteStringValue(SchedulingExecution.ToString());
            writer.WritePropertyName("scope"u8);
            writer.WriteStringValue(Scope.ToString());
            writer.WriteEndObject();
        }

        internal static VirtualMachinePlacementHint DeserializeVirtualMachinePlacementHint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VirtualMachinePlacementHintType hintType = default;
            ResourceIdentifier resourceId = default;
            VirtualMachineSchedulingExecution schedulingExecution = default;
            VirtualMachinePlacementHintPodAffinityScope scope = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hintType"u8))
                {
                    hintType = new VirtualMachinePlacementHintType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedulingExecution"u8))
                {
                    schedulingExecution = new VirtualMachineSchedulingExecution(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = new VirtualMachinePlacementHintPodAffinityScope(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualMachinePlacementHint(hintType, resourceId, schedulingExecution, scope);
        }
    }
}
