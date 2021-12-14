// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The ScanningRuleScanRulesetPropertiesScanningRule. </summary>
    public partial class ScanningRuleScanRulesetPropertiesScanningRule : ScanningRule
    {
        /// <summary> Initializes a new instance of ScanningRuleScanRulesetPropertiesScanningRule. </summary>
        public ScanningRuleScanRulesetPropertiesScanningRule()
        {
        }

        /// <summary> Initializes a new instance of ScanningRuleScanRulesetPropertiesScanningRule. </summary>
        /// <param name="fileExtensions"></param>
        /// <param name="customFileExtensions"></param>
        internal ScanningRuleScanRulesetPropertiesScanningRule(IList<FileExtensionsType> fileExtensions, IList<CustomFileExtension> customFileExtensions) : base(fileExtensions, customFileExtensions)
        {
        }
    }
}
