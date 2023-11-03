// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LargeInstance.Models
{
    /// <summary> described the storage properties of the azure large storage instance. </summary>
    public partial class StorageProperties
    {
        /// <summary> Initializes a new instance of StorageProperties. </summary>
        internal StorageProperties()
        {
        }

        /// <summary> Initializes a new instance of StorageProperties. </summary>
        /// <param name="provisioningState"> State of provisioning of the AzureLargeStorageInstance. </param>
        /// <param name="offeringType"> the offering type for which the resource is getting provisioned. </param>
        /// <param name="storageType"> the storage protocol for which the resource is getting provisioned. </param>
        /// <param name="generation"> the kind of storage instance. </param>
        /// <param name="hardwareType"> the hardware type of the storage instance. </param>
        /// <param name="workloadType"> the workload for which the resource is getting provisioned. </param>
        /// <param name="storageBillingProperties"> the billing related information for the resource. </param>
        internal StorageProperties(ProvisioningState? provisioningState, string offeringType, string storageType, string generation, string hardwareType, string workloadType, StorageBillingProperties storageBillingProperties)
        {
            ProvisioningState = provisioningState;
            OfferingType = offeringType;
            StorageType = storageType;
            Generation = generation;
            HardwareType = hardwareType;
            WorkloadType = workloadType;
            StorageBillingProperties = storageBillingProperties;
        }

        /// <summary> State of provisioning of the AzureLargeStorageInstance. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> the offering type for which the resource is getting provisioned. </summary>
        public string OfferingType { get; }
        /// <summary> the storage protocol for which the resource is getting provisioned. </summary>
        public string StorageType { get; }
        /// <summary> the kind of storage instance. </summary>
        public string Generation { get; }
        /// <summary> the hardware type of the storage instance. </summary>
        public string HardwareType { get; }
        /// <summary> the workload for which the resource is getting provisioned. </summary>
        public string WorkloadType { get; }
        /// <summary> the billing related information for the resource. </summary>
        public StorageBillingProperties StorageBillingProperties { get; }
    }
}
