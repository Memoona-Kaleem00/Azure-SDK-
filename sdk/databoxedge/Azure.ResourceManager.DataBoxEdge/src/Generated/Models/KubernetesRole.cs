// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary>
    /// The limited preview of Kubernetes Cluster Management from the Azure supports:
    /// 1. Using a simple turn-key option in Azure Portal, deploy a Kubernetes cluster on your Azure Stack Edge device. 
    /// 2. Configure Kubernetes cluster running on your device with Arc enabled Kubernetes with a click of a button in the Azure Portal. 
    ///  Azure Arc enables organizations to view, manage, and govern their on-premises Kubernetes clusters using the Azure Portal, command line tools, and APIs.
    /// 3. Easily configure Persistent Volumes using SMB and NFS shares for storing container data. 
    ///  For more information, refer to the document here: https://databoxupdatepackages.blob.core.windows.net/documentation/Microsoft-Azure-Stack-Edge-K8-Cloud-Management-20210323.pdf 
    ///  Or Demo: https://databoxupdatepackages.blob.core.windows.net/documentation/Microsoft-Azure-Stack-Edge-K8S-Cloud-Management-20210323.mp4
    ///  By using this feature, you agree to the preview legal terms. See the https://azure.microsoft.com/en-us/support/legal/preview-supplemental-terms/
    /// </summary>
    public partial class KubernetesRole : RoleData
    {
        /// <summary> Initializes a new instance of KubernetesRole. </summary>
        public KubernetesRole()
        {
            Kind = RoleType.Kubernetes;
        }

        /// <summary> Initializes a new instance of KubernetesRole. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Role type. </param>
        /// <param name="hostPlatform"> Host OS supported by the Kubernetes role. </param>
        /// <param name="provisioningState"> State of Kubernetes deployment. </param>
        /// <param name="hostPlatformType"> Platform where the runtime is hosted. </param>
        /// <param name="kubernetesClusterInfo"> Kubernetes cluster configuration. </param>
        /// <param name="kubernetesRoleResources"> Kubernetes role resources. </param>
        /// <param name="roleStatus"> Role status. </param>
        internal KubernetesRole(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RoleType kind, PlatformType? hostPlatform, KubernetesState? provisioningState, HostPlatformType? hostPlatformType, KubernetesClusterInfo kubernetesClusterInfo, KubernetesRoleResources kubernetesRoleResources, RoleStatus? roleStatus) : base(id, name, resourceType, systemData, kind)
        {
            HostPlatform = hostPlatform;
            ProvisioningState = provisioningState;
            HostPlatformType = hostPlatformType;
            KubernetesClusterInfo = kubernetesClusterInfo;
            KubernetesRoleResources = kubernetesRoleResources;
            RoleStatus = roleStatus;
            Kind = kind;
        }

        /// <summary> Host OS supported by the Kubernetes role. </summary>
        public PlatformType? HostPlatform { get; set; }
        /// <summary> State of Kubernetes deployment. </summary>
        public KubernetesState? ProvisioningState { get; }
        /// <summary> Platform where the runtime is hosted. </summary>
        public HostPlatformType? HostPlatformType { get; }
        /// <summary> Kubernetes cluster configuration. </summary>
        public KubernetesClusterInfo KubernetesClusterInfo { get; set; }
        /// <summary> Kubernetes role resources. </summary>
        public KubernetesRoleResources KubernetesRoleResources { get; set; }
        /// <summary> Role status. </summary>
        public RoleStatus? RoleStatus { get; set; }
    }
}
