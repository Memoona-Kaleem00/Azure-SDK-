// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies the security posture to be used for all virtual machines in the scale set. Minimum api-version: 2023-03-01. </summary>
    public partial class ComputeSecurityPostureReference
    {
        /// <summary> Initializes a new instance of <see cref="ComputeSecurityPostureReference"/>. </summary>
        public ComputeSecurityPostureReference()
        {
            ExcludeExtensions = new ChangeTrackingList<VirtualMachineExtensionData>();
        }

        /// <summary> Initializes a new instance of <see cref="ComputeSecurityPostureReference"/>. </summary>
        /// <param name="id"> The security posture reference id in the form of /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|{major.*}|latest. </param>
        /// <param name="excludeExtensions"> List of virtual machine extensions to exclude when applying the Security Posture. </param>
        internal ComputeSecurityPostureReference(ResourceIdentifier id, IList<VirtualMachineExtensionData> excludeExtensions)
        {
            Id = id;
            ExcludeExtensions = excludeExtensions;
        }

        /// <summary> The security posture reference id in the form of /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|{major.*}|latest. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> List of virtual machine extensions to exclude when applying the Security Posture. </summary>
        public IList<VirtualMachineExtensionData> ExcludeExtensions { get; }
    }
}
