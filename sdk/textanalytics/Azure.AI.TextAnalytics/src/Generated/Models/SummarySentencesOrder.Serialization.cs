// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics
{
    internal static partial class SummarySentencesOrderExtensions
    {
        public static string ToSerialString(this SummarySentencesOrder value) => value switch
        {
            SummarySentencesOrder.Offset => "offset",
            SummarySentencesOrder.Rank => "rank",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SummarySentencesOrder value.")
        };

        public static SummarySentencesOrder ToSummarySentencesOrder(this string value)
        {
            if (string.Equals(value, "offset", StringComparison.InvariantCultureIgnoreCase)) return SummarySentencesOrder.Offset;
            if (string.Equals(value, "rank", StringComparison.InvariantCultureIgnoreCase)) return SummarySentencesOrder.Rank;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SummarySentencesOrder value.");
        }
    }
}
