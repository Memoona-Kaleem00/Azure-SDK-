// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a Upgrade Hint.
    /// </summary>
    public partial class UpgradeHint
    {
        /// <summary>
        /// Initializes a new instance of the UpgradeHint class.
        /// </summary>
        public UpgradeHint() { }

        /// <summary>
        /// Initializes a new instance of the UpgradeHint class.
        /// </summary>
        /// <param
        /// name="targetServiceLevelObjective">TargetServiceLevelObjective for
        /// upgrade hint.</param>
        /// <param
        /// name="targetServiceLevelObjectiveId">TargetServiceLevelObjectiveId
        /// for upgrade hint.</param>
        public UpgradeHint(string targetServiceLevelObjective = default(string), System.Guid? targetServiceLevelObjectiveId = default(System.Guid?))
        {
            TargetServiceLevelObjective = targetServiceLevelObjective;
            TargetServiceLevelObjectiveId = targetServiceLevelObjectiveId;
        }

        /// <summary>
        /// Gets or sets targetServiceLevelObjective for upgrade hint.
        /// </summary>
        [JsonProperty(PropertyName = "targetServiceLevelObjective")]
        public string TargetServiceLevelObjective { get; set; }

        /// <summary>
        /// Gets or sets targetServiceLevelObjectiveId for upgrade hint.
        /// </summary>
        [JsonProperty(PropertyName = "targetServiceLevelObjectiveId")]
        public System.Guid? TargetServiceLevelObjectiveId { get; set; }

    }
}
