// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Supported parameters for a Language Detection task. </summary>
    internal partial class LanguageDetectionTaskParameters : PreBuiltTaskParameters
    {
        /// <summary> Initializes a new instance of <see cref="LanguageDetectionTaskParameters"/>. </summary>
        public LanguageDetectionTaskParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LanguageDetectionTaskParameters"/>. </summary>
        /// <param name="loggingOptOut"></param>
        /// <param name="modelVersion"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LanguageDetectionTaskParameters(bool? loggingOptOut, string modelVersion, Dictionary<string, BinaryData> rawData) : base(loggingOptOut, modelVersion, rawData)
        {
        }
    }
}
