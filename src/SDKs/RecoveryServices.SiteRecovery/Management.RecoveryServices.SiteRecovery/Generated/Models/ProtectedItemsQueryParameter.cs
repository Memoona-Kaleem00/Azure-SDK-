// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Query parameter to enumerate protected items.
    /// </summary>
    public partial class ProtectedItemsQueryParameter
    {
        /// <summary>
        /// Initializes a new instance of the ProtectedItemsQueryParameter
        /// class.
        /// </summary>
        public ProtectedItemsQueryParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProtectedItemsQueryParameter
        /// class.
        /// </summary>
        /// <param name="sourceFabricName">The source fabric name
        /// filter.</param>
        /// <param name="recoveryPlanName">The recovery plan filter.</param>
        /// <param name="vCenterName">The vCenter name filter.</param>
        /// <param name="instanceType">The replication provider type.</param>
        /// <param name="multiVmGroupCreateOption">Whether Multi VM group is
        /// auto created or specified by user. Possible values include:
        /// 'AutoCreated', 'UserSpecified'</param>
        public ProtectedItemsQueryParameter(string sourceFabricName = default(string), string recoveryPlanName = default(string), string vCenterName = default(string), string instanceType = default(string), MultiVmGroupCreateOption? multiVmGroupCreateOption = default(MultiVmGroupCreateOption?))
        {
            SourceFabricName = sourceFabricName;
            RecoveryPlanName = recoveryPlanName;
            VCenterName = vCenterName;
            InstanceType = instanceType;
            MultiVmGroupCreateOption = multiVmGroupCreateOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source fabric name filter.
        /// </summary>
        [JsonProperty(PropertyName = "sourceFabricName")]
        public string SourceFabricName { get; set; }

        /// <summary>
        /// Gets or sets the recovery plan filter.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPlanName")]
        public string RecoveryPlanName { get; set; }

        /// <summary>
        /// Gets or sets the vCenter name filter.
        /// </summary>
        [JsonProperty(PropertyName = "vCenterName")]
        public string VCenterName { get; set; }

        /// <summary>
        /// Gets or sets the replication provider type.
        /// </summary>
        [JsonProperty(PropertyName = "instanceType")]
        public string InstanceType { get; set; }

        /// <summary>
        /// Gets or sets whether Multi VM group is auto created or specified by
        /// user. Possible values include: 'AutoCreated', 'UserSpecified'
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupCreateOption")]
        public MultiVmGroupCreateOption? MultiVmGroupCreateOption { get; set; }

    }
}
