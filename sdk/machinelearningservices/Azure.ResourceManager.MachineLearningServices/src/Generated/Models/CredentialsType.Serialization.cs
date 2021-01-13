// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    internal static class CredentialsTypeExtensions
    {
        public static string ToSerialString(this CredentialsType value) => value switch
        {
            CredentialsType.AccountKey => "AccountKey",
            CredentialsType.Certificate => "Certificate",
            CredentialsType.None => "None",
            CredentialsType.Sas => "Sas",
            CredentialsType.ServicePrincipal => "ServicePrincipal",
            CredentialsType.SqlAdmin => "SqlAdmin",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CredentialsType value.")
        };

        public static CredentialsType ToCredentialsType(this string value)
        {
            if (string.Equals(value, "AccountKey", StringComparison.InvariantCultureIgnoreCase)) return CredentialsType.AccountKey;
            if (string.Equals(value, "Certificate", StringComparison.InvariantCultureIgnoreCase)) return CredentialsType.Certificate;
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return CredentialsType.None;
            if (string.Equals(value, "Sas", StringComparison.InvariantCultureIgnoreCase)) return CredentialsType.Sas;
            if (string.Equals(value, "ServicePrincipal", StringComparison.InvariantCultureIgnoreCase)) return CredentialsType.ServicePrincipal;
            if (string.Equals(value, "SqlAdmin", StringComparison.InvariantCultureIgnoreCase)) return CredentialsType.SqlAdmin;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CredentialsType value.");
        }
    }
}
