// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class UpsertManagedServerOperationStep
    {
        internal static UpsertManagedServerOperationStep DeserializeUpsertManagedServerOperationStep(JsonElement element)
        {
            Optional<int> order = default;
            Optional<string> name = default;
            Optional<UpsertManagedServerOperationStepStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("order"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new UpsertManagedServerOperationStepStatus(property.Value.GetString());
                    continue;
                }
            }
            return new UpsertManagedServerOperationStep(Optional.ToNullable(order), name.Value, Optional.ToNullable(status));
        }
    }
}
