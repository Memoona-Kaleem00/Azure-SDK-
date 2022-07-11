// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// SCM type.
    /// Serialized Name: ScmType
    /// </summary>
    public readonly partial struct ScmType : IEquatable<ScmType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ScmType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ScmType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string DropboxValue = "Dropbox";
        private const string TfsValue = "Tfs";
        private const string LocalGitValue = "LocalGit";
        private const string GitHubValue = "GitHub";
        private const string CodePlexGitValue = "CodePlexGit";
        private const string CodePlexHgValue = "CodePlexHg";
        private const string BitbucketGitValue = "BitbucketGit";
        private const string BitbucketHgValue = "BitbucketHg";
        private const string ExternalGitValue = "ExternalGit";
        private const string ExternalHgValue = "ExternalHg";
        private const string OneDriveValue = "OneDrive";
        private const string VSOValue = "VSO";
        private const string VstsrmValue = "VSTSRM";

        /// <summary>
        /// None
        /// Serialized Name: ScmType.None
        /// </summary>
        public static ScmType None { get; } = new ScmType(NoneValue);
        /// <summary>
        /// Dropbox
        /// Serialized Name: ScmType.Dropbox
        /// </summary>
        public static ScmType Dropbox { get; } = new ScmType(DropboxValue);
        /// <summary>
        /// Tfs
        /// Serialized Name: ScmType.Tfs
        /// </summary>
        public static ScmType Tfs { get; } = new ScmType(TfsValue);
        /// <summary>
        /// LocalGit
        /// Serialized Name: ScmType.LocalGit
        /// </summary>
        public static ScmType LocalGit { get; } = new ScmType(LocalGitValue);
        /// <summary>
        /// GitHub
        /// Serialized Name: ScmType.GitHub
        /// </summary>
        public static ScmType GitHub { get; } = new ScmType(GitHubValue);
        /// <summary>
        /// CodePlexGit
        /// Serialized Name: ScmType.CodePlexGit
        /// </summary>
        public static ScmType CodePlexGit { get; } = new ScmType(CodePlexGitValue);
        /// <summary>
        /// CodePlexHg
        /// Serialized Name: ScmType.CodePlexHg
        /// </summary>
        public static ScmType CodePlexHg { get; } = new ScmType(CodePlexHgValue);
        /// <summary>
        /// BitbucketGit
        /// Serialized Name: ScmType.BitbucketGit
        /// </summary>
        public static ScmType BitbucketGit { get; } = new ScmType(BitbucketGitValue);
        /// <summary>
        /// BitbucketHg
        /// Serialized Name: ScmType.BitbucketHg
        /// </summary>
        public static ScmType BitbucketHg { get; } = new ScmType(BitbucketHgValue);
        /// <summary>
        /// ExternalGit
        /// Serialized Name: ScmType.ExternalGit
        /// </summary>
        public static ScmType ExternalGit { get; } = new ScmType(ExternalGitValue);
        /// <summary>
        /// ExternalHg
        /// Serialized Name: ScmType.ExternalHg
        /// </summary>
        public static ScmType ExternalHg { get; } = new ScmType(ExternalHgValue);
        /// <summary>
        /// OneDrive
        /// Serialized Name: ScmType.OneDrive
        /// </summary>
        public static ScmType OneDrive { get; } = new ScmType(OneDriveValue);
        /// <summary>
        /// VSO
        /// Serialized Name: ScmType.VSO
        /// </summary>
        public static ScmType VSO { get; } = new ScmType(VSOValue);
        /// <summary>
        /// VSTSRM
        /// Serialized Name: ScmType.VSTSRM
        /// </summary>
        public static ScmType Vstsrm { get; } = new ScmType(VstsrmValue);
        /// <summary> Determines if two <see cref="ScmType"/> values are the same. </summary>
        public static bool operator ==(ScmType left, ScmType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ScmType"/> values are not the same. </summary>
        public static bool operator !=(ScmType left, ScmType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ScmType"/>. </summary>
        public static implicit operator ScmType(string value) => new ScmType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ScmType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ScmType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
