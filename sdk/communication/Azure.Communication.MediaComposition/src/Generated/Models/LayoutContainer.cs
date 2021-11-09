// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.MediaComposition.Models
{
    /// <summary> The Container. </summary>
    public partial class LayoutContainer
    {
        /// <summary> Initializes a new instance of LayoutContainer. </summary>
        public LayoutContainer()
        {
            SourceIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of LayoutContainer. </summary>
        /// <param name="position"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="sourceIds"></param>
        internal LayoutContainer(MediaPosition position, int? width, int? height, IList<string> sourceIds)
        {
            Position = position;
            Width = width;
            Height = height;
            SourceIds = sourceIds;
        }

        /// <summary> Gets or sets the position. </summary>
        public MediaPosition Position { get; set; }
        /// <summary> Gets or sets the width. </summary>
        public int? Width { get; set; }
        /// <summary> Gets or sets the height. </summary>
        public int? Height { get; set; }
        /// <summary> Gets the source ids. </summary>
        public IList<string> SourceIds { get; }
    }
}
