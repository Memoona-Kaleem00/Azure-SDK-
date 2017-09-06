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
    /// Enable protection input.
    /// </summary>
    public partial class EnableProtectionInput
    {
        /// <summary>
        /// Initializes a new instance of the EnableProtectionInput class.
        /// </summary>
        public EnableProtectionInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnableProtectionInput class.
        /// </summary>
        /// <param name="properties">Enable protection input
        /// properties.</param>
        public EnableProtectionInput(EnableProtectionInputProperties properties = default(EnableProtectionInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets enable protection input properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public EnableProtectionInputProperties Properties { get; set; }

    }
}
