// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary>
    /// Detailed information about conditions, problems or diagnoses
    /// Based on [FHIR Condition](https://www.hl7.org/fhir/R4/condition.html)
    /// </summary>
    public partial class FhirR4Condition : FhirR4DomainResource
    {
        /// <summary> Initializes a new instance of <see cref="FhirR4Condition"/>. </summary>
        internal FhirR4Condition() : base("Condition")
        {
            Identifier = new ChangeTrackingList<FhirR4Identifier>();
            Category = new ChangeTrackingList<FhirR4CodeableConcept>();
            BodySite = new ChangeTrackingList<FhirR4CodeableConcept>();
            Stage = new ChangeTrackingList<FhirR4ConditionStage>();
            Note = new ChangeTrackingList<FhirR4Annotation>();
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4Condition"/>. </summary>
        /// <param name="resourceType"> The type of resource. </param>
        /// <param name="id"> Resource Id. </param>
        /// <param name="meta"> Metadata about the resource. </param>
        /// <param name="implicitRules"> A set of rules under which this content was created. </param>
        /// <param name="language"> Language of the resource content. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="text"> Text summary of the resource, for human interpretation. </param>
        /// <param name="contained"> Contained, inline Resources. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="modifierExtension"> Extensions that cannot be ignored. </param>
        /// <param name="identifier"> External Ids for this condition. </param>
        /// <param name="clinicalStatus"> active | recurrence | relapse | inactive | remission | resolved. </param>
        /// <param name="verificationStatus"> unconfirmed | provisional | differential | confirmed | refuted | entered-in-error. </param>
        /// <param name="category"> problem-list-item | encounter-diagnosis. </param>
        /// <param name="severity"> Subjective severity of condition. </param>
        /// <param name="code"> Identification of the condition, problem or diagnosis. </param>
        /// <param name="bodySite"> Anatomical location, if relevant. </param>
        /// <param name="encounter"> Encounter created as part of. </param>
        /// <param name="onsetDateTime"> Estimated or actual date,  date-time, or age. </param>
        /// <param name="onsetAge"> Estimated or actual date,  date-time, or age. </param>
        /// <param name="onsetPeriod"> Estimated or actual date,  date-time, or age. </param>
        /// <param name="onsetRange"> Estimated or actual date,  date-time, or age. </param>
        /// <param name="onsetString"> Estimated or actual date,  date-time, or age. </param>
        /// <param name="abatementDateTime"> When in resolution/remission. </param>
        /// <param name="abatementAge"> When in resolution/remission. </param>
        /// <param name="abatementPeriod"> When in resolution/remission. </param>
        /// <param name="abatementRange"> When in resolution/remission. </param>
        /// <param name="abatementString"> When in resolution/remission. </param>
        /// <param name="recordedDate"> Date record was first recorded. </param>
        /// <param name="stage"> stge/grade, usually assessed formally. </param>
        /// <param name="note"> Additional information about the Condition. </param>
        internal FhirR4Condition(string resourceType, string id, FhirR4Meta meta, string implicitRules, string language, IDictionary<string, BinaryData> additionalProperties, FhirR4Narrative text, IReadOnlyList<FhirR4Resource> contained, IReadOnlyList<FhirR4Extension> extension, IReadOnlyList<FhirR4Extension> modifierExtension, IReadOnlyList<FhirR4Identifier> identifier, FhirR4CodeableConcept clinicalStatus, FhirR4CodeableConcept verificationStatus, IReadOnlyList<FhirR4CodeableConcept> category, FhirR4CodeableConcept severity, FhirR4CodeableConcept code, IReadOnlyList<FhirR4CodeableConcept> bodySite, FhirR4Reference encounter, string onsetDateTime, FhirR4Quantity onsetAge, FhirR4Period onsetPeriod, FhirR4Range onsetRange, string onsetString, string abatementDateTime, FhirR4Quantity abatementAge, FhirR4Period abatementPeriod, FhirR4Range abatementRange, string abatementString, string recordedDate, IReadOnlyList<FhirR4ConditionStage> stage, IReadOnlyList<FhirR4Annotation> note) : base(resourceType, id, meta, implicitRules, language, additionalProperties, text, contained, extension, modifierExtension)
        {
            Identifier = identifier;
            ClinicalStatus = clinicalStatus;
            VerificationStatus = verificationStatus;
            Category = category;
            Severity = severity;
            Code = code;
            BodySite = bodySite;
            Encounter = encounter;
            OnsetDateTime = onsetDateTime;
            OnsetAge = onsetAge;
            OnsetPeriod = onsetPeriod;
            OnsetRange = onsetRange;
            OnsetString = onsetString;
            AbatementDateTime = abatementDateTime;
            AbatementAge = abatementAge;
            AbatementPeriod = abatementPeriod;
            AbatementRange = abatementRange;
            AbatementString = abatementString;
            RecordedDate = recordedDate;
            Stage = stage;
            Note = note;
        }

        /// <summary> External Ids for this condition. </summary>
        public IReadOnlyList<FhirR4Identifier> Identifier { get; }
        /// <summary> active | recurrence | relapse | inactive | remission | resolved. </summary>
        public FhirR4CodeableConcept ClinicalStatus { get; }
        /// <summary> unconfirmed | provisional | differential | confirmed | refuted | entered-in-error. </summary>
        public FhirR4CodeableConcept VerificationStatus { get; }
        /// <summary> problem-list-item | encounter-diagnosis. </summary>
        public IReadOnlyList<FhirR4CodeableConcept> Category { get; }
        /// <summary> Subjective severity of condition. </summary>
        public FhirR4CodeableConcept Severity { get; }
        /// <summary> Identification of the condition, problem or diagnosis. </summary>
        public FhirR4CodeableConcept Code { get; }
        /// <summary> Anatomical location, if relevant. </summary>
        public IReadOnlyList<FhirR4CodeableConcept> BodySite { get; }
        /// <summary> Encounter created as part of. </summary>
        public FhirR4Reference Encounter { get; }
        /// <summary> Estimated or actual date,  date-time, or age. </summary>
        public string OnsetDateTime { get; }
        /// <summary> Estimated or actual date,  date-time, or age. </summary>
        public FhirR4Quantity OnsetAge { get; }
        /// <summary> Estimated or actual date,  date-time, or age. </summary>
        public FhirR4Period OnsetPeriod { get; }
        /// <summary> Estimated or actual date,  date-time, or age. </summary>
        public FhirR4Range OnsetRange { get; }
        /// <summary> Estimated or actual date,  date-time, or age. </summary>
        public string OnsetString { get; }
        /// <summary> When in resolution/remission. </summary>
        public string AbatementDateTime { get; }
        /// <summary> When in resolution/remission. </summary>
        public FhirR4Quantity AbatementAge { get; }
        /// <summary> When in resolution/remission. </summary>
        public FhirR4Period AbatementPeriod { get; }
        /// <summary> When in resolution/remission. </summary>
        public FhirR4Range AbatementRange { get; }
        /// <summary> When in resolution/remission. </summary>
        public string AbatementString { get; }
        /// <summary> Date record was first recorded. </summary>
        public string RecordedDate { get; }
        /// <summary> stge/grade, usually assessed formally. </summary>
        public IReadOnlyList<FhirR4ConditionStage> Stage { get; }
        /// <summary> Additional information about the Condition. </summary>
        public IReadOnlyList<FhirR4Annotation> Note { get; }
    }
}
