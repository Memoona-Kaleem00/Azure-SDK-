// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> NetworkAttachment represents the single network attachment. </summary>
    public partial class NetworkAttachment
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

        /// <summary> Initializes a new instance of <see cref="NetworkAttachment"/>. </summary>
        /// <param name="attachedNetworkId">
        /// The resource ID of the associated network attached to the virtual machine.
        /// It can be one of cloudServicesNetwork, l3Network, l2Network or trunkedNetwork resources.
        /// </param>
        /// <param name="ipAllocationMethod">
        /// The IP allocation mechanism for the virtual machine.
        /// Dynamic and Static are only valid for l3Network which may also specify Disabled.
        /// Otherwise, Disabled is the only permitted value.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="attachedNetworkId"/> is null. </exception>
        public NetworkAttachment(ResourceIdentifier attachedNetworkId, VirtualMachineIPAllocationMethod ipAllocationMethod)
        {
            Argument.AssertNotNull(attachedNetworkId, nameof(attachedNetworkId));

            AttachedNetworkId = attachedNetworkId;
            IPAllocationMethod = ipAllocationMethod;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkAttachment"/>. </summary>
        /// <param name="attachedNetworkId">
        /// The resource ID of the associated network attached to the virtual machine.
        /// It can be one of cloudServicesNetwork, l3Network, l2Network or trunkedNetwork resources.
        /// </param>
        /// <param name="defaultGateway">
        /// The indicator of whether this is the default gateway.
        /// Only one of the attached networks (including the CloudServicesNetwork attachment) for a single machine may be specified as True.
        /// </param>
        /// <param name="ipAllocationMethod">
        /// The IP allocation mechanism for the virtual machine.
        /// Dynamic and Static are only valid for l3Network which may also specify Disabled.
        /// Otherwise, Disabled is the only permitted value.
        /// </param>
        /// <param name="ipv4Address">
        /// The IPv4 address of the virtual machine.
        ///
        /// This field is used only if the attached network has IPAllocationType of IPV4 or DualStack.
        ///
        /// If IPAllocationMethod is:
        /// Static - this field must contain a user specified IPv4 address from within the subnet specified in the attached network.
        /// Dynamic - this field is read-only, but will be populated with an address from within the subnet specified in the attached network.
        /// Disabled - this field will be empty.
        /// </param>
        /// <param name="ipv6Address">
        /// The IPv6 address of the virtual machine.
        ///
        /// This field is used only if the attached network has IPAllocationType of IPV6 or DualStack.
        ///
        /// If IPAllocationMethod is:
        /// Static - this field must contain an IPv6 address range from within the range specified in the attached network.
        /// Dynamic - this field is read-only, but will be populated with an range from within the subnet specified in the attached network.
        /// Disabled - this field will be empty.
        /// </param>
        /// <param name="macAddress"> The MAC address of the interface for the virtual machine that corresponds to this network attachment. </param>
        /// <param name="networkAttachmentName">
        /// The associated network's interface name.
        /// If specified, the network attachment name has a maximum length of 15 characters and must be unique to this virtual machine.
        /// If the user doesn’t specify this value, the default interface name of the network resource will be used.
        /// For a CloudServicesNetwork resource, this name will be ignored.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkAttachment(ResourceIdentifier attachedNetworkId, DefaultGateway? defaultGateway, VirtualMachineIPAllocationMethod ipAllocationMethod, string ipv4Address, string ipv6Address, string macAddress, string networkAttachmentName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AttachedNetworkId = attachedNetworkId;
            DefaultGateway = defaultGateway;
            IPAllocationMethod = ipAllocationMethod;
            IPv4Address = ipv4Address;
            IPv6Address = ipv6Address;
            MacAddress = macAddress;
            NetworkAttachmentName = networkAttachmentName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkAttachment"/> for deserialization. </summary>
        internal NetworkAttachment()
        {
        }

        /// <summary>
        /// The resource ID of the associated network attached to the virtual machine.
        /// It can be one of cloudServicesNetwork, l3Network, l2Network or trunkedNetwork resources.
        /// </summary>
        public ResourceIdentifier AttachedNetworkId { get; set; }
        /// <summary>
        /// The indicator of whether this is the default gateway.
        /// Only one of the attached networks (including the CloudServicesNetwork attachment) for a single machine may be specified as True.
        /// </summary>
        public DefaultGateway? DefaultGateway { get; set; }
        /// <summary>
        /// The IP allocation mechanism for the virtual machine.
        /// Dynamic and Static are only valid for l3Network which may also specify Disabled.
        /// Otherwise, Disabled is the only permitted value.
        /// </summary>
        public VirtualMachineIPAllocationMethod IPAllocationMethod { get; set; }
        /// <summary>
        /// The IPv4 address of the virtual machine.
        ///
        /// This field is used only if the attached network has IPAllocationType of IPV4 or DualStack.
        ///
        /// If IPAllocationMethod is:
        /// Static - this field must contain a user specified IPv4 address from within the subnet specified in the attached network.
        /// Dynamic - this field is read-only, but will be populated with an address from within the subnet specified in the attached network.
        /// Disabled - this field will be empty.
        /// </summary>
        public string IPv4Address { get; set; }
        /// <summary>
        /// The IPv6 address of the virtual machine.
        ///
        /// This field is used only if the attached network has IPAllocationType of IPV6 or DualStack.
        ///
        /// If IPAllocationMethod is:
        /// Static - this field must contain an IPv6 address range from within the range specified in the attached network.
        /// Dynamic - this field is read-only, but will be populated with an range from within the subnet specified in the attached network.
        /// Disabled - this field will be empty.
        /// </summary>
        public string IPv6Address { get; set; }
        /// <summary> The MAC address of the interface for the virtual machine that corresponds to this network attachment. </summary>
        public string MacAddress { get; }
        /// <summary>
        /// The associated network's interface name.
        /// If specified, the network attachment name has a maximum length of 15 characters and must be unique to this virtual machine.
        /// If the user doesn’t specify this value, the default interface name of the network resource will be used.
        /// For a CloudServicesNetwork resource, this name will be ignored.
        /// </summary>
        public string NetworkAttachmentName { get; set; }
    }
}
