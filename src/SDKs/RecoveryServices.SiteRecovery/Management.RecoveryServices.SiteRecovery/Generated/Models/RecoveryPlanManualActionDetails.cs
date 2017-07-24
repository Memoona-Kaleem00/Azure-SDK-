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
    /// Recovery plan manual action details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ManualActionDetails")]
    public partial class RecoveryPlanManualActionDetails : RecoveryPlanActionDetails
    {
        /// <summary>
        /// Initializes a new instance of the RecoveryPlanManualActionDetails
        /// class.
        /// </summary>
        public RecoveryPlanManualActionDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecoveryPlanManualActionDetails
        /// class.
        /// </summary>
        /// <param name="description">The manual action description.</param>
        public RecoveryPlanManualActionDetails(string description = default(string))
        {
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the manual action description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
