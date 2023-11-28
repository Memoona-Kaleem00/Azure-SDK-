// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Blueprint;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Blueprint artifact that applies a Role assignment. </summary>
    public partial class RoleAssignmentArtifact : ArtifactData
    {
        /// <summary> Initializes a new instance of <see cref="RoleAssignmentArtifact"/>. </summary>
        /// <param name="roleDefinitionId"> Azure resource ID of the RoleDefinition. </param>
        /// <param name="principalIds"> Array of user or group identities in Azure Active Directory. The roleDefinition will apply to each identity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="roleDefinitionId"/> or <paramref name="principalIds"/> is null. </exception>
        public RoleAssignmentArtifact(string roleDefinitionId, BinaryData principalIds)
        {
            Argument.AssertNotNull(roleDefinitionId, nameof(roleDefinitionId));
            Argument.AssertNotNull(principalIds, nameof(principalIds));

            DependsOn = new ChangeTrackingList<string>();
            RoleDefinitionId = roleDefinitionId;
            PrincipalIds = principalIds;
            Kind = ArtifactKind.RoleAssignment;
        }

        /// <summary> Initializes a new instance of <see cref="RoleAssignmentArtifact"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Specifies the kind of blueprint artifact. </param>
        /// <param name="displayName"> One-liner string explain this resource. </param>
        /// <param name="description"> Multi-line explain this resource. </param>
        /// <param name="dependsOn"> Artifacts which need to be deployed before the specified artifact. </param>
        /// <param name="roleDefinitionId"> Azure resource ID of the RoleDefinition. </param>
        /// <param name="principalIds"> Array of user or group identities in Azure Active Directory. The roleDefinition will apply to each identity. </param>
        /// <param name="resourceGroup"> RoleAssignment will be scope to this resourceGroup. If empty, it scopes to the subscription. </param>
        internal RoleAssignmentArtifact(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ArtifactKind kind, string displayName, string description, IList<string> dependsOn, string roleDefinitionId, BinaryData principalIds, string resourceGroup) : base(id, name, resourceType, systemData, kind)
        {
            DisplayName = displayName;
            Description = description;
            DependsOn = dependsOn;
            RoleDefinitionId = roleDefinitionId;
            PrincipalIds = principalIds;
            ResourceGroup = resourceGroup;
            Kind = kind;
        }

        /// <summary> One-liner string explain this resource. </summary>
        public string DisplayName { get; set; }
        /// <summary> Multi-line explain this resource. </summary>
        public string Description { get; set; }
        /// <summary> Artifacts which need to be deployed before the specified artifact. </summary>
        public IList<string> DependsOn { get; }
        /// <summary> Azure resource ID of the RoleDefinition. </summary>
        public string RoleDefinitionId { get; set; }
        /// <summary>
        /// Array of user or group identities in Azure Active Directory. The roleDefinition will apply to each identity.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData PrincipalIds { get; set; }
        /// <summary> RoleAssignment will be scope to this resourceGroup. If empty, it scopes to the subscription. </summary>
        public string ResourceGroup { get; set; }
    }
}
