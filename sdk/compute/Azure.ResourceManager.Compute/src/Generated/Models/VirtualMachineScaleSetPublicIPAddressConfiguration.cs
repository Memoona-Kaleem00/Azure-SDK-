// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machines scale set IP Configuration&apos;s PublicIPAddress configuration. </summary>
    public partial class VirtualMachineScaleSetPublicIPAddressConfiguration
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetPublicIPAddressConfiguration. </summary>
        /// <param name="name"> The publicIP address configuration name. </param>
        public VirtualMachineScaleSetPublicIPAddressConfiguration(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetPublicIPAddressConfiguration. </summary>
        /// <param name="name"> The publicIP address configuration name. </param>
        /// <param name="idleTimeoutInMinutes"> The idle timeout of the public IP address. </param>
        /// <param name="dnsSettings"> The dns settings to be applied on the publicIP addresses . </param>
        /// <param name="ipTags"> The list of IP tags associated with the public IP address. </param>
        /// <param name="publicIPPrefix"> The PublicIPPrefix from which to allocate publicIP addresses. </param>
        /// <param name="publicIPAddressVersion"> Available from Api-Version 2019-07-01 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;. </param>
        internal VirtualMachineScaleSetPublicIPAddressConfiguration(string name, int? idleTimeoutInMinutes, VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings dnsSettings, IList<VirtualMachineScaleSetIpTag> ipTags, SubResource publicIPPrefix, IPVersion? publicIPAddressVersion)
        {
            Name = name;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            DnsSettings = dnsSettings;
            IpTags = ipTags;
            PublicIPPrefix = publicIPPrefix;
            PublicIPAddressVersion = publicIPAddressVersion;
        }

        /// <summary> The publicIP address configuration name. </summary>
        public string Name { get; set; }
        /// <summary> The idle timeout of the public IP address. </summary>
        public int? IdleTimeoutInMinutes { get; set; }
        /// <summary> The dns settings to be applied on the publicIP addresses . </summary>
        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DnsSettings { get; set; }
        /// <summary> The list of IP tags associated with the public IP address. </summary>
        public IList<VirtualMachineScaleSetIpTag> IpTags { get; set; }
        /// <summary> The PublicIPPrefix from which to allocate publicIP addresses. </summary>
        public SubResource PublicIPPrefix { get; set; }
        /// <summary> Available from Api-Version 2019-07-01 onwards, it represents whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4. Possible values are: &apos;IPv4&apos; and &apos;IPv6&apos;. </summary>
        public IPVersion? PublicIPAddressVersion { get; set; }
    }
}
