// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Maps.Common;

namespace Azure.Maps.Search.Models
{
    public partial class OperatingHours
    {
        internal static OperatingHours DeserializeOperatingHours(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string mode = default;
            IReadOnlyList<OperatingHoursTimeRange> timeRanges = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"u8))
                {
                    mode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeRanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OperatingHoursTimeRange> array = new List<OperatingHoursTimeRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperatingHoursTimeRange.DeserializeOperatingHoursTimeRange(item));
                    }
                    timeRanges = array;
                    continue;
                }
            }
            return new OperatingHours(mode, timeRanges ?? new ChangeTrackingList<OperatingHoursTimeRange>());
        }
    }
}
