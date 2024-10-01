// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The batch state. </summary>
    public readonly partial struct LivyStates : IEquatable<LivyStates>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LivyStates"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LivyStates(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NotStartedValue = "not_started";
        private const string StartingValue = "starting";
        private const string IdleValue = "idle";
        private const string BusyValue = "busy";
        private const string ShuttingDownValue = "shutting_down";
        private const string ErrorValue = "error";
        private const string DeadValue = "dead";
        private const string KilledValue = "killed";
        private const string SuccessValue = "success";
        private const string RunningValue = "running";
        private const string RecoveringValue = "recovering";

        /// <summary> not_started. </summary>
        public static LivyStates NotStarted { get; } = new LivyStates(NotStartedValue);
        /// <summary> starting. </summary>
        public static LivyStates Starting { get; } = new LivyStates(StartingValue);
        /// <summary> idle. </summary>
        public static LivyStates Idle { get; } = new LivyStates(IdleValue);
        /// <summary> busy. </summary>
        public static LivyStates Busy { get; } = new LivyStates(BusyValue);
        /// <summary> shutting_down. </summary>
        public static LivyStates ShuttingDown { get; } = new LivyStates(ShuttingDownValue);
        /// <summary> error. </summary>
        public static LivyStates Error { get; } = new LivyStates(ErrorValue);
        /// <summary> dead. </summary>
        public static LivyStates Dead { get; } = new LivyStates(DeadValue);
        /// <summary> killed. </summary>
        public static LivyStates Killed { get; } = new LivyStates(KilledValue);
        /// <summary> success. </summary>
        public static LivyStates Success { get; } = new LivyStates(SuccessValue);
        /// <summary> running. </summary>
        public static LivyStates Running { get; } = new LivyStates(RunningValue);
        /// <summary> recovering. </summary>
        public static LivyStates Recovering { get; } = new LivyStates(RecoveringValue);
        /// <summary> Determines if two <see cref="LivyStates"/> values are the same. </summary>
        public static bool operator ==(LivyStates left, LivyStates right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LivyStates"/> values are not the same. </summary>
        public static bool operator !=(LivyStates left, LivyStates right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="LivyStates"/>. </summary>
        public static implicit operator LivyStates(string value) => new LivyStates(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LivyStates other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LivyStates other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
