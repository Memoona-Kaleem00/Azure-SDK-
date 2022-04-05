// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.Azure.Management.HealthcareApis.Models;
using Page = Azure.Page<Microsoft.Azure.Management.HealthcareApis.Models.DicomService>;

namespace Microsoft.Azure.Management.HealthcareApis
{
    /// <summary> The DicomServices service client. </summary>
    public partial class DicomServicesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal DicomServicesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of DicomServicesOperations for mocking. </summary>
        protected DicomServicesOperations()
        {
        }
        /// <summary> Initializes a new instance of DicomServicesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal DicomServicesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2021-11-01")
        {
            RestClient = new DicomServicesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the properties of the specified DICOM Service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DicomService>> GetAsync(string resourceGroupName, string workspaceName, string dicomServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DicomServicesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, workspaceName, dicomServiceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the properties of the specified DICOM Service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DicomService> Get(string resourceGroupName, string workspaceName, string dicomServiceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DicomServicesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, workspaceName, dicomServiceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all DICOM Services for the given workspace. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        public virtual AsyncPageable<DicomService> ListByWorkspaceAsync(string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            async Task<Page> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DicomServicesOperations.ListByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByWorkspaceAsync(resourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DicomServicesOperations.ListByWorkspace");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByWorkspaceNextPageAsync(nextLink, resourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all DICOM Services for the given workspace. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        public virtual Pageable<DicomService> ListByWorkspace(string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            Page FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DicomServicesOperations.ListByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.ListByWorkspace(resourceGroupName, workspaceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DicomServicesOperations.ListByWorkspace");
                scope.Start();
                try
                {
                    var response = RestClient.ListByWorkspaceNextPage(nextLink, resourceGroupName, workspaceName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates or updates a DICOM Service resource with the specified parameters. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="dicomservice"> The parameters for creating or updating a Dicom Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="dicomServiceName"/>, or <paramref name="dicomservice"/> is null. </exception>
        public virtual async Task<DicomServicesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string workspaceName, string dicomServiceName, DicomService dicomservice, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (dicomServiceName == null)
            {
                throw new ArgumentNullException(nameof(dicomServiceName));
            }
            if (dicomservice == null)
            {
                throw new ArgumentNullException(nameof(dicomservice));
            }

            using var scope = _clientDiagnostics.CreateScope("DicomServicesOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, workspaceName, dicomServiceName, dicomservice, cancellationToken).ConfigureAwait(false);
                return new DicomServicesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, workspaceName, dicomServiceName, dicomservice).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a DICOM Service resource with the specified parameters. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="dicomservice"> The parameters for creating or updating a Dicom Service resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="dicomServiceName"/>, or <paramref name="dicomservice"/> is null. </exception>
        public virtual DicomServicesCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string workspaceName, string dicomServiceName, DicomService dicomservice, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (dicomServiceName == null)
            {
                throw new ArgumentNullException(nameof(dicomServiceName));
            }
            if (dicomservice == null)
            {
                throw new ArgumentNullException(nameof(dicomservice));
            }

            using var scope = _clientDiagnostics.CreateScope("DicomServicesOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, workspaceName, dicomServiceName, dicomservice, cancellationToken);
                return new DicomServicesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, workspaceName, dicomServiceName, dicomservice).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Patch DICOM Service details. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="dicomservicePatchResource"> The parameters for updating a Dicom Service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="dicomServiceName"/>, <paramref name="workspaceName"/>, or <paramref name="dicomservicePatchResource"/> is null. </exception>
        public virtual async Task<DicomServicesUpdateOperation> StartUpdateAsync(string resourceGroupName, string dicomServiceName, string workspaceName, DicomServicePatchResource dicomservicePatchResource, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (dicomServiceName == null)
            {
                throw new ArgumentNullException(nameof(dicomServiceName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (dicomservicePatchResource == null)
            {
                throw new ArgumentNullException(nameof(dicomservicePatchResource));
            }

            using var scope = _clientDiagnostics.CreateScope("DicomServicesOperations.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.UpdateAsync(resourceGroupName, dicomServiceName, workspaceName, dicomservicePatchResource, cancellationToken).ConfigureAwait(false);
                return new DicomServicesUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, dicomServiceName, workspaceName, dicomservicePatchResource).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Patch DICOM Service details. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="dicomservicePatchResource"> The parameters for updating a Dicom Service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="dicomServiceName"/>, <paramref name="workspaceName"/>, or <paramref name="dicomservicePatchResource"/> is null. </exception>
        public virtual DicomServicesUpdateOperation StartUpdate(string resourceGroupName, string dicomServiceName, string workspaceName, DicomServicePatchResource dicomservicePatchResource, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (dicomServiceName == null)
            {
                throw new ArgumentNullException(nameof(dicomServiceName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (dicomservicePatchResource == null)
            {
                throw new ArgumentNullException(nameof(dicomservicePatchResource));
            }

            using var scope = _clientDiagnostics.CreateScope("DicomServicesOperations.StartUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Update(resourceGroupName, dicomServiceName, workspaceName, dicomservicePatchResource, cancellationToken);
                return new DicomServicesUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateUpdateRequest(resourceGroupName, dicomServiceName, workspaceName, dicomservicePatchResource).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a DICOM Service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="dicomServiceName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<DicomServicesDeleteOperation> StartDeleteAsync(string resourceGroupName, string dicomServiceName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (dicomServiceName == null)
            {
                throw new ArgumentNullException(nameof(dicomServiceName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("DicomServicesOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, dicomServiceName, workspaceName, cancellationToken).ConfigureAwait(false);
                return new DicomServicesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, dicomServiceName, workspaceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a DICOM Service. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the service instance. </param>
        /// <param name="dicomServiceName"> The name of DICOM Service resource. </param>
        /// <param name="workspaceName"> The name of workspace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="dicomServiceName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public virtual DicomServicesDeleteOperation StartDelete(string resourceGroupName, string dicomServiceName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (dicomServiceName == null)
            {
                throw new ArgumentNullException(nameof(dicomServiceName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("DicomServicesOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, dicomServiceName, workspaceName, cancellationToken);
                return new DicomServicesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, dicomServiceName, workspaceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
