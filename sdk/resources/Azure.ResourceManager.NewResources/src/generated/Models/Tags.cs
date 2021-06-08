// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewResources
{
    /// <summary> A dictionary of name and value pairs. </summary>
    internal partial class Tags
    {
        /// <summary> Initializes a new instance of Tags. </summary>
        internal Tags()
        {
            TagsValue = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> TagsValue { get; }
    }
}
