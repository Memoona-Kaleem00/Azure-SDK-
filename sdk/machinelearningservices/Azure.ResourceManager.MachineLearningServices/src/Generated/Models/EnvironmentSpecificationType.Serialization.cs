// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal static class EnvironmentSpecificationTypeExtensions
    {
        public static string ToSerialString(this EnvironmentSpecificationType value) => value switch
        {
            EnvironmentSpecificationType.Curated => "Curated",
            EnvironmentSpecificationType.UserCreated => "UserCreated",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EnvironmentSpecificationType value.")
        };

        public static EnvironmentSpecificationType ToEnvironmentSpecificationType(this string value)
        {
            if (string.Equals(value, "Curated", StringComparison.InvariantCultureIgnoreCase)) return EnvironmentSpecificationType.Curated;
            if (string.Equals(value, "UserCreated", StringComparison.InvariantCultureIgnoreCase)) return EnvironmentSpecificationType.UserCreated;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EnvironmentSpecificationType value.");
        }
    }
}
