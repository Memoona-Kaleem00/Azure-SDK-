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
    /// Switch protection input.
    /// </summary>
    public partial class SwitchProtectionInput
    {
        /// <summary>
        /// Initializes a new instance of the SwitchProtectionInput class.
        /// </summary>
        public SwitchProtectionInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SwitchProtectionInput class.
        /// </summary>
        /// <param name="properties">Switch protection properties</param>
        public SwitchProtectionInput(SwitchProtectionInputProperties properties = default(SwitchProtectionInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets switch protection properties
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public SwitchProtectionInputProperties Properties { get; set; }

    }
}
