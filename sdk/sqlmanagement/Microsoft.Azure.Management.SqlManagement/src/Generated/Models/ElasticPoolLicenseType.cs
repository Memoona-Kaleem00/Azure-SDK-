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
    /// Defines values for ElasticPoolLicenseType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(ElasticPoolLicenseTypeConverter))]
    public struct ElasticPoolLicenseType : System.IEquatable<ElasticPoolLicenseType>
    {
        private ElasticPoolLicenseType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly ElasticPoolLicenseType LicenseIncluded = "LicenseIncluded";

        public static readonly ElasticPoolLicenseType BasePrice = "BasePrice";


        /// <summary>
        /// Underlying value of enum ElasticPoolLicenseType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for ElasticPoolLicenseType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type ElasticPoolLicenseType
        /// </summary>
        public bool Equals(ElasticPoolLicenseType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to ElasticPoolLicenseType
        /// </summary>
        public static implicit operator ElasticPoolLicenseType(string value)
        {
            return new ElasticPoolLicenseType(value);
        }

        /// <summary>
        /// Implicit operator to convert ElasticPoolLicenseType to string
        /// </summary>
        public static implicit operator string(ElasticPoolLicenseType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum ElasticPoolLicenseType
        /// </summary>
        public static bool operator == (ElasticPoolLicenseType e1, ElasticPoolLicenseType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum ElasticPoolLicenseType
        /// </summary>
        public static bool operator != (ElasticPoolLicenseType e1, ElasticPoolLicenseType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for ElasticPoolLicenseType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is ElasticPoolLicenseType && Equals((ElasticPoolLicenseType)obj);
        }

        /// <summary>
        /// Returns for hashCode ElasticPoolLicenseType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
