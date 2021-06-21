// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for CurrentBackupStorageRedundancy.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(CurrentBackupStorageRedundancyConverter))]
    public struct CurrentBackupStorageRedundancy : System.IEquatable<CurrentBackupStorageRedundancy>
    {
        private CurrentBackupStorageRedundancy(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly CurrentBackupStorageRedundancy Geo = "Geo";

        public static readonly CurrentBackupStorageRedundancy Local = "Local";

        public static readonly CurrentBackupStorageRedundancy Zone = "Zone";


        /// <summary>
        /// Underlying value of enum CurrentBackupStorageRedundancy
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for CurrentBackupStorageRedundancy
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type CurrentBackupStorageRedundancy
        /// </summary>
        public bool Equals(CurrentBackupStorageRedundancy e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to
        /// CurrentBackupStorageRedundancy
        /// </summary>
        public static implicit operator CurrentBackupStorageRedundancy(string value)
        {
            return new CurrentBackupStorageRedundancy(value);
        }

        /// <summary>
        /// Implicit operator to convert CurrentBackupStorageRedundancy to
        /// string
        /// </summary>
        public static implicit operator string(CurrentBackupStorageRedundancy e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum CurrentBackupStorageRedundancy
        /// </summary>
        public static bool operator == (CurrentBackupStorageRedundancy e1, CurrentBackupStorageRedundancy e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum CurrentBackupStorageRedundancy
        /// </summary>
        public static bool operator != (CurrentBackupStorageRedundancy e1, CurrentBackupStorageRedundancy e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for CurrentBackupStorageRedundancy
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is CurrentBackupStorageRedundancy && Equals((CurrentBackupStorageRedundancy)obj);
        }

        /// <summary>
        /// Returns for hashCode CurrentBackupStorageRedundancy
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
