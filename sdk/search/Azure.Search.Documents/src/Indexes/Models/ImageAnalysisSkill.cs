﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class ImageAnalysisSkill
    {
        /// <summary> A list of visual features. </summary>
        [CodeGenMember(EmptyAsUndefined = true, Initialize = true)]
        public IList<VisualFeature> VisualFeatures { get; }

        /// <summary> A string indicating which domain-specific details to return. </summary>
        [CodeGenMember(EmptyAsUndefined = true, Initialize = true)]
        public IList<ImageDetail> Details { get; }
    }
}
