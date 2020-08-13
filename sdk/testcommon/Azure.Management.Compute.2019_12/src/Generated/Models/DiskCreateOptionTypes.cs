// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Compute.Models
{
    /// <summary> Specifies how the virtual machine should be created.&lt;br&gt;&lt;br&gt; Possible values are:&lt;br&gt;&lt;br&gt; **Attach** \u2013 This value is used when you are using a specialized disk to create the virtual machine.&lt;br&gt;&lt;br&gt; **FromImage** \u2013 This value is used when you are using an image to create the virtual machine. If you are using a platform image, you also use the imageReference element described above. If you are using a marketplace image, you  also use the plan element previously described. </summary>
    public readonly partial struct DiskCreateOptionTypes : IEquatable<DiskCreateOptionTypes>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="DiskCreateOptionTypes"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DiskCreateOptionTypes(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FromImageValue = "FromImage";
        private const string EmptyValue = "Empty";
        private const string AttachValue = "Attach";

        /// <summary> FromImage. </summary>
        public static DiskCreateOptionTypes FromImage { get; } = new DiskCreateOptionTypes(FromImageValue);
        /// <summary> Empty. </summary>
        public static DiskCreateOptionTypes Empty { get; } = new DiskCreateOptionTypes(EmptyValue);
        /// <summary> Attach. </summary>
        public static DiskCreateOptionTypes Attach { get; } = new DiskCreateOptionTypes(AttachValue);
        /// <summary> Determines if two <see cref="DiskCreateOptionTypes"/> values are the same. </summary>
        public static bool operator ==(DiskCreateOptionTypes left, DiskCreateOptionTypes right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DiskCreateOptionTypes"/> values are not the same. </summary>
        public static bool operator !=(DiskCreateOptionTypes left, DiskCreateOptionTypes right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DiskCreateOptionTypes"/>. </summary>
        public static implicit operator DiskCreateOptionTypes(string value) => new DiskCreateOptionTypes(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DiskCreateOptionTypes other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DiskCreateOptionTypes other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
