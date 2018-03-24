// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
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
    /// TagDescriptionOperations operations.
    /// </summary>
    public partial interface ITagDescriptionOperations
    {
        /// <summary>
        /// Lists all Tags descriptions in scope of API. Model similar to
        /// swagger - tagDescription is defined on API level but tag may be
        /// assigned to the Operations
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API revision identifier. Must be unique in the current API
        /// Management service instance. Non-current revision has ;rev=n as a
        /// suffix where n is the revision number.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
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
        Task<AzureOperationResponse<IPage<TagDescriptionContract>>> ListByApiWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, ODataQuery<TagDescriptionContract> odataQuery = default(ODataQuery<TagDescriptionContract>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the entity state version of the tag specified by its
        /// identifier.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API revision identifier. Must be unique in the current API
        /// Management service instance. Non-current revision has ;rev=n as a
        /// suffix where n is the revision number.
        /// </param>
        /// <param name='tagId'>
        /// Tag identifier. Must be unique in the current API Management
        /// service instance.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<TagDescriptionGetEntityStateHeaders>> GetEntityStateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string tagId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get tag associated with the API.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API revision identifier. Must be unique in the current API
        /// Management service instance. Non-current revision has ;rev=n as a
        /// suffix where n is the revision number.
        /// </param>
        /// <param name='tagId'>
        /// Tag identifier. Must be unique in the current API Management
        /// service instance.
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
        Task<AzureOperationResponse<TagDescriptionContract,TagDescriptionGetHeaders>> GetWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string tagId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create/Update tag fescription in scope of the Api.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API revision identifier. Must be unique in the current API
        /// Management service instance. Non-current revision has ;rev=n as a
        /// suffix where n is the revision number.
        /// </param>
        /// <param name='tagId'>
        /// Tag identifier. Must be unique in the current API Management
        /// service instance.
        /// </param>
        /// <param name='parameters'>
        /// Create parameters.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. Not required when creating an entity, but
        /// required when updating an entity.
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
        Task<AzureOperationResponse<TagDescriptionContract>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string tagId, TagDescriptionCreateParameters parameters, string ifMatch = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete tag description for the Api.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='serviceName'>
        /// The name of the API Management service.
        /// </param>
        /// <param name='apiId'>
        /// API revision identifier. Must be unique in the current API
        /// Management service instance. Non-current revision has ;rev=n as a
        /// suffix where n is the revision number.
        /// </param>
        /// <param name='tagId'>
        /// Tag identifier. Must be unique in the current API Management
        /// service instance.
        /// </param>
        /// <param name='ifMatch'>
        /// ETag of the Entity. ETag should match the current entity state from
        /// the header response of the GET request or it should be * for
        /// unconditional update.
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
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string serviceName, string apiId, string tagId, string ifMatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all Tags descriptions in scope of API. Model similar to
        /// swagger - tagDescription is defined on API level but tag may be
        /// assigned to the Operations
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
        Task<AzureOperationResponse<IPage<TagDescriptionContract>>> ListByApiNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
