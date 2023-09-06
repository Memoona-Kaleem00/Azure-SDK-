// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The KqlScriptsResourceCollectionResponse. </summary>
    internal partial class KqlScriptsResourceCollectionResponse
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KqlScriptsResourceCollectionResponse"/>. </summary>
        internal KqlScriptsResourceCollectionResponse()
        {
            Value = new ChangeTrackingList<KqlScriptResource>();
        }

        /// <summary> Initializes a new instance of <see cref="KqlScriptsResourceCollectionResponse"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KqlScriptsResourceCollectionResponse(IReadOnlyList<KqlScriptResource> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<KqlScriptResource> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
