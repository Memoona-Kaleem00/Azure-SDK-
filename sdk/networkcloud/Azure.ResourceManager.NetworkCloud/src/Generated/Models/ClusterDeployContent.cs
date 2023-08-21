// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ClusterDeployParameters represents the body of the request to deploy cluster. </summary>
    public partial class ClusterDeployContent
    {
        /// <summary> Initializes a new instance of ClusterDeployContent. </summary>
        public ClusterDeployContent()
        {
            SkipValidationsForMachines = new Core.ChangeTrackingList<string>();
        }

        /// <summary> The names of bare metal machines in the cluster that should be skipped during environment validation. </summary>
        public IList<string> SkipValidationsForMachines { get; }
    }
}
