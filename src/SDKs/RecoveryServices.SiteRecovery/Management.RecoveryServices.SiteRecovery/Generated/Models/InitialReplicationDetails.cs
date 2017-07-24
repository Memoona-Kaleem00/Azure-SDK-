// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Initial replication details.
    /// </summary>
    public partial class InitialReplicationDetails
    {
        /// <summary>
        /// Initializes a new instance of the InitialReplicationDetails class.
        /// </summary>
        public InitialReplicationDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InitialReplicationDetails class.
        /// </summary>
        /// <param name="initialReplicationType">Initial replication
        /// type.</param>
        /// <param name="initialReplicationProgressPercentage">The initial
        /// replication progress percentage.</param>
        public InitialReplicationDetails(string initialReplicationType = default(string), string initialReplicationProgressPercentage = default(string))
        {
            InitialReplicationType = initialReplicationType;
            InitialReplicationProgressPercentage = initialReplicationProgressPercentage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets initial replication type.
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationType")]
        public string InitialReplicationType { get; set; }

        /// <summary>
        /// Gets or sets the initial replication progress percentage.
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationProgressPercentage")]
        public string InitialReplicationProgressPercentage { get; set; }

    }
}
