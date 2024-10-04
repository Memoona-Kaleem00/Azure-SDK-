// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> The ClinicalTrialRegistryFilter. </summary>
    public partial class ClinicalTrialRegistryFilter
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

        /// <summary> Initializes a new instance of <see cref="ClinicalTrialRegistryFilter"/>. </summary>
        public ClinicalTrialRegistryFilter()
        {
            Conditions = new ChangeTrackingList<string>();
            StudyTypes = new ChangeTrackingList<ClinicalTrialStudyType>();
            RecruitmentStatuses = new ChangeTrackingList<ClinicalTrialRecruitmentStatus>();
            Sponsors = new ChangeTrackingList<string>();
            Phases = new ChangeTrackingList<ClinicalTrialPhase>();
            Purposes = new ChangeTrackingList<ClinicalTrialPurpose>();
            Ids = new ChangeTrackingList<string>();
            Sources = new ChangeTrackingList<ClinicalTrialSource>();
            FacilityNames = new ChangeTrackingList<string>();
            FacilityLocations = new ChangeTrackingList<GeographicLocation>();
            FacilityAreas = new ChangeTrackingList<GeographicArea>();
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalTrialRegistryFilter"/>. </summary>
        /// <param name="conditions"></param>
        /// <param name="studyTypes"></param>
        /// <param name="recruitmentStatuses"></param>
        /// <param name="sponsors"></param>
        /// <param name="phases"></param>
        /// <param name="purposes"></param>
        /// <param name="ids"></param>
        /// <param name="sources"></param>
        /// <param name="facilityNames"></param>
        /// <param name="facilityLocations"></param>
        /// <param name="facilityAreas"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClinicalTrialRegistryFilter(IList<string> conditions, IList<ClinicalTrialStudyType> studyTypes, IList<ClinicalTrialRecruitmentStatus> recruitmentStatuses, IList<string> sponsors, IList<ClinicalTrialPhase> phases, IList<ClinicalTrialPurpose> purposes, IList<string> ids, IList<ClinicalTrialSource> sources, IList<string> facilityNames, IList<GeographicLocation> facilityLocations, IList<GeographicArea> facilityAreas, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Conditions = conditions;
            StudyTypes = studyTypes;
            RecruitmentStatuses = recruitmentStatuses;
            Sponsors = sponsors;
            Phases = phases;
            Purposes = purposes;
            Ids = ids;
            Sources = sources;
            FacilityNames = facilityNames;
            FacilityLocations = facilityLocations;
            FacilityAreas = facilityAreas;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the conditions. </summary>
        public IList<string> Conditions { get; }
        /// <summary> Gets the study types. </summary>
        public IList<ClinicalTrialStudyType> StudyTypes { get; }
        /// <summary> Gets the recruitment statuses. </summary>
        public IList<ClinicalTrialRecruitmentStatus> RecruitmentStatuses { get; }
        /// <summary> Gets the sponsors. </summary>
        public IList<string> Sponsors { get; }
        /// <summary> Gets the phases. </summary>
        public IList<ClinicalTrialPhase> Phases { get; }
        /// <summary> Gets the purposes. </summary>
        public IList<ClinicalTrialPurpose> Purposes { get; }
        /// <summary> Gets the ids. </summary>
        public IList<string> Ids { get; }
        /// <summary> Gets the sources. </summary>
        public IList<ClinicalTrialSource> Sources { get; }
        /// <summary> Gets the facility names. </summary>
        public IList<string> FacilityNames { get; }
        /// <summary> Gets the facility locations. </summary>
        public IList<GeographicLocation> FacilityLocations { get; }
        /// <summary> Gets the facility areas. </summary>
        public IList<GeographicArea> FacilityAreas { get; }
    }
}
