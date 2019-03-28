// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Filter for the Event Subscription
    /// </summary>
    public partial class EventSubscriptionFilter
    {
        /// <summary>
        /// Initializes a new instance of the EventSubscriptionFilter class.
        /// </summary>
        public EventSubscriptionFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventSubscriptionFilter class.
        /// </summary>
        /// <param name="subjectBeginsWith">An optional string to filter events
        /// for an event subscription based on a resource path prefix.
        /// The format of this depends on the publisher of the events.
        /// Wildcard characters are not supported in this path.</param>
        /// <param name="subjectEndsWith">An optional string to filter events
        /// for an event subscription based on a resource path suffix.
        /// Wildcard characters are not supported in this path.</param>
        /// <param name="includedEventTypes">A list of applicable event types
        /// that need to be part of the event subscription.
        /// If it is desired to subscribe to all event types, the string "all"
        /// needs to be specified as an element in this list.</param>
        /// <param name="isSubjectCaseSensitive">Specifies if the
        /// SubjectBeginsWith and SubjectEndsWith properties of the filter
        /// should be compared in a case sensitive manner.</param>
        public EventSubscriptionFilter(string subjectBeginsWith = default(string), string subjectEndsWith = default(string), IList<string> includedEventTypes = default(IList<string>), bool? isSubjectCaseSensitive = default(bool?))
        {
            SubjectBeginsWith = subjectBeginsWith;
            SubjectEndsWith = subjectEndsWith;
            IncludedEventTypes = includedEventTypes;
            IsSubjectCaseSensitive = isSubjectCaseSensitive;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an optional string to filter events for an event
        /// subscription based on a resource path prefix.
        /// The format of this depends on the publisher of the events.
        /// Wildcard characters are not supported in this path.
        /// </summary>
        [JsonProperty(PropertyName = "subjectBeginsWith")]
        public string SubjectBeginsWith { get; set; }

        /// <summary>
        /// Gets or sets an optional string to filter events for an event
        /// subscription based on a resource path suffix.
        /// Wildcard characters are not supported in this path.
        /// </summary>
        [JsonProperty(PropertyName = "subjectEndsWith")]
        public string SubjectEndsWith { get; set; }

        /// <summary>
        /// Gets or sets a list of applicable event types that need to be part
        /// of the event subscription.
        /// If it is desired to subscribe to all event types, the string "all"
        /// needs to be specified as an element in this list.
        /// </summary>
        [JsonProperty(PropertyName = "includedEventTypes")]
        public IList<string> IncludedEventTypes { get; set; }

        /// <summary>
        /// Gets or sets specifies if the SubjectBeginsWith and SubjectEndsWith
        /// properties of the filter
        /// should be compared in a case sensitive manner.
        /// </summary>
        [JsonProperty(PropertyName = "isSubjectCaseSensitive")]
        public bool? IsSubjectCaseSensitive { get; set; }

    }
}
