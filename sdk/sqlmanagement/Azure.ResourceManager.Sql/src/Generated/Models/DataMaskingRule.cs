// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Represents a database data masking rule. </summary>
    public partial class DataMaskingRule : ResourceData
    {
        /// <summary> Initializes a new instance of DataMaskingRule. </summary>
        public DataMaskingRule()
        {
        }

        /// <summary> Initializes a new instance of DataMaskingRule. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the data masking rule. </param>
        /// <param name="kind"> The kind of Data Masking Rule. Metadata, used for Azure portal. </param>
        /// <param name="idPropertiesId"> The rule Id. </param>
        /// <param name="aliasName"> The alias name. This is a legacy parameter and is no longer used. </param>
        /// <param name="ruleState"> The rule state. Used to delete a rule. To delete an existing rule, specify the schemaName, tableName, columnName, maskingFunction, and specify ruleState as disabled. However, if the rule doesn&apos;t already exist, the rule will be created with ruleState set to enabled, regardless of the provided value of ruleState. </param>
        /// <param name="schemaName"> The schema name on which the data masking rule is applied. </param>
        /// <param name="tableName"> The table name on which the data masking rule is applied. </param>
        /// <param name="columnName"> The column name on which the data masking rule is applied. </param>
        /// <param name="maskingFunction"> The masking function that is used for the data masking rule. </param>
        /// <param name="numberFrom"> The numberFrom property of the masking rule. Required if maskingFunction is set to Number, otherwise this parameter will be ignored. </param>
        /// <param name="numberTo"> The numberTo property of the data masking rule. Required if maskingFunction is set to Number, otherwise this parameter will be ignored. </param>
        /// <param name="prefixSize"> If maskingFunction is set to Text, the number of characters to show unmasked in the beginning of the string. Otherwise, this parameter will be ignored. </param>
        /// <param name="suffixSize"> If maskingFunction is set to Text, the number of characters to show unmasked at the end of the string. Otherwise, this parameter will be ignored. </param>
        /// <param name="replacementString"> If maskingFunction is set to Text, the character to use for masking the unexposed part of the string. Otherwise, this parameter will be ignored. </param>
        internal DataMaskingRule(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string kind, string idPropertiesId, string aliasName, DataMaskingRuleState? ruleState, string schemaName, string tableName, string columnName, DataMaskingFunction? maskingFunction, string numberFrom, string numberTo, string prefixSize, string suffixSize, string replacementString) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Kind = kind;
            IdPropertiesId = idPropertiesId;
            AliasName = aliasName;
            RuleState = ruleState;
            SchemaName = schemaName;
            TableName = tableName;
            ColumnName = columnName;
            MaskingFunction = maskingFunction;
            NumberFrom = numberFrom;
            NumberTo = numberTo;
            PrefixSize = prefixSize;
            SuffixSize = suffixSize;
            ReplacementString = replacementString;
        }

        /// <summary> The location of the data masking rule. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The kind of Data Masking Rule. Metadata, used for Azure portal. </summary>
        public string Kind { get; }
        /// <summary> The rule Id. </summary>
        public string IdPropertiesId { get; }
        /// <summary> The alias name. This is a legacy parameter and is no longer used. </summary>
        public string AliasName { get; set; }
        /// <summary> The rule state. Used to delete a rule. To delete an existing rule, specify the schemaName, tableName, columnName, maskingFunction, and specify ruleState as disabled. However, if the rule doesn&apos;t already exist, the rule will be created with ruleState set to enabled, regardless of the provided value of ruleState. </summary>
        public DataMaskingRuleState? RuleState { get; set; }
        /// <summary> The schema name on which the data masking rule is applied. </summary>
        public string SchemaName { get; set; }
        /// <summary> The table name on which the data masking rule is applied. </summary>
        public string TableName { get; set; }
        /// <summary> The column name on which the data masking rule is applied. </summary>
        public string ColumnName { get; set; }
        /// <summary> The masking function that is used for the data masking rule. </summary>
        public DataMaskingFunction? MaskingFunction { get; set; }
        /// <summary> The numberFrom property of the masking rule. Required if maskingFunction is set to Number, otherwise this parameter will be ignored. </summary>
        public string NumberFrom { get; set; }
        /// <summary> The numberTo property of the data masking rule. Required if maskingFunction is set to Number, otherwise this parameter will be ignored. </summary>
        public string NumberTo { get; set; }
        /// <summary> If maskingFunction is set to Text, the number of characters to show unmasked in the beginning of the string. Otherwise, this parameter will be ignored. </summary>
        public string PrefixSize { get; set; }
        /// <summary> If maskingFunction is set to Text, the number of characters to show unmasked at the end of the string. Otherwise, this parameter will be ignored. </summary>
        public string SuffixSize { get; set; }
        /// <summary> If maskingFunction is set to Text, the character to use for masking the unexposed part of the string. Otherwise, this parameter will be ignored. </summary>
        public string ReplacementString { get; set; }
    }
}
