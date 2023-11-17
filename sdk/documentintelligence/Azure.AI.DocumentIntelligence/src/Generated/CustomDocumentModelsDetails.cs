// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Details regarding custom document models. </summary>
    public partial class CustomDocumentModelsDetails
    {
        /// <summary> Initializes a new instance of CustomDocumentModelsDetails. </summary>
        /// <param name="count"> Number of custom document models in the current resource. </param>
        /// <param name="limit"> Maximum number of custom document models supported in the current resource. </param>
        internal CustomDocumentModelsDetails(int count, int limit)
        {
            Count = count;
            Limit = limit;
        }

        /// <summary> Number of custom document models in the current resource. </summary>
        public int Count { get; }
        /// <summary> Maximum number of custom document models supported in the current resource. </summary>
        public int Limit { get; }
    }
}
