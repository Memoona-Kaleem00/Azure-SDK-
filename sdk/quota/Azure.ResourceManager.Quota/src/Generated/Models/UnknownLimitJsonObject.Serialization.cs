// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    internal partial class UnknownLimitJsonObject : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("limitObjectType");
            writer.WriteStringValue(LimitObjectType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownLimitJsonObject DeserializeUnknownLimitJsonObject(JsonElement element)
        {
            LimitType limitObjectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("limitObjectType"))
                {
                    limitObjectType = new LimitType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownLimitJsonObject(limitObjectType);
        }
    }
}
