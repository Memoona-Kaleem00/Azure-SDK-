// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing the MachineLearningPrivateEndpointConnection data model.
    /// The Private Endpoint Connection resource.
    /// </summary>
    public partial class MachineLearningPrivateEndpointConnectionData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="MachineLearningPrivateEndpointConnectionData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MachineLearningPrivateEndpointConnectionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the resource. </param>
        /// <param name="sku"> The sku of the workspace. </param>
        /// <param name="subResource"> The resource of private end point. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningPrivateEndpointConnectionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, MachineLearningSku sku, SubResource subResource, MachineLearningPrivateLinkServiceConnectionState connectionState, MachineLearningPrivateEndpointConnectionProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Sku = sku;
            SubResource = subResource;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningPrivateEndpointConnectionData"/> for deserialization. </summary>
        internal MachineLearningPrivateEndpointConnectionData()
        {
        }

        /// <summary> The identity of the resource. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The sku of the workspace. </summary>
        [WirePath("sku")]
        public MachineLearningSku Sku { get; set; }
        /// <summary> The resource of private end point. </summary>
        internal SubResource SubResource { get; set; }
        /// <summary> Gets Id. </summary>
        [WirePath("properties.privateEndpoint.id")]
        public ResourceIdentifier SubResourceId
        {
            get => SubResource is null ? default : SubResource.Id;
        }

        /// <summary> A collection of information about the state of the connection between service consumer and provider. </summary>
        [WirePath("properties.privateLinkServiceConnectionState")]
        public MachineLearningPrivateLinkServiceConnectionState ConnectionState { get; set; }
        /// <summary> The provisioning state of the private endpoint connection resource. </summary>
        [WirePath("properties.provisioningState")]
        public MachineLearningPrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
    }
}
