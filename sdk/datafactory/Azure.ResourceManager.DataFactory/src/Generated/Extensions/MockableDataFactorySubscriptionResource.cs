// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.DataFactory;
using Azure.ResourceManager.DataFactory.Models;

namespace Azure.ResourceManager.DataFactory.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableDataFactorySubscriptionResource : ArmResource
    {
        private ClientDiagnostics _dataFactoryFactoriesClientDiagnostics;
        private FactoriesRestOperations _dataFactoryFactoriesRestClient;
        private ClientDiagnostics _exposureControlClientDiagnostics;
        private ExposureControlRestOperations _exposureControlRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableDataFactorySubscriptionResource"/> class for mocking. </summary>
        protected MockableDataFactorySubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDataFactorySubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDataFactorySubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DataFactoryFactoriesClientDiagnostics => _dataFactoryFactoriesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataFactory", DataFactoryResource.ResourceType.Namespace, Diagnostics);
        private FactoriesRestOperations DataFactoryFactoriesRestClient => _dataFactoryFactoriesRestClient ??= new FactoriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DataFactoryResource.ResourceType));
        private ClientDiagnostics ExposureControlClientDiagnostics => _exposureControlClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.DataFactory", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private ExposureControlRestOperations ExposureControlRestClient => _exposureControlRestClient ??= new ExposureControlRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists factories under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/factories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataFactoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataFactoryResource> GetDataFactoriesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataFactoryFactoriesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataFactoryFactoriesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataFactoryResource(Client, DataFactoryData.DeserializeDataFactoryData(e)), DataFactoryFactoriesClientDiagnostics, Pipeline, "MockableDataFactorySubscriptionResource.GetDataFactories", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists factories under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/factories</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataFactoryResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataFactoryResource> GetDataFactories(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DataFactoryFactoriesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => DataFactoryFactoriesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataFactoryResource(Client, DataFactoryData.DeserializeDataFactoryData(e)), DataFactoryFactoriesClientDiagnostics, Pipeline, "MockableDataFactorySubscriptionResource.GetDataFactories", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Updates a factory's repo information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/configureFactoryRepo</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_ConfigureFactoryRepo</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="content"> Update factory repo request definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<DataFactoryResource>> ConfigureFactoryRepoInformationAsync(AzureLocation locationId, FactoryRepoContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = DataFactoryFactoriesClientDiagnostics.CreateScope("MockableDataFactorySubscriptionResource.ConfigureFactoryRepoInformation");
            scope.Start();
            try
            {
                var response = await DataFactoryFactoriesRestClient.ConfigureFactoryRepoAsync(Id.SubscriptionId, locationId, content, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DataFactoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a factory's repo information.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/configureFactoryRepo</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Factories_ConfigureFactoryRepo</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataFactoryResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="content"> Update factory repo request definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<DataFactoryResource> ConfigureFactoryRepoInformation(AzureLocation locationId, FactoryRepoContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = DataFactoryFactoriesClientDiagnostics.CreateScope("MockableDataFactorySubscriptionResource.ConfigureFactoryRepoInformation");
            scope.Start();
            try
            {
                var response = DataFactoryFactoriesRestClient.ConfigureFactoryRepo(Id.SubscriptionId, locationId, content, cancellationToken);
                return Response.FromValue(new DataFactoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get exposure control feature for specific location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/getFeatureValue</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExposureControl_GetFeatureValue</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="content"> The exposure control request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<ExposureControlResult>> GetFeatureValueExposureControlAsync(AzureLocation locationId, ExposureControlContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = ExposureControlClientDiagnostics.CreateScope("MockableDataFactorySubscriptionResource.GetFeatureValueExposureControl");
            scope.Start();
            try
            {
                var response = await ExposureControlRestClient.GetFeatureValueAsync(Id.SubscriptionId, locationId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get exposure control feature for specific location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataFactory/locations/{locationId}/getFeatureValue</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExposureControl_GetFeatureValue</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-06-01</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationId"> The location identifier. </param>
        /// <param name="content"> The exposure control request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<ExposureControlResult> GetFeatureValueExposureControl(AzureLocation locationId, ExposureControlContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = ExposureControlClientDiagnostics.CreateScope("MockableDataFactorySubscriptionResource.GetFeatureValueExposureControl");
            scope.Start();
            try
            {
                var response = ExposureControlRestClient.GetFeatureValue(Id.SubscriptionId, locationId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
