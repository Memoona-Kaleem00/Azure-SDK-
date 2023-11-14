// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Result for utterances query. </summary>
    public partial class QueryUtterancesResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="QueryUtterancesResult"/>. </summary>
        public QueryUtterancesResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QueryUtterancesResult"/>. </summary>
        /// <param name="sampleUtterance"> A sample utterance. </param>
        /// <param name="score"> Score of a sample utterance. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryUtterancesResult(SampleUtterance sampleUtterance, float? score, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SampleUtterance = sampleUtterance;
            Score = score;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A sample utterance. </summary>
        public SampleUtterance SampleUtterance { get; set; }
        /// <summary> Score of a sample utterance. </summary>
        public float? Score { get; set; }
    }
}
