// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureResourceGroupCredentialScan. </summary>
    public partial class AzureResourceGroupCredentialScan : Scan
    {
        /// <summary> Initializes a new instance of AzureResourceGroupCredentialScan. </summary>
        public AzureResourceGroupCredentialScan()
        {
            Kind = ScanAuthorizationType.AzureResourceGroupCredential;
        }

        /// <summary> Initializes a new instance of AzureResourceGroupCredentialScan. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="scanResults"></param>
        /// <param name="properties"></param>
        internal AzureResourceGroupCredentialScan(string id, string name, ScanAuthorizationType kind, IReadOnlyList<ScanResult> scanResults, AzureResourceGroupCredentialScanPropertiesAutoGenerated properties) : base(id, name, kind, scanResults)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public AzureResourceGroupCredentialScanPropertiesAutoGenerated Properties { get; set; }
    }
}
