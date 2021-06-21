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
    /// Defines values for TransparentDataEncryptionActivityStatus.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(TransparentDataEncryptionActivityStatusConverter))]
    public struct TransparentDataEncryptionActivityStatus : System.IEquatable<TransparentDataEncryptionActivityStatus>
    {
        private TransparentDataEncryptionActivityStatus(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly TransparentDataEncryptionActivityStatus Encrypting = "Encrypting";

        public static readonly TransparentDataEncryptionActivityStatus Decrypting = "Decrypting";


        /// <summary>
        /// Underlying value of enum TransparentDataEncryptionActivityStatus
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for
        /// TransparentDataEncryptionActivityStatus
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue == null ? null : UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type TransparentDataEncryptionActivityStatus
        /// </summary>
        public bool Equals(TransparentDataEncryptionActivityStatus e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to
        /// TransparentDataEncryptionActivityStatus
        /// </summary>
        public static implicit operator TransparentDataEncryptionActivityStatus(string value)
        {
            return new TransparentDataEncryptionActivityStatus(value);
        }

        /// <summary>
        /// Implicit operator to convert
        /// TransparentDataEncryptionActivityStatus to string
        /// </summary>
        public static implicit operator string(TransparentDataEncryptionActivityStatus e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum
        /// TransparentDataEncryptionActivityStatus
        /// </summary>
        public static bool operator == (TransparentDataEncryptionActivityStatus e1, TransparentDataEncryptionActivityStatus e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum
        /// TransparentDataEncryptionActivityStatus
        /// </summary>
        public static bool operator != (TransparentDataEncryptionActivityStatus e1, TransparentDataEncryptionActivityStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for
        /// TransparentDataEncryptionActivityStatus
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is TransparentDataEncryptionActivityStatus && Equals((TransparentDataEncryptionActivityStatus)obj);
        }

        /// <summary>
        /// Returns for hashCode TransparentDataEncryptionActivityStatus
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
