// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Trusted access role definition. </summary>
    public partial class ContainerServiceTrustedAccessRole
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

        /// <summary> Initializes a new instance of <see cref="ContainerServiceTrustedAccessRole"/>. </summary>
        internal ContainerServiceTrustedAccessRole()
        {
            Rules = new ChangeTrackingList<ContainerServiceTrustedAccessRoleRule>();
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceTrustedAccessRole"/>. </summary>
        /// <param name="sourceResourceType"> Resource type of Azure resource. </param>
        /// <param name="name"> Name of role, name is unique under a source resource type. </param>
        /// <param name="rules"> List of rules for the role. This maps to 'rules' property of [Kubernetes Cluster Role](https://kubernetes.io/docs/reference/kubernetes-api/authorization-resources/cluster-role-v1/#ClusterRole). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceTrustedAccessRole(string sourceResourceType, string name, IReadOnlyList<ContainerServiceTrustedAccessRoleRule> rules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceResourceType = sourceResourceType;
            Name = name;
            Rules = rules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource type of Azure resource. </summary>
        [WirePath("sourceResourceType")]
        public string SourceResourceType { get; }
        /// <summary> Name of role, name is unique under a source resource type. </summary>
        [WirePath("name")]
        public string Name { get; }
        /// <summary> List of rules for the role. This maps to 'rules' property of [Kubernetes Cluster Role](https://kubernetes.io/docs/reference/kubernetes-api/authorization-resources/cluster-role-v1/#ClusterRole). </summary>
        [WirePath("rules")]
        public IReadOnlyList<ContainerServiceTrustedAccessRoleRule> Rules { get; }
    }
}
