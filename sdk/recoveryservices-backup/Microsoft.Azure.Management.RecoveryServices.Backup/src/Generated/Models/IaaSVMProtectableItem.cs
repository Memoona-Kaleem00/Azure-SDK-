// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IaaS VM workload-specific backup item.
    /// </summary>
    [Newtonsoft.Json.JsonObject("IaaSVMProtectableItem")]
    public partial class IaaSVMProtectableItem : WorkloadProtectableItem
    {
        /// <summary>
        /// Initializes a new instance of the IaaSVMProtectableItem class.
        /// </summary>
        public IaaSVMProtectableItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IaaSVMProtectableItem class.
        /// </summary>
        /// <param name="backupManagementType">Type of backup management to
        /// backup an item.</param>
        /// <param name="workloadType">Type of workload for the backup
        /// management</param>
        /// <param name="friendlyName">Friendly name of the backup
        /// item.</param>
        /// <param name="protectionState">State of the back up item. Possible
        /// values include: 'Invalid', 'NotProtected', 'Protecting',
        /// 'Protected', 'ProtectionFailed'</param>
        /// <param name="virtualMachineId">Fully qualified ARM ID of the
        /// virtual machine.</param>
        public IaaSVMProtectableItem(string backupManagementType = default(string), string workloadType = default(string), string friendlyName = default(string), string protectionState = default(string), string virtualMachineId = default(string))
            : base(backupManagementType, workloadType, friendlyName, protectionState)
        {
            VirtualMachineId = virtualMachineId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets fully qualified ARM ID of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineId")]
        public string VirtualMachineId { get; set; }

    }
}
