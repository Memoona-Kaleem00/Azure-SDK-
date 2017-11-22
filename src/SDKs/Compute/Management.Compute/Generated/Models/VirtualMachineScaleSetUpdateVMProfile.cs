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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set virtual machine profile.
    /// </summary>
    public partial class VirtualMachineScaleSetUpdateVMProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetUpdateVMProfile class.
        /// </summary>
        public VirtualMachineScaleSetUpdateVMProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VirtualMachineScaleSetUpdateVMProfile class.
        /// </summary>
        /// <param name="osProfile">The virtual machine scale set OS
        /// profile.</param>
        /// <param name="storageProfile">The virtual machine scale set storage
        /// profile.</param>
        /// <param name="networkProfile">The virtual machine scale set network
        /// profile.</param>
        /// <param name="diagnosticsProfile">The virtual machine scale set
        /// diagnostics profile.</param>
        /// <param name="extensionProfile">The virtual machine scale set
        /// extension profile.</param>
        /// <param name="licenseType">The license type, which is for bring your
        /// own license scenario.</param>
        public VirtualMachineScaleSetUpdateVMProfile(VirtualMachineScaleSetUpdateOSProfile osProfile = default(VirtualMachineScaleSetUpdateOSProfile), VirtualMachineScaleSetUpdateStorageProfile storageProfile = default(VirtualMachineScaleSetUpdateStorageProfile), VirtualMachineScaleSetUpdateNetworkProfile networkProfile = default(VirtualMachineScaleSetUpdateNetworkProfile), DiagnosticsProfile diagnosticsProfile = default(DiagnosticsProfile), VirtualMachineScaleSetExtensionProfile extensionProfile = default(VirtualMachineScaleSetExtensionProfile), string licenseType = default(string))
        {
            OsProfile = osProfile;
            StorageProfile = storageProfile;
            NetworkProfile = networkProfile;
            DiagnosticsProfile = diagnosticsProfile;
            ExtensionProfile = extensionProfile;
            LicenseType = licenseType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the virtual machine scale set OS profile.
        /// </summary>
        [JsonProperty(PropertyName = "osProfile")]
        public VirtualMachineScaleSetUpdateOSProfile OsProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set storage profile.
        /// </summary>
        [JsonProperty(PropertyName = "storageProfile")]
        public VirtualMachineScaleSetUpdateStorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set network profile.
        /// </summary>
        [JsonProperty(PropertyName = "networkProfile")]
        public VirtualMachineScaleSetUpdateNetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set diagnostics profile.
        /// </summary>
        [JsonProperty(PropertyName = "diagnosticsProfile")]
        public DiagnosticsProfile DiagnosticsProfile { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set extension profile.
        /// </summary>
        [JsonProperty(PropertyName = "extensionProfile")]
        public VirtualMachineScaleSetExtensionProfile ExtensionProfile { get; set; }

        /// <summary>
        /// Gets or sets the license type, which is for bring your own license
        /// scenario.
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

    }
}
