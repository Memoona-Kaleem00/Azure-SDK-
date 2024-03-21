// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Filter for the Event Subscription. </summary>
    public partial class EventSubscriptionFilter
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

        /// <summary> Initializes a new instance of <see cref="EventSubscriptionFilter"/>. </summary>
        public EventSubscriptionFilter()
        {
            IncludedEventTypes = new ChangeTrackingList<string>();
            AdvancedFilters = new ChangeTrackingList<AdvancedFilter>();
        }

        /// <summary> Initializes a new instance of <see cref="EventSubscriptionFilter"/>. </summary>
        /// <param name="subjectBeginsWith">
        /// An optional string to filter events for an event subscription based on a resource path prefix.
        /// The format of this depends on the publisher of the events.
        /// Wildcard characters are not supported in this path.
        /// </param>
        /// <param name="subjectEndsWith">
        /// An optional string to filter events for an event subscription based on a resource path suffix.
        /// Wildcard characters are not supported in this path.
        /// </param>
        /// <param name="includedEventTypes"> A list of applicable event types that need to be part of the event subscription. If it is desired to subscribe to all default event types, set the IncludedEventTypes to null. </param>
        /// <param name="isSubjectCaseSensitive">
        /// Specifies if the SubjectBeginsWith and SubjectEndsWith properties of the filter
        /// should be compared in a case sensitive manner.
        /// </param>
        /// <param name="isAdvancedFilteringOnArraysEnabled"> Allows advanced filters to be evaluated against an array of values instead of expecting a singular value. </param>
        /// <param name="advancedFilters">
        /// An array of advanced filters that are used for filtering event subscriptions.
        /// Please note <see cref="AdvancedFilter"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BoolEqualsAdvancedFilter"/>, <see cref="IsNotNullAdvancedFilter"/>, <see cref="IsNullOrUndefinedAdvancedFilter"/>, <see cref="NumberGreaterThanAdvancedFilter"/>, <see cref="NumberGreaterThanOrEqualsAdvancedFilter"/>, <see cref="NumberInAdvancedFilter"/>, <see cref="NumberInRangeAdvancedFilter"/>, <see cref="NumberLessThanAdvancedFilter"/>, <see cref="NumberLessThanOrEqualsAdvancedFilter"/>, <see cref="NumberNotInAdvancedFilter"/>, <see cref="NumberNotInRangeAdvancedFilter"/>, <see cref="StringBeginsWithAdvancedFilter"/>, <see cref="StringContainsAdvancedFilter"/>, <see cref="StringEndsWithAdvancedFilter"/>, <see cref="StringInAdvancedFilter"/>, <see cref="StringNotBeginsWithAdvancedFilter"/>, <see cref="StringNotContainsAdvancedFilter"/>, <see cref="StringNotEndsWithAdvancedFilter"/> and <see cref="StringNotInAdvancedFilter"/>.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventSubscriptionFilter(string subjectBeginsWith, string subjectEndsWith, IList<string> includedEventTypes, bool? isSubjectCaseSensitive, bool? isAdvancedFilteringOnArraysEnabled, IList<AdvancedFilter> advancedFilters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubjectBeginsWith = subjectBeginsWith;
            SubjectEndsWith = subjectEndsWith;
            IncludedEventTypes = includedEventTypes;
            IsSubjectCaseSensitive = isSubjectCaseSensitive;
            IsAdvancedFilteringOnArraysEnabled = isAdvancedFilteringOnArraysEnabled;
            AdvancedFilters = advancedFilters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// An optional string to filter events for an event subscription based on a resource path prefix.
        /// The format of this depends on the publisher of the events.
        /// Wildcard characters are not supported in this path.
        /// </summary>
        public string SubjectBeginsWith { get; set; }
        /// <summary>
        /// An optional string to filter events for an event subscription based on a resource path suffix.
        /// Wildcard characters are not supported in this path.
        /// </summary>
        public string SubjectEndsWith { get; set; }
        /// <summary> A list of applicable event types that need to be part of the event subscription. If it is desired to subscribe to all default event types, set the IncludedEventTypes to null. </summary>
        public IList<string> IncludedEventTypes { get; }
        /// <summary>
        /// Specifies if the SubjectBeginsWith and SubjectEndsWith properties of the filter
        /// should be compared in a case sensitive manner.
        /// </summary>
        public bool? IsSubjectCaseSensitive { get; set; }
        /// <summary> Allows advanced filters to be evaluated against an array of values instead of expecting a singular value. </summary>
        public bool? IsAdvancedFilteringOnArraysEnabled { get; set; }
        /// <summary>
        /// An array of advanced filters that are used for filtering event subscriptions.
        /// Please note <see cref="AdvancedFilter"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BoolEqualsAdvancedFilter"/>, <see cref="IsNotNullAdvancedFilter"/>, <see cref="IsNullOrUndefinedAdvancedFilter"/>, <see cref="NumberGreaterThanAdvancedFilter"/>, <see cref="NumberGreaterThanOrEqualsAdvancedFilter"/>, <see cref="NumberInAdvancedFilter"/>, <see cref="NumberInRangeAdvancedFilter"/>, <see cref="NumberLessThanAdvancedFilter"/>, <see cref="NumberLessThanOrEqualsAdvancedFilter"/>, <see cref="NumberNotInAdvancedFilter"/>, <see cref="NumberNotInRangeAdvancedFilter"/>, <see cref="StringBeginsWithAdvancedFilter"/>, <see cref="StringContainsAdvancedFilter"/>, <see cref="StringEndsWithAdvancedFilter"/>, <see cref="StringInAdvancedFilter"/>, <see cref="StringNotBeginsWithAdvancedFilter"/>, <see cref="StringNotContainsAdvancedFilter"/>, <see cref="StringNotEndsWithAdvancedFilter"/> and <see cref="StringNotInAdvancedFilter"/>.
        /// </summary>
        public IList<AdvancedFilter> AdvancedFilters { get; }
    }
}
