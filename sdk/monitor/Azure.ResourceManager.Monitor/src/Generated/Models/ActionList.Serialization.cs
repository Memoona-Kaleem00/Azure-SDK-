// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    internal partial class ActionList : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(ActionGroups))
            {
                writer.WritePropertyName("actionGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ActionGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static ActionList DeserializeActionList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<ActivityLogAlertActionGroup>> actionGroups = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ActivityLogAlertActionGroup> array = new List<ActivityLogAlertActionGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityLogAlertActionGroup.DeserializeActivityLogAlertActionGroup(item));
                    }
                    actionGroups = array;
                    continue;
                }
            }
            return new ActionList(Core.Optional.ToList(actionGroups));
        }
    }
}
