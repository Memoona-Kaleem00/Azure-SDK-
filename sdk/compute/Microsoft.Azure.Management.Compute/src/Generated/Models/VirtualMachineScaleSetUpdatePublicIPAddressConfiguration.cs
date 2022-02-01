// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machines scale set IP Configuration's
    /// PublicIPAddress configuration
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualMachineScaleSetUpdatePublicIPAddressConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetUpdatePublicIPAddressConfiguration class.
        /// </summary>
        public VirtualMachineScaleSetUpdatePublicIPAddressConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetUpdatePublicIPAddressConfiguration class.
        /// </summary>
        /// <param name="name">The publicIP address configuration name.</param>
        /// <param name="idleTimeoutInMinutes">The idle timeout of the public
        /// IP address.</param>
        /// <param name="dnsSettings">The dns settings to be applied on the
        /// publicIP addresses .</param>
        /// <param name="publicIPPrefix">The PublicIPPrefix from which to
        /// allocate publicIP addresses.</param>
        /// <param name="deleteOption">Specify what happens to the public IP
        /// when the VM is deleted. Possible values include: 'Delete',
        /// 'Detach'</param>
        public VirtualMachineScaleSetUpdatePublicIPAddressConfiguration(string name = default(string), int? idleTimeoutInMinutes = default(int?), VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings dnsSettings = default(VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings), SubResource publicIPPrefix = default(SubResource), string deleteOption = default(string))
        {
            Name = name;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            DnsSettings = dnsSettings;
            PublicIPPrefix = publicIPPrefix;
            DeleteOption = deleteOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the publicIP address configuration name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the idle timeout of the public IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the dns settings to be applied on the publicIP
        /// addresses .
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSettings")]
        public VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings DnsSettings { get; set; }

        /// <summary>
        /// Gets or sets the PublicIPPrefix from which to allocate publicIP
        /// addresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPPrefix")]
        public SubResource PublicIPPrefix { get; set; }

        /// <summary>
        /// Gets or sets specify what happens to the public IP when the VM is
        /// deleted. Possible values include: 'Delete', 'Detach'
        /// </summary>
        [JsonProperty(PropertyName = "properties.deleteOption")]
        public string DeleteOption { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DnsSettings != null)
            {
                DnsSettings.Validate();
            }
        }
    }
}
