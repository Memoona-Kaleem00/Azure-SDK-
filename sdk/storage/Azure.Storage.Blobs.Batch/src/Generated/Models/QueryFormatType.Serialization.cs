// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Batch.Models
{
    internal static class QueryFormatTypeExtensions
    {
        public static string ToSerialString(this QueryFormatType value) => value switch
        {
            QueryFormatType.Delimited => "delimited",
            QueryFormatType.Json => "json",
            QueryFormatType.Arrow => "arrow",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown QueryFormatType value.")
        };

        public static QueryFormatType ToQueryFormatType(this string value)
        {
            if (string.Equals(value, "delimited", StringComparison.InvariantCultureIgnoreCase)) return QueryFormatType.Delimited;
            if (string.Equals(value, "json", StringComparison.InvariantCultureIgnoreCase)) return QueryFormatType.Json;
            if (string.Equals(value, "arrow", StringComparison.InvariantCultureIgnoreCase)) return QueryFormatType.Arrow;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown QueryFormatType value.");
        }
    }
}
