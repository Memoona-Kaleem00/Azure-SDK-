// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources
{
    public partial class WhatIfChange
    {
        internal static WhatIfChange DeserializeWhatIfChange(JsonElement element)
        {
            string resourceId = default;
            ChangeType changeType = default;
            Optional<string> unsupportedReason = default;
            Optional<object> before = default;
            Optional<object> after = default;
            Optional<IReadOnlyList<WhatIfPropertyChange>> delta = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("changeType"))
                {
                    changeType = property.Value.GetString().ToChangeType();
                    continue;
                }
                if (property.NameEquals("unsupportedReason"))
                {
                    unsupportedReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("before"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    before = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("after"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    after = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("delta"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WhatIfPropertyChange> array = new List<WhatIfPropertyChange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WhatIfPropertyChange.DeserializeWhatIfPropertyChange(item));
                    }
                    delta = array;
                    continue;
                }
            }
            return new WhatIfChange(resourceId, changeType, unsupportedReason.Value, before.Value, after.Value, Optional.ToList(delta));
        }
    }
}
