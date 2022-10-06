// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines reference to NSG. </summary>
    internal partial class NetworkSecurityGroupResourceReferenceInfo : MoverResourceReferenceInfo
    {
        /// <summary> Initializes a new instance of NetworkSecurityGroupResourceReferenceInfo. </summary>
        /// <param name="sourceArmResourceId"> Gets the ARM resource ID of the tracked resource being referenced. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceArmResourceId"/> is null. </exception>
        public NetworkSecurityGroupResourceReferenceInfo(ResourceIdentifier sourceArmResourceId) : base(sourceArmResourceId)
        {
            if (sourceArmResourceId == null)
            {
                throw new ArgumentNullException(nameof(sourceArmResourceId));
            }
        }
    }
}
