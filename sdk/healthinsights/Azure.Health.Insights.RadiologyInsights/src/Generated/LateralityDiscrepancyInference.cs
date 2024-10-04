// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> The LateralityDiscrepancyInference. </summary>
    public partial class LateralityDiscrepancyInference : RadiologyInsightsInference
    {
        /// <summary> Initializes a new instance of <see cref="LateralityDiscrepancyInference"/>. </summary>
        /// <param name="discrepancyType"></param>
        internal LateralityDiscrepancyInference(LateralityDiscrepancyType discrepancyType)
        {
            Kind = RadiologyInsightsInferenceType.LateralityDiscrepancy;
            DiscrepancyType = discrepancyType;
        }

        /// <summary> Initializes a new instance of <see cref="LateralityDiscrepancyInference"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="extension"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="lateralityIndication"></param>
        /// <param name="discrepancyType"></param>
        internal LateralityDiscrepancyInference(RadiologyInsightsInferenceType kind, IReadOnlyList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, FhirR4CodeableConcept lateralityIndication, LateralityDiscrepancyType discrepancyType) : base(kind, extension, serializedAdditionalRawData)
        {
            LateralityIndication = lateralityIndication;
            DiscrepancyType = discrepancyType;
        }

        /// <summary> Initializes a new instance of <see cref="LateralityDiscrepancyInference"/> for deserialization. </summary>
        internal LateralityDiscrepancyInference()
        {
        }

        /// <summary> Gets the laterality indication. </summary>
        public FhirR4CodeableConcept LateralityIndication { get; }
        /// <summary> Gets the discrepancy type. </summary>
        public LateralityDiscrepancyType DiscrepancyType { get; }
    }
}
