// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Video streaming holds information about video streaming URLs.
    /// </summary>
    public partial class VideoStreaming
    {
        /// <summary>
        /// Initializes a new instance of the VideoStreaming class.
        /// </summary>
        public VideoStreaming()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoStreaming class.
        /// </summary>
        /// <param name="archiveBaseUrl">Video streaming base URL for the video
        /// archive. When present, archived video can be played through the
        /// Azure Video Analyzer player. Alternatively, this URL can be used
        /// with compatible DASH or HLS players by appending the following to
        /// the base URL:
        ///
        /// - HLSv4:     /manifest(format=m3u8-aapl).m3u8
        /// - HLS CMAF:  /manifest(format=m3u8-cmaf)
        /// - DASH CMAF: /manifest(format=mpd-time-cmaf)
        ///
        /// Moreover, an ongoing video recording can be played in "live mode"
        /// with latencies which are approximately double of the chosen video
        /// segment length.</param>
        public VideoStreaming(string archiveBaseUrl = default(string))
        {
            ArchiveBaseUrl = archiveBaseUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets video streaming base URL for the video archive. When
        /// present, archived video can be played through the Azure Video
        /// Analyzer player. Alternatively, this URL can be used with
        /// compatible DASH or HLS players by appending the following to the
        /// base URL:
        ///
        /// - HLSv4:     /manifest(format=m3u8-aapl).m3u8
        /// - HLS CMAF:  /manifest(format=m3u8-cmaf)
        /// - DASH CMAF: /manifest(format=mpd-time-cmaf)
        ///
        /// Moreover, an ongoing video recording can be played in "live mode"
        /// with latencies which are approximately double of the chosen video
        /// segment length.
        /// </summary>
        [JsonProperty(PropertyName = "archiveBaseUrl")]
        public string ArchiveBaseUrl { get; set; }

    }
}
