// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of all Static Routes. </summary>
    public partial class StaticRoute
    {
        /// <summary> Initializes a new instance of StaticRoute. </summary>
        public StaticRoute()
        {
        }

        /// <summary> Initializes a new instance of StaticRoute. </summary>
        /// <param name="name"> The name of the StaticRoute that is unique within a VnetRoute. </param>
        /// <param name="addressPrefixes"> List of all address prefixes. </param>
        /// <param name="nextHopIpAddress"> The ip address of the next hop. </param>
        internal StaticRoute(string name, IList<string> addressPrefixes, string nextHopIpAddress)
        {
            Name = name;
            AddressPrefixes = addressPrefixes;
            NextHopIpAddress = nextHopIpAddress;
        }

        /// <summary> The name of the StaticRoute that is unique within a VnetRoute. </summary>
        public string Name { get; set; }
        /// <summary> List of all address prefixes. </summary>
        public IList<string> AddressPrefixes { get; set; }
        /// <summary> The ip address of the next hop. </summary>
        public string NextHopIpAddress { get; set; }
    }
}
