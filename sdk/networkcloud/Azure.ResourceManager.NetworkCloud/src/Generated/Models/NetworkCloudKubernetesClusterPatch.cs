// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> KubernetesClusterPatchParameters represents the body of the request to patch the Hybrid AKS cluster. </summary>
    public partial class NetworkCloudKubernetesClusterPatch
    {
        /// <summary> Initializes a new instance of NetworkCloudKubernetesClusterPatch. </summary>
        public NetworkCloudKubernetesClusterPatch()
        {
            Tags = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The defining characteristics of the control plane that can be patched for this Kubernetes cluster. </summary>
        internal ControlPlaneNodePatchConfiguration ControlPlaneNodeConfiguration { get; set; }
        /// <summary> The number of virtual machines that use this configuration. </summary>
        public long? ControlPlaneNodeCount
        {
            get => ControlPlaneNodeConfiguration is null ? default : ControlPlaneNodeConfiguration.Count;
            set
            {
                if (ControlPlaneNodeConfiguration is null)
                    ControlPlaneNodeConfiguration = new ControlPlaneNodePatchConfiguration();
                ControlPlaneNodeConfiguration.Count = value;
            }
        }

        /// <summary> The Kubernetes version for this cluster. Accepts n.n, n.n.n, and n.n.n-n format. The interpreted version used will be resolved into this field after creation or update. </summary>
        public string KubernetesVersion { get; set; }
    }
}
