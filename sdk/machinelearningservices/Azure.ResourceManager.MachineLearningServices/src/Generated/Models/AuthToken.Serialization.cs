// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class AuthToken
    {
        internal static AuthToken DeserializeAuthToken(JsonElement element)
        {
            Optional<string> accessToken = default;
            Optional<string> tokenType = default;
            Optional<long> expiryTimeUtc = default;
            Optional<long> refreshAfterTimeUtc = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessToken"))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokenType"))
                {
                    tokenType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiryTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    expiryTimeUtc = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("refreshAfterTimeUtc"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    refreshAfterTimeUtc = property.Value.GetInt64();
                    continue;
                }
            }
            return new AuthToken(accessToken.Value, tokenType.Value, Optional.ToNullable(expiryTimeUtc), Optional.ToNullable(refreshAfterTimeUtc));
        }
    }
}
