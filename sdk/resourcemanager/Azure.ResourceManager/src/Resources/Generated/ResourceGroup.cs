// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A Class representing a ResourceGroup along with the instance operations that can be performed on it. </summary>
    public partial class ResourceGroup : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResourceGroup"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resourceGroupClientDiagnostics;
        private readonly ResourceGroupsRestOperations _resourceGroupRestClient;
        private readonly ClientDiagnostics _resourceGroupResourcesClientDiagnostics;
        private readonly ResourcesRestOperations _resourceGroupResourcesRestClient;
        private readonly ResourceGroupData _data;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroup"/> class for mocking. </summary>
        protected ResourceGroup()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResourceGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResourceGroup(ArmClient client, ResourceGroupData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroup"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroup(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourceGroupClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string resourceGroupApiVersion);
            _resourceGroupRestClient = new ResourceGroupsRestOperations(_resourceGroupClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, resourceGroupApiVersion);
            _resourceGroupResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Resources", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string resourceGroupResourcesApiVersion);
            _resourceGroupResourcesRestClient = new ResourcesRestOperations(_resourceGroupResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, resourceGroupResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Resources/resourceGroups";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResourceGroupData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ResourceGroup>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.Get");
            scope.Start();
            try
            {
                var response = await _resourceGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _resourceGroupClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResourceGroup> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.Get");
            scope.Start();
            try
            {
                var response = _resourceGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                if (response.Value == null)
                    throw _resourceGroupClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// When you delete a resource group, all of its resources are also deleted. Deleting a resource group deletes all of its template deployments and currently stored operations.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="forceDeletionTypes"> The resource types you want to force delete. Currently, only the following is supported: forceDeletionTypes=Microsoft.Compute/virtualMachines,Microsoft.Compute/virtualMachineScaleSets. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ArmOperation> DeleteAsync(bool waitForCompletion, string forceDeletionTypes = null, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.Delete");
            scope.Start();
            try
            {
                var response = await _resourceGroupRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, forceDeletionTypes, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation(_resourceGroupClientDiagnostics, Pipeline, _resourceGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, forceDeletionTypes).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// When you delete a resource group, all of its resources are also deleted. Deleting a resource group deletes all of its template deployments and currently stored operations.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Delete
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="forceDeletionTypes"> The resource types you want to force delete. Currently, only the following is supported: forceDeletionTypes=Microsoft.Compute/virtualMachines,Microsoft.Compute/virtualMachineScaleSets. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(bool waitForCompletion, string forceDeletionTypes = null, CancellationToken cancellationToken = default)
        {
            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.Delete");
            scope.Start();
            try
            {
                var response = _resourceGroupRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, forceDeletionTypes, cancellationToken);
                var operation = new ResourcesArmOperation(_resourceGroupClientDiagnostics, Pipeline, _resourceGroupRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, forceDeletionTypes).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Resource groups can be updated through a simple PATCH operation to a group address. The format of the request is the same as that for creating a resource group. If a field is unspecified, the current value is retained.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Update
        /// </summary>
        /// <param name="data"> Parameters supplied to update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public async virtual Task<Response<ResourceGroup>> UpdateAsync(PatchableResourceGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.Update");
            scope.Start();
            try
            {
                var response = await _resourceGroupRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Resource groups can be updated through a simple PATCH operation to a group address. The format of the request is the same as that for creating a resource group. If a field is unspecified, the current value is retained.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Update
        /// </summary>
        /// <param name="data"> Parameters supplied to update a resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<ResourceGroup> Update(PatchableResourceGroupData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.Update");
            scope.Start();
            try
            {
                var response = _resourceGroupRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, data, cancellationToken);
                return Response.FromValue(new ResourceGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Captures the specified resource group as a template.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/exportTemplate
        /// Operation Id: ResourceGroups_ExportTemplate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameters for exporting the template. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<ResourceGroupExportResult>> ExportTemplateAsync(bool waitForCompletion, ExportTemplateRequest parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.ExportTemplate");
            scope.Start();
            try
            {
                var response = await _resourceGroupRestClient.ExportTemplateAsync(Id.SubscriptionId, Id.ResourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation<ResourceGroupExportResult>(new ResourceGroupExportResultOperationSource(), _resourceGroupClientDiagnostics, Pipeline, _resourceGroupRestClient.CreateExportTemplateRequest(Id.SubscriptionId, Id.ResourceGroupName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Captures the specified resource group as a template.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/exportTemplate
        /// Operation Id: ResourceGroups_ExportTemplate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameters for exporting the template. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<ResourceGroupExportResult> ExportTemplate(bool waitForCompletion, ExportTemplateRequest parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.ExportTemplate");
            scope.Start();
            try
            {
                var response = _resourceGroupRestClient.ExportTemplate(Id.SubscriptionId, Id.ResourceGroupName, parameters, cancellationToken);
                var operation = new ResourcesArmOperation<ResourceGroupExportResult>(new ResourceGroupExportResultOperationSource(), _resourceGroupClientDiagnostics, Pipeline, _resourceGroupRestClient.CreateExportTemplateRequest(Id.SubscriptionId, Id.ResourceGroupName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The resources to be moved must be in the same source resource group in the source subscription being used. The target resource group may be in a different subscription. When moving resources, both the source group and the target group are locked for the duration of the operation. Write and delete operations are blocked on the groups until the move completes. 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{sourceResourceGroupName}/moveResources
        /// Operation Id: ResourceGroups_MoveResources
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameters for moving resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation> MoveResourcesAsync(bool waitForCompletion, ResourcesMoveInfo parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.MoveResources");
            scope.Start();
            try
            {
                var response = await _resourceGroupRestClient.MoveResourcesAsync(Id.SubscriptionId, Id.ResourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation(_resourceGroupClientDiagnostics, Pipeline, _resourceGroupRestClient.CreateMoveResourcesRequest(Id.SubscriptionId, Id.ResourceGroupName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The resources to be moved must be in the same source resource group in the source subscription being used. The target resource group may be in a different subscription. When moving resources, both the source group and the target group are locked for the duration of the operation. Write and delete operations are blocked on the groups until the move completes. 
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{sourceResourceGroupName}/moveResources
        /// Operation Id: ResourceGroups_MoveResources
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameters for moving resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation MoveResources(bool waitForCompletion, ResourcesMoveInfo parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.MoveResources");
            scope.Start();
            try
            {
                var response = _resourceGroupRestClient.MoveResources(Id.SubscriptionId, Id.ResourceGroupName, parameters, cancellationToken);
                var operation = new ResourcesArmOperation(_resourceGroupClientDiagnostics, Pipeline, _resourceGroupRestClient.CreateMoveResourcesRequest(Id.SubscriptionId, Id.ResourceGroupName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation checks whether the specified resources can be moved to the target. The resources to be moved must be in the same source resource group in the source subscription being used. The target resource group may be in a different subscription. If validation succeeds, it returns HTTP response code 204 (no content). If validation fails, it returns HTTP response code 409 (Conflict) with an error message. Retrieve the URL in the Location header value to check the result of the long-running operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{sourceResourceGroupName}/validateMoveResources
        /// Operation Id: ResourceGroups_ValidateMoveResources
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameters for moving resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation> ValidateMoveResourcesAsync(bool waitForCompletion, ResourcesMoveInfo parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.ValidateMoveResources");
            scope.Start();
            try
            {
                var response = await _resourceGroupRestClient.ValidateMoveResourcesAsync(Id.SubscriptionId, Id.ResourceGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ResourcesArmOperation(_resourceGroupClientDiagnostics, Pipeline, _resourceGroupRestClient.CreateValidateMoveResourcesRequest(Id.SubscriptionId, Id.ResourceGroupName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// This operation checks whether the specified resources can be moved to the target. The resources to be moved must be in the same source resource group in the source subscription being used. The target resource group may be in a different subscription. If validation succeeds, it returns HTTP response code 204 (no content). If validation fails, it returns HTTP response code 409 (Conflict) with an error message. Retrieve the URL in the Location header value to check the result of the long-running operation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{sourceResourceGroupName}/validateMoveResources
        /// Operation Id: ResourceGroups_ValidateMoveResources
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="parameters"> Parameters for moving resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation ValidateMoveResources(bool waitForCompletion, ResourcesMoveInfo parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.ValidateMoveResources");
            scope.Start();
            try
            {
                var response = _resourceGroupRestClient.ValidateMoveResources(Id.SubscriptionId, Id.ResourceGroupName, parameters, cancellationToken);
                var operation = new ResourcesArmOperation(_resourceGroupClientDiagnostics, Pipeline, _resourceGroupRestClient.CreateValidateMoveResourcesRequest(Id.SubscriptionId, Id.ResourceGroupName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitForCompletion)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public async virtual Task<Response<ResourceGroup>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _resourceGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<ResourceGroup> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _resourceGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                return Response.FromValue(new ResourceGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public async virtual Task<Response<ResourceGroup>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(true, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _resourceGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<ResourceGroup> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(true, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _resourceGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                return Response.FromValue(new ResourceGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public async virtual Task<Response<ResourceGroup>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagResource.CreateOrUpdateAsync(true, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _resourceGroupRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResourceGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}
        /// Operation Id: ResourceGroups_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<ResourceGroup> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _resourceGroupClientDiagnostics.CreateScope("ResourceGroup.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagResource.CreateOrUpdate(true, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _resourceGroupRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                return Response.FromValue(new ResourceGroup(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
