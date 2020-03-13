// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for an
    /// Microsoft.MachineLearningServices.RunStatusChanged event.
    /// </summary>
    public partial class MachineLearningServicesRunStatusChangedEventData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MachineLearningServicesRunStatusChangedEventData class.
        /// </summary>
        public MachineLearningServicesRunStatusChangedEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MachineLearningServicesRunStatusChangedEventData class.
        /// </summary>
        /// <param name="experimentId">The ID of the experiment that the
        /// Machine Learning Run belongs to.</param>
        /// <param name="experimentName">The name of the experiment that the
        /// Machine Learning Run belongs to.</param>
        /// <param name="runId">The ID of the Machine Learning Run.</param>
        /// <param name="runType">The Run Type of the Machine Learning
        /// Run.</param>
        /// <param name="runTags">The tags of the Machine Learning Run.</param>
        /// <param name="runProperties">The properties of the Machine Learning
        /// Run.</param>
        /// <param name="runStatus">The status of the Machine Learning
        /// Run.</param>
        public MachineLearningServicesRunStatusChangedEventData(string experimentId = default(string), string experimentName = default(string), string runId = default(string), string runType = default(string), object runTags = default(object), object runProperties = default(object), string runStatus = default(string))
        {
            ExperimentId = experimentId;
            ExperimentName = experimentName;
            RunId = runId;
            RunType = runType;
            RunTags = runTags;
            RunProperties = runProperties;
            RunStatus = runStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the experiment that the Machine Learning Run
        /// belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "experimentId")]
        public string ExperimentId { get; set; }

        /// <summary>
        /// Gets or sets the name of the experiment that the Machine Learning
        /// Run belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "experimentName")]
        public string ExperimentName { get; set; }

        /// <summary>
        /// Gets or sets the ID of the Machine Learning Run.
        /// </summary>
        [JsonProperty(PropertyName = "runId")]
        public string RunId { get; set; }

        /// <summary>
        /// Gets or sets the Run Type of the Machine Learning Run.
        /// </summary>
        [JsonProperty(PropertyName = "runType")]
        public string RunType { get; set; }

        /// <summary>
        /// Gets or sets the tags of the Machine Learning Run.
        /// </summary>
        [JsonProperty(PropertyName = "runTags")]
        public object RunTags { get; set; }

        /// <summary>
        /// Gets or sets the properties of the Machine Learning Run.
        /// </summary>
        [JsonProperty(PropertyName = "runProperties")]
        public object RunProperties { get; set; }

        /// <summary>
        /// Gets or sets the status of the Machine Learning Run.
        /// </summary>
        [JsonProperty(PropertyName = "runStatus")]
        public string RunStatus { get; set; }

    }
}
