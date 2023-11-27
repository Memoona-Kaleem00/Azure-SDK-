// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CostManagement;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Result of listing exports. It contains a list of available exports in the scope provided. </summary>
    internal partial class ExportListResult
    {
        /// <summary> Initializes a new instance of <see cref="ExportListResult"/>. </summary>
        internal ExportListResult()
        {
            Value = new ChangeTrackingList<CostManagementExportData>();
        }

        /// <summary> Initializes a new instance of <see cref="ExportListResult"/>. </summary>
        /// <param name="value"> The list of exports. </param>
        internal ExportListResult(IReadOnlyList<CostManagementExportData> value)
        {
            Value = value;
        }

        /// <summary> The list of exports. </summary>
        public IReadOnlyList<CostManagementExportData> Value { get; }
    }
}
