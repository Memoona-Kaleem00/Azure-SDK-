// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional information on Azure Workload for SQL specific backup item.
    /// </summary>
    public partial class AzureVmWorkloadProtectedItemExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AzureVmWorkloadProtectedItemExtendedInfo class.
        /// </summary>
        public AzureVmWorkloadProtectedItemExtendedInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AzureVmWorkloadProtectedItemExtendedInfo class.
        /// </summary>
        /// <param name="oldestRecoveryPoint">The oldest backup copy available
        /// for this backup item.</param>
        /// <param name="recoveryPointCount">Number of backup copies available
        /// for this backup item.</param>
        /// <param name="policyState">Indicates consistency of policy object
        /// and policy applied to this backup item.</param>
        /// <param name="recoveryModel">Indicates consistency of policy object
        /// and policy applied to this backup item.</param>
        public AzureVmWorkloadProtectedItemExtendedInfo(System.DateTime? oldestRecoveryPoint = default(System.DateTime?), int? recoveryPointCount = default(int?), string policyState = default(string), string recoveryModel = default(string))
        {
            OldestRecoveryPoint = oldestRecoveryPoint;
            RecoveryPointCount = recoveryPointCount;
            PolicyState = policyState;
            RecoveryModel = recoveryModel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the oldest backup copy available for this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "oldestRecoveryPoint")]
        public System.DateTime? OldestRecoveryPoint { get; set; }

        /// <summary>
        /// Gets or sets number of backup copies available for this backup
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointCount")]
        public int? RecoveryPointCount { get; set; }

        /// <summary>
        /// Gets or sets indicates consistency of policy object and policy
        /// applied to this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "policyState")]
        public string PolicyState { get; set; }

        /// <summary>
        /// Gets or sets indicates consistency of policy object and policy
        /// applied to this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryModel")]
        public string RecoveryModel { get; set; }

    }
}
