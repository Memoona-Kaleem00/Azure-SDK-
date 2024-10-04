// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DeveloperHub.Models
{
    /// <summary> Describes the status of the workflow run. </summary>
    public readonly partial struct WorkflowRunStatus : IEquatable<WorkflowRunStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WorkflowRunStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WorkflowRunStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QueuedValue = "queued";
        private const string InprogressValue = "inprogress";
        private const string CompletedValue = "completed";

        /// <summary> Workflow run is queued. </summary>
        public static WorkflowRunStatus Queued { get; } = new WorkflowRunStatus(QueuedValue);
        /// <summary> Workflow run is inprogress. </summary>
        public static WorkflowRunStatus Inprogress { get; } = new WorkflowRunStatus(InprogressValue);
        /// <summary> Workflow run is completed. </summary>
        public static WorkflowRunStatus Completed { get; } = new WorkflowRunStatus(CompletedValue);
        /// <summary> Determines if two <see cref="WorkflowRunStatus"/> values are the same. </summary>
        public static bool operator ==(WorkflowRunStatus left, WorkflowRunStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WorkflowRunStatus"/> values are not the same. </summary>
        public static bool operator !=(WorkflowRunStatus left, WorkflowRunStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WorkflowRunStatus"/>. </summary>
        public static implicit operator WorkflowRunStatus(string value) => new WorkflowRunStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WorkflowRunStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WorkflowRunStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
