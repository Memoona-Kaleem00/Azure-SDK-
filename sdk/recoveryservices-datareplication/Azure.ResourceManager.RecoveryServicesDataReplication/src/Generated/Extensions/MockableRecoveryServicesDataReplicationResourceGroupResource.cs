// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.RecoveryServicesDataReplication;
using Azure.ResourceManager.RecoveryServicesDataReplication.Models;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableRecoveryServicesDataReplicationResourceGroupResource : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private AzureSiteRecoveryManagementServiceAPIRestOperations _defaultRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableRecoveryServicesDataReplicationResourceGroupResource"/> class for mocking. </summary>
        protected MockableRecoveryServicesDataReplicationResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableRecoveryServicesDataReplicationResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableRecoveryServicesDataReplicationResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesDataReplication", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private AzureSiteRecoveryManagementServiceAPIRestOperations DefaultRestClient => _defaultRestClient ??= new AzureSiteRecoveryManagementServiceAPIRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DataReplicationFabricResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DataReplicationFabricResources and their operations over a DataReplicationFabricResource. </returns>
        public virtual DataReplicationFabricCollection GetDataReplicationFabrics()
        {
            return GetCachedClient(client => new DataReplicationFabricCollection(client, Id));
        }

        /// <summary>
        /// Gets the details of the fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fabric_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-16-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> The fabric name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataReplicationFabricResource>> GetDataReplicationFabricAsync(string fabricName, CancellationToken cancellationToken = default)
        {
            return await GetDataReplicationFabrics().GetAsync(fabricName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationFabrics/{fabricName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fabric_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-16-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationFabricResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fabricName"> The fabric name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fabricName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fabricName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataReplicationFabricResource> GetDataReplicationFabric(string fabricName, CancellationToken cancellationToken = default)
        {
            return GetDataReplicationFabrics().Get(fabricName, cancellationToken);
        }

        /// <summary> Gets a collection of DataReplicationVaultResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DataReplicationVaultResources and their operations over a DataReplicationVaultResource. </returns>
        public virtual DataReplicationVaultCollection GetDataReplicationVaults()
        {
            return GetCachedClient(client => new DataReplicationVaultCollection(client, Id));
        }

        /// <summary>
        /// Gets the details of the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-16-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DataReplicationVaultResource>> GetDataReplicationVaultAsync(string vaultName, CancellationToken cancellationToken = default)
        {
            return await GetDataReplicationVaults().GetAsync(vaultName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the details of the vault.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/replicationVaults/{vaultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Vault_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-16-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataReplicationVaultResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="vaultName"> The vault name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="vaultName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DataReplicationVaultResource> GetDataReplicationVault(string vaultName, CancellationToken cancellationToken = default)
        {
            return GetDataReplicationVaults().Get(vaultName, cancellationToken);
        }

        /// <summary>
        /// Performs resource deployment validation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/deployments/{deploymentId}/preflight</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentPreflight</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-16-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentId"> Deployment Id. </param>
        /// <param name="body"> Deployment preflight model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentId"/> is null. </exception>
        public virtual async Task<Response<DeploymentPreflightModel>> DeploymentPreflightAsync(string deploymentId, DeploymentPreflightModel body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));

            using var scope = DefaultClientDiagnostics.CreateScope("MockableRecoveryServicesDataReplicationResourceGroupResource.DeploymentPreflight");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.DeploymentPreflightAsync(Id.SubscriptionId, Id.ResourceGroupName, deploymentId, body, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Performs resource deployment validation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataReplication/deployments/{deploymentId}/preflight</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeploymentPreflight</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-16-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="deploymentId"> Deployment Id. </param>
        /// <param name="body"> Deployment preflight model. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="deploymentId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentId"/> is null. </exception>
        public virtual Response<DeploymentPreflightModel> DeploymentPreflight(string deploymentId, DeploymentPreflightModel body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(deploymentId, nameof(deploymentId));

            using var scope = DefaultClientDiagnostics.CreateScope("MockableRecoveryServicesDataReplicationResourceGroupResource.DeploymentPreflight");
            scope.Start();
            try
            {
                var response = DefaultRestClient.DeploymentPreflight(Id.SubscriptionId, Id.ResourceGroupName, deploymentId, body, cancellationToken);
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
