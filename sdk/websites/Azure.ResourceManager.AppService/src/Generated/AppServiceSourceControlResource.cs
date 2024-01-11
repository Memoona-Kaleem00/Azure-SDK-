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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing an AppServiceSourceControl along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AppServiceSourceControlResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAppServiceSourceControlResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetAppServiceSourceControl method.
    /// </summary>
    public partial class AppServiceSourceControlResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppServiceSourceControlResource"/> instance. </summary>
        /// <param name="sourceControlType"> The sourceControlType. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string sourceControlType)
        {
            var resourceId = $"/providers/Microsoft.Web/sourcecontrols/{sourceControlType}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appServiceSourceControlClientDiagnostics;
        private readonly WebSiteManagementRestOperations _appServiceSourceControlRestClient;
        private readonly AppServiceSourceControlData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sourcecontrols";

        /// <summary> Initializes a new instance of the <see cref="AppServiceSourceControlResource"/> class for mocking. </summary>
        protected AppServiceSourceControlResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppServiceSourceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppServiceSourceControlResource(ArmClient client, AppServiceSourceControlData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AppServiceSourceControlResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppServiceSourceControlResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appServiceSourceControlClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appServiceSourceControlApiVersion);
            _appServiceSourceControlRestClient = new WebSiteManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appServiceSourceControlApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppServiceSourceControlData Data
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
        /// Description for Gets source control token
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetSourceControl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppServiceSourceControlResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appServiceSourceControlClientDiagnostics.CreateScope("AppServiceSourceControlResource.Get");
            scope.Start();
            try
            {
                var response = await _appServiceSourceControlRestClient.GetSourceControlAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets source control token
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetSourceControl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppServiceSourceControlResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _appServiceSourceControlClientDiagnostics.CreateScope("AppServiceSourceControlResource.Get");
            scope.Start();
            try
            {
                var response = _appServiceSourceControlRestClient.GetSourceControl(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceSourceControlResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Updates source control token
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateSourceControl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Source control token information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<AppServiceSourceControlResource>> UpdateAsync(WaitUntil waitUntil, AppServiceSourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServiceSourceControlClientDiagnostics.CreateScope("AppServiceSourceControlResource.Update");
            scope.Start();
            try
            {
                var response = await _appServiceSourceControlRestClient.UpdateSourceControlAsync(Id.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _appServiceSourceControlRestClient.CreateUpdateSourceControlRequestUri(Id.Name, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new AppServiceArmOperation<AppServiceSourceControlResource>(Response.FromValue(new AppServiceSourceControlResource(Client, response), response.GetRawResponse()), operationId);
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
        /// Description for Updates source control token
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Web/sourcecontrols/{sourceControlType}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>UpdateSourceControl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppServiceSourceControlResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Source control token information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<AppServiceSourceControlResource> Update(WaitUntil waitUntil, AppServiceSourceControlData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _appServiceSourceControlClientDiagnostics.CreateScope("AppServiceSourceControlResource.Update");
            scope.Start();
            try
            {
                var response = _appServiceSourceControlRestClient.UpdateSourceControl(Id.Name, data, cancellationToken);
                var uri = _appServiceSourceControlRestClient.CreateUpdateSourceControlRequestUri(Id.Name, data);
                var operationId = NextLinkOperationImplementation.GetOperationId(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None, false, null, OperationFinalStateVia.OriginalUri);
                var operation = new AppServiceArmOperation<AppServiceSourceControlResource>(Response.FromValue(new AppServiceSourceControlResource(Client, response), response.GetRawResponse()), operationId);
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
