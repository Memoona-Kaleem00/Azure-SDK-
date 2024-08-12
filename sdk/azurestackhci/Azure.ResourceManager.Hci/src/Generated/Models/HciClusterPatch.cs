// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Cluster details to update. </summary>
    public partial class HciClusterPatch
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

        /// <summary> Initializes a new instance of <see cref="HciClusterPatch"/>. </summary>
        public HciClusterPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            UserAssignedIdentities = new ChangeTrackingDictionary<string, UserAssignedIdentity>();
        }

        /// <summary> Initializes a new instance of <see cref="HciClusterPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cloudManagementEndpoint"> Endpoint configured for management from the Azure portal. </param>
        /// <param name="aadClientId"> App id of cluster AAD identity. </param>
        /// <param name="aadTenantId"> Tenant id of cluster AAD identity. </param>
        /// <param name="desiredProperties"> Desired properties of the cluster. </param>
        /// <param name="principalId"> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="tenantId"> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="managedServiceIdentityType"> Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed). </param>
        /// <param name="userAssignedIdentities"> The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HciClusterPatch(IDictionary<string, string> tags, string cloudManagementEndpoint, Guid? aadClientId, Guid? aadTenantId, HciClusterDesiredProperties desiredProperties, Guid? principalId, Guid? tenantId, HciManagedServiceIdentityType? managedServiceIdentityType, IDictionary<string, UserAssignedIdentity> userAssignedIdentities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            CloudManagementEndpoint = cloudManagementEndpoint;
            AadClientId = aadClientId;
            AadTenantId = aadTenantId;
            DesiredProperties = desiredProperties;
            PrincipalId = principalId;
            TenantId = tenantId;
            ManagedServiceIdentityType = managedServiceIdentityType;
            UserAssignedIdentities = userAssignedIdentities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource tags. </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; }
        /// <summary> Endpoint configured for management from the Azure portal. </summary>
        [WirePath("properties.cloudManagementEndpoint")]
        public string CloudManagementEndpoint { get; set; }
        /// <summary> App id of cluster AAD identity. </summary>
        [WirePath("properties.aadClientId")]
        public Guid? AadClientId { get; set; }
        /// <summary> Tenant id of cluster AAD identity. </summary>
        [WirePath("properties.aadTenantId")]
        public Guid? AadTenantId { get; set; }
        /// <summary> Desired properties of the cluster. </summary>
        [WirePath("properties.desiredProperties")]
        public HciClusterDesiredProperties DesiredProperties { get; set; }
        /// <summary> The service principal ID of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        [WirePath("identity.principalId")]
        public Guid? PrincipalId { get; }
        /// <summary> The tenant ID of the system assigned identity. This property will only be provided for a system assigned identity. </summary>
        [WirePath("identity.tenantId")]
        public Guid? TenantId { get; }
        /// <summary> Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed). </summary>
        [WirePath("identity.type")]
        public HciManagedServiceIdentityType? ManagedServiceIdentityType { get; set; }
        /// <summary> The set of user assigned identities associated with the resource. The userAssignedIdentities dictionary keys will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}. The dictionary values can be empty objects ({}) in requests. </summary>
        [WirePath("identity.userAssignedIdentities")]
        public IDictionary<string, UserAssignedIdentity> UserAssignedIdentities { get; }
    }
}
