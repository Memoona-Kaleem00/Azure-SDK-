// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> A string indicating what maskingMode to use to mask the personal information detected in the input text. </summary>
    public readonly partial struct PIIDetectionSkillMaskingMode : IEquatable<PIIDetectionSkillMaskingMode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PIIDetectionSkillMaskingMode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PIIDetectionSkillMaskingMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string ReplaceValue = "replace";

        /// <summary> No masking occurs and the maskedText output will not be returned. </summary>
        public static PIIDetectionSkillMaskingMode None { get; } = new PIIDetectionSkillMaskingMode(NoneValue);
        /// <summary> Replaces the detected entities with the character given in the maskingCharacter parameter. The character will be repeated to the length of the detected entity so that the offsets will correctly correspond to both the input text as well as the output maskedText. </summary>
        public static PIIDetectionSkillMaskingMode Replace { get; } = new PIIDetectionSkillMaskingMode(ReplaceValue);
        /// <summary> Determines if two <see cref="PIIDetectionSkillMaskingMode"/> values are the same. </summary>
        public static bool operator ==(PIIDetectionSkillMaskingMode left, PIIDetectionSkillMaskingMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PIIDetectionSkillMaskingMode"/> values are not the same. </summary>
        public static bool operator !=(PIIDetectionSkillMaskingMode left, PIIDetectionSkillMaskingMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PIIDetectionSkillMaskingMode"/>. </summary>
        public static implicit operator PIIDetectionSkillMaskingMode(string value) => new PIIDetectionSkillMaskingMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PIIDetectionSkillMaskingMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PIIDetectionSkillMaskingMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
