// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the SwiftVirtualNetwork data model. </summary>
    public partial class SwiftVirtualNetworkData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of SwiftVirtualNetworkData. </summary>
        public SwiftVirtualNetworkData()
        {
        }

        /// <summary> Initializes a new instance of SwiftVirtualNetworkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="subnetResourceId"> The Virtual Network subnet&apos;s resource ID. This is the subnet that this Web App will join. This subnet must have a delegation to Microsoft.Web/serverFarms defined first. </param>
        /// <param name="swiftSupported"> A flag that specifies if the scale unit this Web App is on supports Swift integration. </param>
        internal SwiftVirtualNetworkData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string kind, string subnetResourceId, bool? swiftSupported) : base(id, name, type, systemData, kind)
        {
            SubnetResourceId = subnetResourceId;
            SwiftSupported = swiftSupported;
        }

        /// <summary> The Virtual Network subnet&apos;s resource ID. This is the subnet that this Web App will join. This subnet must have a delegation to Microsoft.Web/serverFarms defined first. </summary>
        public string SubnetResourceId { get; set; }
        /// <summary> A flag that specifies if the scale unit this Web App is on supports Swift integration. </summary>
        public bool? SwiftSupported { get; set; }
    }
}
