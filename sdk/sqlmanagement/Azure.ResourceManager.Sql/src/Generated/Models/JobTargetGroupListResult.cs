// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of target groups. </summary>
    internal partial class JobTargetGroupListResult
    {
        /// <summary> Initializes a new instance of JobTargetGroupListResult. </summary>
        internal JobTargetGroupListResult()
        {
            Value = new ChangeTrackingList<SqlServerJobTargetGroupData>();
        }

        /// <summary> Initializes a new instance of JobTargetGroupListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal JobTargetGroupListResult(IReadOnlyList<SqlServerJobTargetGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlServerJobTargetGroupData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
