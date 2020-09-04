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
    /// Defines values for UnitDefinitionType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(UnitDefinitionTypeConverter))]
    public struct UnitDefinitionType : System.IEquatable<UnitDefinitionType>
    {
        private UnitDefinitionType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly UnitDefinitionType Count = "Count";

        public static readonly UnitDefinitionType Bytes = "Bytes";

        public static readonly UnitDefinitionType Seconds = "Seconds";

        public static readonly UnitDefinitionType Percent = "Percent";

        public static readonly UnitDefinitionType CountPerSecond = "CountPerSecond";

        public static readonly UnitDefinitionType BytesPerSecond = "BytesPerSecond";


        /// <summary>
        /// Underlying value of enum UnitDefinitionType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for UnitDefinitionType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type UnitDefinitionType
        /// </summary>
        public bool Equals(UnitDefinitionType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to UnitDefinitionType
        /// </summary>
        public static implicit operator UnitDefinitionType(string value)
        {
            return new UnitDefinitionType(value);
        }

        /// <summary>
        /// Implicit operator to convert UnitDefinitionType to string
        /// </summary>
        public static implicit operator string(UnitDefinitionType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum UnitDefinitionType
        /// </summary>
        public static bool operator == (UnitDefinitionType e1, UnitDefinitionType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum UnitDefinitionType
        /// </summary>
        public static bool operator != (UnitDefinitionType e1, UnitDefinitionType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for UnitDefinitionType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is UnitDefinitionType && Equals((UnitDefinitionType)obj);
        }

        /// <summary>
        /// Returns for hashCode UnitDefinitionType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
