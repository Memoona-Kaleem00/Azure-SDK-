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

namespace Azure.ResourceManager.Blueprint
{
    /// <summary>
    /// A class representing a collection of <see cref="PublishedBlueprintResource"/> and their operations.
    /// Each <see cref="PublishedBlueprintResource"/> in the collection will belong to the same instance of <see cref="BlueprintResource"/>.
    /// To get a <see cref="PublishedBlueprintCollection"/> instance call the GetPublishedBlueprints method from an instance of <see cref="BlueprintResource"/>.
    /// </summary>
    public partial class PublishedBlueprintCollection : ArmCollection
    {
        private readonly ClientDiagnostics _publishedBlueprintClientDiagnostics;
        private readonly PublishedBlueprintsRestOperations _publishedBlueprintRestClient;

        /// <summary> Initializes a new instance of the <see cref="PublishedBlueprintCollection"/> class for mocking. </summary>
        protected PublishedBlueprintCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PublishedBlueprintCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PublishedBlueprintCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _publishedBlueprintClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Blueprint", PublishedBlueprintResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PublishedBlueprintResource.ResourceType, out string publishedBlueprintApiVersion);
            _publishedBlueprintRestClient = new PublishedBlueprintsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, publishedBlueprintApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != BlueprintResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, BlueprintResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Publish a new version of the blueprint definition with the latest artifacts. Published blueprint definitions are immutable.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Create</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Blueprint/blueprints/versions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="data"> Published Blueprint to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PublishedBlueprintResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string versionId, PublishedBlueprintData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _publishedBlueprintRestClient.CreateAsync(Id.Parent, Id.Name, versionId, data, cancellationToken).ConfigureAwait(false);
                var operation = new BlueprintArmOperation<PublishedBlueprintResource>(Response.FromValue(new PublishedBlueprintResource(Client, response), response.GetRawResponse()));
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
        /// Publish a new version of the blueprint definition with the latest artifacts. Published blueprint definitions are immutable.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Create</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Blueprint/blueprints/versions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="data"> Published Blueprint to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PublishedBlueprintResource> CreateOrUpdate(WaitUntil waitUntil, string versionId, PublishedBlueprintData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _publishedBlueprintRestClient.Create(Id.Parent, Id.Name, versionId, data, cancellationToken);
                var operation = new BlueprintArmOperation<PublishedBlueprintResource>(Response.FromValue(new PublishedBlueprintResource(Client, response), response.GetRawResponse()));
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
        /// Get a published version of a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Blueprint/blueprints/versions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        public virtual async Task<Response<PublishedBlueprintResource>> GetAsync(string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintCollection.Get");
            scope.Start();
            try
            {
                var response = await _publishedBlueprintRestClient.GetAsync(Id.Parent, Id.Name, versionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublishedBlueprintResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a published version of a blueprint definition.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Blueprint/blueprints/versions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        public virtual Response<PublishedBlueprintResource> Get(string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintCollection.Get");
            scope.Start();
            try
            {
                var response = _publishedBlueprintRestClient.Get(Id.Parent, Id.Name, versionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PublishedBlueprintResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Blueprint/blueprints/versions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintCollection.Exists");
            scope.Start();
            try
            {
                var response = await _publishedBlueprintRestClient.GetAsync(Id.Parent, Id.Name, versionId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Blueprint/blueprints/versions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        public virtual Response<bool> Exists(string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintCollection.Exists");
            scope.Start();
            try
            {
                var response = _publishedBlueprintRestClient.Get(Id.Parent, Id.Name, versionId, cancellationToken: cancellationToken);
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
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Blueprint/blueprints/versions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        public virtual async Task<NullableResponse<PublishedBlueprintResource>> GetIfExistsAsync(string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _publishedBlueprintRestClient.GetAsync(Id.Parent, Id.Name, versionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PublishedBlueprintResource>(response.GetRawResponse());
                return Response.FromValue(new PublishedBlueprintResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/versions/{versionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PublishedBlueprints_Get</description>
        /// </item>
        /// <item>
        /// <term>Resource Type</term>
        /// <description>Microsoft.Blueprint/blueprints/versions</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionId"> Version of the published blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionId"/> is null. </exception>
        public virtual NullableResponse<PublishedBlueprintResource> GetIfExists(string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var scope = _publishedBlueprintClientDiagnostics.CreateScope("PublishedBlueprintCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _publishedBlueprintRestClient.Get(Id.Parent, Id.Name, versionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PublishedBlueprintResource>(response.GetRawResponse());
                return Response.FromValue(new PublishedBlueprintResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
