// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A list of Notebook resources. </summary>
    public partial class NotebookListResponse
    {
        /// <summary> Initializes a new instance of NotebookListResponse. </summary>
        /// <param name="value"> List of Notebooks. </param>
        internal NotebookListResponse(IEnumerable<NotebookResource> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToArray();
        }

        /// <summary> Initializes a new instance of NotebookListResponse. </summary>
        /// <param name="value"> List of Notebooks. </param>
        /// <param name="nextLink"> The link to the next page of results, if any remaining results exist. </param>
        internal NotebookListResponse(IReadOnlyList<NotebookResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Notebooks. </summary>
        public IReadOnlyList<NotebookResource> Value { get; }
        /// <summary> The link to the next page of results, if any remaining results exist. </summary>
        public string NextLink { get; }
    }
}
