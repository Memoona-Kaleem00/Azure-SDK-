// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureSqlDataWarehouseCredentialScan. </summary>
    public partial class AzureSqlDataWarehouseCredentialScan : Scan
    {
        /// <summary> Initializes a new instance of AzureSqlDataWarehouseCredentialScan. </summary>
        public AzureSqlDataWarehouseCredentialScan()
        {
            Kind = ScanAuthorizationType.AzureSqlDataWarehouseCredential;
        }

        /// <summary> Initializes a new instance of AzureSqlDataWarehouseCredentialScan. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="scanResults"></param>
        /// <param name="properties"></param>
        internal AzureSqlDataWarehouseCredentialScan(string id, string name, ScanAuthorizationType kind, IReadOnlyList<ScanResult> scanResults, AzureSqlDataWarehouseCredentialScanPropertiesAutoGenerated properties) : base(id, name, kind, scanResults)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public AzureSqlDataWarehouseCredentialScanPropertiesAutoGenerated Properties { get; set; }
    }
}
