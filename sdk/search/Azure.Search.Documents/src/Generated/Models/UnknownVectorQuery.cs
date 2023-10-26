// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary> Unknown version of VectorQuery. </summary>
    internal partial class UnknownVectorQuery : VectorQuery
    {
        /// <summary> Initializes a new instance of UnknownVectorQuery. </summary>
        /// <param name="kind"> The kind of vector query being performed. </param>
        /// <param name="kNearestNeighborsCount"> Number of nearest neighbors to return as top hits. </param>
        /// <param name="fieldsRaw"> Vector Fields of type Collection(Edm.Single) to be included in the vector searched. </param>
        /// <param name="exhaustive"> When true, triggers an exhaustive k-nearest neighbor search across all vectors within the vector index. Useful for scenarios where exact matches are critical, such as determining ground truth values. </param>
        internal UnknownVectorQuery(VectorQueryKind kind, int? kNearestNeighborsCount, string fieldsRaw, bool? exhaustive) : base(kind, kNearestNeighborsCount, fieldsRaw, exhaustive)
        {
            Kind = kind;
        }
    }
}
