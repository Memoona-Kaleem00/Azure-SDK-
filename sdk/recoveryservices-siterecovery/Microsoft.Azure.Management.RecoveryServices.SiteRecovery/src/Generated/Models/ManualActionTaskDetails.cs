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
    /// This class represents the manual action task details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ManualActionTaskDetails")]
    public partial class ManualActionTaskDetails : TaskTypeDetails
    {
        /// <summary>
        /// Initializes a new instance of the ManualActionTaskDetails class.
        /// </summary>
        public ManualActionTaskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManualActionTaskDetails class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="instructions">The instructions.</param>
        /// <param name="observation">The observation.</param>
        public ManualActionTaskDetails(string name = default(string), string instructions = default(string), string observation = default(string))
        {
            Name = name;
            Instructions = instructions;
            Observation = observation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the instructions.
        /// </summary>
        [JsonProperty(PropertyName = "instructions")]
        public string Instructions { get; set; }

        /// <summary>
        /// Gets or sets the observation.
        /// </summary>
        [JsonProperty(PropertyName = "observation")]
        public string Observation { get; set; }

    }
}
