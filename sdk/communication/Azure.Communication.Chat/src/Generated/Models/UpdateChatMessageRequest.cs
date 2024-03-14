// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Communication.Chat
{
    /// <summary> Request payload for updating a chat message. </summary>
    internal partial class UpdateChatMessageRequest
    {
        /// <summary> Initializes a new instance of <see cref="UpdateChatMessageRequest"/>. </summary>
        public UpdateChatMessageRequest()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="UpdateChatMessageRequest"/>. </summary>
        /// <param name="content"> Chat message content. </param>
        /// <param name="metadata"> Message metadata. </param>
        internal UpdateChatMessageRequest(string content, IDictionary<string, string> metadata)
        {
            Content = content;
            Metadata = metadata;
        }

        /// <summary> Chat message content. </summary>
        public string Content { get; set; }
        /// <summary> Message metadata. </summary>
        public IDictionary<string, string> Metadata { get; }
    }
}
