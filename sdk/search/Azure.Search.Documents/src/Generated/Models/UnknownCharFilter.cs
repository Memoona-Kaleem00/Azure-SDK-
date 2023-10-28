// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> The UnknownCharFilter. </summary>
    internal partial class UnknownCharFilter : CharFilter
    {
        /// <summary> Initializes a new instance of UnknownCharFilter. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the char filter. </param>
        /// <param name="name"> The name of the char filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal UnknownCharFilter(string oDataType, string name) : base(oDataType, name)
        {
            ODataType = oDataType ?? "Unknown";
        }
    }
}
