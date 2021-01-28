// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Batch.Models
{
    /// <summary> signed identifier. </summary>
    internal partial class SignedIdentifier
    {
        /// <summary> Initializes a new instance of SignedIdentifier. </summary>
        /// <param name="id"> a unique id. </param>
        /// <param name="accessPolicy"> An Access policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="accessPolicy"/> is null. </exception>
        internal SignedIdentifier(string id, AccessPolicy accessPolicy)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (accessPolicy == null)
            {
                throw new ArgumentNullException(nameof(accessPolicy));
            }

            Id = id;
            AccessPolicy = accessPolicy;
        }

        /// <summary> a unique id. </summary>
        public string Id { get; }
        /// <summary> An Access policy. </summary>
        public AccessPolicy AccessPolicy { get; }
    }
}
