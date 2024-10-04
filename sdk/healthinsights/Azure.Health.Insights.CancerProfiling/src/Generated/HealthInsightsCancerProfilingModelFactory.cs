// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Health.Insights.CancerProfiling
{
    /// <summary> Model factory for models. </summary>
    public static partial class HealthInsightsCancerProfilingModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="CancerProfiling.PatientRecord"/>. </summary>
        /// <param name="id"></param>
        /// <param name="info"></param>
        /// <param name="data"></param>
        /// <returns> A new <see cref="CancerProfiling.PatientRecord"/> instance for mocking. </returns>
        public static PatientRecord PatientRecord(string id = null, PatientInfo info = null, IEnumerable<PatientDocument> data = null)
        {
            data ??= new List<PatientDocument>();

            return new PatientRecord(id, info, data?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CancerProfiling.PatientDocument"/>. </summary>
        /// <param name="type"></param>
        /// <param name="clinicalType"></param>
        /// <param name="id"></param>
        /// <param name="language"></param>
        /// <param name="createdDateTime"></param>
        /// <param name="content"></param>
        /// <returns> A new <see cref="CancerProfiling.PatientDocument"/> instance for mocking. </returns>
        public static PatientDocument PatientDocument(DocumentType type = default, ClinicalDocumentType? clinicalType = null, string id = null, string language = null, DateTimeOffset? createdDateTime = null, DocumentContent content = null)
        {
            return new PatientDocument(
                type,
                clinicalType,
                id,
                language,
                createdDateTime,
                content,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CancerProfiling.OncoPhenotypeResults"/>. </summary>
        /// <param name="patients"></param>
        /// <param name="modelVersion"></param>
        /// <returns> A new <see cref="CancerProfiling.OncoPhenotypeResults"/> instance for mocking. </returns>
        public static OncoPhenotypeResults OncoPhenotypeResults(IEnumerable<OncoPhenotypePatientResult> patients = null, string modelVersion = null)
        {
            patients ??= new List<OncoPhenotypePatientResult>();

            return new OncoPhenotypeResults(patients?.ToList(), modelVersion, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CancerProfiling.OncoPhenotypePatientResult"/>. </summary>
        /// <param name="id"></param>
        /// <param name="inferences"></param>
        /// <returns> A new <see cref="CancerProfiling.OncoPhenotypePatientResult"/> instance for mocking. </returns>
        public static OncoPhenotypePatientResult OncoPhenotypePatientResult(string id = null, IEnumerable<OncoPhenotypeInference> inferences = null)
        {
            inferences ??= new List<OncoPhenotypeInference>();

            return new OncoPhenotypePatientResult(id, inferences?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CancerProfiling.OncoPhenotypeInference"/>. </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        /// <param name="confidenceScore"></param>
        /// <param name="evidence"></param>
        /// <param name="caseId"></param>
        /// <returns> A new <see cref="CancerProfiling.OncoPhenotypeInference"/> instance for mocking. </returns>
        public static OncoPhenotypeInference OncoPhenotypeInference(OncoPhenotypeInferenceType type = default, string value = null, string description = null, float? confidenceScore = null, IEnumerable<InferenceEvidence> evidence = null, string caseId = null)
        {
            evidence ??= new List<InferenceEvidence>();

            return new OncoPhenotypeInference(
                type,
                value,
                description,
                confidenceScore,
                evidence?.ToList(),
                caseId,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CancerProfiling.InferenceEvidence"/>. </summary>
        /// <param name="patientDataEvidence"></param>
        /// <param name="patientInfoEvidence"></param>
        /// <param name="importance"></param>
        /// <returns> A new <see cref="CancerProfiling.InferenceEvidence"/> instance for mocking. </returns>
        public static InferenceEvidence InferenceEvidence(ClinicalNoteEvidence patientDataEvidence = null, ClinicalCodedElement patientInfoEvidence = null, float? importance = null)
        {
            return new InferenceEvidence(patientDataEvidence, patientInfoEvidence, importance, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CancerProfiling.ClinicalNoteEvidence"/>. </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <param name="offset"></param>
        /// <param name="length"></param>
        /// <returns> A new <see cref="CancerProfiling.ClinicalNoteEvidence"/> instance for mocking. </returns>
        public static ClinicalNoteEvidence ClinicalNoteEvidence(string id = null, string text = null, int offset = default, int length = default)
        {
            return new ClinicalNoteEvidence(id, text, offset, length, serializedAdditionalRawData: null);
        }
    }
}
