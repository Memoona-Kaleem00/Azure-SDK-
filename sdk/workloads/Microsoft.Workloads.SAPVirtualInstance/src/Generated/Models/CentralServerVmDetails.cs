// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Workloads.SAPVirtualInstance.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The SAP Central Services Instance VM details.
    /// </summary>
    public partial class CentralServerVmDetails
    {
        /// <summary>
        /// Initializes a new instance of the CentralServerVmDetails class.
        /// </summary>
        public CentralServerVmDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CentralServerVmDetails class.
        /// </summary>
        /// <param name="type">Possible values include: 'Primary', 'Secondary',
        /// 'Unknown', 'ASCS', 'ERSInactive', 'ERS', 'Standby'</param>
        /// <param name="storageDetails">Storage details of all the Storage
        /// Accounts attached to the ASCS Virtual Machine. For e.g. NFS on AFS
        /// Shared Storage.</param>
        public CentralServerVmDetails(string type = default(string), string virtualMachineId = default(string), IList<StorageInformation> storageDetails = default(IList<StorageInformation>))
        {
            Type = type;
            VirtualMachineId = virtualMachineId;
            StorageDetails = storageDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets possible values include: 'Primary', 'Secondary', 'Unknown',
        /// 'ASCS', 'ERSInactive', 'ERS', 'Standby'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineId")]
        public string VirtualMachineId { get; private set; }

        /// <summary>
        /// Gets storage details of all the Storage Accounts attached to the
        /// ASCS Virtual Machine. For e.g. NFS on AFS Shared Storage.
        /// </summary>
        [JsonProperty(PropertyName = "storageDetails")]
        public IList<StorageInformation> StorageDetails { get; private set; }

    }
}
