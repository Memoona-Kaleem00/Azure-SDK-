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
    /// Parameters for a CloudPoolOperations.EnableAutoScale request.
    /// </summary>
    public partial class PoolEnableAutoScaleParameter
    {
        /// <summary>
        /// Initializes a new instance of the PoolEnableAutoScaleParameter
        /// class.
        /// </summary>
        public PoolEnableAutoScaleParameter() { }

        /// <summary>
        /// Initializes a new instance of the PoolEnableAutoScaleParameter
        /// class.
        /// </summary>
        /// <param name="autoScaleFormula">The formula for the desired number of compute nodes in the pool.</param>
        /// <param name="autoScaleEvaluationInterval">A time interval for the desired autoscale evaluation period in the pool.</param>
        public PoolEnableAutoScaleParameter(string autoScaleFormula = default(string), TimeSpan? autoScaleEvaluationInterval = default(TimeSpan?))
        {
            AutoScaleFormula = autoScaleFormula;
            AutoScaleEvaluationInterval = autoScaleEvaluationInterval;
        }

        /// <summary>
        /// Gets or sets the formula for the desired number of compute nodes
        /// in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "autoScaleFormula")]
        public string AutoScaleFormula { get; set; }

        /// <summary>
        /// Gets or sets a time interval for the desired autoscale evaluation
        /// period in the pool.
        /// </summary>
        [JsonProperty(PropertyName = "autoScaleEvaluationInterval")]
        public TimeSpan? AutoScaleEvaluationInterval { get; set; }

    }
}
