// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.ResourceGraph;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    /// <summary> A facet whose execution resulted in an error. </summary>
    public partial class FacetError : Facet
    {
        /// <summary> Initializes a new instance of <see cref="FacetError"/>. </summary>
        /// <param name="expression"> Facet expression, same as in the corresponding facet request. </param>
        /// <param name="errors"> An array containing detected facet errors with details. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expression"/> or <paramref name="errors"/> is null. </exception>
        internal FacetError(string expression, IEnumerable<FacetErrorDetails> errors) : base(expression)
        {
            Argument.AssertNotNull(expression, nameof(expression));
            Argument.AssertNotNull(errors, nameof(errors));

            Errors = errors.ToList();
            ResultType = "FacetError";
        }

        /// <summary> Initializes a new instance of <see cref="FacetError"/>. </summary>
        /// <param name="expression"> Facet expression, same as in the corresponding facet request. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="errors"> An array containing detected facet errors with details. </param>
        internal FacetError(string expression, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<FacetErrorDetails> errors) : base(expression, resultType, serializedAdditionalRawData)
        {
            Errors = errors;
            ResultType = resultType ?? "FacetError";
        }

        /// <summary> Initializes a new instance of <see cref="FacetError"/> for deserialization. </summary>
        internal FacetError()
        {
        }

        /// <summary> An array containing detected facet errors with details. </summary>
        public IReadOnlyList<FacetErrorDetails> Errors { get; }
    }
}
