// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationsPropertiesUtilization
    {
        internal static ReservationsPropertiesUtilization DeserializeReservationsPropertiesUtilization(JsonElement element)
        {
            Optional<string> trend = default;
            Optional<IReadOnlyList<ReservationUtilizationAggregates>> aggregates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trend"))
                {
                    trend = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregates"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ReservationUtilizationAggregates> array = new List<ReservationUtilizationAggregates>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationUtilizationAggregates.DeserializeReservationUtilizationAggregates(item));
                    }
                    aggregates = array;
                    continue;
                }
            }
            return new ReservationsPropertiesUtilization(trend.Value, Optional.ToList(aggregates));
        }
    }
}
