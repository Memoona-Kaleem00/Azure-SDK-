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
    /// Site details provided during the time of site creation
    /// </summary>
    public partial class FabricCreationInput
    {
        /// <summary>
        /// Initializes a new instance of the FabricCreationInput class.
        /// </summary>
        public FabricCreationInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FabricCreationInput class.
        /// </summary>
        /// <param name="properties">Fabric creation input.</param>
        public FabricCreationInput(FabricCreationInputProperties properties = default(FabricCreationInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets fabric creation input.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public FabricCreationInputProperties Properties { get; set; }

    }
}
