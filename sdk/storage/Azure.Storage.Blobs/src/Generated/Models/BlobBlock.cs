// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Represents a single block in a block blob.  It describes the block's ID and size. </summary>
    public readonly partial struct BlobBlock
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private readonly Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BlobBlock"/>. </summary>
        /// <param name="name"> The base64 encoded block ID. </param>
        /// <param name="sizeLong"> The block size in bytes. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal BlobBlock(string name, long sizeLong)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            SizeLong = sizeLong;
        }

        /// <summary> Initializes a new instance of <see cref="BlobBlock"/>. </summary>
        /// <param name="name"> The base64 encoded block ID. </param>
        /// <param name="sizeLong"> The block size in bytes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BlobBlock(string name, long sizeLong, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            SizeLong = sizeLong;
            _rawData = rawData;
        }
    }
}
