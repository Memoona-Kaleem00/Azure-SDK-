// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> The parameters used when calling recall action on server endpoint. </summary>
    public partial class RecallActionContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RecallActionContent"/>. </summary>
        public RecallActionContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecallActionContent"/>. </summary>
        /// <param name="pattern"> Pattern of the files. </param>
        /// <param name="recallPath"> Recall path. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RecallActionContent(string pattern, string recallPath, Dictionary<string, BinaryData> rawData)
        {
            Pattern = pattern;
            RecallPath = recallPath;
            _rawData = rawData;
        }

        /// <summary> Pattern of the files. </summary>
        public string Pattern { get; set; }
        /// <summary> Recall path. </summary>
        public string RecallPath { get; set; }
    }
}
