// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary> It is a wrap up a Question Answering KB response. </summary>
    public partial class QuestionAnsweringTargetIntentResult : TargetIntentResult
    {
        /// <summary> Initializes a new instance of <see cref="QuestionAnsweringTargetIntentResult"/>. </summary>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        internal QuestionAnsweringTargetIntentResult(double confidence) : base(confidence)
        {
            TargetProjectKind = TargetProjectKind.QuestionAnswering;
        }

        /// <summary> Initializes a new instance of <see cref="QuestionAnsweringTargetIntentResult"/>. </summary>
        /// <param name="targetProjectKind"> This is the base class of an intent prediction. </param>
        /// <param name="apiVersion"> The API version used to call a target service. </param>
        /// <param name="confidence"> The prediction score and it ranges from 0.0 to 1.0. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="result"> The generated answer by a Question Answering KB. </param>
        internal QuestionAnsweringTargetIntentResult(TargetProjectKind targetProjectKind, string apiVersion, double confidence, IDictionary<string, BinaryData> serializedAdditionalRawData, AnswersResult result) : base(targetProjectKind, apiVersion, confidence, serializedAdditionalRawData)
        {
            Result = result;
        }

        /// <summary> Initializes a new instance of <see cref="QuestionAnsweringTargetIntentResult"/> for deserialization. </summary>
        internal QuestionAnsweringTargetIntentResult()
        {
        }

        /// <summary> The generated answer by a Question Answering KB. </summary>
        public AnswersResult Result { get; }
    }
}
