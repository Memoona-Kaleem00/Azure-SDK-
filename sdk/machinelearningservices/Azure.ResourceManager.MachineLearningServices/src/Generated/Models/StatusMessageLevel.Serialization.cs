// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal static class StatusMessageLevelExtensions
    {
        public static string ToSerialString(this StatusMessageLevel value) => value switch
        {
            StatusMessageLevel.Error => "Error",
            StatusMessageLevel.Information => "Information",
            StatusMessageLevel.Warning => "Warning",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StatusMessageLevel value.")
        };

        public static StatusMessageLevel ToStatusMessageLevel(this string value)
        {
            if (string.Equals(value, "Error", StringComparison.InvariantCultureIgnoreCase)) return StatusMessageLevel.Error;
            if (string.Equals(value, "Information", StringComparison.InvariantCultureIgnoreCase)) return StatusMessageLevel.Information;
            if (string.Equals(value, "Warning", StringComparison.InvariantCultureIgnoreCase)) return StatusMessageLevel.Warning;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StatusMessageLevel value.");
        }
    }
}
