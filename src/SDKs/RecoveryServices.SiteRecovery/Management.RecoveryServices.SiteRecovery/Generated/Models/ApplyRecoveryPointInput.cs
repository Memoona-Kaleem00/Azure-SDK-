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
    /// Input to apply recovery point.
    /// </summary>
    public partial class ApplyRecoveryPointInput
    {
        /// <summary>
        /// Initializes a new instance of the ApplyRecoveryPointInput class.
        /// </summary>
        public ApplyRecoveryPointInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplyRecoveryPointInput class.
        /// </summary>
        /// <param name="properties">The input properties to apply recovery
        /// point.</param>
        public ApplyRecoveryPointInput(ApplyRecoveryPointInputProperties properties = default(ApplyRecoveryPointInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the input properties to apply recovery point.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ApplyRecoveryPointInputProperties Properties { get; set; }

    }
}
