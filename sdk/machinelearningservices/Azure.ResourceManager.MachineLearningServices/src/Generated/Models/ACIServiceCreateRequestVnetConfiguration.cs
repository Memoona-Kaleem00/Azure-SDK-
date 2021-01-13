// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The virtual network configuration. </summary>
    public partial class ACIServiceCreateRequestVnetConfiguration : VnetConfiguration
    {
        /// <summary> Initializes a new instance of ACIServiceCreateRequestVnetConfiguration. </summary>
        public ACIServiceCreateRequestVnetConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ACIServiceCreateRequestVnetConfiguration. </summary>
        /// <param name="vnetName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the virtual network subnet. </param>
        internal ACIServiceCreateRequestVnetConfiguration(string vnetName, string subnetName) : base(vnetName, subnetName)
        {
        }
    }
}
