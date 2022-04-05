// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Microsoft.Azure.Management.HealthcareApis.Models
{
    /// <summary> A list of service description objects with a next link. </summary>
    public partial class ServicesDescriptionListResult
    {
        /// <summary> Initializes a new instance of ServicesDescriptionListResult. </summary>
        internal ServicesDescriptionListResult()
        {
            Value = new ChangeTrackingList<ServicesDescription>();
        }

        /// <summary> Initializes a new instance of ServicesDescriptionListResult. </summary>
        /// <param name="nextLink"> The link used to get the next page of service description objects. </param>
        /// <param name="value"> A list of service description objects. </param>
        internal ServicesDescriptionListResult(string nextLink, IReadOnlyList<ServicesDescription> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of service description objects. </summary>
        public string NextLink { get; }
        /// <summary> A list of service description objects. </summary>
        public IReadOnlyList<ServicesDescription> Value { get; }
    }
}
