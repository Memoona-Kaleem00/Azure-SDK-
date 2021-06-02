// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Resources
{
    internal static partial class ApplicationArtifactTypeExtensions
    {
        public static string ToSerialString(this ApplicationArtifactType value) => value switch
        {
            ApplicationArtifactType.Template => "Template",
            ApplicationArtifactType.Custom => "Custom",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ApplicationArtifactType value.")
        };

        public static ApplicationArtifactType ToApplicationArtifactType(this string value)
        {
            if (string.Equals(value, "Template", StringComparison.InvariantCultureIgnoreCase)) return ApplicationArtifactType.Template;
            if (string.Equals(value, "Custom", StringComparison.InvariantCultureIgnoreCase)) return ApplicationArtifactType.Custom;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ApplicationArtifactType value.");
        }
    }
}
