// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A landmark recognized in the image.
    /// </summary>
    public partial class LandmarksModel
    {
        /// <summary>
        /// Initializes a new instance of the LandmarksModel class.
        /// </summary>
        public LandmarksModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LandmarksModel class.
        /// </summary>
        /// <param name="name">Name of the landmark.</param>
        /// <param name="confidence">Confidence level for the landmark
        /// recognition as a value ranging from 0 to 1.</param>
        public LandmarksModel(string name = default(string), double confidence = default(double))
        {
            Name = name;
            Confidence = confidence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the landmark.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets confidence level for the landmark recognition as a
        /// value ranging from 0 to 1.
        /// </summary>
        [JsonProperty(PropertyName = "confidence")]
        public double Confidence { get; set; }

    }
}
