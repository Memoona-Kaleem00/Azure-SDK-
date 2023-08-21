// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Response of get metrics status Operation. </summary>
    public partial class NewRelicMetricsStatusResult
    {
        /// <summary> Initializes a new instance of NewRelicMetricsStatusResult. </summary>
        internal NewRelicMetricsStatusResult()
        {
            AzureResourceIds = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of NewRelicMetricsStatusResult. </summary>
        /// <param name="azureResourceIds"> Azure resource IDs. </param>
        internal NewRelicMetricsStatusResult(IReadOnlyList<string> azureResourceIds)
        {
            AzureResourceIds = azureResourceIds;
        }

        /// <summary> Azure resource IDs. </summary>
        public IReadOnlyList<string> AzureResourceIds { get; }
    }
}
