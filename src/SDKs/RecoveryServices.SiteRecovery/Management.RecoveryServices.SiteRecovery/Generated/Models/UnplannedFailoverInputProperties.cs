// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
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
    /// Input definition for planned failover input properties.
    /// </summary>
    public partial class UnplannedFailoverInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the UnplannedFailoverInputProperties
        /// class.
        /// </summary>
        public UnplannedFailoverInputProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UnplannedFailoverInputProperties
        /// class.
        /// </summary>
        /// <param name="failoverDirection">Failover direction.</param>
        /// <param name="sourceSiteOperations">Source site operations
        /// status</param>
        /// <param name="providerSpecificDetails">Provider specific
        /// settings</param>
        public UnplannedFailoverInputProperties(string failoverDirection = default(string), string sourceSiteOperations = default(string), ProviderSpecificFailoverInput providerSpecificDetails = default(ProviderSpecificFailoverInput))
        {
            FailoverDirection = failoverDirection;
            SourceSiteOperations = sourceSiteOperations;
            ProviderSpecificDetails = providerSpecificDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets failover direction.
        /// </summary>
        [JsonProperty(PropertyName = "failoverDirection")]
        public string FailoverDirection { get; set; }

        /// <summary>
        /// Gets or sets source site operations status
        /// </summary>
        [JsonProperty(PropertyName = "sourceSiteOperations")]
        public string SourceSiteOperations { get; set; }

        /// <summary>
        /// Gets or sets provider specific settings
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificDetails")]
        public ProviderSpecificFailoverInput ProviderSpecificDetails { get; set; }

    }
}
