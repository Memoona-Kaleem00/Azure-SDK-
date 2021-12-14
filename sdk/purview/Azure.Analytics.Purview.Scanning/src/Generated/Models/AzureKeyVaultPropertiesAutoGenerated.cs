// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AzureKeyVaultPropertiesAutoGenerated. </summary>
    public partial class AzureKeyVaultPropertiesAutoGenerated
    {
        /// <summary> Initializes a new instance of AzureKeyVaultPropertiesAutoGenerated. </summary>
        public AzureKeyVaultPropertiesAutoGenerated()
        {
        }

        /// <summary> Initializes a new instance of AzureKeyVaultPropertiesAutoGenerated. </summary>
        /// <param name="baseUrl"></param>
        /// <param name="description"></param>
        internal AzureKeyVaultPropertiesAutoGenerated(string baseUrl, string description)
        {
            BaseUrl = baseUrl;
            Description = description;
        }

        /// <summary> Gets or sets the base url. </summary>
        public string BaseUrl { get; set; }
        /// <summary> Gets or sets the description. </summary>
        public string Description { get; set; }
    }
}
