// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureBlobDataFeedPatch. </summary>
    internal partial class AzureBlobDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of AzureBlobDataFeedPatch. </summary>
        public AzureBlobDataFeedPatch()
        {
            DataSourceType = DataFeedSourceType.AzureBlob;
        }

        public AzureBlobParameterPatch DataSourceParameter { get; set; }
    }
}
