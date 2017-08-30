// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ComputePoliciesOperations operations.
    /// </summary>
    public partial interface IComputePoliciesOperations
    {
        /// <summary>
        /// Creates or updates the specified compute policy. During update, the
        /// compute policy with the specified name will be replaced with this
        /// new compute policy. An account supports, at most, 50 policies
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to add or replace the
        /// compute policy.
        /// </param>
        /// <param name='computePolicyName'>
        /// The name of the compute policy to create or update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to create or update the compute policy. The max
        /// degree of parallelism per job property, min priority per job
        /// property, or both must be present.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ComputePolicy>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string computePolicyName, ComputePolicyCreateOrUpdateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified compute policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account to which to update the
        /// compute policy.
        /// </param>
        /// <param name='computePolicyName'>
        /// The name of the compute policy to update.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to update the compute policy.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ComputePolicy>> UpdateWithHttpMessagesAsync(string resourceGroupName, string accountName, string computePolicyName, ComputePolicy parameters = default(ComputePolicy), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified compute policy from the specified Data Lake
        /// Analytics account
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account from which to delete
        /// the compute policy.
        /// </param>
        /// <param name='computePolicyName'>
        /// The name of the compute policy to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string computePolicyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the specified Data Lake Analytics compute policy.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account from which to get the
        /// compute policy.
        /// </param>
        /// <param name='computePolicyName'>
        /// The name of the compute policy to retrieve.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ComputePolicy>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string computePolicyName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Analytics compute policies within the specified
        /// Data Lake Analytics account. An account supports, at most, 50
        /// policies
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake
        /// Analytics account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Analytics account from which to get the
        /// compute policies.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ComputePolicy>>> ListByAccountWithHttpMessagesAsync(string resourceGroupName, string accountName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the Data Lake Analytics compute policies within the specified
        /// Data Lake Analytics account. An account supports, at most, 50
        /// policies
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ComputePolicy>>> ListByAccountNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
