// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the availability set that the virtual machine should be assigned to. Only tags may be updated. </summary>
    public partial class AvailabilitySetUpdate : UpdateResource
    {
        /// <summary> Initializes a new instance of AvailabilitySetUpdate. </summary>
        public AvailabilitySetUpdate()
        {
        }

        /// <summary> Initializes a new instance of AvailabilitySetUpdate. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> Sku of the availability set. </param>
        /// <param name="platformUpdateDomainCount"> Update Domain count. </param>
        /// <param name="platformFaultDomainCount"> Fault Domain count. </param>
        /// <param name="virtualMachines"> A list of references to all virtual machines in the availability set. </param>
        /// <param name="proximityPlacementGroup"> Specifies information about the proximity placement group that the availability set should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01. </param>
        /// <param name="statuses"> The resource status information. </param>
        internal AvailabilitySetUpdate(IDictionary<string, string> tags, Sku sku, int? platformUpdateDomainCount, int? platformFaultDomainCount, IList<SubResource> virtualMachines, SubResource proximityPlacementGroup, IList<InstanceViewStatus> statuses) : base(tags)
        {
            Sku = sku;
            PlatformUpdateDomainCount = platformUpdateDomainCount;
            PlatformFaultDomainCount = platformFaultDomainCount;
            VirtualMachines = virtualMachines;
            ProximityPlacementGroup = proximityPlacementGroup;
            Statuses = statuses;
        }

        /// <summary> Sku of the availability set. </summary>
        public Sku Sku { get; set; }
        /// <summary> Update Domain count. </summary>
        public int? PlatformUpdateDomainCount { get; set; }
        /// <summary> Fault Domain count. </summary>
        public int? PlatformFaultDomainCount { get; set; }
        /// <summary> A list of references to all virtual machines in the availability set. </summary>
        public IList<SubResource> VirtualMachines { get; set; }
        /// <summary> Specifies information about the proximity placement group that the availability set should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01. </summary>
        public SubResource ProximityPlacementGroup { get; set; }
        /// <summary> The resource status information. </summary>
        public IList<InstanceViewStatus> Statuses { get; }
    }
}
