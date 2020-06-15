// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Response from a List Indexes request. If successful, it includes the full definitions of all indexes. </summary>
    internal partial class ListIndexesResult
    {
        /// <summary> Initializes a new instance of ListIndexesResult. </summary>
        /// <param name="indexes"> The indexes in the Search service. </param>
        internal ListIndexesResult(IEnumerable<SearchIndex> indexes)
        {
            if (indexes == null)
            {
                throw new ArgumentNullException(nameof(indexes));
            }

            Indexes = indexes.ToArray();
        }

        /// <summary> Initializes a new instance of ListIndexesResult. </summary>
        /// <param name="indexes"> The indexes in the Search service. </param>
        internal ListIndexesResult(IReadOnlyList<SearchIndex> indexes)
        {
            Indexes = indexes ?? new List<SearchIndex>();
        }

        /// <summary> The indexes in the Search service. </summary>
        public IReadOnlyList<SearchIndex> Indexes { get; }
    }
}
