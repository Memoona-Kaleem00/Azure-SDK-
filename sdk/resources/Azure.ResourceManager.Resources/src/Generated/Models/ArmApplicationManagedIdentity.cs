// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Identity for the resource. </summary>
    public partial class ArmApplicationManagedIdentity
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

        /// <summary> Initializes a new instance of <see cref="ArmApplicationManagedIdentity"/>. </summary>
        public ArmApplicationManagedIdentity()
        {
            UserAssignedIdentities = new ChangeTrackingDictionary<string, ArmApplicationUserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of <see cref="ArmApplicationManagedIdentity"/>. </summary>
        /// <param name="principalId"> The principal ID of resource identity. </param>
        /// <param name="tenantId"> The tenant ID of resource. </param>
        /// <param name="identityType"> The identity type. </param>
        /// <param name="userAssignedIdentities"> The list of user identities associated with the resource. The user identity dictionary key references will be resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmApplicationManagedIdentity(Guid? principalId, Guid? tenantId, ArmApplicationManagedIdentityType? identityType, IDictionary<string, ArmApplicationUserAssignedIdentity> userAssignedIdentities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            IdentityType = identityType;
            UserAssignedIdentities = userAssignedIdentities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The principal ID of resource identity. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The tenant ID of resource. </summary>
        public Guid? TenantId { get; }
        /// <summary> The identity type. </summary>
        public ArmApplicationManagedIdentityType? IdentityType { get; set; }
        /// <summary> The list of user identities associated with the resource. The user identity dictionary key references will be resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'. </summary>
        public IDictionary<string, ArmApplicationUserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
