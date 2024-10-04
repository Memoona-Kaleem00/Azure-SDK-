// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> The RadiologyInsightsModelConfiguration. </summary>
    public partial class RadiologyInsightsModelConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsModelConfiguration"/>. </summary>
        public RadiologyInsightsModelConfiguration()
        {
            InferenceTypes = new ChangeTrackingList<RadiologyInsightsInferenceType>();
        }

        /// <summary> Initializes a new instance of <see cref="RadiologyInsightsModelConfiguration"/>. </summary>
        /// <param name="verbose"></param>
        /// <param name="includeEvidence"></param>
        /// <param name="inferenceTypes"></param>
        /// <param name="inferenceOptions"></param>
        /// <param name="locale"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RadiologyInsightsModelConfiguration(bool? verbose, bool? includeEvidence, IList<RadiologyInsightsInferenceType> inferenceTypes, RadiologyInsightsInferenceOptions inferenceOptions, string locale, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Verbose = verbose;
            IncludeEvidence = includeEvidence;
            InferenceTypes = inferenceTypes;
            InferenceOptions = inferenceOptions;
            Locale = locale;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the verbose. </summary>
        public bool? Verbose { get; set; }
        /// <summary> Gets or sets the include evidence. </summary>
        public bool? IncludeEvidence { get; set; }
        /// <summary> Gets the inference types. </summary>
        public IList<RadiologyInsightsInferenceType> InferenceTypes { get; }
        /// <summary> Gets or sets the inference options. </summary>
        public RadiologyInsightsInferenceOptions InferenceOptions { get; set; }
        /// <summary> Gets or sets the locale. </summary>
        public string Locale { get; set; }
    }
}
