// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The SystemClassificationRule. </summary>
    public partial class SystemClassificationRule : ClassificationRule
    {
        /// <summary> Initializes a new instance of SystemClassificationRule. </summary>
        public SystemClassificationRule()
        {
            Kind = ClassificationRuleType.System;
        }

        /// <summary> Initializes a new instance of SystemClassificationRule. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="properties"></param>
        internal SystemClassificationRule(string id, string name, ClassificationRuleType kind, SystemClassificationRulePropertiesAutoGenerated properties) : base(id, name, kind)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public SystemClassificationRulePropertiesAutoGenerated Properties { get; set; }
    }
}
