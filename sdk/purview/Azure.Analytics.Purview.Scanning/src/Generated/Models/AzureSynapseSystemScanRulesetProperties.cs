// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureSynapseSystemScanRulesetProperties. </summary>
    public partial class AzureSynapseSystemScanRulesetProperties : AzureSynapseScanRulesetProperties
    {
        /// <summary> Initializes a new instance of AzureSynapseSystemScanRulesetProperties. </summary>
        public AzureSynapseSystemScanRulesetProperties()
        {
        }

        /// <summary> Initializes a new instance of AzureSynapseSystemScanRulesetProperties. </summary>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="excludedSystemClassifications"></param>
        /// <param name="includedCustomClassificationRuleNames"></param>
        /// <param name="lastModifiedAt"></param>
        internal AzureSynapseSystemScanRulesetProperties(DateTimeOffset? createdAt, string description, IList<string> excludedSystemClassifications, IList<string> includedCustomClassificationRuleNames, DateTimeOffset? lastModifiedAt) : base(createdAt, description, excludedSystemClassifications, includedCustomClassificationRuleNames, lastModifiedAt)
        {
        }
    }
}
