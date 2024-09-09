// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The intent of the alert. </summary>
    public readonly partial struct SecurityInsightsKillChainIntent : IEquatable<SecurityInsightsKillChainIntent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsKillChainIntent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsKillChainIntent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string ProbingValue = "Probing";
        private const string ExploitationValue = "Exploitation";
        private const string PersistenceValue = "Persistence";
        private const string PrivilegeEscalationValue = "PrivilegeEscalation";
        private const string DefenseEvasionValue = "DefenseEvasion";
        private const string CredentialAccessValue = "CredentialAccess";
        private const string DiscoveryValue = "Discovery";
        private const string LateralMovementValue = "LateralMovement";
        private const string ExecutionValue = "Execution";
        private const string CollectionValue = "Collection";
        private const string ExfiltrationValue = "Exfiltration";
        private const string CommandAndControlValue = "CommandAndControl";
        private const string ImpactValue = "Impact";

        /// <summary> The default value. </summary>
        public static SecurityInsightsKillChainIntent Unknown { get; } = new SecurityInsightsKillChainIntent(UnknownValue);
        /// <summary> Probing could be an attempt to access a certain resource regardless of a malicious intent or a failed attempt to gain access to a target system to gather information prior to exploitation. This step is usually detected as an attempt originating from outside the network in attempt to scan the target system and find a way in. </summary>
        public static SecurityInsightsKillChainIntent Probing { get; } = new SecurityInsightsKillChainIntent(ProbingValue);
        /// <summary> Exploitation is the stage where an attacker manage to get foothold on the attacked resource. This stage is applicable not only for compute hosts, but also for resources such as user accounts, certificates etc. Adversaries will often be able to control the resource after this stage. </summary>
        public static SecurityInsightsKillChainIntent Exploitation { get; } = new SecurityInsightsKillChainIntent(ExploitationValue);
        /// <summary> Persistence is any access, action, or configuration change to a system that gives an adversary a persistent presence on that system. Adversaries will often need to maintain access to systems through interruptions such as system restarts, loss of credentials, or other failures that would require a remote access tool to restart or alternate backdoor for them to regain access. </summary>
        public static SecurityInsightsKillChainIntent Persistence { get; } = new SecurityInsightsKillChainIntent(PersistenceValue);
        /// <summary> Privilege escalation is the result of actions that allow an adversary to obtain a higher level of permissions on a system or network. Certain tools or actions require a higher level of privilege to work and are likely necessary at many points throughout an operation. User accounts with permissions to access specific systems or perform specific functions necessary for adversaries to achieve their objective may also be considered an escalation of privilege. </summary>
        public static SecurityInsightsKillChainIntent PrivilegeEscalation { get; } = new SecurityInsightsKillChainIntent(PrivilegeEscalationValue);
        /// <summary> Defense evasion consists of techniques an adversary may use to evade detection or avoid other defenses. Sometimes these actions are the same as or variations of techniques in other categories that have the added benefit of subverting a particular defense or mitigation. </summary>
        public static SecurityInsightsKillChainIntent DefenseEvasion { get; } = new SecurityInsightsKillChainIntent(DefenseEvasionValue);
        /// <summary> Credential access represents techniques resulting in access to or control over system, domain, or service credentials that are used within an enterprise environment. Adversaries will likely attempt to obtain legitimate credentials from users or administrator accounts (local system administrator or domain users with administrator access) to use within the network. With sufficient access within a network, an adversary can create accounts for later use within the environment. </summary>
        public static SecurityInsightsKillChainIntent CredentialAccess { get; } = new SecurityInsightsKillChainIntent(CredentialAccessValue);
        /// <summary> Discovery consists of techniques that allow the adversary to gain knowledge about the system and internal network. When adversaries gain access to a new system, they must navigate themselves to what they now have control of and what benefits operating from that system give to their current objective or overall goals during the intrusion. The operating system provides many native tools that aid in this post-compromise information-gathering phase. </summary>
        public static SecurityInsightsKillChainIntent Discovery { get; } = new SecurityInsightsKillChainIntent(DiscoveryValue);
        /// <summary> Lateral movement consists of techniques that enable an adversary to access and control remote systems on a network and could, but does not necessarily, include execution of tools on remote systems. The lateral movement techniques could allow an adversary to gather information from a system without needing additional tools, such as a remote access tool. An adversary can use lateral movement for many purposes, including remote Execution of tools, pivoting to additional systems, access to specific information or files, access to additional credentials, or to cause an effect. </summary>
        public static SecurityInsightsKillChainIntent LateralMovement { get; } = new SecurityInsightsKillChainIntent(LateralMovementValue);
        /// <summary> The execution tactic represents techniques that result in execution of adversary-controlled code on a local or remote system. This tactic is often used in conjunction with lateral movement to expand access to remote systems on a network. </summary>
        public static SecurityInsightsKillChainIntent Execution { get; } = new SecurityInsightsKillChainIntent(ExecutionValue);
        /// <summary> Collection consists of techniques used to identify and gather information, such as sensitive files, from a target network prior to exfiltration. This category also covers locations on a system or network where the adversary may look for information to exfiltrate. </summary>
        public static SecurityInsightsKillChainIntent Collection { get; } = new SecurityInsightsKillChainIntent(CollectionValue);
        /// <summary> Exfiltration refers to techniques and attributes that result or aid in the adversary removing files and information from a target network. This category also covers locations on a system or network where the adversary may look for information to exfiltrate. </summary>
        public static SecurityInsightsKillChainIntent Exfiltration { get; } = new SecurityInsightsKillChainIntent(ExfiltrationValue);
        /// <summary> The command and control tactic represents how adversaries communicate with systems under their control within a target network. </summary>
        public static SecurityInsightsKillChainIntent CommandAndControl { get; } = new SecurityInsightsKillChainIntent(CommandAndControlValue);
        /// <summary> The impact intent primary objective is to directly reduce the availability or integrity of a system, service, or network; including manipulation of data to impact a business or operational process. This would often refer to techniques such as ransom-ware, defacement, data manipulation and others. </summary>
        public static SecurityInsightsKillChainIntent Impact { get; } = new SecurityInsightsKillChainIntent(ImpactValue);
        /// <summary> Determines if two <see cref="SecurityInsightsKillChainIntent"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsKillChainIntent left, SecurityInsightsKillChainIntent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsKillChainIntent"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsKillChainIntent left, SecurityInsightsKillChainIntent right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityInsightsKillChainIntent"/>. </summary>
        public static implicit operator SecurityInsightsKillChainIntent(string value) => new SecurityInsightsKillChainIntent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsKillChainIntent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsKillChainIntent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
