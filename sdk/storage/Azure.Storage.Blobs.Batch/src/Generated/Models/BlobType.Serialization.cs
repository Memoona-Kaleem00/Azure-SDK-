// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Batch.Models
{
    internal static class BlobTypeExtensions
    {
        public static string ToSerialString(this BlobType value) => value switch
        {
            BlobType.BlockBlob => "BlockBlob",
            BlobType.PageBlob => "PageBlob",
            BlobType.AppendBlob => "AppendBlob",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BlobType value.")
        };

        public static BlobType ToBlobType(this string value)
        {
            if (string.Equals(value, "BlockBlob", StringComparison.InvariantCultureIgnoreCase)) return BlobType.BlockBlob;
            if (string.Equals(value, "PageBlob", StringComparison.InvariantCultureIgnoreCase)) return BlobType.PageBlob;
            if (string.Equals(value, "AppendBlob", StringComparison.InvariantCultureIgnoreCase)) return BlobType.AppendBlob;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown BlobType value.");
        }
    }
}
