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
    /// Defines values for MetricType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(MetricTypeConverter))]
    public struct MetricType : System.IEquatable<MetricType>
    {
        private MetricType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly MetricType Cpu = "cpu";

        public static readonly MetricType Io = "io";

        public static readonly MetricType LogIo = "logIo";

        public static readonly MetricType Duration = "duration";

        public static readonly MetricType Dtu = "dtu";


        /// <summary>
        /// Underlying value of enum MetricType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for MetricType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type MetricType
        /// </summary>
        public bool Equals(MetricType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to MetricType
        /// </summary>
        public static implicit operator MetricType(string value)
        {
            return new MetricType(value);
        }

        /// <summary>
        /// Implicit operator to convert MetricType to string
        /// </summary>
        public static implicit operator string(MetricType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum MetricType
        /// </summary>
        public static bool operator == (MetricType e1, MetricType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum MetricType
        /// </summary>
        public static bool operator != (MetricType e1, MetricType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for MetricType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is MetricType && Equals((MetricType)obj);
        }

        /// <summary>
        /// Returns for hashCode MetricType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
