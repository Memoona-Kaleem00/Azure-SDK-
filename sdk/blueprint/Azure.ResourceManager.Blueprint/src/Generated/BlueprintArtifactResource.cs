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
    /// A Class representing a BlueprintArtifact along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="BlueprintArtifactResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetBlueprintArtifactResource method.
    /// Otherwise you can get one from its parent resource <see cref="BlueprintResource"/> using the GetBlueprintArtifact method.
    /// </summary>
    public partial class BlueprintArtifactResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="BlueprintArtifactResource"/> instance. </summary>
        /// <param name="resourceScope"> The resourceScope. </param>
        /// <param name="blueprintName"> The blueprintName. </param>
        /// <param name="artifactName"> The artifactName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string resourceScope, string blueprintName, string artifactName)
        {
            var resourceId = $"{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _blueprintArtifactArtifactsClientDiagnostics;
        private readonly ArtifactsRestOperations _blueprintArtifactArtifactsRestClient;
        private readonly ArtifactData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Blueprint/blueprints/artifacts";

        /// <summary> Initializes a new instance of the <see cref="BlueprintArtifactResource"/> class for mocking. </summary>
        protected BlueprintArtifactResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BlueprintArtifactResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal BlueprintArtifactResource(ArmClient client, ArtifactData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="BlueprintArtifactResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BlueprintArtifactResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _blueprintArtifactArtifactsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Blueprint", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string blueprintArtifactArtifactsApiVersion);
            _blueprintArtifactArtifactsRestClient = new ArtifactsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, blueprintArtifactArtifactsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ArtifactData Data
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
        /// Get a blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BlueprintArtifactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BlueprintArtifactResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _blueprintArtifactArtifactsClientDiagnostics.CreateScope("BlueprintArtifactResource.Get");
            scope.Start();
            try
            {
                var response = await _blueprintArtifactArtifactsRestClient.GetAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlueprintArtifactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BlueprintArtifactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BlueprintArtifactResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _blueprintArtifactArtifactsClientDiagnostics.CreateScope("BlueprintArtifactResource.Get");
            scope.Start();
            try
            {
                var response = _blueprintArtifactArtifactsRestClient.Get(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlueprintArtifactResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete a blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BlueprintArtifactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<BlueprintArtifactResource>> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _blueprintArtifactArtifactsClientDiagnostics.CreateScope("BlueprintArtifactResource.Delete");
            scope.Start();
            try
            {
                var response = await _blueprintArtifactArtifactsRestClient.DeleteAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _blueprintArtifactArtifactsRestClient.CreateDeleteRequestUri(Id.Parent.Parent, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new BlueprintArmOperation<BlueprintArtifactResource>(Response.FromValue(new BlueprintArtifactResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Delete a blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BlueprintArtifactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<BlueprintArtifactResource> Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _blueprintArtifactArtifactsClientDiagnostics.CreateScope("BlueprintArtifactResource.Delete");
            scope.Start();
            try
            {
                var response = _blueprintArtifactArtifactsRestClient.Delete(Id.Parent.Parent, Id.Parent.Name, Id.Name, cancellationToken);
                var uri = _blueprintArtifactArtifactsRestClient.CreateDeleteRequestUri(Id.Parent.Parent, Id.Parent.Name, Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new BlueprintArmOperation<BlueprintArtifactResource>(Response.FromValue(new BlueprintArtifactResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BlueprintArtifactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Blueprint artifact to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<BlueprintArtifactResource>> UpdateAsync(WaitUntil waitUntil, ArtifactData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _blueprintArtifactArtifactsClientDiagnostics.CreateScope("BlueprintArtifactResource.Update");
            scope.Start();
            try
            {
                var response = await _blueprintArtifactArtifactsRestClient.CreateOrUpdateAsync(Id.Parent.Parent, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var uri = _blueprintArtifactArtifactsRestClient.CreateCreateOrUpdateRequestUri(Id.Parent.Parent, Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new BlueprintArmOperation<BlueprintArtifactResource>(Response.FromValue(new BlueprintArtifactResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create or update blueprint artifact.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}/artifacts/{artifactName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Artifacts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BlueprintArtifactResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Blueprint artifact to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<BlueprintArtifactResource> Update(WaitUntil waitUntil, ArtifactData data, CancellationToken cancellationToken = default)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _blueprintArtifactArtifactsClientDiagnostics.CreateScope("BlueprintArtifactResource.Update");
            scope.Start();
            try
            {
                var response = _blueprintArtifactArtifactsRestClient.CreateOrUpdate(Id.Parent.Parent, Id.Parent.Name, Id.Name, data, cancellationToken);
                var uri = _blueprintArtifactArtifactsRestClient.CreateCreateOrUpdateRequestUri(Id.Parent.Parent, Id.Parent.Name, Id.Name, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new BlueprintArmOperation<BlueprintArtifactResource>(Response.FromValue(new BlueprintArtifactResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
