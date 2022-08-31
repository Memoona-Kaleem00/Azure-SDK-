// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class ServiceAccountModelDeprecationInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FineTuneOn))
            {
                writer.WritePropertyName("fineTune");
                writer.WriteStringValue(FineTuneOn.Value, "O");
            }
            if (Optional.IsDefined(InferenceOn))
            {
                writer.WritePropertyName("inference");
                writer.WriteStringValue(InferenceOn.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static ServiceAccountModelDeprecationInfo DeserializeServiceAccountModelDeprecationInfo(JsonElement element)
        {
            Optional<DateTimeOffset> fineTune = default;
            Optional<DateTimeOffset> inference = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fineTune"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    fineTune = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("inference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    inference = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ServiceAccountModelDeprecationInfo(Optional.ToNullable(fineTune), Optional.ToNullable(inference));
        }
    }
}
