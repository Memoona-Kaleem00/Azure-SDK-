// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;

namespace Azure.Communication.MediaComposition
{
    /// <summary> The MediaCompositionBody. </summary>
    public partial class MediaCompositionBody
    {
        /// <summary> Initializes a new instance of MediaCompositionBody. </summary>
        public MediaCompositionBody()
        {
            MediaInputs = new ChangeTrackingDictionary<string, MediaInput>();
            MediaOutputs = new ChangeTrackingDictionary<string, MediaOutput>();
            Sources = new ChangeTrackingDictionary<string, MediaSource>();
        }

        /// <summary> Initializes a new instance of MediaCompositionBody. </summary>
        /// <param name="id"></param>
        /// <param name="layout"></param>
        /// <param name="mediaInputs"> Dictionary of &lt;MediaInput&gt;. </param>
        /// <param name="mediaOutputs"> Dictionary of &lt;MediaOutput&gt;. </param>
        /// <param name="sources"> Dictionary of &lt;Source&gt;. </param>
        /// <param name="streamState"></param>
        internal MediaCompositionBody(string id, MediaLayout layout, IDictionary<string, MediaInput> mediaInputs, IDictionary<string, MediaOutput> mediaOutputs, IDictionary<string, MediaSource> sources, CompositionStreamState? streamState)
        {
            Id = id;
            Layout = layout;
            MediaInputs = mediaInputs;
            MediaOutputs = mediaOutputs;
            Sources = sources;
            StreamState = streamState;
        }

        /// <summary> Gets or sets the id. </summary>
        public string Id { get; set; }
        /// <summary> Gets or sets the layout. </summary>
        public MediaLayout Layout { get; set; }
        /// <summary> Dictionary of &lt;MediaInput&gt;. </summary>
        public IDictionary<string, MediaInput> MediaInputs { get; }
        /// <summary> Dictionary of &lt;MediaOutput&gt;. </summary>
        public IDictionary<string, MediaOutput> MediaOutputs { get; }
        /// <summary> Dictionary of &lt;Source&gt;. </summary>
        public IDictionary<string, MediaSource> Sources { get; }
        /// <summary> Gets or sets the stream state. </summary>
        public CompositionStreamState? StreamState { get; set; }
    }
}
