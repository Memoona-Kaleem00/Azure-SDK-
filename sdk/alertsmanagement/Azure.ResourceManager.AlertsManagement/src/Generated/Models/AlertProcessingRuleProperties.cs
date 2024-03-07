// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.AlertsManagement;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Alert processing rule properties defining scopes, conditions and scheduling logic for alert processing rule. </summary>
    public partial class AlertProcessingRuleProperties
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

        /// <summary> Initializes a new instance of <see cref="AlertProcessingRuleProperties"/>. </summary>
        /// <param name="scopes"> Scopes on which alert processing rule will apply. </param>
        /// <param name="actions">
        /// Actions to be applied.
        /// Please note <see cref="AlertProcessingRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AlertProcessingRuleAddGroupsAction"/> and <see cref="AlertProcessingRuleRemoveAllGroupsAction"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scopes"/> or <paramref name="actions"/> is null. </exception>
        public AlertProcessingRuleProperties(IEnumerable<string> scopes, IEnumerable<AlertProcessingRuleAction> actions)
        {
            Argument.AssertNotNull(scopes, nameof(scopes));
            Argument.AssertNotNull(actions, nameof(actions));

            Scopes = scopes.ToList();
            Conditions = new ChangeTrackingList<AlertProcessingRuleCondition>();
            Actions = actions.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AlertProcessingRuleProperties"/>. </summary>
        /// <param name="scopes"> Scopes on which alert processing rule will apply. </param>
        /// <param name="conditions"> Conditions on which alerts will be filtered. </param>
        /// <param name="schedule"> Scheduling for alert processing rule. </param>
        /// <param name="actions">
        /// Actions to be applied.
        /// Please note <see cref="AlertProcessingRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AlertProcessingRuleAddGroupsAction"/> and <see cref="AlertProcessingRuleRemoveAllGroupsAction"/>.
        /// </param>
        /// <param name="description"> Description of alert processing rule. </param>
        /// <param name="isEnabled"> Indicates if the given alert processing rule is enabled or disabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AlertProcessingRuleProperties(IList<string> scopes, IList<AlertProcessingRuleCondition> conditions, AlertProcessingRuleSchedule schedule, IList<AlertProcessingRuleAction> actions, string description, bool? isEnabled, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Scopes = scopes;
            Conditions = conditions;
            Schedule = schedule;
            Actions = actions;
            Description = description;
            IsEnabled = isEnabled;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AlertProcessingRuleProperties"/> for deserialization. </summary>
        internal AlertProcessingRuleProperties()
        {
        }

        /// <summary> Scopes on which alert processing rule will apply. </summary>
        public IList<string> Scopes { get; }
        /// <summary> Conditions on which alerts will be filtered. </summary>
        public IList<AlertProcessingRuleCondition> Conditions { get; }
        /// <summary> Scheduling for alert processing rule. </summary>
        public AlertProcessingRuleSchedule Schedule { get; set; }
        /// <summary>
        /// Actions to be applied.
        /// Please note <see cref="AlertProcessingRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AlertProcessingRuleAddGroupsAction"/> and <see cref="AlertProcessingRuleRemoveAllGroupsAction"/>.
        /// </summary>
        public IList<AlertProcessingRuleAction> Actions { get; }
        /// <summary> Description of alert processing rule. </summary>
        public string Description { get; set; }
        /// <summary> Indicates if the given alert processing rule is enabled or disabled. </summary>
        public bool? IsEnabled { get; set; }
    }
}
