// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> PNG image encoding. </summary>
    public partial class ImageFormatPng : ImageFormatProperties
    {
        /// <summary> Initializes a new instance of <see cref="ImageFormatPng"/>. </summary>
        public ImageFormatPng()
        {
            Type = "#Microsoft.VideoAnalyzer.ImageFormatPng";
        }

        /// <summary> Initializes a new instance of <see cref="ImageFormatPng"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageFormatPng(string type, Dictionary<string, BinaryData> rawData) : base(type, rawData)
        {
            Type = type ?? "#Microsoft.VideoAnalyzer.ImageFormatPng";
        }
    }
}
