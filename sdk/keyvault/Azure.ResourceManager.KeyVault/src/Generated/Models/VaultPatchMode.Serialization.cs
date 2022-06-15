// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal static partial class VaultPatchModeExtensions
    {
        public static string ToSerialString(this VaultPatchMode value) => value switch
        {
            VaultPatchMode.Default => "default",
            VaultPatchMode.Recover => "recover",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown VaultPatchMode value.")
        };

        public static VaultPatchMode ToVaultPatchMode(this string value)
        {
            if (string.Equals(value, "default", StringComparison.InvariantCultureIgnoreCase)) return VaultPatchMode.Default;
            if (string.Equals(value, "recover", StringComparison.InvariantCultureIgnoreCase)) return VaultPatchMode.Recover;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown VaultPatchMode value.");
        }
    }
}
