// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.ServiceFabricManagedClusters;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Specifies the settings for a network interface to attach to the node type. </summary>
    public partial class AdditionalNetworkInterfaceConfiguration
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

        /// <summary> Initializes a new instance of <see cref="AdditionalNetworkInterfaceConfiguration"/>. </summary>
        /// <param name="name"> Name of the network interface. </param>
        /// <param name="ipConfigurations"> Specifies the IP configurations of the network interface. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="ipConfigurations"/> is null. </exception>
        public AdditionalNetworkInterfaceConfiguration(string name, IEnumerable<ServiceFabricManagedClusterIPConfiguration> ipConfigurations)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(ipConfigurations, nameof(ipConfigurations));

            Name = name;
            IPConfigurations = ipConfigurations.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AdditionalNetworkInterfaceConfiguration"/>. </summary>
        /// <param name="name"> Name of the network interface. </param>
        /// <param name="enableAcceleratedNetworking"> Specifies whether the network interface is accelerated networking-enabled. </param>
        /// <param name="dscpConfiguration"> Specifies the DSCP configuration to apply to the network interface. </param>
        /// <param name="ipConfigurations"> Specifies the IP configurations of the network interface. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AdditionalNetworkInterfaceConfiguration(string name, bool? enableAcceleratedNetworking, WritableSubResource dscpConfiguration, IList<ServiceFabricManagedClusterIPConfiguration> ipConfigurations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            EnableAcceleratedNetworking = enableAcceleratedNetworking;
            DscpConfiguration = dscpConfiguration;
            IPConfigurations = ipConfigurations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AdditionalNetworkInterfaceConfiguration"/> for deserialization. </summary>
        internal AdditionalNetworkInterfaceConfiguration()
        {
        }

        /// <summary> Name of the network interface. </summary>
        public string Name { get; set; }
        /// <summary> Specifies whether the network interface is accelerated networking-enabled. </summary>
        public bool? EnableAcceleratedNetworking { get; set; }
        /// <summary> Specifies the DSCP configuration to apply to the network interface. </summary>
        internal WritableSubResource DscpConfiguration { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DscpConfigurationId
        {
            get => DscpConfiguration is null ? default : DscpConfiguration.Id;
            set
            {
                if (DscpConfiguration is null)
                    DscpConfiguration = new WritableSubResource();
                DscpConfiguration.Id = value;
            }
        }

        /// <summary> Specifies the IP configurations of the network interface. </summary>
        public IList<ServiceFabricManagedClusterIPConfiguration> IPConfigurations { get; }
    }
}
