// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations
{
    public partial class ReservationOrderResponseData
    {
        internal static ReservationOrderResponseData DeserializeReservationOrderResponseData(JsonElement element)
        {
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            Core.ResourceType type = default;
            SystemData systemData = default;
            Optional<string> displayName = default;
            Optional<DateTimeOffset> requestDateTime = default;
            Optional<DateTimeOffset> createdDateTime = default;
            Optional<DateTimeOffset> expiryDate = default;
            Optional<DateTimeOffset> benefitStartTime = default;
            Optional<int> originalQuantity = default;
            Optional<ReservationTerm> term = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<ReservationBillingPlan> billingPlan = default;
            Optional<ReservationOrderBillingPlanInformation> planInformation = default;
            Optional<IReadOnlyList<ReservationResponseData>> reservations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requestDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            requestDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdDateTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("expiryDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expiryDate = property0.Value.GetDateTimeOffset("D");
                            continue;
                        }
                        if (property0.NameEquals("benefitStartTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            benefitStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("originalQuantity"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            originalQuantity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("term"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            term = new ReservationTerm(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingPlan"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            billingPlan = new ReservationBillingPlan(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("planInformation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            planInformation = ReservationOrderBillingPlanInformation.DeserializeReservationOrderBillingPlanInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("reservations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ReservationResponseData> array = new List<ReservationResponseData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ReservationResponseData.DeserializeReservationResponseData(item));
                            }
                            reservations = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ReservationOrderResponseData(id, name, type, systemData, Optional.ToNullable(etag), displayName.Value, Optional.ToNullable(requestDateTime), Optional.ToNullable(createdDateTime), Optional.ToNullable(expiryDate), Optional.ToNullable(benefitStartTime), Optional.ToNullable(originalQuantity), Optional.ToNullable(term), Optional.ToNullable(provisioningState), Optional.ToNullable(billingPlan), planInformation.Value, Optional.ToList(reservations));
        }
    }
}
