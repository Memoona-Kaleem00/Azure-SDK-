// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureCosmosDbScanRuleset. </summary>
    public partial class AzureCosmosDbScanRuleset : ScanRuleset
    {
        /// <summary> Initializes a new instance of AzureCosmosDbScanRuleset. </summary>
        public AzureCosmosDbScanRuleset()
        {
            Kind = DataSourceType.AzureCosmosDb;
        }

        /// <summary> Initializes a new instance of AzureCosmosDbScanRuleset. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="scanRulesetType"></param>
        /// <param name="status"></param>
        /// <param name="version"></param>
        /// <param name="kind"></param>
        /// <param name="properties"></param>
        internal AzureCosmosDbScanRuleset(string id, string name, ScanRulesetType? scanRulesetType, ScanRulesetStatus? status, int? version, DataSourceType kind, AzureCosmosDbScanRulesetPropertiesAutoGenerated properties) : base(id, name, scanRulesetType, status, version, kind)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public AzureCosmosDbScanRulesetPropertiesAutoGenerated Properties { get; set; }
    }
}
