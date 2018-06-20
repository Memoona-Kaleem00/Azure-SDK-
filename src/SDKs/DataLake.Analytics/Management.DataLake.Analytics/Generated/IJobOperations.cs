// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// JobOperations operations.
    /// </summary>
    public partial interface IJobOperations
    {
        /// <summary>
        /// Lists the jobs, if any, associated with the specified Data Lake
        /// Analytics account. The response includes a link to the next page of
        /// results, if any.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='select'>
        /// OData Select statement. Limits the properties on each entry to just
        /// those requested, e.g. Categories?$select=CategoryName,Description.
        /// Optional.
        /// </param>
        /// <param name='count'>
        /// The Boolean value of true or false to request a count of the
        /// matching resources included with the resources in the response,
        /// e.g. Categories?$count=true. Optional.
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
        Task<AzureOperationResponse<IPage<JobInformationBasic>>> ListWithHttpMessagesAsync(string accountName, ODataQuery<JobInformationBasic> odataQuery = default(ODataQuery<JobInformationBasic>), string select = default(string), bool? count = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Submits a job to the specified Data Lake Analytics account.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job identifier. Uniquely identifies the job across all jobs
        /// submitted to the service.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to submit a job.
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
        Task<AzureOperationResponse<JobInformation>> CreateWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, CreateJobParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the job information for the specified job ID.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job identifier. Uniquely identifies the job across all jobs
        /// submitted to the service.
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
        Task<AzureOperationResponse<JobInformation>> GetWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the job information for the specified job ID. (Only for use
        /// internally with Scope job type.)
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job identifier. Uniquely identifies the job across all jobs
        /// submitted to the service.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to update a job.
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
        Task<AzureOperationResponse<JobInformation>> UpdateWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, UpdateJobParameters parameters = default(UpdateJobParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets statistics of the specified job.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job Information ID.
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
        Task<AzureOperationResponse<JobStatistics>> GetStatisticsWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the job debug data information specified by the job ID.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job identifier. Uniquely identifies the job across all jobs
        /// submitted to the service.
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
        Task<AzureOperationResponse<JobDataPath>> GetDebugDataPathWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels the running job specified by the job ID.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job identifier. Uniquely identifies the job across all jobs
        /// submitted to the service.
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
        Task<AzureOperationResponse> CancelWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Pauses the specified job and places it back in the job queue,
        /// behind other jobs of equal or higher importance, based on priority.
        /// (Only for use internally with Scope job type.)
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job identifier. Uniquely identifies the job across all jobs
        /// submitted to the service.
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
        Task<AzureOperationResponse> YieldOperationWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Builds (compiles) the specified job in the specified Data Lake
        /// Analytics account for job correctness and validation.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to build a job.
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
        Task<AzureOperationResponse<JobInformation>> BuildWithHttpMessagesAsync(string accountName, BuildJobParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the job information for the specified job ID. (Only for use
        /// internally with Scope job type.)
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job identifier. Uniquely identifies the job across all jobs
        /// submitted to the service.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to update a job.
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
        Task<AzureOperationResponse<JobInformation>> BeginUpdateWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, UpdateJobParameters parameters = default(UpdateJobParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels the running job specified by the job ID.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job identifier. Uniquely identifies the job across all jobs
        /// submitted to the service.
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
        Task<AzureOperationResponse> BeginCancelWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Pauses the specified job and places it back in the job queue,
        /// behind other jobs of equal or higher importance, based on priority.
        /// (Only for use internally with Scope job type.)
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job identifier. Uniquely identifies the job across all jobs
        /// submitted to the service.
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
        Task<AzureOperationResponse> BeginYieldOperationWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels the running job specified by the job ID.
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job identifier. Uniquely identifies the job across all jobs
        /// submitted to the service.
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
        Task<AzureOperationResponse> BeginCancelWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Pauses the specified job and places it back in the job queue,
        /// behind other jobs of equal or higher importance, based on priority.
        /// (Only for use internally with Scope job type.)
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job identifier. Uniquely identifies the job across all jobs
        /// submitted to the service.
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
        Task<AzureOperationResponse> BeginYieldOperationWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the job information for the specified job ID. (Only for use
        /// internally with Scope job type.)
        /// </summary>
        /// <param name='accountName'>
        /// The Azure Data Lake Analytics account to execute job operations on.
        /// </param>
        /// <param name='jobIdentity'>
        /// Job identifier. Uniquely identifies the job across all jobs
        /// submitted to the service.
        /// </param>
        /// <param name='parameters'>
        /// The parameters to update a job.
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
        Task<AzureOperationResponse<JobInformation>> BeginUpdateWithHttpMessagesAsync(string accountName, System.Guid jobIdentity, UpdateJobParameters parameters = default(UpdateJobParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists the jobs, if any, associated with the specified Data Lake
        /// Analytics account. The response includes a link to the next page of
        /// results, if any.
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
        Task<AzureOperationResponse<IPage<JobInformationBasic>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
