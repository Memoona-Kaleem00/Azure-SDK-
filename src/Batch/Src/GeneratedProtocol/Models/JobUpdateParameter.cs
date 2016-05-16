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
    /// Parameters for a CloudJobOperations.Update request.
    /// </summary>
    public partial class JobUpdateParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobUpdateParameter class.
        /// </summary>
        public JobUpdateParameter() { }

        /// <summary>
        /// Initializes a new instance of the JobUpdateParameter class.
        /// </summary>
        public JobUpdateParameter(PoolInformation poolInfo, int? priority = default(int?), JobConstraints constraints = default(JobConstraints), IList<MetadataItem> metadata = default(IList<MetadataItem>))
        {
            Priority = priority;
            Constraints = constraints;
            PoolInfo = poolInfo;
            Metadata = metadata;
        }

        /// <summary>
        /// Gets or sets the priority of the job. Priority values can range
        /// from -1000 to 1000, with -1000 being the lowest priority and 1000
        /// being the highest priority. If omitted, the priority of the job
        /// is left unchanged.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints for the job. If omitted,
        /// the existing execution constraints are left unchanged.
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public JobConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets the pool on which the Batch service runs the job's
        /// tasks. If omitted, the job continues to run on its current pool.
        /// </summary>
        [JsonProperty(PropertyName = "poolInfo")]
        public PoolInformation PoolInfo { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the job as
        /// metadata. If omitted, the existing job metadata is left unchanged.
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (PoolInfo == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PoolInfo");
            }
            if (this.PoolInfo != null)
            {
                this.PoolInfo.Validate();
            }
        }
    }
}
