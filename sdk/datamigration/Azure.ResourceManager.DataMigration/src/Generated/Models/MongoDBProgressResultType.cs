// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The type of progress object. </summary>
    internal readonly partial struct MongoDBProgressResultType : IEquatable<MongoDBProgressResultType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MongoDBProgressResultType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MongoDBProgressResultType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MigrationValue = "Migration";
        private const string DatabaseValue = "Database";
        private const string CollectionValue = "Collection";

        /// <summary> Migration. </summary>
        public static MongoDBProgressResultType Migration { get; } = new MongoDBProgressResultType(MigrationValue);
        /// <summary> Database. </summary>
        public static MongoDBProgressResultType Database { get; } = new MongoDBProgressResultType(DatabaseValue);
        /// <summary> Collection. </summary>
        public static MongoDBProgressResultType Collection { get; } = new MongoDBProgressResultType(CollectionValue);
        /// <summary> Determines if two <see cref="MongoDBProgressResultType"/> values are the same. </summary>
        public static bool operator ==(MongoDBProgressResultType left, MongoDBProgressResultType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MongoDBProgressResultType"/> values are not the same. </summary>
        public static bool operator !=(MongoDBProgressResultType left, MongoDBProgressResultType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MongoDBProgressResultType"/>. </summary>
        public static implicit operator MongoDBProgressResultType(string value) => new MongoDBProgressResultType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MongoDBProgressResultType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MongoDBProgressResultType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
