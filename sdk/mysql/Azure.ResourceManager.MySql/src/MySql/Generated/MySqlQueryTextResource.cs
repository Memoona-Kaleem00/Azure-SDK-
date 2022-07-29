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

namespace Azure.ResourceManager.MySql
{
    /// <summary>
    /// A Class representing a MySqlQueryText along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MySqlQueryTextResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMySqlQueryTextResource method.
    /// Otherwise you can get one from its parent resource <see cref="MySqlServerResource" /> using the GetMySqlQueryText method.
    /// </summary>
    public partial class MySqlQueryTextResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MySqlQueryTextResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string queryId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/queryTexts/{queryId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _mySqlQueryTextQueryTextsClientDiagnostics;
        private readonly QueryTextsRestOperations _mySqlQueryTextQueryTextsRestClient;
        private readonly MySqlQueryTextData _data;

        /// <summary> Initializes a new instance of the <see cref="MySqlQueryTextResource"/> class for mocking. </summary>
        protected MySqlQueryTextResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MySqlQueryTextResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MySqlQueryTextResource(ArmClient client, MySqlQueryTextData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MySqlQueryTextResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MySqlQueryTextResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _mySqlQueryTextQueryTextsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MySql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string mySqlQueryTextQueryTextsApiVersion);
            _mySqlQueryTextQueryTextsRestClient = new QueryTextsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, mySqlQueryTextQueryTextsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DBforMySQL/servers/queryTexts";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MySqlQueryTextData Data
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
        /// Retrieve the Query-Store query texts for the queryId.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/queryTexts/{queryId}
        /// Operation Id: QueryTexts_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MySqlQueryTextResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _mySqlQueryTextQueryTextsClientDiagnostics.CreateScope("MySqlQueryTextResource.Get");
            scope.Start();
            try
            {
                var response = await _mySqlQueryTextQueryTextsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlQueryTextResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the Query-Store query texts for the queryId.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}/queryTexts/{queryId}
        /// Operation Id: QueryTexts_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MySqlQueryTextResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _mySqlQueryTextQueryTextsClientDiagnostics.CreateScope("MySqlQueryTextResource.Get");
            scope.Start();
            try
            {
                var response = _mySqlQueryTextQueryTextsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MySqlQueryTextResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
