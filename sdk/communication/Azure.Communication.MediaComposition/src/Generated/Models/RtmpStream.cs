// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Communication.MediaComposition.Models;

namespace Azure.Communication.MediaComposition
{
    /// <summary> The RtmpStream. </summary>
    public partial class RtmpStream
    {
        /// <summary> Initializes a new instance of RtmpStream. </summary>
        public RtmpStream()
        {
        }

        /// <summary> Initializes a new instance of RtmpStream. </summary>
        /// <param name="enableSsl"></param>
        /// <param name="streamUrl"></param>
        /// <param name="streamKey"></param>
        /// <param name="resolution"></param>
        /// <param name="mode"></param>
        internal RtmpStream(bool? enableSsl, string streamUrl, string streamKey, MediaResolution resolution, RtmpMode? mode)
        {
            EnableSsl = enableSsl;
            StreamUrl = streamUrl;
            StreamKey = streamKey;
            Resolution = resolution;
            Mode = mode;
        }

        /// <summary> Gets or sets the enable ssl. </summary>
        public bool? EnableSsl { get; set; }
        /// <summary> Gets or sets the stream url. </summary>
        public string StreamUrl { get; set; }
        /// <summary> Gets or sets the stream key. </summary>
        public string StreamKey { get; set; }
        /// <summary> Gets or sets the resolution. </summary>
        public MediaResolution Resolution { get; set; }
        /// <summary> Gets or sets the mode. </summary>
        public RtmpMode? Mode { get; set; }
    }
}
