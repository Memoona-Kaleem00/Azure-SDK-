// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Truncates the terms to a specific length. This token filter is implemented using Apache Lucene. </summary>
    public partial class TruncateTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of <see cref="TruncateTokenFilter"/>. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public TruncateTokenFilter(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ODataType = "#Microsoft.Azure.Search.TruncateTokenFilter";
        }

        /// <summary> Initializes a new instance of <see cref="TruncateTokenFilter"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="length"> The length at which terms will be truncated. Default and maximum is 300. </param>
        internal TruncateTokenFilter(string oDataType, string name, int? length) : base(oDataType, name)
        {
            Length = length;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.TruncateTokenFilter";
        }

        /// <summary> The length at which terms will be truncated. Default and maximum is 300. </summary>
        public int? Length { get; set; }
    }
}
