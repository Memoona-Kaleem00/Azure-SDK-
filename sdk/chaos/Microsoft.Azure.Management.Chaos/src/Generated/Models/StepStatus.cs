// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Chaos.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Model that represents the a list of branches and branch statuses.
    /// </summary>
    public partial class StepStatus
    {
        /// <summary>
        /// Initializes a new instance of the StepStatus class.
        /// </summary>
        public StepStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StepStatus class.
        /// </summary>
        /// <param name="name">The name of the step.</param>
        /// <param name="id">The id of the step.</param>
        /// <param name="status">The value of the status of the step.</param>
        /// <param name="branches">The array of branches.</param>
        public StepStatus(string name = default(string), string id = default(string), string status = default(string), IList<BranchStatus> branches = default(IList<BranchStatus>))
        {
            Name = name;
            Id = id;
            Status = status;
            Branches = branches;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the step.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the id of the step.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the value of the status of the step.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the array of branches.
        /// </summary>
        [JsonProperty(PropertyName = "branches")]
        public IList<BranchStatus> Branches { get; private set; }

    }
}
