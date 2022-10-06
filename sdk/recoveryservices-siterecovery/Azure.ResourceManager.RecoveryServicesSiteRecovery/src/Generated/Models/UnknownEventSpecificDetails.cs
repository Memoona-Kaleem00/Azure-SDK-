// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownEventSpecificDetails. </summary>
    internal partial class UnknownEventSpecificDetails : EventSpecificDetails
    {
        /// <summary> Initializes a new instance of UnknownEventSpecificDetails. </summary>
        /// <param name="instanceType"> Gets the class type. Overridden in derived classes. </param>
        internal UnknownEventSpecificDetails(string instanceType) : base(instanceType)
        {
            InstanceType = instanceType ?? "Unknown";
        }
    }
}
