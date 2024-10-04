// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Translation.Document
{
    /// <summary> The Status. </summary>
    public readonly partial struct DocumentTranslationStatus : IEquatable<DocumentTranslationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentTranslationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentTranslationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "NotStarted";
        private const string RunningValue = "Running";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Cancelled";
        private const string CancelingValue = "Cancelling";
        private const string ValidationFailedValue = "ValidationFailed";

        /// <summary> NotStarted. </summary>
        public static DocumentTranslationStatus NotStarted { get; } = new DocumentTranslationStatus(NotStartedValue);
        /// <summary> Running. </summary>
        public static DocumentTranslationStatus Running { get; } = new DocumentTranslationStatus(RunningValue);
        /// <summary> Succeeded. </summary>
        public static DocumentTranslationStatus Succeeded { get; } = new DocumentTranslationStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static DocumentTranslationStatus Failed { get; } = new DocumentTranslationStatus(FailedValue);
        /// <summary> ValidationFailed. </summary>
        public static DocumentTranslationStatus ValidationFailed { get; } = new DocumentTranslationStatus(ValidationFailedValue);
        /// <summary> Determines if two <see cref="DocumentTranslationStatus"/> values are the same. </summary>
        public static bool operator ==(DocumentTranslationStatus left, DocumentTranslationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentTranslationStatus"/> values are not the same. </summary>
        public static bool operator !=(DocumentTranslationStatus left, DocumentTranslationStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DocumentTranslationStatus"/>. </summary>
        public static implicit operator DocumentTranslationStatus(string value) => new DocumentTranslationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentTranslationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentTranslationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
