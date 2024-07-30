// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Quota
{
    /// <summary>
    /// A Class representing a GroupQuotaSubscription along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="GroupQuotaSubscriptionResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetGroupQuotaSubscriptionResource method.
    /// Otherwise you can get one from its parent resource <see cref="GroupQuotaEntityResource"/> using the GetGroupQuotaSubscription method.
    /// </summary>
    public partial class GroupQuotaSubscriptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="GroupQuotaSubscriptionResource"/> instance. </summary>
        /// <param name="managementGroupId"> The managementGroupId. </param>
        /// <param name="groupQuotaName"> The groupQuotaName. </param>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string managementGroupId, string groupQuotaName, string subscriptionId)
        {
            var resourceId = $"/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/subscriptions/{subscriptionId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _groupQuotaSubscriptionClientDiagnostics;
        private readonly GroupQuotaSubscriptionsRestOperations _groupQuotaSubscriptionRestClient;
        private readonly GroupQuotaSubscriptionData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Quota/groupQuotas/subscriptions";

        /// <summary> Initializes a new instance of the <see cref="GroupQuotaSubscriptionResource"/> class for mocking. </summary>
        protected GroupQuotaSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="GroupQuotaSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal GroupQuotaSubscriptionResource(ArmClient client, GroupQuotaSubscriptionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="GroupQuotaSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal GroupQuotaSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _groupQuotaSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Quota", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string groupQuotaSubscriptionApiVersion);
            _groupQuotaSubscriptionRestClient = new GroupQuotaSubscriptionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, groupQuotaSubscriptionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual GroupQuotaSubscriptionData Data
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
        /// Returns the subscriptionIds along with its provisioning state for being associated with the GroupQuota. If the subscription is not a member of GroupQuota, it will return 404, else 200.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/subscriptions/{subscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<GroupQuotaSubscriptionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _groupQuotaSubscriptionClientDiagnostics.CreateScope("GroupQuotaSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = await _groupQuotaSubscriptionRestClient.GetAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GroupQuotaSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the subscriptionIds along with its provisioning state for being associated with the GroupQuota. If the subscription is not a member of GroupQuota, it will return 404, else 200.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/subscriptions/{subscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptions_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GroupQuotaSubscriptionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _groupQuotaSubscriptionClientDiagnostics.CreateScope("GroupQuotaSubscriptionResource.Get");
            scope.Start();
            try
            {
                var response = _groupQuotaSubscriptionRestClient.Get(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GroupQuotaSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes the subscription from GroupQuotas. The request's TenantId is validated against the subscription's TenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/subscriptions/{subscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptions_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _groupQuotaSubscriptionClientDiagnostics.CreateScope("GroupQuotaSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = await _groupQuotaSubscriptionRestClient.DeleteAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new QuotaArmOperation(_groupQuotaSubscriptionClientDiagnostics, Pipeline, _groupQuotaSubscriptionRestClient.CreateDeleteRequest(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Removes the subscription from GroupQuotas. The request's TenantId is validated against the subscription's TenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/subscriptions/{subscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptions_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _groupQuotaSubscriptionClientDiagnostics.CreateScope("GroupQuotaSubscriptionResource.Delete");
            scope.Start();
            try
            {
                var response = _groupQuotaSubscriptionRestClient.Delete(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new QuotaArmOperation(_groupQuotaSubscriptionClientDiagnostics, Pipeline, _groupQuotaSubscriptionRestClient.CreateDeleteRequest(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Updates the GroupQuotas with the subscription to add to the subscriptions list. The subscriptions will be validated if additionalAttributes are defined in the GroupQuota. The request's TenantId is validated against the subscription's TenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/subscriptions/{subscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptions_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<GroupQuotaSubscriptionResource>> UpdateAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _groupQuotaSubscriptionClientDiagnostics.CreateScope("GroupQuotaSubscriptionResource.Update");
            scope.Start();
            try
            {
                var response = await _groupQuotaSubscriptionRestClient.UpdateAsync(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new QuotaArmOperation<GroupQuotaSubscriptionResource>(new GroupQuotaSubscriptionOperationSource(Client), _groupQuotaSubscriptionClientDiagnostics, Pipeline, _groupQuotaSubscriptionRestClient.CreateUpdateRequest(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
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
        /// Updates the GroupQuotas with the subscription to add to the subscriptions list. The subscriptions will be validated if additionalAttributes are defined in the GroupQuota. The request's TenantId is validated against the subscription's TenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Management/managementGroups/{managementGroupId}/providers/Microsoft.Quota/groupQuotas/{groupQuotaName}/subscriptions/{subscriptionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GroupQuotaSubscriptions_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GroupQuotaSubscriptionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<GroupQuotaSubscriptionResource> Update(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _groupQuotaSubscriptionClientDiagnostics.CreateScope("GroupQuotaSubscriptionResource.Update");
            scope.Start();
            try
            {
                var response = _groupQuotaSubscriptionRestClient.Update(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new QuotaArmOperation<GroupQuotaSubscriptionResource>(new GroupQuotaSubscriptionOperationSource(Client), _groupQuotaSubscriptionClientDiagnostics, Pipeline, _groupQuotaSubscriptionRestClient.CreateUpdateRequest(Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
