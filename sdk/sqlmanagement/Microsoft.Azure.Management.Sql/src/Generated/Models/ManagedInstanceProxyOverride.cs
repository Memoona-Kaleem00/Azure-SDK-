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
    /// Defines values for ManagedInstanceProxyOverride.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(ManagedInstanceProxyOverrideConverter))]
    public struct ManagedInstanceProxyOverride : System.IEquatable<ManagedInstanceProxyOverride>
    {
        private ManagedInstanceProxyOverride(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly ManagedInstanceProxyOverride Proxy = "Proxy";

        public static readonly ManagedInstanceProxyOverride Redirect = "Redirect";

        public static readonly ManagedInstanceProxyOverride Default = "Default";


        /// <summary>
        /// Underlying value of enum ManagedInstanceProxyOverride
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for ManagedInstanceProxyOverride
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type ManagedInstanceProxyOverride
        /// </summary>
        public bool Equals(ManagedInstanceProxyOverride e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to ManagedInstanceProxyOverride
        /// </summary>
        public static implicit operator ManagedInstanceProxyOverride(string value)
        {
            return new ManagedInstanceProxyOverride(value);
        }

        /// <summary>
        /// Implicit operator to convert ManagedInstanceProxyOverride to string
        /// </summary>
        public static implicit operator string(ManagedInstanceProxyOverride e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum ManagedInstanceProxyOverride
        /// </summary>
        public static bool operator == (ManagedInstanceProxyOverride e1, ManagedInstanceProxyOverride e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum ManagedInstanceProxyOverride
        /// </summary>
        public static bool operator != (ManagedInstanceProxyOverride e1, ManagedInstanceProxyOverride e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for ManagedInstanceProxyOverride
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is ManagedInstanceProxyOverride && Equals((ManagedInstanceProxyOverride)obj);
        }

        /// <summary>
        /// Returns for hashCode ManagedInstanceProxyOverride
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
