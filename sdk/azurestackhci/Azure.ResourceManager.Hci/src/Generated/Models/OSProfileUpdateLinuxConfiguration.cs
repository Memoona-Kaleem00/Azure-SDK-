// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> The OSProfileUpdateLinuxConfiguration. </summary>
    public partial class OSProfileUpdateLinuxConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="OSProfileUpdateLinuxConfiguration"/>. </summary>
        public OSProfileUpdateLinuxConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OSProfileUpdateLinuxConfiguration"/>. </summary>
        /// <param name="provisionVmAgent"> Used to indicate whether Arc for Servers agent onboarding should be triggered during the virtual machine instance creation process. </param>
        /// <param name="provisionVmConfigAgent"> Used to indicate whether the VM Config Agent should be installed during the virtual machine creation process. </param>
        internal OSProfileUpdateLinuxConfiguration(bool? provisionVmAgent, bool? provisionVmConfigAgent)
        {
            ProvisionVmAgent = provisionVmAgent;
            ProvisionVmConfigAgent = provisionVmConfigAgent;
        }

        /// <summary> Used to indicate whether Arc for Servers agent onboarding should be triggered during the virtual machine instance creation process. </summary>
        public bool? ProvisionVmAgent { get; set; }
        /// <summary> Used to indicate whether the VM Config Agent should be installed during the virtual machine creation process. </summary>
        public bool? ProvisionVmConfigAgent { get; set; }
    }
}
