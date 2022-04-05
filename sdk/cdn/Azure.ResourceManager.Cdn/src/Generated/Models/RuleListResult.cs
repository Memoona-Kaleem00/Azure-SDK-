// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Result of the request to list rules. It contains a list of rule objects and a URL link to get the next set of results. </summary>
    internal partial class RuleListResult
    {
        /// <summary> Initializes a new instance of RuleListResult. </summary>
        internal RuleListResult()
        {
            Value = new ChangeTrackingList<AfdRuleData>();
        }

        /// <summary> Initializes a new instance of RuleListResult. </summary>
        /// <param name="value"> List of AzureFrontDoor rules within a rule set. </param>
        /// <param name="nextLink"> URL to get the next set of rule objects if there are any. </param>
        internal RuleListResult(IReadOnlyList<AfdRuleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of AzureFrontDoor rules within a rule set. </summary>
        public IReadOnlyList<AfdRuleData> Value { get; }
        /// <summary> URL to get the next set of rule objects if there are any. </summary>
        public string NextLink { get; }
    }
}
