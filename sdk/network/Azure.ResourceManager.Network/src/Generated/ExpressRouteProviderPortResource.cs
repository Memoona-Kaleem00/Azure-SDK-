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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing an ExpressRouteProviderPort along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="ExpressRouteProviderPortResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetExpressRouteProviderPortResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetExpressRouteProviderPort method.
    /// </summary>
    public partial class ExpressRouteProviderPortResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ExpressRouteProviderPortResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="providerport"> The providerport. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string providerport)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Network/expressRouteProviderPorts/{providerport}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _expressRouteProviderPortClientDiagnostics;
        private readonly NetworkManagementRestOperations _expressRouteProviderPortRestClient;
        private readonly ExpressRouteProviderPortData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/expressRouteProviderPorts";

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteProviderPortResource"/> class for mocking. </summary>
        protected ExpressRouteProviderPortResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteProviderPortResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ExpressRouteProviderPortResource(ArmClient client, ExpressRouteProviderPortData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteProviderPortResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ExpressRouteProviderPortResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteProviderPortClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string expressRouteProviderPortApiVersion);
            _expressRouteProviderPortRestClient = new NetworkManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteProviderPortApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ExpressRouteProviderPortData Data
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
        /// Retrieves detail of a provider port.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/expressRouteProviderPorts/{providerport}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteProviderPort</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteProviderPortResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteProviderPortResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteProviderPortClientDiagnostics.CreateScope("ExpressRouteProviderPortResource.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteProviderPortRestClient.ExpressRouteProviderPortAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteProviderPortResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves detail of a provider port.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/expressRouteProviderPorts/{providerport}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteProviderPort</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ExpressRouteProviderPortResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteProviderPortResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRouteProviderPortClientDiagnostics.CreateScope("ExpressRouteProviderPortResource.Get");
            scope.Start();
            try
            {
                var response = _expressRouteProviderPortRestClient.ExpressRouteProviderPort(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteProviderPortResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
