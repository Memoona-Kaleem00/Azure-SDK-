// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.AccessControl.Models
{
    /// <summary> Role Assignment response details. </summary>
    public partial class RoleAssignmentDetailsList
    {
        /// <summary> Initializes a new instance of RoleAssignmentDetailsList. </summary>
        internal RoleAssignmentDetailsList()
        {
            Value = new ChangeTrackingList<RoleAssignmentDetails>();
        }

        /// <summary> Initializes a new instance of RoleAssignmentDetailsList. </summary>
        /// <param name="count"> Number of role assignments. </param>
        /// <param name="value"> A list of role assignments. </param>
        internal RoleAssignmentDetailsList(int? count, IReadOnlyList<RoleAssignmentDetails> value)
        {
            Count = count;
            Value = value;
        }

        /// <summary> Number of role assignments. </summary>
        public int? Count { get; }
        /// <summary> A list of role assignments. </summary>
        public IReadOnlyList<RoleAssignmentDetails> Value { get; }
    }
}
