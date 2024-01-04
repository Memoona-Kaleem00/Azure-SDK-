// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> Kubernetes Patch Version profile. </summary>
    public partial class KubernetesPatchVersions
    {
        /// <summary> Initializes a new instance of <see cref="KubernetesPatchVersions"/>. </summary>
        internal KubernetesPatchVersions()
        {
            Readiness = new ChangeTrackingList<KubernetesVersionReadiness>();
            Upgrades = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="KubernetesPatchVersions"/>. </summary>
        /// <param name="readiness"> Whether the kubernetes version variant (Linux, Windows, Windows2022) is ready or not. </param>
        /// <param name="upgrades"> Possible upgrade path for given patch version. </param>
        internal KubernetesPatchVersions(IReadOnlyList<KubernetesVersionReadiness> readiness, IReadOnlyList<string> upgrades)
        {
            Readiness = readiness;
            Upgrades = upgrades;
        }

        /// <summary> Whether the kubernetes version variant (Linux, Windows, Windows2022) is ready or not. </summary>
        public IReadOnlyList<KubernetesVersionReadiness> Readiness { get; }
        /// <summary> Possible upgrade path for given patch version. </summary>
        public IReadOnlyList<string> Upgrades { get; }
    }
}
