// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> BareMetalMachinePatchParameters represents the body of the request to patch bare metal machine properties. </summary>
    public partial class NetworkCloudBareMetalMachinePatch
    {
        /// <summary> Initializes a new instance of <see cref="NetworkCloudBareMetalMachinePatch"/>. </summary>
        public NetworkCloudBareMetalMachinePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudBareMetalMachinePatch"/>. </summary>
        /// <param name="tags"> The Azure resource tags that will replace the existing ones. </param>
        /// <param name="machineDetails">
        /// The details provided by the customer during the creation of rack manifests
        /// that allows for custom data to be associated with this machine.
        /// </param>
        internal NetworkCloudBareMetalMachinePatch(IDictionary<string, string> tags, string machineDetails)
        {
            Tags = tags;
            MachineDetails = machineDetails;
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary>
        /// The details provided by the customer during the creation of rack manifests
        /// that allows for custom data to be associated with this machine.
        /// </summary>
        public string MachineDetails { get; set; }
    }
}
