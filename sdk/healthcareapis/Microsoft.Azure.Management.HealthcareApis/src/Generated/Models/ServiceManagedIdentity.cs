// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
    public partial class ServiceManagedIdentity
    {
        /// <summary> Initializes a new instance of ServiceManagedIdentity. </summary>
        public ServiceManagedIdentity()
        {
        }

        /// <summary> Initializes a new instance of ServiceManagedIdentity. </summary>
        /// <param name="identity"> Setting indicating whether the service has a managed identity associated with it. </param>
        internal ServiceManagedIdentity(ServiceManagedIdentityIdentity identity)
        {
            Identity = identity;
        }

        /// <summary> Setting indicating whether the service has a managed identity associated with it. </summary>
        public ServiceManagedIdentityIdentity Identity { get; set; }
    }
}
