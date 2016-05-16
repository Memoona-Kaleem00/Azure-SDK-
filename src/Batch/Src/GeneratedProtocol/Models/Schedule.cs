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
    /// The schedule according to which jobs will be created
    /// </summary>
    public partial class Schedule
    {
        /// <summary>
        /// Initializes a new instance of the Schedule class.
        /// </summary>
        public Schedule() { }

        /// <summary>
        /// Initializes a new instance of the Schedule class.
        /// </summary>
        public Schedule(DateTime? doNotRunUntil = default(DateTime?), DateTime? doNotRunAfter = default(DateTime?), TimeSpan? startWindow = default(TimeSpan?), TimeSpan? recurrenceInterval = default(TimeSpan?))
        {
            DoNotRunUntil = doNotRunUntil;
            DoNotRunAfter = doNotRunAfter;
            StartWindow = startWindow;
            RecurrenceInterval = recurrenceInterval;
        }

        /// <summary>
        /// Gets or sets the earliest time at which any job may be created
        /// under this job schedule. If you do not specify a doNotRunUntil
        /// time, the schedule becomes ready to create jobs immediately.
        /// </summary>
        [JsonProperty(PropertyName = "doNotRunUntil")]
        public DateTime? DoNotRunUntil { get; set; }

        /// <summary>
        /// Gets or sets a time after which no job will be created under this
        /// job schedule. The schedule will move to the completed state as
        /// soon as this deadline is past and there is no active job under
        /// this job schedule.
        /// </summary>
        [JsonProperty(PropertyName = "doNotRunAfter")]
        public DateTime? DoNotRunAfter { get; set; }

        /// <summary>
        /// Gets or sets the time interval, starting from the time at which
        /// the schedule indicates a job should be created, within which a
        /// job must be created. If a job is not created within the
        /// startWindow interval, then the 'opportunity' is lost; no job will
        /// be created until the next recurrence of the schedule.
        /// </summary>
        [JsonProperty(PropertyName = "startWindow")]
        public TimeSpan? StartWindow { get; set; }

        /// <summary>
        /// Gets or sets the time interval between the start times of two
        /// successive jobs under the job schedule. A job schedule can have
        /// at most one active job under it at any given time.
        /// </summary>
        [JsonProperty(PropertyName = "recurrenceInterval")]
        public TimeSpan? RecurrenceInterval { get; set; }

    }
}
