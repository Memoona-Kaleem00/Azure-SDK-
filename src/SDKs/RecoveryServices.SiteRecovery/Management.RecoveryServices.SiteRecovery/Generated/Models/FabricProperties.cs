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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Fabric properties.
    /// </summary>
    public partial class FabricProperties
    {
        /// <summary>
        /// Initializes a new instance of the FabricProperties class.
        /// </summary>
        public FabricProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FabricProperties class.
        /// </summary>
        /// <param name="friendlyName">Friendly name of the fabric.</param>
        /// <param name="encryptionDetails">Encryption details for the
        /// fabric.</param>
        /// <param name="rolloverEncryptionDetails">Rollover encryption details
        /// for the fabric.</param>
        /// <param name="internalIdentifier">Dra Registration Id.</param>
        /// <param name="bcdrState">BCDR state of the fabric.</param>
        /// <param name="customDetails">Fabric specific settings.</param>
        /// <param name="healthErrorDetails">Fabric health error
        /// details.</param>
        /// <param name="health">Health of fabric.</param>
        public FabricProperties(string friendlyName = default(string), EncryptionDetails encryptionDetails = default(EncryptionDetails), EncryptionDetails rolloverEncryptionDetails = default(EncryptionDetails), string internalIdentifier = default(string), string bcdrState = default(string), FabricSpecificDetails customDetails = default(FabricSpecificDetails), IList<HealthError> healthErrorDetails = default(IList<HealthError>), string health = default(string))
        {
            FriendlyName = friendlyName;
            EncryptionDetails = encryptionDetails;
            RolloverEncryptionDetails = rolloverEncryptionDetails;
            InternalIdentifier = internalIdentifier;
            BcdrState = bcdrState;
            CustomDetails = customDetails;
            HealthErrorDetails = healthErrorDetails;
            Health = health;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets friendly name of the fabric.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets encryption details for the fabric.
        /// </summary>
        [JsonProperty(PropertyName = "encryptionDetails")]
        public EncryptionDetails EncryptionDetails { get; set; }

        /// <summary>
        /// Gets or sets rollover encryption details for the fabric.
        /// </summary>
        [JsonProperty(PropertyName = "rolloverEncryptionDetails")]
        public EncryptionDetails RolloverEncryptionDetails { get; set; }

        /// <summary>
        /// Gets or sets dra Registration Id.
        /// </summary>
        [JsonProperty(PropertyName = "internalIdentifier")]
        public string InternalIdentifier { get; set; }

        /// <summary>
        /// Gets or sets BCDR state of the fabric.
        /// </summary>
        [JsonProperty(PropertyName = "bcdrState")]
        public string BcdrState { get; set; }

        /// <summary>
        /// Gets or sets fabric specific settings.
        /// </summary>
        [JsonProperty(PropertyName = "customDetails")]
        public FabricSpecificDetails CustomDetails { get; set; }

        /// <summary>
        /// Gets or sets fabric health error details.
        /// </summary>
        [JsonProperty(PropertyName = "healthErrorDetails")]
        public IList<HealthError> HealthErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets health of fabric.
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        public string Health { get; set; }

    }
}
