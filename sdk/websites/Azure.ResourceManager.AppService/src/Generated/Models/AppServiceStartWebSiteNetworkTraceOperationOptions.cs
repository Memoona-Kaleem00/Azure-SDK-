// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A class representing the optional parameters in StartWebSiteNetworkTraceOperation method. </summary>
    public partial class AppServiceStartWebSiteNetworkTraceOperationOptions
    {
        /// <summary> Initializes a new instance of AppServiceStartWebSiteNetworkTraceOperationOptions. </summary>
        public AppServiceStartWebSiteNetworkTraceOperationOptions()
        {
        }

        /// <summary> The duration to keep capturing in seconds. </summary>
        public int? DurationInSeconds { get; set; }
        /// <summary> The maximum frame length in bytes (Optional). </summary>
        public int? MaxFrameLength { get; set; }
        /// <summary> The Blob URL to store capture file. </summary>
        public string SasUrl { get; set; }
    }
}
