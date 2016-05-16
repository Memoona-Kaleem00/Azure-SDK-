// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Contains utilization and resource usage statistics for the lifetime of
    /// a pool.
    /// </summary>
    public partial class PoolStatistics
    {
        /// <summary>
        /// Initializes a new instance of the PoolStatistics class.
        /// </summary>
        public PoolStatistics() { }

        /// <summary>
        /// Initializes a new instance of the PoolStatistics class.
        /// </summary>
        public PoolStatistics(string url, DateTime startTime, DateTime lastUpdateTime, UsageStatistics usageStats = default(UsageStatistics), ResourceStatistics resourceStats = default(ResourceStatistics))
        {
            Url = url;
            StartTime = startTime;
            LastUpdateTime = lastUpdateTime;
            UsageStats = usageStats;
            ResourceStats = resourceStats;
        }

        /// <summary>
        /// Gets or sets the URL for the statistics.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the start time of the time range covered by the
        /// statistics.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the statistics were last updated.
        /// All statistics are limited to the range between startTime and
        /// lastUpdateTime.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// Gets or sets statistics related to pool usage, such as the amount
        /// of core-time used.
        /// </summary>
        [JsonProperty(PropertyName = "usageStats")]
        public UsageStatistics UsageStats { get; set; }

        /// <summary>
        /// Gets or sets statistics related to resource consumption by compute
        /// nodes in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "resourceStats")]
        public ResourceStatistics ResourceStats { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Url == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Url");
            }
            if (this.UsageStats != null)
            {
                this.UsageStats.Validate();
            }
            if (this.ResourceStats != null)
            {
                this.ResourceStats.Validate();
            }
        }
    }
}
