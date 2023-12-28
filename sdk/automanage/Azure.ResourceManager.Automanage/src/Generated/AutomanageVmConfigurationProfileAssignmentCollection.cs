// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Automanage
{
    /// <summary>
    /// A class representing a collection of <see cref="AutomanageVmConfigurationProfileAssignmentResource"/> and their operations.
    /// Each <see cref="AutomanageVmConfigurationProfileAssignmentResource"/> in the collection will belong to the same instance of <see cref="ArmResource"/>.
    /// To get an <see cref="AutomanageVmConfigurationProfileAssignmentCollection"/> instance call the GetAutomanageVmConfigurationProfileAssignments method from an instance of <see cref="ArmResource"/>.
    /// </summary>
    public partial class AutomanageVmConfigurationProfileAssignmentCollection : ArmCollection, IEnumerable<AutomanageVmConfigurationProfileAssignmentResource>, IAsyncEnumerable<AutomanageVmConfigurationProfileAssignmentResource>
    {
        private readonly ClientDiagnostics _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics;
        private readonly ConfigurationProfileAssignmentsRestOperations _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="AutomanageVmConfigurationProfileAssignmentCollection"/> class for mocking. </summary>
        protected AutomanageVmConfigurationProfileAssignmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomanageVmConfigurationProfileAssignmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AutomanageVmConfigurationProfileAssignmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Automanage", AutomanageVmConfigurationProfileAssignmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AutomanageVmConfigurationProfileAssignmentResource.ResourceType, out string automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsApiVersion);
            _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient = new ConfigurationProfileAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != "Microsoft.Compute/virtualMachines")
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, "Microsoft.Compute/virtualMachines"), nameof(id));
        }

        /// <summary>
        /// Creates an association between a VM and Automanage configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationProfileAssignmentName"> Name of the configuration profile assignment. Only default is supported. </param>
        /// <param name="data"> Parameters supplied to the create or update configuration profile assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AutomanageVmConfigurationProfileAssignmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string configurationProfileAssignmentName, AutomanageConfigurationProfileAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AutomanageArmOperation<AutomanageVmConfigurationProfileAssignmentResource>(Response.FromValue(new AutomanageVmConfigurationProfileAssignmentResource(Client, response), response.GetRawResponse()));
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
        /// Creates an association between a VM and Automanage configuration profile
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="configurationProfileAssignmentName"> Name of the configuration profile assignment. Only default is supported. </param>
        /// <param name="data"> Parameters supplied to the create or update configuration profile assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AutomanageVmConfigurationProfileAssignmentResource> CreateOrUpdate(WaitUntil waitUntil, string configurationProfileAssignmentName, AutomanageConfigurationProfileAssignmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, data, cancellationToken);
                var operation = new AutomanageArmOperation<AutomanageVmConfigurationProfileAssignmentResource>(Response.FromValue(new AutomanageVmConfigurationProfileAssignmentResource(Client, response), response.GetRawResponse()));
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

        /// <summary>
        /// Get information about a configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual async Task<Response<AutomanageVmConfigurationProfileAssignmentResource>> GetAsync(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageVmConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get information about a configuration profile assignment
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual Response<AutomanageVmConfigurationProfileAssignmentResource> Get(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentCollection.Get");
            scope.Start();
            try
            {
                var response = _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AutomanageVmConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get list of configuration profile assignments
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_ListByVirtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AutomanageVmConfigurationProfileAssignmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AutomanageVmConfigurationProfileAssignmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.CreateListByVirtualMachinesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new AutomanageVmConfigurationProfileAssignmentResource(Client, AutomanageConfigurationProfileAssignmentData.DeserializeAutomanageConfigurationProfileAssignmentData(e)), _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics, Pipeline, "AutomanageVmConfigurationProfileAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Get list of configuration profile assignments
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_ListByVirtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AutomanageVmConfigurationProfileAssignmentResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AutomanageVmConfigurationProfileAssignmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.CreateListByVirtualMachinesRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new AutomanageVmConfigurationProfileAssignmentResource(Client, AutomanageConfigurationProfileAssignmentData.DeserializeAutomanageConfigurationProfileAssignmentData(e)), _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics, Pipeline, "AutomanageVmConfigurationProfileAssignmentCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual async Task<NullableResponse<AutomanageVmConfigurationProfileAssignmentResource>> GetIfExistsAsync(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<AutomanageVmConfigurationProfileAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new AutomanageVmConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}/providers/Microsoft.Automanage/configurationProfileAssignments/{configurationProfileAssignmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConfigurationProfileAssignments_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Automanage/configurationProfileAssignments</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="configurationProfileAssignmentName"> The configuration profile assignment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="configurationProfileAssignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="configurationProfileAssignmentName"/> is null. </exception>
        public virtual NullableResponse<AutomanageVmConfigurationProfileAssignmentResource> GetIfExists(string configurationProfileAssignmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(configurationProfileAssignmentName, nameof(configurationProfileAssignmentName));

            using var scope = _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsClientDiagnostics.CreateScope("AutomanageVmConfigurationProfileAssignmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _automanageVmConfigurationProfileAssignmentConfigurationProfileAssignmentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, configurationProfileAssignmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<AutomanageVmConfigurationProfileAssignmentResource>(response.GetRawResponse());
                return Response.FromValue(new AutomanageVmConfigurationProfileAssignmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AutomanageVmConfigurationProfileAssignmentResource> IEnumerable<AutomanageVmConfigurationProfileAssignmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AutomanageVmConfigurationProfileAssignmentResource> IAsyncEnumerable<AutomanageVmConfigurationProfileAssignmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
