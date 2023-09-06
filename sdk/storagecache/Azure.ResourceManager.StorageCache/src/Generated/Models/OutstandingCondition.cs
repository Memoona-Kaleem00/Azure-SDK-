// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Outstanding conditions that will need to be resolved. </summary>
    public partial class OutstandingCondition
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OutstandingCondition"/>. </summary>
        internal OutstandingCondition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OutstandingCondition"/>. </summary>
        /// <param name="timestamp"> The time when the condition was raised. </param>
        /// <param name="message"> The issue requiring attention. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OutstandingCondition(DateTimeOffset? timestamp, string message, Dictionary<string, BinaryData> rawData)
        {
            Timestamp = timestamp;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> The time when the condition was raised. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> The issue requiring attention. </summary>
        public string Message { get; }
    }
}
