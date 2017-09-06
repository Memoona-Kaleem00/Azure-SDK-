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
    /// Unpairing input properties.
    /// </summary>
    public partial class RemoveProtectionContainerMappingInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RemoveProtectionContainerMappingInputProperties class.
        /// </summary>
        public RemoveProtectionContainerMappingInputProperties()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RemoveProtectionContainerMappingInputProperties class.
        /// </summary>
        /// <param name="providerSpecificInput">Provider specific input for
        /// unpairing.</param>
        public RemoveProtectionContainerMappingInputProperties(ReplicationProviderContainerUnmappingInput providerSpecificInput = default(ReplicationProviderContainerUnmappingInput))
        {
            ProviderSpecificInput = providerSpecificInput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets provider specific input for unpairing.
        /// </summary>
        [JsonProperty(PropertyName = "providerSpecificInput")]
        public ReplicationProviderContainerUnmappingInput ProviderSpecificInput { get; set; }

    }
}
