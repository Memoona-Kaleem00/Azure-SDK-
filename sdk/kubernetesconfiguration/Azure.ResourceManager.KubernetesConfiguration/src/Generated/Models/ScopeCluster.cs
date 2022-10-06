// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Specifies that the scope of the extension is Cluster. </summary>
    internal partial class ScopeCluster
    {
        /// <summary> Initializes a new instance of ScopeCluster. </summary>
        public ScopeCluster()
        {
        }

        /// <summary> Initializes a new instance of ScopeCluster. </summary>
        /// <param name="releaseNamespace"> Namespace where the extension Release must be placed, for a Cluster scoped extension.  If this namespace does not exist, it will be created. </param>
        internal ScopeCluster(string releaseNamespace)
        {
            ReleaseNamespace = releaseNamespace;
        }

        /// <summary> Namespace where the extension Release must be placed, for a Cluster scoped extension.  If this namespace does not exist, it will be created. </summary>
        public string ReleaseNamespace { get; set; }
    }
}
