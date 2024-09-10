// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Group based on connection category. </summary>
    public readonly partial struct WorkspaceConnectionGroup : IEquatable<WorkspaceConnectionGroup>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WorkspaceConnectionGroup"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WorkspaceConnectionGroup(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AzureValue = "Azure";
        private const string AzureAIValue = "AzureAI";
        private const string DatabaseValue = "Database";
        private const string NoSQLValue = "NoSQL";
        private const string FileValue = "File";
        private const string GenericProtocolValue = "GenericProtocol";
        private const string ServicesAndAppsValue = "ServicesAndApps";

        /// <summary> Azure. </summary>
        public static WorkspaceConnectionGroup Azure { get; } = new WorkspaceConnectionGroup(AzureValue);
        /// <summary> AzureAI. </summary>
        public static WorkspaceConnectionGroup AzureAI { get; } = new WorkspaceConnectionGroup(AzureAIValue);
        /// <summary> Database. </summary>
        public static WorkspaceConnectionGroup Database { get; } = new WorkspaceConnectionGroup(DatabaseValue);
        /// <summary> NoSQL. </summary>
        public static WorkspaceConnectionGroup NoSQL { get; } = new WorkspaceConnectionGroup(NoSQLValue);
        /// <summary> File. </summary>
        public static WorkspaceConnectionGroup File { get; } = new WorkspaceConnectionGroup(FileValue);
        /// <summary> GenericProtocol. </summary>
        public static WorkspaceConnectionGroup GenericProtocol { get; } = new WorkspaceConnectionGroup(GenericProtocolValue);
        /// <summary> ServicesAndApps. </summary>
        public static WorkspaceConnectionGroup ServicesAndApps { get; } = new WorkspaceConnectionGroup(ServicesAndAppsValue);
        /// <summary> Determines if two <see cref="WorkspaceConnectionGroup"/> values are the same. </summary>
        public static bool operator ==(WorkspaceConnectionGroup left, WorkspaceConnectionGroup right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WorkspaceConnectionGroup"/> values are not the same. </summary>
        public static bool operator !=(WorkspaceConnectionGroup left, WorkspaceConnectionGroup right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WorkspaceConnectionGroup"/>. </summary>
        public static implicit operator WorkspaceConnectionGroup(string value) => new WorkspaceConnectionGroup(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WorkspaceConnectionGroup other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WorkspaceConnectionGroup other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
