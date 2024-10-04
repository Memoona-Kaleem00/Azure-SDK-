// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> The CriticalResultInference. </summary>
    public partial class CriticalResultInference : RadiologyInsightsInference
    {
        /// <summary> Initializes a new instance of <see cref="CriticalResultInference"/>. </summary>
        /// <param name="result"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="result"/> is null. </exception>
        internal CriticalResultInference(CriticalResult result)
        {
            Argument.AssertNotNull(result, nameof(result));

            Kind = RadiologyInsightsInferenceType.CriticalResult;
            Result = result;
        }

        /// <summary> Initializes a new instance of <see cref="CriticalResultInference"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="extension"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="result"></param>
        internal CriticalResultInference(RadiologyInsightsInferenceType kind, IReadOnlyList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, CriticalResult result) : base(kind, extension, serializedAdditionalRawData)
        {
            Result = result;
        }

        /// <summary> Initializes a new instance of <see cref="CriticalResultInference"/> for deserialization. </summary>
        internal CriticalResultInference()
        {
        }

        /// <summary> Gets the result. </summary>
        public CriticalResult Result { get; }
    }
}
