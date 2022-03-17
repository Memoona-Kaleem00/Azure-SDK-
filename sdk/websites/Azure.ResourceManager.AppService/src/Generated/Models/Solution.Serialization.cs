// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class Solution : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteNumberValue(Id.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Order))
            {
                writer.WritePropertyName("order");
                writer.WriteNumberValue(Order.Value);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(SolutionType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(SolutionType.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(Data))
            {
                writer.WritePropertyName("data");
                writer.WriteStartArray();
                foreach (var item in Data)
                {
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata");
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static Solution DeserializeSolution(JsonElement element)
        {
            Optional<double> id = default;
            Optional<string> displayName = default;
            Optional<double> order = default;
            Optional<string> description = default;
            Optional<SolutionType> type = default;
            Optional<IList<IList<NameValuePair>>> data = default;
            Optional<IList<IList<NameValuePair>>> metadata = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    id = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("order"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    order = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = property.Value.GetString().ToSolutionType();
                    continue;
                }
                if (property.NameEquals("data"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IList<NameValuePair>> array = new List<IList<NameValuePair>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        List<NameValuePair> array0 = new List<NameValuePair>();
                        foreach (var item0 in item.EnumerateArray())
                        {
                            array0.Add(NameValuePair.DeserializeNameValuePair(item0));
                        }
                        array.Add(array0);
                    }
                    data = array;
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IList<NameValuePair>> array = new List<IList<NameValuePair>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        List<NameValuePair> array0 = new List<NameValuePair>();
                        foreach (var item0 in item.EnumerateArray())
                        {
                            array0.Add(NameValuePair.DeserializeNameValuePair(item0));
                        }
                        array.Add(array0);
                    }
                    metadata = array;
                    continue;
                }
            }
            return new Solution(Optional.ToNullable(id), displayName.Value, Optional.ToNullable(order), description.Value, Optional.ToNullable(type), Optional.ToList(data), Optional.ToList(metadata));
        }
    }
}
