// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> Unknown version of DataChangeDetectionPolicy. </summary>
    internal partial class UnknownDataChangeDetectionPolicy : DataChangeDetectionPolicy
    {
        /// <summary> Initializes a new instance of <see cref="UnknownDataChangeDetectionPolicy"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of data change detection policy. </param>
        internal UnknownDataChangeDetectionPolicy(string oDataType) : base(oDataType)
        {
            ODataType = oDataType ?? "Unknown";
        }
    }
}
