// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication.MediaComposition.Models;

namespace Azure.Communication.MediaComposition
{
    /// <summary> Srt stream to be used as an output. </summary>
    public partial class SrtOutput : MediaOutput
    {
        /// <summary> Initializes a new instance of SrtOutput. </summary>
        /// <param name="resolution"> The dimensions of the scene or objects in the scene. </param>
        /// <param name="streamUrl"> The url of the stream. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resolution"/> or <paramref name="streamUrl"/> is null. </exception>
        public SrtOutput(LayoutResolution resolution, string streamUrl)
        {
            if (resolution == null)
            {
                throw new ArgumentNullException(nameof(resolution));
            }
            if (streamUrl == null)
            {
                throw new ArgumentNullException(nameof(streamUrl));
            }

            Resolution = resolution;
            StreamUrl = streamUrl;
            Kind = MediaOutputType.Srt;
        }

        /// <summary> Initializes a new instance of SrtOutput. </summary>
        /// <param name="kind"> Kind of media output. </param>
        /// <param name="resolution"> The dimensions of the scene or objects in the scene. </param>
        /// <param name="streamUrl"> The url of the stream. </param>
        internal SrtOutput(MediaOutputType kind, LayoutResolution resolution, string streamUrl) : base(kind)
        {
            Resolution = resolution;
            StreamUrl = streamUrl;
            Kind = kind;
        }

        /// <summary> The dimensions of the scene or objects in the scene. </summary>
        public LayoutResolution Resolution { get; set; }
        /// <summary> The url of the stream. </summary>
        public string StreamUrl { get; set; }
    }
}
