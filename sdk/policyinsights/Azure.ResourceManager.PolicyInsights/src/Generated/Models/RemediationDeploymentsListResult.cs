// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> List of deployments for a remediation. </summary>
    internal partial class RemediationDeploymentsListResult
    {
        /// <summary> Initializes a new instance of RemediationDeploymentsListResult. </summary>
        internal RemediationDeploymentsListResult()
        {
            Value = new Core.ChangeTrackingList<RemediationDeployment>();
        }

        /// <summary> Initializes a new instance of RemediationDeploymentsListResult. </summary>
        /// <param name="value"> Array of deployments for the remediation. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal RemediationDeploymentsListResult(IReadOnlyList<RemediationDeployment> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of deployments for the remediation. </summary>
        public IReadOnlyList<RemediationDeployment> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
