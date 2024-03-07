// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> The type of Elasticsearch® retrieval query that should be executed when using it as an Azure OpenAI chat extension. </summary>
    public readonly partial struct ElasticsearchQueryType : IEquatable<ElasticsearchQueryType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ElasticsearchQueryType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ElasticsearchQueryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SimpleValue = "simple";
        private const string VectorValue = "vector";

        /// <summary> Represents the default, simple query parser. </summary>
        public static ElasticsearchQueryType Simple { get; } = new ElasticsearchQueryType(SimpleValue);
        /// <summary> Represents vector search over computed data. </summary>
        public static ElasticsearchQueryType Vector { get; } = new ElasticsearchQueryType(VectorValue);
        /// <summary> Determines if two <see cref="ElasticsearchQueryType"/> values are the same. </summary>
        public static bool operator ==(ElasticsearchQueryType left, ElasticsearchQueryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ElasticsearchQueryType"/> values are not the same. </summary>
        public static bool operator !=(ElasticsearchQueryType left, ElasticsearchQueryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ElasticsearchQueryType"/>. </summary>
        public static implicit operator ElasticsearchQueryType(string value) => new ElasticsearchQueryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ElasticsearchQueryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ElasticsearchQueryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
