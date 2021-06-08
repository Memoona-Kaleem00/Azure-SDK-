// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NewResources
{
    internal static partial class AliasPatternTypeExtensions
    {
        public static string ToSerialString(this AliasPatternType value) => value switch
        {
            AliasPatternType.NotSpecified => "NotSpecified",
            AliasPatternType.Extract => "Extract",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AliasPatternType value.")
        };

        public static AliasPatternType ToAliasPatternType(this string value)
        {
            if (string.Equals(value, "NotSpecified", StringComparison.InvariantCultureIgnoreCase)) return AliasPatternType.NotSpecified;
            if (string.Equals(value, "Extract", StringComparison.InvariantCultureIgnoreCase)) return AliasPatternType.Extract;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AliasPatternType value.");
        }
    }
}
