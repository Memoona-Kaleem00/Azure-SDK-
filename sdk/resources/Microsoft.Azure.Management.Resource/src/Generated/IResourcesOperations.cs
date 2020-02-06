// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager
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
    /// ResourcesOperations operations.
    /// </summary>
    public partial interface IResourcesOperations
    {
        /// <summary>
        /// Get all the resources for a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group with the resources to get.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<GenericResource>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, ODataQuery<GenericResourceFilter> odataQuery = default(ODataQuery<GenericResourceFilter>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Moves resources from one resource group to another resource group.
        /// </summary>
        /// <remarks>
        /// The resources to move must be in the same source resource group.
        /// The target resource group may be in a different subscription. When
        /// moving resources, both the source group and the target group are
        /// locked for the duration of the operation. Write and delete
        /// operations are blocked on the groups until the move completes.
        /// </remarks>
        /// <param name='sourceResourceGroupName'>
        /// The name of the resource group containing the resources to move.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for moving resources.
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
        Task<AzureOperationResponse> MoveResourcesWithHttpMessagesAsync(string sourceResourceGroupName, ResourcesMoveInfo parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Validates whether resources can be moved from one resource group to
        /// another resource group.
        /// </summary>
        /// <remarks>
        /// This operation checks whether the specified resources can be moved
        /// to the target. The resources to move must be in the same source
        /// resource group. The target resource group may be in a different
        /// subscription. If validation succeeds, it returns HTTP response code
        /// 204 (no content). If validation fails, it returns HTTP response
        /// code 409 (Conflict) with an error message. Retrieve the URL in the
        /// Location header value to check the result of the long-running
        /// operation.
        /// </remarks>
        /// <param name='sourceResourceGroupName'>
        /// The name of the resource group containing the resources to validate
        /// for move.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for moving resources.
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
        Task<AzureOperationResponse> ValidateMoveResourcesWithHttpMessagesAsync(string sourceResourceGroupName, ResourcesMoveInfo parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all the resources in a subscription.
        /// </summary>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
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
        Task<AzureOperationResponse<IPage<GenericResource>>> ListWithHttpMessagesAsync(ODataQuery<GenericResourceFilter> odataQuery = default(ODataQuery<GenericResourceFilter>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks whether a resource exists.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the resource to check.
        /// The name is case insensitive.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The resource provider of the resource to check.
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource identity.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource to check whether it exists.
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
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
        Task<AzureOperationResponse<bool>> CheckExistenceWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource to
        /// delete. The name is case insensitive.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource identity.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource to delete.
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
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
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group for the resource. The name is case
        /// insensitive.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource identity.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type of the resource to create.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource to create.
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for creating or updating the resource.
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
        Task<AzureOperationResponse<GenericResource>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string apiVersion, GenericResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group for the resource. The name is case
        /// insensitive.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource identity.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type of the resource to update.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource to update.
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for updating the resource.
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
        Task<AzureOperationResponse<GenericResource>> UpdateWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string apiVersion, GenericResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the resource to get. The
        /// name is case insensitive.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource identity.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type of the resource.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource to get.
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
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
        Task<AzureOperationResponse<GenericResource>> GetWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Checks by ID whether a resource exists.
        /// </summary>
        /// <param name='resourceId'>
        /// The fully qualified ID of the resource, including the resource name
        /// and resource type. Use the format,
        /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
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
        Task<AzureOperationResponse<bool>> CheckExistenceByIdWithHttpMessagesAsync(string resourceId, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a resource by ID.
        /// </summary>
        /// <param name='resourceId'>
        /// The fully qualified ID of the resource, including the resource name
        /// and resource type. Use the format,
        /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
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
        Task<AzureOperationResponse> DeleteByIdWithHttpMessagesAsync(string resourceId, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a resource by ID.
        /// </summary>
        /// <param name='resourceId'>
        /// The fully qualified ID of the resource, including the resource name
        /// and resource type. Use the format,
        /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
        /// </param>
        /// <param name='parameters'>
        /// Create or update resource parameters.
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
        Task<AzureOperationResponse<GenericResource>> CreateOrUpdateByIdWithHttpMessagesAsync(string resourceId, string apiVersion, GenericResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a resource by ID.
        /// </summary>
        /// <param name='resourceId'>
        /// The fully qualified ID of the resource, including the resource name
        /// and resource type. Use the format,
        /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
        /// </param>
        /// <param name='parameters'>
        /// Update resource parameters.
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
        Task<AzureOperationResponse<GenericResource>> UpdateByIdWithHttpMessagesAsync(string resourceId, string apiVersion, GenericResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a resource by ID.
        /// </summary>
        /// <param name='resourceId'>
        /// The fully qualified ID of the resource, including the resource name
        /// and resource type. Use the format,
        /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
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
        Task<AzureOperationResponse<GenericResource>> GetByIdWithHttpMessagesAsync(string resourceId, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Moves resources from one resource group to another resource group.
        /// </summary>
        /// <remarks>
        /// The resources to move must be in the same source resource group.
        /// The target resource group may be in a different subscription. When
        /// moving resources, both the source group and the target group are
        /// locked for the duration of the operation. Write and delete
        /// operations are blocked on the groups until the move completes.
        /// </remarks>
        /// <param name='sourceResourceGroupName'>
        /// The name of the resource group containing the resources to move.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for moving resources.
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
        Task<AzureOperationResponse> BeginMoveResourcesWithHttpMessagesAsync(string sourceResourceGroupName, ResourcesMoveInfo parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Validates whether resources can be moved from one resource group to
        /// another resource group.
        /// </summary>
        /// <remarks>
        /// This operation checks whether the specified resources can be moved
        /// to the target. The resources to move must be in the same source
        /// resource group. The target resource group may be in a different
        /// subscription. If validation succeeds, it returns HTTP response code
        /// 204 (no content). If validation fails, it returns HTTP response
        /// code 409 (Conflict) with an error message. Retrieve the URL in the
        /// Location header value to check the result of the long-running
        /// operation.
        /// </remarks>
        /// <param name='sourceResourceGroupName'>
        /// The name of the resource group containing the resources to validate
        /// for move.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for moving resources.
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
        Task<AzureOperationResponse> BeginValidateMoveResourcesWithHttpMessagesAsync(string sourceResourceGroupName, ResourcesMoveInfo parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource to
        /// delete. The name is case insensitive.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource identity.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource to delete.
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
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
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group for the resource. The name is case
        /// insensitive.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource identity.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type of the resource to create.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource to create.
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for creating or updating the resource.
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
        Task<AzureOperationResponse<GenericResource>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string apiVersion, GenericResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group for the resource. The name is case
        /// insensitive.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource identity.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type of the resource to update.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource to update.
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for updating the resource.
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
        Task<AzureOperationResponse<GenericResource>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string apiVersion, GenericResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a resource by ID.
        /// </summary>
        /// <param name='resourceId'>
        /// The fully qualified ID of the resource, including the resource name
        /// and resource type. Use the format,
        /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
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
        Task<AzureOperationResponse> BeginDeleteByIdWithHttpMessagesAsync(string resourceId, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a resource by ID.
        /// </summary>
        /// <param name='resourceId'>
        /// The fully qualified ID of the resource, including the resource name
        /// and resource type. Use the format,
        /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
        /// </param>
        /// <param name='parameters'>
        /// Create or update resource parameters.
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
        Task<AzureOperationResponse<GenericResource>> BeginCreateOrUpdateByIdWithHttpMessagesAsync(string resourceId, string apiVersion, GenericResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates a resource by ID.
        /// </summary>
        /// <param name='resourceId'>
        /// The fully qualified ID of the resource, including the resource name
        /// and resource type. Use the format,
        /// /subscriptions/{guid}/resourceGroups/{resource-group-name}/{resource-provider-namespace}/{resource-type}/{resource-name}
        /// </param>
        /// <param name='apiVersion'>
        /// The API version to use for the operation.
        /// </param>
        /// <param name='parameters'>
        /// Update resource parameters.
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
        Task<AzureOperationResponse<GenericResource>> BeginUpdateByIdWithHttpMessagesAsync(string resourceId, string apiVersion, GenericResource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all the resources for a resource group.
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
        Task<AzureOperationResponse<IPage<GenericResource>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all the resources in a subscription.
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
        Task<AzureOperationResponse<IPage<GenericResource>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
