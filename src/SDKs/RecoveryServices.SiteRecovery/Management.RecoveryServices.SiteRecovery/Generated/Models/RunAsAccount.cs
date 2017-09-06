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
    /// CS Accounts Details.
    /// </summary>
    public partial class RunAsAccount
    {
        /// <summary>
        /// Initializes a new instance of the RunAsAccount class.
        /// </summary>
        public RunAsAccount()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RunAsAccount class.
        /// </summary>
        /// <param name="accountId">The CS RunAs account Id.</param>
        /// <param name="accountName">The CS RunAs account name.</param>
        public RunAsAccount(string accountId = default(string), string accountName = default(string))
        {
            AccountId = accountId;
            AccountName = accountName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the CS RunAs account Id.
        /// </summary>
        [JsonProperty(PropertyName = "accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets the CS RunAs account name.
        /// </summary>
        [JsonProperty(PropertyName = "accountName")]
        public string AccountName { get; set; }

    }
}
