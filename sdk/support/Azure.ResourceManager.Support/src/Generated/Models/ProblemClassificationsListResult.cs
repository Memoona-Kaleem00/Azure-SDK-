// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Support;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Collection of ProblemClassification resources. </summary>
    internal partial class ProblemClassificationsListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ProblemClassificationsListResult"/>. </summary>
        internal ProblemClassificationsListResult()
        {
            Value = new ChangeTrackingList<ProblemClassificationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ProblemClassificationsListResult"/>. </summary>
        /// <param name="value"> List of ProblemClassification resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ProblemClassificationsListResult(IReadOnlyList<ProblemClassificationData> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> List of ProblemClassification resources. </summary>
        public IReadOnlyList<ProblemClassificationData> Value { get; }
    }
}
