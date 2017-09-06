// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Recovery plan test failover cleanup input.
    /// </summary>
    public partial class RecoveryPlanTestFailoverCleanupInput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanTestFailoverCleanupInput class.
        /// </summary>
        public RecoveryPlanTestFailoverCleanupInput()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryPlanTestFailoverCleanupInput class.
        /// </summary>
        /// <param name="properties">The recovery plan test failover cleanup
        /// input properties.</param>
        public RecoveryPlanTestFailoverCleanupInput(RecoveryPlanTestFailoverCleanupInputProperties properties)
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery plan test failover cleanup input
        /// properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RecoveryPlanTestFailoverCleanupInputProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
        }
    }
}
