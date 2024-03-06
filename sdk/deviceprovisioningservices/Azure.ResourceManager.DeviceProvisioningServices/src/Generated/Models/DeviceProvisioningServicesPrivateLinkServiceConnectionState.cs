// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> The current state of a private endpoint connection. </summary>
    public partial class DeviceProvisioningServicesPrivateLinkServiceConnectionState
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

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> The status of a private endpoint connection. </param>
        /// <param name="description"> The description for the current state of a private endpoint connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="description"/> is null. </exception>
        public DeviceProvisioningServicesPrivateLinkServiceConnectionState(DeviceProvisioningServicesPrivateLinkServiceConnectionStatus status, string description)
        {
            Argument.AssertNotNull(description, nameof(description));

            Status = status;
            Description = description;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesPrivateLinkServiceConnectionState"/>. </summary>
        /// <param name="status"> The status of a private endpoint connection. </param>
        /// <param name="description"> The description for the current state of a private endpoint connection. </param>
        /// <param name="actionsRequired"> Actions required for a private endpoint connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceProvisioningServicesPrivateLinkServiceConnectionState(DeviceProvisioningServicesPrivateLinkServiceConnectionStatus status, string description, string actionsRequired, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesPrivateLinkServiceConnectionState"/> for deserialization. </summary>
        internal DeviceProvisioningServicesPrivateLinkServiceConnectionState()
        {
        }

        /// <summary> The status of a private endpoint connection. </summary>
        public DeviceProvisioningServicesPrivateLinkServiceConnectionStatus Status { get; set; }
        /// <summary> The description for the current state of a private endpoint connection. </summary>
        public string Description { get; set; }
        /// <summary> Actions required for a private endpoint connection. </summary>
        public string ActionsRequired { get; set; }
    }
}
