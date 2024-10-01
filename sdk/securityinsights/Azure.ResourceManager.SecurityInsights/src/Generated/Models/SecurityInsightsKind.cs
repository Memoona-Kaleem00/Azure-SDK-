// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The kind of content the metadata is for. </summary>
    public readonly partial struct SecurityInsightsKind : IEquatable<SecurityInsightsKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityInsightsKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DataConnectorValue = "DataConnector";
        private const string DataTypeValue = "DataType";
        private const string WorkbookValue = "Workbook";
        private const string WorkbookTemplateValue = "WorkbookTemplate";
        private const string PlaybookValue = "Playbook";
        private const string PlaybookTemplateValue = "PlaybookTemplate";
        private const string AnalyticsRuleTemplateValue = "AnalyticsRuleTemplate";
        private const string AnalyticsRuleValue = "AnalyticsRule";
        private const string HuntingQueryValue = "HuntingQuery";
        private const string InvestigationQueryValue = "InvestigationQuery";
        private const string ParserValue = "Parser";
        private const string WatchlistValue = "Watchlist";
        private const string WatchlistTemplateValue = "WatchlistTemplate";
        private const string SolutionValue = "Solution";
        private const string AzureFunctionValue = "AzureFunction";
        private const string LogicAppsCustomConnectorValue = "LogicAppsCustomConnector";
        private const string AutomationRuleValue = "AutomationRule";

        /// <summary> DataConnector. </summary>
        public static SecurityInsightsKind DataConnector { get; } = new SecurityInsightsKind(DataConnectorValue);
        /// <summary> DataType. </summary>
        public static SecurityInsightsKind DataType { get; } = new SecurityInsightsKind(DataTypeValue);
        /// <summary> Workbook. </summary>
        public static SecurityInsightsKind Workbook { get; } = new SecurityInsightsKind(WorkbookValue);
        /// <summary> WorkbookTemplate. </summary>
        public static SecurityInsightsKind WorkbookTemplate { get; } = new SecurityInsightsKind(WorkbookTemplateValue);
        /// <summary> Playbook. </summary>
        public static SecurityInsightsKind Playbook { get; } = new SecurityInsightsKind(PlaybookValue);
        /// <summary> PlaybookTemplate. </summary>
        public static SecurityInsightsKind PlaybookTemplate { get; } = new SecurityInsightsKind(PlaybookTemplateValue);
        /// <summary> AnalyticsRuleTemplate. </summary>
        public static SecurityInsightsKind AnalyticsRuleTemplate { get; } = new SecurityInsightsKind(AnalyticsRuleTemplateValue);
        /// <summary> AnalyticsRule. </summary>
        public static SecurityInsightsKind AnalyticsRule { get; } = new SecurityInsightsKind(AnalyticsRuleValue);
        /// <summary> HuntingQuery. </summary>
        public static SecurityInsightsKind HuntingQuery { get; } = new SecurityInsightsKind(HuntingQueryValue);
        /// <summary> InvestigationQuery. </summary>
        public static SecurityInsightsKind InvestigationQuery { get; } = new SecurityInsightsKind(InvestigationQueryValue);
        /// <summary> Parser. </summary>
        public static SecurityInsightsKind Parser { get; } = new SecurityInsightsKind(ParserValue);
        /// <summary> Watchlist. </summary>
        public static SecurityInsightsKind Watchlist { get; } = new SecurityInsightsKind(WatchlistValue);
        /// <summary> WatchlistTemplate. </summary>
        public static SecurityInsightsKind WatchlistTemplate { get; } = new SecurityInsightsKind(WatchlistTemplateValue);
        /// <summary> Solution. </summary>
        public static SecurityInsightsKind Solution { get; } = new SecurityInsightsKind(SolutionValue);
        /// <summary> AzureFunction. </summary>
        public static SecurityInsightsKind AzureFunction { get; } = new SecurityInsightsKind(AzureFunctionValue);
        /// <summary> LogicAppsCustomConnector. </summary>
        public static SecurityInsightsKind LogicAppsCustomConnector { get; } = new SecurityInsightsKind(LogicAppsCustomConnectorValue);
        /// <summary> AutomationRule. </summary>
        public static SecurityInsightsKind AutomationRule { get; } = new SecurityInsightsKind(AutomationRuleValue);
        /// <summary> Determines if two <see cref="SecurityInsightsKind"/> values are the same. </summary>
        public static bool operator ==(SecurityInsightsKind left, SecurityInsightsKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityInsightsKind"/> values are not the same. </summary>
        public static bool operator !=(SecurityInsightsKind left, SecurityInsightsKind right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SecurityInsightsKind"/>. </summary>
        public static implicit operator SecurityInsightsKind(string value) => new SecurityInsightsKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityInsightsKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityInsightsKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
