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
    /// Defines values for RequestedBackupStorageRedundancy.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(RequestedBackupStorageRedundancyConverter))]
    public struct RequestedBackupStorageRedundancy : System.IEquatable<RequestedBackupStorageRedundancy>
    {
        private RequestedBackupStorageRedundancy(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly RequestedBackupStorageRedundancy Geo = "Geo";

        public static readonly RequestedBackupStorageRedundancy Local = "Local";

        public static readonly RequestedBackupStorageRedundancy Zone = "Zone";


        /// <summary>
        /// Underlying value of enum RequestedBackupStorageRedundancy
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for RequestedBackupStorageRedundancy
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type RequestedBackupStorageRedundancy
        /// </summary>
        public bool Equals(RequestedBackupStorageRedundancy e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to
        /// RequestedBackupStorageRedundancy
        /// </summary>
        public static implicit operator RequestedBackupStorageRedundancy(string value)
        {
            return new RequestedBackupStorageRedundancy(value);
        }

        /// <summary>
        /// Implicit operator to convert RequestedBackupStorageRedundancy to
        /// string
        /// </summary>
        public static implicit operator string(RequestedBackupStorageRedundancy e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum RequestedBackupStorageRedundancy
        /// </summary>
        public static bool operator == (RequestedBackupStorageRedundancy e1, RequestedBackupStorageRedundancy e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum RequestedBackupStorageRedundancy
        /// </summary>
        public static bool operator != (RequestedBackupStorageRedundancy e1, RequestedBackupStorageRedundancy e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for RequestedBackupStorageRedundancy
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is RequestedBackupStorageRedundancy && Equals((RequestedBackupStorageRedundancy)obj);
        }

        /// <summary>
        /// Returns for hashCode RequestedBackupStorageRedundancy
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
