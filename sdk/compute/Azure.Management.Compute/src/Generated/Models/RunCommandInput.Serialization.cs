// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class RunCommandInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("commandId");
            writer.WriteStringValue(CommandId);
            if (Script != null)
            {
                writer.WritePropertyName("script");
                writer.WriteStartArray();
                foreach (var item in Script)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Parameters != null)
            {
                writer.WritePropertyName("parameters");
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
