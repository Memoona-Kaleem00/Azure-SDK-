// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> The ManualTriggerRequestBody. </summary>
    public partial class ManualTriggerRequestBody
    {
        /// <summary> Initializes a new instance of ManualTriggerRequestBody. </summary>
        public ManualTriggerRequestBody()
        {
        }

        /// <summary> Gets or sets the tenant id. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> Gets or sets the logic apps resource id. </summary>
        public string LogicAppsResourceId { get; set; }
    }
}
