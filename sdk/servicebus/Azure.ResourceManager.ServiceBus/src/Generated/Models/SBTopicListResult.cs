// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> The response to the List Topics operation. </summary>
    internal partial class SBTopicListResult
    {
        /// <summary> Initializes a new instance of SBTopicListResult. </summary>
        internal SBTopicListResult()
        {
            Value = new ChangeTrackingList<SBTopicData>();
        }

        /// <summary> Initializes a new instance of SBTopicListResult. </summary>
        /// <param name="value"> Result of the List Topics operation. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of topics. </param>
        internal SBTopicListResult(IReadOnlyList<SBTopicData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Result of the List Topics operation. </summary>
        public IReadOnlyList<SBTopicData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of topics. </summary>
        public string NextLink { get; }
    }
}
