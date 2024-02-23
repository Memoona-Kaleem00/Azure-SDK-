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
    /// A class representing a collection of <see cref="PartnerResponseResource"/> and their operations.
    /// Each <see cref="PartnerResponseResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get a <see cref="PartnerResponseCollection"/> instance call the GetPartnerResponses method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class PartnerResponseCollection : ArmCollection
    {
        private readonly ClientDiagnostics _partnerResponsePartnerClientDiagnostics;
        private readonly PartnerRestOperations _partnerResponsePartnerRestClient;

        /// <summary> Initializes a new instance of the <see cref="PartnerResponseCollection"/> class for mocking. </summary>
        protected PartnerResponseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PartnerResponseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PartnerResponseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _partnerResponsePartnerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagementPartner", PartnerResponseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PartnerResponseResource.ResourceType, out string partnerResponsePartnerApiVersion);
            _partnerResponsePartnerRestClient = new PartnerRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, partnerResponsePartnerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a management partner for the objectId and tenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/partners/{partnerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Partner_Create</description>
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
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerId"/> is null. </exception>
        public virtual async Task<ArmOperation<PartnerResponseResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string partnerId, CancellationToken cancellationToken = default)
        {
            if (partnerId == null)
            {
                throw new ArgumentNullException(nameof(partnerId));
            }
            if (partnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(partnerId));
            }

            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _partnerResponsePartnerRestClient.CreateAsync(partnerId, cancellationToken).ConfigureAwait(false);
                var uri = _partnerResponsePartnerRestClient.CreateCreateRequestUri(partnerId);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ManagementPartnerArmOperation<PartnerResponseResource>(Response.FromValue(new PartnerResponseResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// Create a management partner for the objectId and tenantId.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.ManagementPartner/partners/{partnerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Partner_Create</description>
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
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerId"/> is null. </exception>
        public virtual ArmOperation<PartnerResponseResource> CreateOrUpdate(WaitUntil waitUntil, string partnerId, CancellationToken cancellationToken = default)
        {
            if (partnerId == null)
            {
                throw new ArgumentNullException(nameof(partnerId));
            }
            if (partnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(partnerId));
            }

            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _partnerResponsePartnerRestClient.Create(partnerId, cancellationToken);
                var uri = _partnerResponsePartnerRestClient.CreateCreateRequestUri(partnerId);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), NextLinkOperationImplementation.HeaderSource.None.ToString(), null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new ManagementPartnerArmOperation<PartnerResponseResource>(Response.FromValue(new PartnerResponseResource(Client, response), response.GetRawResponse()), rehydrationToken);
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
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerId"/> is null. </exception>
        public virtual async Task<Response<PartnerResponseResource>> GetAsync(string partnerId, CancellationToken cancellationToken = default)
        {
            if (partnerId == null)
            {
                throw new ArgumentNullException(nameof(partnerId));
            }
            if (partnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(partnerId));
            }

            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseCollection.Get");
            scope.Start();
            try
            {
                var response = await _partnerResponsePartnerRestClient.GetAsync(partnerId, cancellationToken).ConfigureAwait(false);
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
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerId"/> is null. </exception>
        public virtual Response<PartnerResponseResource> Get(string partnerId, CancellationToken cancellationToken = default)
        {
            if (partnerId == null)
            {
                throw new ArgumentNullException(nameof(partnerId));
            }
            if (partnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(partnerId));
            }

            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseCollection.Get");
            scope.Start();
            try
            {
                var response = _partnerResponsePartnerRestClient.Get(partnerId, cancellationToken);
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
        /// Checks to see if the resource exists in azure.
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
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string partnerId, CancellationToken cancellationToken = default)
        {
            if (partnerId == null)
            {
                throw new ArgumentNullException(nameof(partnerId));
            }
            if (partnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(partnerId));
            }

            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _partnerResponsePartnerRestClient.GetAsync(partnerId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerId"/> is null. </exception>
        public virtual Response<bool> Exists(string partnerId, CancellationToken cancellationToken = default)
        {
            if (partnerId == null)
            {
                throw new ArgumentNullException(nameof(partnerId));
            }
            if (partnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(partnerId));
            }

            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseCollection.Exists");
            scope.Start();
            try
            {
                var response = _partnerResponsePartnerRestClient.Get(partnerId, cancellationToken: cancellationToken);
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
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerId"/> is null. </exception>
        public virtual async Task<NullableResponse<PartnerResponseResource>> GetIfExistsAsync(string partnerId, CancellationToken cancellationToken = default)
        {
            if (partnerId == null)
            {
                throw new ArgumentNullException(nameof(partnerId));
            }
            if (partnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(partnerId));
            }

            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _partnerResponsePartnerRestClient.GetAsync(partnerId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PartnerResponseResource>(response.GetRawResponse());
                return Response.FromValue(new PartnerResponseResource(Client, response.Value), response.GetRawResponse());
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
        /// <param name="partnerId"> Id of the Partner. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="partnerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerId"/> is null. </exception>
        public virtual NullableResponse<PartnerResponseResource> GetIfExists(string partnerId, CancellationToken cancellationToken = default)
        {
            if (partnerId == null)
            {
                throw new ArgumentNullException(nameof(partnerId));
            }
            if (partnerId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(partnerId));
            }

            using var scope = _partnerResponsePartnerClientDiagnostics.CreateScope("PartnerResponseCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _partnerResponsePartnerRestClient.Get(partnerId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PartnerResponseResource>(response.GetRawResponse());
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
