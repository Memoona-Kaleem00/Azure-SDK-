// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Policy model properties. </summary>
    public partial class DataReplicationPolicyProperties
    {
        /// <summary> Initializes a new instance of DataReplicationPolicyProperties. </summary>
        /// <param name="customProperties">
        /// Policy model custom properties.
        /// Please note <see cref="PolicyModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciPolicyModelCustomProperties"/>, <see cref="GeneralPolicyModelCustomProperties"/> and <see cref="VMwareToAzStackHciPolicyModelCustomProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customProperties"/> is null. </exception>
        public DataReplicationPolicyProperties(PolicyModelCustomProperties customProperties)
        {
            Argument.AssertNotNull(customProperties, nameof(customProperties));

            CustomProperties = customProperties;
        }

        /// <summary> Initializes a new instance of DataReplicationPolicyProperties. </summary>
        /// <param name="provisioningState"> Gets or sets the provisioning state of the policy. </param>
        /// <param name="customProperties">
        /// Policy model custom properties.
        /// Please note <see cref="PolicyModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciPolicyModelCustomProperties"/>, <see cref="GeneralPolicyModelCustomProperties"/> and <see cref="VMwareToAzStackHciPolicyModelCustomProperties"/>.
        /// </param>
        internal DataReplicationPolicyProperties(DataReplicationProvisioningState? provisioningState, PolicyModelCustomProperties customProperties)
        {
            ProvisioningState = provisioningState;
            CustomProperties = customProperties;
        }

        /// <summary> Gets or sets the provisioning state of the policy. </summary>
        public DataReplicationProvisioningState? ProvisioningState { get; }
        /// <summary>
        /// Policy model custom properties.
        /// Please note <see cref="PolicyModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciPolicyModelCustomProperties"/>, <see cref="GeneralPolicyModelCustomProperties"/> and <see cref="VMwareToAzStackHciPolicyModelCustomProperties"/>.
        /// </summary>
        public PolicyModelCustomProperties CustomProperties { get; set; }
    }
}
