// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> The StringEncoded. </summary>
    internal partial class StringEncoded
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StringEncoded"/>. </summary>
        internal StringEncoded()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StringEncoded"/>. </summary>
        /// <param name="encoded"></param>
        /// <param name="content"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StringEncoded(bool? encoded, string content, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Encoded = encoded;
            Content = content;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the encoded. </summary>
        public bool? Encoded { get; }
        /// <summary> Gets the content. </summary>
        public string Content { get; }
    }
}
