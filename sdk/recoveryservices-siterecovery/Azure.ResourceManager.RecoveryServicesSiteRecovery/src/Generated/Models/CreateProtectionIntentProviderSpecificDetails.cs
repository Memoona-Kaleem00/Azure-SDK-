// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary>
    /// Create protection intent provider specific input.
    /// Please note <see cref="CreateProtectionIntentProviderSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="A2ACreateProtectionIntentInput"/>.
    /// </summary>
    public abstract partial class CreateProtectionIntentProviderSpecificDetails
    {
        /// <summary> Initializes a new instance of CreateProtectionIntentProviderSpecificDetails. </summary>
        protected CreateProtectionIntentProviderSpecificDetails()
        {
        }

        /// <summary> The class type. </summary>
        internal string InstanceType { get; set; }
    }
}
