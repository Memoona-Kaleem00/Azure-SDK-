// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The UnknownCopyTranslator. </summary>
    internal partial class UnknownCopyTranslator : CopyTranslator
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCopyTranslator"/>. </summary>
        /// <param name="type"> Copy translator type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownCopyTranslator(string type, IDictionary<string, object> additionalProperties) : base(type, additionalProperties)
        {
            Type = type ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownCopyTranslator"/> for deserialization. </summary>
        internal UnknownCopyTranslator()
        {
        }
    }
}
