// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    /// <summary> Export operation configuration information. </summary>
    public partial class ServiceExportConfigurationInfo
    {
        /// <summary> Initializes a new instance of ServiceExportConfigurationInfo. </summary>
        public ServiceExportConfigurationInfo()
        {
        }

        /// <summary> Initializes a new instance of ServiceExportConfigurationInfo. </summary>
        /// <param name="storageAccountName"> The name of the default export storage account. </param>
        internal ServiceExportConfigurationInfo(string storageAccountName)
        {
            StorageAccountName = storageAccountName;
        }

        /// <summary> The name of the default export storage account. </summary>
        public string StorageAccountName { get; set; }
    }
}
