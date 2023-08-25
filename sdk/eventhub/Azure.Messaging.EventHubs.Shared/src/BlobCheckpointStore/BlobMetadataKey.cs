﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Messaging.EventHubs.Primitives
{
    /// <summary>
    ///   The set of keys to access or modify metadata for a blob.
    /// </summary>
    ///
    /// <remarks>
    ///   The current storage SDK throws an exception when the key contains
    ///   an uppercase letter.
    /// </remarks>
    ///
    internal static class BlobMetadataKey
    {
        /// <summary>The key to the owner identifier metadata.</summary>
        public const string OwnerIdentifier = "ownerid";

        /// <summary>The key to the offset metadata.</summary>
        public const string Offset = "offset";

        /// <summary>The key to the sequence number metadata.</summary>
        public const string SequenceNumber = "sequencenumber";

        /// <summary>The unique identifier of the client that authored this checkpoint.</summary>
        public const string ClientAuthorIdentifier = "clientauthoridentifier";

        /// <summary>The replication segment associated with this checkpoint. Used in conjunction with the sequence number if using a geo replication enabled Event Hubs namespace.</summary>
        public const string ReplicationSegment = "replicationsegment";
    }
}
