// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The HealthcareEntityProperties. </summary>
    internal partial class HealthcareEntityProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HealthcareEntityProperties"/>. </summary>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="category"> Healthcare Entity Category. </param>
        /// <param name="offset"> Start position for the entity text. Use of different 'stringIndexType' values can affect the offset returned. </param>
        /// <param name="length"> Length for the entity text. Use of different 'stringIndexType' values can affect the length returned. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the extracted entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        internal HealthcareEntityProperties(string text, HealthcareEntityCategory category, int offset, int length, double confidenceScore)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
            Category = category;
            Offset = offset;
            Length = length;
            ConfidenceScore = confidenceScore;
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareEntityProperties"/>. </summary>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="category"> Healthcare Entity Category. </param>
        /// <param name="subcategory"> (Optional) Entity sub type. </param>
        /// <param name="offset"> Start position for the entity text. Use of different 'stringIndexType' values can affect the offset returned. </param>
        /// <param name="length"> Length for the entity text. Use of different 'stringIndexType' values can affect the length returned. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the extracted entity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthcareEntityProperties(string text, HealthcareEntityCategory category, string subcategory, int offset, int length, double confidenceScore, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            Category = category;
            Subcategory = subcategory;
            Offset = offset;
            Length = length;
            ConfidenceScore = confidenceScore;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HealthcareEntityProperties"/> for deserialization. </summary>
        internal HealthcareEntityProperties()
        {
        }

        /// <summary> Entity text as appears in the request. </summary>
        public string Text { get; }
        /// <summary> Healthcare Entity Category. </summary>
        public HealthcareEntityCategory Category { get; }
        /// <summary> (Optional) Entity sub type. </summary>
        public string Subcategory { get; }
        /// <summary> Start position for the entity text. Use of different 'stringIndexType' values can affect the offset returned. </summary>
        public int Offset { get; }
        /// <summary> Length for the entity text. Use of different 'stringIndexType' values can affect the length returned. </summary>
        public int Length { get; }
        /// <summary> Confidence score between 0 and 1 of the extracted entity. </summary>
        public double ConfidenceScore { get; }
    }
}
