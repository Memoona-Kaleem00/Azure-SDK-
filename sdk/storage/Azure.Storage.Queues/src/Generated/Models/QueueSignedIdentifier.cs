// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    /// <summary> signed identifier. </summary>
    public partial class QueueSignedIdentifier
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QueueSignedIdentifier"/>. </summary>
        /// <param name="id"> a unique id. </param>
        /// <param name="accessPolicy"> The access policy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QueueSignedIdentifier(string id, QueueAccessPolicy accessPolicy, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            AccessPolicy = accessPolicy;
            _rawData = rawData;
        }

        /// <summary> a unique id. </summary>
        public string Id { get; set; }
        /// <summary> The access policy. </summary>
        public QueueAccessPolicy AccessPolicy { get; set; }
    }
}
