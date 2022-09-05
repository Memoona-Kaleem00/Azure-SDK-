// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverPrepareContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ValidateOnly))
            {
                writer.WritePropertyName("validateOnly");
                writer.WriteBooleanValue(ValidateOnly.Value);
            }
            writer.WritePropertyName("moveResources");
            writer.WriteStartArray();
            foreach (var item in MoverResources)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(MoverResourceInputType))
            {
                writer.WritePropertyName("moveResourceInputType");
                writer.WriteStringValue(MoverResourceInputType.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
