// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.Chat
{
    /// <summary> Collection of chat messages for a particular chat thread. </summary>
    internal partial class ChatMessagesCollection
    {
        /// <summary> Initializes a new instance of <see cref="ChatMessagesCollection"/>. </summary>
        /// <param name="value"> Collection of chat messages. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ChatMessagesCollection(IEnumerable<ChatMessageInternal> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ChatMessagesCollection"/>. </summary>
        /// <param name="value"> Collection of chat messages. </param>
        /// <param name="nextLink"> If there are more chat messages that can be retrieved, the next link will be populated. </param>
        internal ChatMessagesCollection(IReadOnlyList<ChatMessageInternal> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of chat messages. </summary>
        public IReadOnlyList<ChatMessageInternal> Value { get; }
        /// <summary> If there are more chat messages that can be retrieved, the next link will be populated. </summary>
        public string NextLink { get; }
    }
}
