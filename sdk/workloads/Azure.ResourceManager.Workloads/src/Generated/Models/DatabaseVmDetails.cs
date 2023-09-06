// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Database VM details. </summary>
    public partial class DatabaseVmDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DatabaseVmDetails"/>. </summary>
        internal DatabaseVmDetails()
        {
            StorageDetails = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseVmDetails"/>. </summary>
        /// <param name="virtualMachineId"></param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="storageDetails"> Storage details of all the Storage Accounts attached to the Database Virtual Machine. For e.g. NFS on AFS Shared Storage. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseVmDetails(ResourceIdentifier virtualMachineId, SapVirtualInstanceStatus? status, IReadOnlyList<SubResource> storageDetails, Dictionary<string, BinaryData> rawData)
        {
            VirtualMachineId = virtualMachineId;
            Status = status;
            StorageDetails = storageDetails;
            _rawData = rawData;
        }

        /// <summary> Gets the virtual machine id. </summary>
        public ResourceIdentifier VirtualMachineId { get; }
        /// <summary> Defines the SAP Instance status. </summary>
        public SapVirtualInstanceStatus? Status { get; }
        /// <summary> Storage details of all the Storage Accounts attached to the Database Virtual Machine. For e.g. NFS on AFS Shared Storage. </summary>
        public IReadOnlyList<SubResource> StorageDetails { get; }
    }
}
