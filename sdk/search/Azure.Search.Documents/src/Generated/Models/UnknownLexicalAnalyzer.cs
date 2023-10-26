// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Unknown version of LexicalAnalyzer. </summary>
    internal partial class UnknownLexicalAnalyzer : LexicalAnalyzer
    {
        /// <summary> Initializes a new instance of UnknownLexicalAnalyzer. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the analyzer. </param>
        /// <param name="name"> The name of the analyzer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal UnknownLexicalAnalyzer(string oDataType, string name) : base(oDataType, name)
        {
            ODataType = oDataType ?? "Unknown";
        }
    }
}
