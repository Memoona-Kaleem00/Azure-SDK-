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

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A Class representing a SubscriptionFileWorkspace along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SubscriptionFileWorkspaceResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSubscriptionFileWorkspaceResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetSubscriptionFileWorkspace method.
    /// </summary>
    public partial class SubscriptionFileWorkspaceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionFileWorkspaceResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="fileWorkspaceName"> The fileWorkspaceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string fileWorkspaceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics;
        private readonly FileWorkspacesRestOperations _subscriptionFileWorkspaceFileWorkspacesRestClient;
        private readonly FileWorkspaceDetailData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Support/fileWorkspaces";

        /// <summary> Initializes a new instance of the <see cref="SubscriptionFileWorkspaceResource"/> class for mocking. </summary>
        protected SubscriptionFileWorkspaceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionFileWorkspaceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SubscriptionFileWorkspaceResource(ArmClient client, FileWorkspaceDetailData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionFileWorkspaceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionFileWorkspaceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string subscriptionFileWorkspaceFileWorkspacesApiVersion);
            _subscriptionFileWorkspaceFileWorkspacesRestClient = new FileWorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionFileWorkspaceFileWorkspacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FileWorkspaceDetailData Data
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

        /// <summary> Gets a collection of SupportTicketFileResources in the SubscriptionFileWorkspace. </summary>
        /// <returns> An object representing collection of SupportTicketFileResources and their operations over a SupportTicketFileResource. </returns>
        public virtual SupportTicketFileCollection GetSupportTicketFiles()
        {
            return GetCachedClient(client => new SupportTicketFileCollection(client, Id));
        }

        /// <summary>
        /// Returns details of a specific file in a work space.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketFileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileName"> File Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SupportTicketFileResource>> GetSupportTicketFileAsync(string fileName, CancellationToken cancellationToken = default)
        {
            return await GetSupportTicketFiles().GetAsync(fileName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns details of a specific file in a work space.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}/files/{fileName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Files_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportTicketFileResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fileName"> File Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="fileName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SupportTicketFileResource> GetSupportTicketFile(string fileName, CancellationToken cancellationToken = default)
        {
            return GetSupportTicketFiles().Get(fileName, cancellationToken);
        }

        /// <summary>
        /// Gets details for a specific file workspace in an Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SubscriptionFileWorkspaceResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics.CreateScope("SubscriptionFileWorkspaceResource.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionFileWorkspaceFileWorkspacesRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionFileWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets details for a specific file workspace in an Azure subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspaces_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SubscriptionFileWorkspaceResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics.CreateScope("SubscriptionFileWorkspaceResource.Get");
            scope.Start();
            try
            {
                var response = _subscriptionFileWorkspaceFileWorkspacesRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionFileWorkspaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a new file workspace for the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspaces_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<SubscriptionFileWorkspaceResource>> UpdateAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics.CreateScope("SubscriptionFileWorkspaceResource.Update");
            scope.Start();
            try
            {
                var response = await _subscriptionFileWorkspaceFileWorkspacesRestClient.CreateAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _subscriptionFileWorkspaceFileWorkspacesRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.Name);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new SupportArmOperation<SubscriptionFileWorkspaceResource>(Response.FromValue(new SubscriptionFileWorkspaceResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Creates a new file workspace for the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/fileWorkspaces/{fileWorkspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FileWorkspaces_Create</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SubscriptionFileWorkspaceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<SubscriptionFileWorkspaceResource> Update(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _subscriptionFileWorkspaceFileWorkspacesClientDiagnostics.CreateScope("SubscriptionFileWorkspaceResource.Update");
            scope.Start();
            try
            {
                var response = _subscriptionFileWorkspaceFileWorkspacesRestClient.Create(Id.SubscriptionId, Id.Name, cancellationToken);
                var uri = _subscriptionFileWorkspaceFileWorkspacesRestClient.CreateCreateRequestUri(Id.SubscriptionId, Id.Name);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new SupportArmOperation<SubscriptionFileWorkspaceResource>(Response.FromValue(new SubscriptionFileWorkspaceResource(Client, response), response.GetRawResponse()), operationId);
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
