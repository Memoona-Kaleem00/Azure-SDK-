// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewResources
{
    public partial class WhatIfPropertyChange
    {
        internal static WhatIfPropertyChange DeserializeWhatIfPropertyChange(JsonElement element)
        {
            string path = default;
            PropertyChangeType propertyChangeType = default;
            Optional<object> before = default;
            Optional<object> after = default;
            Optional<IReadOnlyList<WhatIfPropertyChange>> children = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("propertyChangeType"))
                {
                    propertyChangeType = property.Value.GetString().ToPropertyChangeType();
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
                if (property.NameEquals("children"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<WhatIfPropertyChange> array = new List<WhatIfPropertyChange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeWhatIfPropertyChange(item));
                    }
                    children = array;
                    continue;
                }
            }
            return new WhatIfPropertyChange(path, propertyChangeType, before.Value, after.Value, Optional.ToList(children));
        }
    }
}
