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

namespace Azure.ResourceManager.ManagementPartner
{
    /// <summary>
    /// A Class representing a PartnerResponse along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="PartnerResponseResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetPartnerResponseResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetPartnerResponse method.
    /// </summary>
    public partial class PartnerResponseResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PartnerResponseResource"/> instance. </summary>
        /// <param name="partnerId"> The partnerId. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string partnerId)
        {
            var resourceId = $"/providers/Microsoft.ManagementPartner/partners/{partnerId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _partnerResponsePartnerClientDiagnostics;
        private readonly PartnerRestOperations _partnerResponsePartnerRestClient;
        private readonly PartnerResponseData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ManagementPartner/partners";

        /// <summary> Initializes a new instance of the <see cref="PartnerResponseResource"/> class for mocking. </summary>
        protected PartnerResponseResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PartnerResponseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PartnerResponseResource(ArmClient client, PartnerResponseData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PartnerResponseResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PartnerResponseResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _partnerResponsePartnerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagementPartner", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string partnerResponsePartnerApiVersion);
            _partnerResponsePartnerRestClient = new PartnerRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, partnerResponsePartnerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PartnerResponseData Data
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
        /// Get the management partner using the partnerId, objectId and tenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/partners/{partnerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Partner_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PartnerResponseResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseResource.Get");
            scope.Start();
            try
            {
                var response = await _partnerResponsePartnerRestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PartnerResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the management partner using the partnerId, objectId and tenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/partners/{partnerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Partner_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PartnerResponseResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseResource.Get");
            scope.Start();
            try
            {
                var response = _partnerResponsePartnerRestClient.Get(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PartnerResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the management partner for the objectId and tenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/partners/{partnerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Partner_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseResource.Delete");
            scope.Start();
            try
            {
                var response = await _partnerResponsePartnerRestClient.DeleteAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                var uri = _partnerResponsePartnerRestClient.CreateDeleteRequestUri(Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ManagementPartnerArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the management partner for the objectId and tenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/partners/{partnerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Partner_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseResource.Delete");
            scope.Start();
            try
            {
                var response = _partnerResponsePartnerRestClient.Delete(Id.Name, cancellationToken);
                var uri = _partnerResponsePartnerRestClient.CreateDeleteRequestUri(Id.Name);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Delete, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ManagementPartnerArmOperation(response, rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the management partner for the objectId and tenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/partners/{partnerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Partner_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PartnerResponseResource>> UpdateAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseResource.Update");
            scope.Start();
            try
            {
                var response = await _partnerResponsePartnerRestClient.UpdateAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new PartnerResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Update the management partner for the objectId and tenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/partners/{partnerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Partner_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2018-02-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="PartnerResponseResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PartnerResponseResource> Update(CancellationToken cancellationToken = default)
        {
            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseResource.Update");
            scope.Start();
            try
            {
                var response = _partnerResponsePartnerRestClient.Update(Id.Name, cancellationToken);
                return Response.FromValue(new PartnerResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
