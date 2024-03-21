// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Application gateway web application firewall configuration. </summary>
    public partial class ApplicationGatewayWebApplicationFirewallConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayWebApplicationFirewallConfiguration"/>. </summary>
        /// <param name="enabled"> Whether the web application firewall is enabled or not. </param>
        /// <param name="firewallMode"> Web application firewall mode. </param>
        /// <param name="ruleSetType"> The type of the web application firewall rule set. Possible values are: 'OWASP'. </param>
        /// <param name="ruleSetVersion"> The version of the rule set type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleSetType"/> or <paramref name="ruleSetVersion"/> is null. </exception>
        public ApplicationGatewayWebApplicationFirewallConfiguration(bool enabled, ApplicationGatewayFirewallMode firewallMode, string ruleSetType, string ruleSetVersion)
        {
            Argument.AssertNotNull(ruleSetType, nameof(ruleSetType));
            Argument.AssertNotNull(ruleSetVersion, nameof(ruleSetVersion));

            Enabled = enabled;
            FirewallMode = firewallMode;
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            DisabledRuleGroups = new ChangeTrackingList<ApplicationGatewayFirewallDisabledRuleGroup>();
            Exclusions = new ChangeTrackingList<ApplicationGatewayFirewallExclusion>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayWebApplicationFirewallConfiguration"/>. </summary>
        /// <param name="enabled"> Whether the web application firewall is enabled or not. </param>
        /// <param name="firewallMode"> Web application firewall mode. </param>
        /// <param name="ruleSetType"> The type of the web application firewall rule set. Possible values are: 'OWASP'. </param>
        /// <param name="ruleSetVersion"> The version of the rule set type. </param>
        /// <param name="disabledRuleGroups"> The disabled rule groups. </param>
        /// <param name="requestBodyCheck"> Whether allow WAF to check request Body. </param>
        /// <param name="maxRequestBodySize"> Maximum request body size for WAF. </param>
        /// <param name="maxRequestBodySizeInKb"> Maximum request body size in Kb for WAF. </param>
        /// <param name="fileUploadLimitInMb"> Maximum file upload size in Mb for WAF. </param>
        /// <param name="exclusions"> The exclusion list. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationGatewayWebApplicationFirewallConfiguration(bool enabled, ApplicationGatewayFirewallMode firewallMode, string ruleSetType, string ruleSetVersion, IList<ApplicationGatewayFirewallDisabledRuleGroup> disabledRuleGroups, bool? requestBodyCheck, int? maxRequestBodySize, int? maxRequestBodySizeInKb, int? fileUploadLimitInMb, IList<ApplicationGatewayFirewallExclusion> exclusions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Enabled = enabled;
            FirewallMode = firewallMode;
            RuleSetType = ruleSetType;
            RuleSetVersion = ruleSetVersion;
            DisabledRuleGroups = disabledRuleGroups;
            RequestBodyCheck = requestBodyCheck;
            MaxRequestBodySize = maxRequestBodySize;
            MaxRequestBodySizeInKb = maxRequestBodySizeInKb;
            FileUploadLimitInMb = fileUploadLimitInMb;
            Exclusions = exclusions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationGatewayWebApplicationFirewallConfiguration"/> for deserialization. </summary>
        internal ApplicationGatewayWebApplicationFirewallConfiguration()
        {
        }

        /// <summary> Whether the web application firewall is enabled or not. </summary>
        public bool Enabled { get; set; }
        /// <summary> Web application firewall mode. </summary>
        public ApplicationGatewayFirewallMode FirewallMode { get; set; }
        /// <summary> The type of the web application firewall rule set. Possible values are: 'OWASP'. </summary>
        public string RuleSetType { get; set; }
        /// <summary> The version of the rule set type. </summary>
        public string RuleSetVersion { get; set; }
        /// <summary> The disabled rule groups. </summary>
        public IList<ApplicationGatewayFirewallDisabledRuleGroup> DisabledRuleGroups { get; }
        /// <summary> Whether allow WAF to check request Body. </summary>
        public bool? RequestBodyCheck { get; set; }
        /// <summary> Maximum request body size for WAF. </summary>
        public int? MaxRequestBodySize { get; set; }
        /// <summary> Maximum request body size in Kb for WAF. </summary>
        public int? MaxRequestBodySizeInKb { get; set; }
        /// <summary> Maximum file upload size in Mb for WAF. </summary>
        public int? FileUploadLimitInMb { get; set; }
        /// <summary> The exclusion list. </summary>
        public IList<ApplicationGatewayFirewallExclusion> Exclusions { get; }
    }
}
