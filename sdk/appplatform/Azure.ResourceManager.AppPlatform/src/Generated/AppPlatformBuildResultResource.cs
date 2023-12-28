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
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A Class representing an AppPlatformBuildResult along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AppPlatformBuildResultResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAppPlatformBuildResultResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppPlatformBuildResource"/> using the GetAppPlatformBuildResult method.
    /// </summary>
    public partial class AppPlatformBuildResultResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppPlatformBuildResultResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="buildServiceName"> The buildServiceName. </param>
        /// <param name="buildName"> The buildName. </param>
        /// <param name="buildResultName"> The buildResultName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName, string buildName, string buildResultName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builds/{buildName}/results/{buildResultName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appPlatformBuildResultBuildServiceClientDiagnostics;
        private readonly BuildServiceRestOperations _appPlatformBuildResultBuildServiceRestClient;
        private readonly AppPlatformBuildResultData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppPlatform/Spring/buildServices/builds/results";

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildResultResource"/> class for mocking. </summary>
        protected AppPlatformBuildResultResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildResultResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppPlatformBuildResultResource(ArmClient client, AppPlatformBuildResultData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildResultResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppPlatformBuildResultResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformBuildResultBuildServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appPlatformBuildResultBuildServiceApiVersion);
            _appPlatformBuildResultBuildServiceRestClient = new BuildServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformBuildResultBuildServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppPlatformBuildResultData Data
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
        /// Get a KPack build result.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builds/{buildName}/results/{buildResultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuildResult</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/buildServices/builds/results</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppPlatformBuildResultResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformBuildResultBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildResultResource.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildResultBuildServiceRestClient.GetBuildResultAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a KPack build result.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builds/{buildName}/results/{buildResultName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuildResult</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/buildServices/builds/results</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppPlatformBuildResultResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformBuildResultBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildResultResource.Get");
            scope.Start();
            try
            {
                var response = _appPlatformBuildResultBuildServiceRestClient.GetBuildResult(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildResultResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a KPack build result log download URL.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builds/{buildName}/results/{buildResultName}/getLogFileUrl</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuildResultLog</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/buildServices/builds/results</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppPlatformBuildResultLog>> GetBuildResultLogAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformBuildResultBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildResultResource.GetBuildResultLog");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildResultBuildServiceRestClient.GetBuildResultLogAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a KPack build result log download URL.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builds/{buildName}/results/{buildResultName}/getLogFileUrl</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuildResultLog</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.AppPlatform/Spring/buildServices/builds/results</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppPlatformBuildResultLog> GetBuildResultLog(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformBuildResultBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildResultResource.GetBuildResultLog");
            scope.Start();
            try
            {
                var response = _appPlatformBuildResultBuildServiceRestClient.GetBuildResultLog(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
