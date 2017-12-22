// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Check SKU availability result.
    /// </summary>
    public partial class CheckSkuAvailabilityResult
    {
        /// <summary>
        /// Initializes a new instance of the CheckSkuAvailabilityResult class.
        /// </summary>
        public CheckSkuAvailabilityResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckSkuAvailabilityResult class.
        /// </summary>
        /// <param name="kind">The Kind of the resource. Possible values
        /// include: 'Academic', 'Bing.Autosuggest', 'Bing.Autosuggest.v7',
        /// 'Bing.CustomSearch', 'Bing.Search', 'Bing.Search.v7',
        /// 'Bing.Speech', 'Bing.SpellCheck', 'Bing.SpellCheck.v7',
        /// 'ComputerVision', 'ContentModerator', 'CustomSpeech', 'Emotion',
        /// 'Face', 'LUIS', 'Recommendations', 'SpeakerRecognition', 'Speech',
        /// 'SpeechTranslation', 'TextAnalytics', 'TextTranslation',
        /// 'WebLM'</param>
        /// <param name="type">The Type of the resource.</param>
        /// <param name="skuName">The SKU of Cognitive Services account.
        /// Possible values include: 'F0', 'P0', 'P1', 'P2', 'S0', 'S1', 'S2',
        /// 'S3', 'S4', 'S5', 'S6'</param>
        /// <param name="skuAvailable">Indicates the given SKU is available or
        /// not.</param>
        /// <param name="reason">Reason why the SKU is not available.</param>
        /// <param name="message">Additional error message.</param>
        public CheckSkuAvailabilityResult(string kind = default(string), string type = default(string), string skuName = default(string), bool? skuAvailable = default(bool?), string reason = default(string), string message = default(string))
        {
            Kind = kind;
            Type = type;
            SkuName = skuName;
            SkuAvailable = skuAvailable;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Kind of the resource. Possible values include:
        /// 'Academic', 'Bing.Autosuggest', 'Bing.Autosuggest.v7',
        /// 'Bing.CustomSearch', 'Bing.Search', 'Bing.Search.v7',
        /// 'Bing.Speech', 'Bing.SpellCheck', 'Bing.SpellCheck.v7',
        /// 'ComputerVision', 'ContentModerator', 'CustomSpeech', 'Emotion',
        /// 'Face', 'LUIS', 'Recommendations', 'SpeakerRecognition', 'Speech',
        /// 'SpeechTranslation', 'TextAnalytics', 'TextTranslation', 'WebLM'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets the Type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the SKU of Cognitive Services account. Possible values
        /// include: 'F0', 'P0', 'P1', 'P2', 'S0', 'S1', 'S2', 'S3', 'S4',
        /// 'S5', 'S6'
        /// </summary>
        [JsonProperty(PropertyName = "skuName")]
        public string SkuName { get; set; }

        /// <summary>
        /// Gets or sets indicates the given SKU is available or not.
        /// </summary>
        [JsonProperty(PropertyName = "skuAvailable")]
        public bool? SkuAvailable { get; set; }

        /// <summary>
        /// Gets or sets reason why the SKU is not available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets additional error message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}
