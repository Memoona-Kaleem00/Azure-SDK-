// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Network.Models
{
    /// <summary> Allow to exclude some variable satisfy the condition for the WAF check. </summary>
    public partial class OwaspCrsExclusionEntry
    {
        /// <summary> Initializes a new instance of OwaspCrsExclusionEntry. </summary>
        /// <param name="matchVariable"> The variable to be excluded. </param>
        /// <param name="selectorMatchOperator"> When matchVariable is a collection, operate on the selector to specify which elements in the collection this exclusion applies to. </param>
        /// <param name="selector"> When matchVariable is a collection, operator used to specify which elements in the collection this exclusion applies to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="selector"/> is null. </exception>
        public OwaspCrsExclusionEntry(OwaspCrsExclusionEntryMatchVariable matchVariable, OwaspCrsExclusionEntrySelectorMatchOperator selectorMatchOperator, string selector)
        {
            if (selector == null)
            {
                throw new ArgumentNullException(nameof(selector));
            }

            MatchVariable = matchVariable;
            SelectorMatchOperator = selectorMatchOperator;
            Selector = selector;
        }

        /// <summary> The variable to be excluded. </summary>
        public OwaspCrsExclusionEntryMatchVariable MatchVariable { get; set; }
        /// <summary> When matchVariable is a collection, operate on the selector to specify which elements in the collection this exclusion applies to. </summary>
        public OwaspCrsExclusionEntrySelectorMatchOperator SelectorMatchOperator { get; set; }
        /// <summary> When matchVariable is a collection, operator used to specify which elements in the collection this exclusion applies to. </summary>
        public string Selector { get; set; }
    }
}
