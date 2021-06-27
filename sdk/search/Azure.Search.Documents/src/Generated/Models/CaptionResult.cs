// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    /// <summary> Captions are the most representative passages from the document relatively to the search query. They are often used as document summary. Captions are only returned for queries of type &apos;semantic&apos;.. </summary>
    public partial class CaptionResult
    {
        /// <summary> Initializes a new instance of CaptionResult. </summary>
        internal CaptionResult()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of CaptionResult. </summary>
        /// <param name="text"> A representative text passage extracted from the document most relevant to the search query. </param>
        /// <param name="highlights"> Same text passage as in the Text property with highlighted phrases most relevant to the query. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal CaptionResult(string text, string highlights, IReadOnlyDictionary<string, object> additionalProperties)
        {
            Text = text;
            Highlights = highlights;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> A representative text passage extracted from the document most relevant to the search query. </summary>
        public string Text { get; }
        /// <summary> Same text passage as in the Text property with highlighted phrases most relevant to the query. </summary>
        public string Highlights { get; }
        /// <summary> Additional Properties. </summary>
        public IReadOnlyDictionary<string, object> AdditionalProperties { get; }
    }
}
