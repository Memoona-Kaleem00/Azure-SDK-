// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector.Models
{
    internal partial class AnomalyDetectorError
    {
        internal static AnomalyDetectorError DeserializeAnomalyDetectorError(JsonElement element)
        {
            Optional<AnomalyDetectorErrorCodes> code = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = new AnomalyDetectorErrorCodes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new AnomalyDetectorError(Optional.ToNullable(code), message.Value);
        }
    }
}
