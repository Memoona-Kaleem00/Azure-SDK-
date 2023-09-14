// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Enabled configuration. </summary>
    public partial class WebAppEnabledConfig
    {
        /// <summary> Initializes a new instance of WebAppEnabledConfig. </summary>
        public WebAppEnabledConfig()
        {
        }

        /// <summary> Initializes a new instance of WebAppEnabledConfig. </summary>
        /// <param name="enabled"> True if configuration is enabled, false if it is disabled and null if configuration is not set. </param>
        internal WebAppEnabledConfig(bool? enabled)
        {
            Enabled = enabled;
        }

        /// <summary> True if configuration is enabled, false if it is disabled and null if configuration is not set. </summary>
        public bool? Enabled { get; set; }
    }
}
