// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary>
    /// Details for all kinds of technology mediated contact points for a person or organization, including telephone, email, etc.
    /// See https://www.hl7.org/fhir/R4/datatypes.html#ContactPoint
    /// </summary>
    public partial class FhirR4ContactPoint
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

        /// <summary> Initializes a new instance of <see cref="FhirR4ContactPoint"/>. </summary>
        internal FhirR4ContactPoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4ContactPoint"/>. </summary>
        /// <param name="system"> phone | fax | email | pager | url | sms | other. </param>
        /// <param name="value"> The actual contact point details. </param>
        /// <param name="use"> home | work | temp | old | mobile - purpose of this contact point. </param>
        /// <param name="rank"> Specify preferred order of use (1 = highest). </param>
        /// <param name="period"> Time period when the contact point was/is in use. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FhirR4ContactPoint(ContactPointSystem? system, string value, ContactPointUse? use, int? rank, FhirR4Period period, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            System = system;
            Value = value;
            Use = use;
            Rank = rank;
            Period = period;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> phone | fax | email | pager | url | sms | other. </summary>
        public ContactPointSystem? System { get; }
        /// <summary> The actual contact point details. </summary>
        public string Value { get; }
        /// <summary> home | work | temp | old | mobile - purpose of this contact point. </summary>
        public ContactPointUse? Use { get; }
        /// <summary> Specify preferred order of use (1 = highest). </summary>
        public int? Rank { get; }
        /// <summary> Time period when the contact point was/is in use. </summary>
        public FhirR4Period Period { get; }
    }
}
