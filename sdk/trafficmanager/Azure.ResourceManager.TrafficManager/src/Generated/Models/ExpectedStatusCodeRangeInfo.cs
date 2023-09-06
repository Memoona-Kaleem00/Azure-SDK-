// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> Min and max value of a status code range. </summary>
    public partial class ExpectedStatusCodeRangeInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExpectedStatusCodeRangeInfo"/>. </summary>
        public ExpectedStatusCodeRangeInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExpectedStatusCodeRangeInfo"/>. </summary>
        /// <param name="min"> Min status code. </param>
        /// <param name="max"> Max status code. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpectedStatusCodeRangeInfo(int? min, int? max, Dictionary<string, BinaryData> rawData)
        {
            Min = min;
            Max = max;
            _rawData = rawData;
        }

        /// <summary> Min status code. </summary>
        public int? Min { get; set; }
        /// <summary> Max status code. </summary>
        public int? Max { get; set; }
    }
}
