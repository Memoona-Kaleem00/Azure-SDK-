// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Update replication protected item provider specific input.
    /// Please note <see cref="UpdateApplianceForReplicationProtectedItemProviderSpecificContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="InMageRcmUpdateApplianceForReplicationProtectedItemContent"/>.
    /// </summary>
    public abstract partial class UpdateApplianceForReplicationProtectedItemProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="UpdateApplianceForReplicationProtectedItemProviderSpecificContent"/>. </summary>
        protected UpdateApplianceForReplicationProtectedItemProviderSpecificContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UpdateApplianceForReplicationProtectedItemProviderSpecificContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        internal UpdateApplianceForReplicationProtectedItemProviderSpecificContent(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}
