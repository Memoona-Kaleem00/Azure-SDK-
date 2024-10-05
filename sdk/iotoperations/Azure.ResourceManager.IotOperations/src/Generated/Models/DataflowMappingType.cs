// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IoTOperations.Models
{
    /// <summary> Dataflow type mapping properties. </summary>
    public readonly partial struct DataflowMappingType : IEquatable<DataflowMappingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataflowMappingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataflowMappingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NewPropertiesValue = "NewProperties";
        private const string RenameValue = "Rename";
        private const string ComputeValue = "Compute";
        private const string PassThroughValue = "PassThrough";
        private const string BuiltInFunctionValue = "BuiltInFunction";

        /// <summary> New Properties type. </summary>
        public static DataflowMappingType NewProperties { get; } = new DataflowMappingType(NewPropertiesValue);
        /// <summary> Rename type. </summary>
        public static DataflowMappingType Rename { get; } = new DataflowMappingType(RenameValue);
        /// <summary> Compute type. </summary>
        public static DataflowMappingType Compute { get; } = new DataflowMappingType(ComputeValue);
        /// <summary> Pass-through type. </summary>
        public static DataflowMappingType PassThrough { get; } = new DataflowMappingType(PassThroughValue);
        /// <summary> Built in function type. </summary>
        public static DataflowMappingType BuiltInFunction { get; } = new DataflowMappingType(BuiltInFunctionValue);
        /// <summary> Determines if two <see cref="DataflowMappingType"/> values are the same. </summary>
        public static bool operator ==(DataflowMappingType left, DataflowMappingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataflowMappingType"/> values are not the same. </summary>
        public static bool operator !=(DataflowMappingType left, DataflowMappingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataflowMappingType"/>. </summary>
        public static implicit operator DataflowMappingType(string value) => new DataflowMappingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataflowMappingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataflowMappingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
