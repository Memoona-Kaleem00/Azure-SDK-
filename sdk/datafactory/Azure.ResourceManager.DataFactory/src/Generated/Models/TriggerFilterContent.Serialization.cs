// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class TriggerFilterContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ContinuationToken))
            {
                writer.WritePropertyName("continuationToken");
                writer.WriteStringValue(ContinuationToken);
            }
            if (Optional.IsDefined(ParentTriggerName))
            {
                writer.WritePropertyName("parentTriggerName");
                writer.WriteStringValue(ParentTriggerName);
            }
            writer.WriteEndObject();
        }
    }
}
