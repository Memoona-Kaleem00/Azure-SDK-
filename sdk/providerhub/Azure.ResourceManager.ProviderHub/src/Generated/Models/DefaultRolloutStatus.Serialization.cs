// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class DefaultRolloutStatus : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(NextTrafficRegion))
            {
                writer.WritePropertyName("nextTrafficRegion"u8);
                writer.WriteStringValue(NextTrafficRegion.Value.ToString());
            }
            if (Core.Optional.IsDefined(NextTrafficRegionScheduledOn))
            {
                writer.WritePropertyName("nextTrafficRegionScheduledTime"u8);
                writer.WriteStringValue(NextTrafficRegionScheduledOn.Value, "O");
            }
            if (Core.Optional.IsDefined(SubscriptionReregistrationResult))
            {
                writer.WritePropertyName("subscriptionReregistrationResult"u8);
                writer.WriteStringValue(SubscriptionReregistrationResult.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(CompletedRegions))
            {
                writer.WritePropertyName("completedRegions"u8);
                writer.WriteStartArray();
                foreach (var item in CompletedRegions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(FailedOrSkippedRegions))
            {
                writer.WritePropertyName("failedOrSkippedRegions"u8);
                writer.WriteStartObject();
                foreach (var item in FailedOrSkippedRegions)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static DefaultRolloutStatus DeserializeDefaultRolloutStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<TrafficRegionCategory> nextTrafficRegion = default;
            Core.Optional<DateTimeOffset> nextTrafficRegionScheduledTime = default;
            Core.Optional<SubscriptionReregistrationResult> subscriptionReregistrationResult = default;
            Core.Optional<IList<AzureLocation>> completedRegions = default;
            Core.Optional<IDictionary<string, ExtendedErrorInfo>> failedOrSkippedRegions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextTrafficRegion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextTrafficRegion = new TrafficRegionCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nextTrafficRegionScheduledTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextTrafficRegionScheduledTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("subscriptionReregistrationResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionReregistrationResult = new SubscriptionReregistrationResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("completedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    completedRegions = array;
                    continue;
                }
                if (property.NameEquals("failedOrSkippedRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ExtendedErrorInfo> dictionary = new Dictionary<string, ExtendedErrorInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ExtendedErrorInfo.DeserializeExtendedErrorInfo(property0.Value));
                    }
                    failedOrSkippedRegions = dictionary;
                    continue;
                }
            }
            return new DefaultRolloutStatus(Core.Optional.ToList(completedRegions), Core.Optional.ToDictionary(failedOrSkippedRegions), Core.Optional.ToNullable(nextTrafficRegion), Core.Optional.ToNullable(nextTrafficRegionScheduledTime), Core.Optional.ToNullable(subscriptionReregistrationResult));
        }
    }
}
