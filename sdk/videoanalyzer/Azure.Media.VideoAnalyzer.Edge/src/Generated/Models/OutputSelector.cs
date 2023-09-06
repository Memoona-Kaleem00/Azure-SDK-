// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Allows for the selection of particular streams from another node. </summary>
    public partial class OutputSelector
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OutputSelector"/>. </summary>
        public OutputSelector()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OutputSelector"/>. </summary>
        /// <param name="property"> The property of the data stream to be used as the selection criteria. </param>
        /// <param name="operator"> The operator to compare properties by. </param>
        /// <param name="value"> Value to compare against. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OutputSelector(OutputSelectorProperty? property, OutputSelectorOperator? @operator, string value, Dictionary<string, BinaryData> rawData)
        {
            Property = property;
            Operator = @operator;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> The property of the data stream to be used as the selection criteria. </summary>
        public OutputSelectorProperty? Property { get; set; }
        /// <summary> The operator to compare properties by. </summary>
        public OutputSelectorOperator? Operator { get; set; }
        /// <summary> Value to compare against. </summary>
        public string Value { get; set; }
    }
}
