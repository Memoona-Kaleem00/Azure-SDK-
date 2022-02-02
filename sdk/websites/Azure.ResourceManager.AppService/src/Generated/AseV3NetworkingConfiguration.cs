// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A Class representing a AseV3NetworkingConfiguration along with the instance operations that can be performed on it. </summary>
    public partial class AseV3NetworkingConfiguration : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AseV3NetworkingConfiguration"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/configurations/networking";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _aseV3NetworkingConfigurationAppServiceEnvironmentsClientDiagnostics;
        private readonly AppServiceEnvironmentsRestOperations _aseV3NetworkingConfigurationAppServiceEnvironmentsRestClient;
        private readonly AseV3NetworkingConfigurationData _data;

        /// <summary> Initializes a new instance of the <see cref="AseV3NetworkingConfiguration"/> class for mocking. </summary>
        protected AseV3NetworkingConfiguration()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "AseV3NetworkingConfiguration"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AseV3NetworkingConfiguration(ArmClient armClient, AseV3NetworkingConfigurationData data) : this(armClient, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AseV3NetworkingConfiguration"/> class. </summary>
        /// <param name="armClient"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AseV3NetworkingConfiguration(ArmClient armClient, ResourceIdentifier id) : base(armClient, id)
        {
            _aseV3NetworkingConfigurationAppServiceEnvironmentsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, DiagnosticOptions);
            ArmClient.TryGetApiVersion(ResourceType, out string aseV3NetworkingConfigurationAppServiceEnvironmentsApiVersion);
            _aseV3NetworkingConfigurationAppServiceEnvironmentsRestClient = new AppServiceEnvironmentsRestOperations(_aseV3NetworkingConfigurationAppServiceEnvironmentsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, aseV3NetworkingConfigurationAppServiceEnvironmentsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/hostingEnvironments/configurations";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AseV3NetworkingConfigurationData Data
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/configurations/networking
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/configurations/networking
        /// OperationId: AppServiceEnvironments_GetAseV3NetworkingConfiguration
        /// <summary> Description for Get networking configuration of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<AseV3NetworkingConfiguration>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _aseV3NetworkingConfigurationAppServiceEnvironmentsClientDiagnostics.CreateScope("AseV3NetworkingConfiguration.Get");
            scope.Start();
            try
            {
                var response = await _aseV3NetworkingConfigurationAppServiceEnvironmentsRestClient.GetAseV3NetworkingConfigurationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _aseV3NetworkingConfigurationAppServiceEnvironmentsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AseV3NetworkingConfiguration(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/configurations/networking
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/configurations/networking
        /// OperationId: AppServiceEnvironments_GetAseV3NetworkingConfiguration
        /// <summary> Description for Get networking configuration of an App Service Environment. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AseV3NetworkingConfiguration> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _aseV3NetworkingConfigurationAppServiceEnvironmentsClientDiagnostics.CreateScope("AseV3NetworkingConfiguration.Get");
            scope.Start();
            try
            {
                var response = _aseV3NetworkingConfigurationAppServiceEnvironmentsRestClient.GetAseV3NetworkingConfiguration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw _aseV3NetworkingConfigurationAppServiceEnvironmentsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AseV3NetworkingConfiguration(ArmClient, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<AzureLocation>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _aseV3NetworkingConfigurationAppServiceEnvironmentsClientDiagnostics.CreateScope("AseV3NetworkingConfiguration.GetAvailableLocations");
            scope.Start();
            try
            {
                return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<AzureLocation> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            using var scope = _aseV3NetworkingConfigurationAppServiceEnvironmentsClientDiagnostics.CreateScope("AseV3NetworkingConfiguration.GetAvailableLocations");
            scope.Start();
            try
            {
                return ListAvailableLocations(ResourceType, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/configurations/networking
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/configurations/networking
        /// OperationId: AppServiceEnvironments_UpdateAseNetworkingConfiguration
        /// <summary> Description for Update networking configuration of an App Service Environment. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="aseNetworkingConfiguration"> The AseV3NetworkingConfiguration to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aseNetworkingConfiguration"/> is null. </exception>
        public async virtual Task<AseV3NetworkingConfigurationCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, AseV3NetworkingConfigurationData aseNetworkingConfiguration, CancellationToken cancellationToken = default)
        {
            if (aseNetworkingConfiguration == null)
            {
                throw new ArgumentNullException(nameof(aseNetworkingConfiguration));
            }

            using var scope = _aseV3NetworkingConfigurationAppServiceEnvironmentsClientDiagnostics.CreateScope("AseV3NetworkingConfiguration.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _aseV3NetworkingConfigurationAppServiceEnvironmentsRestClient.UpdateAseNetworkingConfigurationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, aseNetworkingConfiguration, cancellationToken).ConfigureAwait(false);
                var operation = new AseV3NetworkingConfigurationCreateOrUpdateOperation(ArmClient, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/configurations/networking
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/hostingEnvironments/{name}/configurations/networking
        /// OperationId: AppServiceEnvironments_UpdateAseNetworkingConfiguration
        /// <summary> Description for Update networking configuration of an App Service Environment. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="aseNetworkingConfiguration"> The AseV3NetworkingConfiguration to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aseNetworkingConfiguration"/> is null. </exception>
        public virtual AseV3NetworkingConfigurationCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, AseV3NetworkingConfigurationData aseNetworkingConfiguration, CancellationToken cancellationToken = default)
        {
            if (aseNetworkingConfiguration == null)
            {
                throw new ArgumentNullException(nameof(aseNetworkingConfiguration));
            }

            using var scope = _aseV3NetworkingConfigurationAppServiceEnvironmentsClientDiagnostics.CreateScope("AseV3NetworkingConfiguration.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _aseV3NetworkingConfigurationAppServiceEnvironmentsRestClient.UpdateAseNetworkingConfiguration(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, aseNetworkingConfiguration, cancellationToken);
                var operation = new AseV3NetworkingConfigurationCreateOrUpdateOperation(ArmClient, response);
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
    }
}
