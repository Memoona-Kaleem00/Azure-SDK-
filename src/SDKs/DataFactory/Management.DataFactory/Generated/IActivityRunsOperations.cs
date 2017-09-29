// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.2.22.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ActivityRunsOperations operations.
    /// </summary>
    public partial interface IActivityRunsOperations
    {
        /// <summary>
        /// List activity runs based on input filter conditions.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='factoryName'>
        /// The factory name.
        /// </param>
        /// <param name='runId'>
        /// The pipeline run identifier.
        /// </param>
        /// <param name='startTime'>
        /// The start time of activity runs in ISO8601 format.
        /// </param>
        /// <param name='endTime'>
        /// The end time of activity runs in ISO8601 format.
        /// </param>
        /// <param name='status'>
        /// The status of the pipeline run.
        /// </param>
        /// <param name='activityName'>
        /// The name of the activity.
        /// </param>
        /// <param name='linkedServiceName'>
        /// The linked service name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ActivityRun>>> ListByPipelineRunWithHttpMessagesAsync(string resourceGroupName, string factoryName, string runId, System.DateTime startTime, System.DateTime endTime, string status = default(string), string activityName = default(string), string linkedServiceName = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List activity runs based on input filter conditions.
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
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ActivityRun>>> ListByPipelineRunNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
