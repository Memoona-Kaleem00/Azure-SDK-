// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IoT recommendation
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IotRecommendationModel : Resource
    {
        /// <summary>
        /// Initializes a new instance of the IotRecommendationModel class.
        /// </summary>
        public IotRecommendationModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotRecommendationModel class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="deviceId">Identifier of the device being reported
        /// on</param>
        /// <param name="recommendationType">The type name of the
        /// recommendation</param>
        /// <param name="discoveredTimeUtc">The discovery time of the
        /// recommendation</param>
        /// <param name="recommendationAdditionalData">A bag of fields which
        /// extends the recommendation information</param>
        public IotRecommendationModel(string id = default(string), string name = default(string), string type = default(string), string deviceId = default(string), string recommendationType = default(string), string discoveredTimeUtc = default(string), object recommendationAdditionalData = default(object))
            : base(id, name, type)
        {
            DeviceId = deviceId;
            RecommendationType = recommendationType;
            DiscoveredTimeUtc = discoveredTimeUtc;
            RecommendationAdditionalData = recommendationAdditionalData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets identifier of the device being reported on
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceId")]
        public string DeviceId { get; private set; }

        /// <summary>
        /// Gets the type name of the recommendation
        /// </summary>
        [JsonProperty(PropertyName = "properties.recommendationType")]
        public string RecommendationType { get; private set; }

        /// <summary>
        /// Gets the discovery time of the recommendation
        /// </summary>
        [JsonProperty(PropertyName = "properties.discoveredTimeUtc")]
        public string DiscoveredTimeUtc { get; private set; }

        /// <summary>
        /// Gets or sets a bag of fields which extends the recommendation
        /// information
        /// </summary>
        [JsonProperty(PropertyName = "properties.recommendationAdditionalData")]
        public object RecommendationAdditionalData { get; set; }

    }
}
