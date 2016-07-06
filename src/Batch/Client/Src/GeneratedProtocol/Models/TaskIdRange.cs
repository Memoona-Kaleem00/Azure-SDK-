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
    /// A range of task ids that a task can depend on. All tasks with ids in
    /// the range must complete successfully before the dependent task can be
    /// scheduled.
    /// </summary>
    public partial class TaskIdRange
    {
        /// <summary>
        /// Initializes a new instance of the TaskIdRange class.
        /// </summary>
        public TaskIdRange() { }

        /// <summary>
        /// Initializes a new instance of the TaskIdRange class.
        /// </summary>
        /// <param name="start">The first task id in the range.</param>
        /// <param name="end">The last task id in the range.</param>
        public TaskIdRange(int start, int end)
        {
            Start = start;
            End = end;
        }

        /// <summary>
        /// Gets or sets the first task id in the range.
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public int Start { get; set; }

        /// <summary>
        /// Gets or sets the last task id in the range.
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public int End { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
