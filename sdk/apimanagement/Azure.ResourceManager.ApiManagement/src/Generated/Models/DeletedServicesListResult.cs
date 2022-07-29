// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged deleted API Management Services List Representation. </summary>
    internal partial class DeletedServicesListResult
    {
        /// <summary> Initializes a new instance of DeletedServicesListResult. </summary>
        internal DeletedServicesListResult()
        {
            Value = new ChangeTrackingList<ApiManagementDeletedServiceData>();
        }

        /// <summary> Initializes a new instance of DeletedServicesListResult. </summary>
        /// <param name="value"> Page values. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        internal DeletedServicesListResult(IReadOnlyList<ApiManagementDeletedServiceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Page values. </summary>
        public IReadOnlyList<ApiManagementDeletedServiceData> Value { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
