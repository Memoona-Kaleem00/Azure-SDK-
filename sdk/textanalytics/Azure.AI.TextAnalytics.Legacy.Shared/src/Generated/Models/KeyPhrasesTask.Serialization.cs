// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class KeyPhrasesTask : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteObjectValue<KeyPhrasesTaskParameters>(Parameters);
            }
            if (Optional.IsDefined(TaskName))
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(TaskName);
            }
            writer.WriteEndObject();
        }
    }
}
