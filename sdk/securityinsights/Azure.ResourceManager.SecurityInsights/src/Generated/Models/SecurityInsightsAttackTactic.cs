// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The severity for alerts created by this alert rule. </summary>
    public readonly partial struct SecurityInsightsAttackTactic : IEquatable<SecurityInsightsAttackTactic>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAttackTactic"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsAttackTactic(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReconnaissanceValue = "Reconnaissance";
        private const string ResourceDevelopmentValue = "ResourceDevelopment";
        private const string InitialAccessValue = "InitialAccess";
        private const string ExecutionValue = "Execution";
        private const string PersistenceValue = "Persistence";
        private const string PrivilegeEscalationValue = "PrivilegeEscalation";
        private const string DefenseEvasionValue = "DefenseEvasion";
        private const string CredentialAccessValue = "CredentialAccess";
        private const string DiscoveryValue = "Discovery";
        private const string LateralMovementValue = "LateralMovement";
        private const string CollectionValue = "Collection";
        private const string ExfiltrationValue = "Exfiltration";
        private const string CommandAndControlValue = "CommandAndControl";
        private const string ImpactValue = "Impact";
        private const string PreAttackValue = "PreAttack";
        private const string ImpairProcessControlValue = "ImpairProcessControl";
        private const string InhibitResponseFunctionValue = "InhibitResponseFunction";

        /// <summary> Reconnaissance. </summary>
        public static SecurityInsightsAttackTactic Reconnaissance { get; } = new SecurityInsightsAttackTactic(ReconnaissanceValue);
        /// <summary> ResourceDevelopment. </summary>
        public static SecurityInsightsAttackTactic ResourceDevelopment { get; } = new SecurityInsightsAttackTactic(ResourceDevelopmentValue);
        /// <summary> InitialAccess. </summary>
        public static SecurityInsightsAttackTactic InitialAccess { get; } = new SecurityInsightsAttackTactic(InitialAccessValue);
        /// <summary> Execution. </summary>
        public static SecurityInsightsAttackTactic Execution { get; } = new SecurityInsightsAttackTactic(ExecutionValue);
        /// <summary> Persistence. </summary>
        public static SecurityInsightsAttackTactic Persistence { get; } = new SecurityInsightsAttackTactic(PersistenceValue);
        /// <summary> PrivilegeEscalation. </summary>
        public static SecurityInsightsAttackTactic PrivilegeEscalation { get; } = new SecurityInsightsAttackTactic(PrivilegeEscalationValue);
        /// <summary> DefenseEvasion. </summary>
        public static SecurityInsightsAttackTactic DefenseEvasion { get; } = new SecurityInsightsAttackTactic(DefenseEvasionValue);
        /// <summary> CredentialAccess. </summary>
        public static SecurityInsightsAttackTactic CredentialAccess { get; } = new SecurityInsightsAttackTactic(CredentialAccessValue);
        /// <summary> Discovery. </summary>
        public static SecurityInsightsAttackTactic Discovery { get; } = new SecurityInsightsAttackTactic(DiscoveryValue);
        /// <summary> LateralMovement. </summary>
        public static SecurityInsightsAttackTactic LateralMovement { get; } = new SecurityInsightsAttackTactic(LateralMovementValue);
        /// <summary> Collection. </summary>
        public static SecurityInsightsAttackTactic Collection { get; } = new SecurityInsightsAttackTactic(CollectionValue);
        /// <summary> Exfiltration. </summary>
        public static SecurityInsightsAttackTactic Exfiltration { get; } = new SecurityInsightsAttackTactic(ExfiltrationValue);
        /// <summary> CommandAndControl. </summary>
        public static SecurityInsightsAttackTactic CommandAndControl { get; } = new SecurityInsightsAttackTactic(CommandAndControlValue);
        /// <summary> Impact. </summary>
        public static SecurityInsightsAttackTactic Impact { get; } = new SecurityInsightsAttackTactic(ImpactValue);
        /// <summary> PreAttack. </summary>
        public static SecurityInsightsAttackTactic PreAttack { get; } = new SecurityInsightsAttackTactic(PreAttackValue);
        /// <summary> ImpairProcessControl. </summary>
        public static SecurityInsightsAttackTactic ImpairProcessControl { get; } = new SecurityInsightsAttackTactic(ImpairProcessControlValue);
        /// <summary> InhibitResponseFunction. </summary>
        public static SecurityInsightsAttackTactic InhibitResponseFunction { get; } = new SecurityInsightsAttackTactic(InhibitResponseFunctionValue);
        /// <summary> Determines if two <see cref="SecurityInsightsAttackTactic"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsAttackTactic left, SecurityInsightsAttackTactic right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsAttackTactic"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsAttackTactic left, SecurityInsightsAttackTactic right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsAttackTactic"/>. </summary>
        public static implicit operator SecurityInsightsAttackTactic(string value) => new SecurityInsightsAttackTactic(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsAttackTactic other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsAttackTactic other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
