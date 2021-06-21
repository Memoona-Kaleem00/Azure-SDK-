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
    /// Defines values for PauseDelayTimeUnit.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(PauseDelayTimeUnitConverter))]
    public struct PauseDelayTimeUnit : System.IEquatable<PauseDelayTimeUnit>
    {
        private PauseDelayTimeUnit(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly PauseDelayTimeUnit Minutes = "Minutes";


        /// <summary>
        /// Underlying value of enum PauseDelayTimeUnit
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for PauseDelayTimeUnit
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type PauseDelayTimeUnit
        /// </summary>
        public bool Equals(PauseDelayTimeUnit e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to PauseDelayTimeUnit
        /// </summary>
        public static implicit operator PauseDelayTimeUnit(string value)
        {
            return new PauseDelayTimeUnit(value);
        }

        /// <summary>
        /// Implicit operator to convert PauseDelayTimeUnit to string
        /// </summary>
        public static implicit operator string(PauseDelayTimeUnit e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum PauseDelayTimeUnit
        /// </summary>
        public static bool operator == (PauseDelayTimeUnit e1, PauseDelayTimeUnit e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum PauseDelayTimeUnit
        /// </summary>
        public static bool operator != (PauseDelayTimeUnit e1, PauseDelayTimeUnit e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for PauseDelayTimeUnit
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is PauseDelayTimeUnit && Equals((PauseDelayTimeUnit)obj);
        }

        /// <summary>
        /// Returns for hashCode PauseDelayTimeUnit
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
