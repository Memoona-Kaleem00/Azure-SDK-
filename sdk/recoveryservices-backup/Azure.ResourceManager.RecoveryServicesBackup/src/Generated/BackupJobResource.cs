// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.RecoveryServicesBackup
{
    /// <summary>
    /// A Class representing a BackupJob along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BackupJobResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBackupJobResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource"/> using the GetBackupJob method.
    /// </summary>
    public partial class BackupJobResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BackupJobResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="vaultName"> The vaultName. </param>
        /// <param name="jobName"> The jobName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string vaultName, string jobName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs/{jobName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _backupJobJobDetailsClientDiagnostics;
        private readonly JobDetailsRestOperations _backupJobJobDetailsRestClient;
        private readonly ClientDiagnostics _jobCancellationsClientDiagnostics;
        private readonly JobCancellationsRestOperations _jobCancellationsRestClient;
        private readonly BackupJobData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.RecoveryServices/vaults/backupJobs";

        /// <summary> Initializes a new instance of the <see cref="BackupJobResource"/> class for mocking. </summary>
        protected BackupJobResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BackupJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BackupJobResource(ArmClient client, BackupJobData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BackupJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BackupJobResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _backupJobJobDetailsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string backupJobJobDetailsApiVersion);
            _backupJobJobDetailsRestClient = new JobDetailsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, backupJobJobDetailsApiVersion);
            _jobCancellationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.RecoveryServicesBackup", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _jobCancellationsRestClient = new JobCancellationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual BackupJobData Data
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
        /// Gets extended information associated with the job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDetails_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BackupJobResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _backupJobJobDetailsClientDiagnostics.CreateScope("BackupJobResource.Get");
            scope.Start();
            try
            {
                var response = await _backupJobJobDetailsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets extended information associated with the job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobDetails_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BackupJobResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _backupJobJobDetailsClientDiagnostics.CreateScope("BackupJobResource.Get");
            scope.Start();
            try
            {
                var response = _backupJobJobDetailsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BackupJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a job. This is an asynchronous operation. To know the status of the cancellation, call
        /// GetCancelOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs/{jobName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobCancellations_Trigger</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> TriggerJobCancellationAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _jobCancellationsClientDiagnostics.CreateScope("BackupJobResource.TriggerJobCancellation");
            scope.Start();
            try
            {
                var response = await _jobCancellationsRestClient.TriggerAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Cancels a job. This is an asynchronous operation. To know the status of the cancellation, call
        /// GetCancelOperationResult API.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.RecoveryServices/vaults/{vaultName}/backupJobs/{jobName}/cancel</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>JobCancellations_Trigger</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response TriggerJobCancellation(CancellationToken cancellationToken = default)
        {
            using var scope = _jobCancellationsClientDiagnostics.CreateScope("BackupJobResource.TriggerJobCancellation");
            scope.Start();
            try
            {
                var response = _jobCancellationsRestClient.Trigger(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
