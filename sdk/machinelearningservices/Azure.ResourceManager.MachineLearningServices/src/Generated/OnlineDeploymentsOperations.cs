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
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The OnlineDeployments service client. </summary>
    public partial class OnlineDeploymentsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal OnlineDeploymentsRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of OnlineDeploymentsOperations for mocking. </summary>
        protected OnlineDeploymentsOperations()
        {
        }
        /// <summary> Initializes a new instance of OnlineDeploymentsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Azure subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal OnlineDeploymentsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-12-01-preview")
        {
            RestClient = new OnlineDeploymentsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Delete Inference Endpoint Deployment. </summary>
        /// <param name="endpointName"> Inference endpoint name. </param>
        /// <param name="deploymentName"> Inference Endpoint Deployment name. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string endpointName, string deploymentName, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(endpointName, deploymentName, resourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Delete Inference Endpoint Deployment. </summary>
        /// <param name="endpointName"> Inference endpoint name. </param>
        /// <param name="deploymentName"> Inference Endpoint Deployment name. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string endpointName, string deploymentName, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(endpointName, deploymentName, resourceGroupName, workspaceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Inference Deployment Deployment. </summary>
        /// <param name="endpointName"> Inference endpoint name. </param>
        /// <param name="deploymentName"> Inference Endpoint Deployment name. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<OnlineDeploymentPropertiesTrackedResource>> GetAsync(string endpointName, string deploymentName, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(endpointName, deploymentName, resourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get Inference Deployment Deployment. </summary>
        /// <param name="endpointName"> Inference endpoint name. </param>
        /// <param name="deploymentName"> Inference Endpoint Deployment name. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<OnlineDeploymentPropertiesTrackedResource> Get(string endpointName, string deploymentName, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(endpointName, deploymentName, resourceGroupName, workspaceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update Inference Endpoint Deployment. </summary>
        /// <param name="endpointName"> Inference endpoint name. </param>
        /// <param name="deploymentName"> Inference Endpoint Deployment name. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Inference Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> CreateOrUpdateAsync(string endpointName, string deploymentName, string resourceGroupName, string workspaceName, OnlineDeploymentPropertiesTrackedResource body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(endpointName, deploymentName, resourceGroupName, workspaceName, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update Inference Endpoint Deployment. </summary>
        /// <param name="endpointName"> Inference endpoint name. </param>
        /// <param name="deploymentName"> Inference Endpoint Deployment name. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> Inference Endpoint entity to apply during operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> CreateOrUpdate(string endpointName, string deploymentName, string resourceGroupName, string workspaceName, OnlineDeploymentPropertiesTrackedResource body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(endpointName, deploymentName, resourceGroupName, workspaceName, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Polls an Endpoint operation. </summary>
        /// <param name="endpointName"> Inference endpoint name. </param>
        /// <param name="deploymentName"> The name and identifier for the endpoint. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> The request containing parameters for retrieving logs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeploymentLogs>> GetLogsAsync(string endpointName, string deploymentName, string resourceGroupName, string workspaceName, DeploymentLogsRequest body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.GetLogs");
            scope.Start();
            try
            {
                return await RestClient.GetLogsAsync(endpointName, deploymentName, resourceGroupName, workspaceName, body, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Polls an Endpoint operation. </summary>
        /// <param name="endpointName"> Inference endpoint name. </param>
        /// <param name="deploymentName"> The name and identifier for the endpoint. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="body"> The request containing parameters for retrieving logs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeploymentLogs> GetLogs(string endpointName, string deploymentName, string resourceGroupName, string workspaceName, DeploymentLogsRequest body = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.GetLogs");
            scope.Start();
            try
            {
                return RestClient.GetLogs(endpointName, deploymentName, resourceGroupName, workspaceName, body, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Polls an Endpoint operation. </summary>
        /// <param name="endpointName"> Inference endpoint name. </param>
        /// <param name="deploymentName"> The name and identifier for the endpoint. </param>
        /// <param name="operationId"> The operation ID of the async operation to be polled. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> PollAsync(string endpointName, string deploymentName, string operationId, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.Poll");
            scope.Start();
            try
            {
                return await RestClient.PollAsync(endpointName, deploymentName, operationId, resourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Polls an Endpoint operation. </summary>
        /// <param name="endpointName"> Inference endpoint name. </param>
        /// <param name="deploymentName"> The name and identifier for the endpoint. </param>
        /// <param name="operationId"> The operation ID of the async operation to be polled. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> Poll(string endpointName, string deploymentName, string operationId, string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.Poll");
            scope.Start();
            try
            {
                return RestClient.Poll(endpointName, deploymentName, operationId, resourceGroupName, workspaceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List Inference Endpoint Deployments. </summary>
        /// <param name="endpointName"> Inference endpoint name. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public virtual AsyncPageable<OnlineDeploymentPropertiesTrackedResource> ListAsync(string endpointName, string resourceGroupName, string workspaceName, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            async Task<Page<OnlineDeploymentPropertiesTrackedResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(endpointName, resourceGroupName, workspaceName, skiptoken, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<OnlineDeploymentPropertiesTrackedResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, endpointName, resourceGroupName, workspaceName, skiptoken, cancellationToken).ConfigureAwait(false);
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

        /// <summary> List Inference Endpoint Deployments. </summary>
        /// <param name="endpointName"> Inference endpoint name. </param>
        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="skiptoken"> Continuation token for pagination. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/>, <paramref name="resourceGroupName"/>, or <paramref name="workspaceName"/> is null. </exception>
        public virtual Pageable<OnlineDeploymentPropertiesTrackedResource> List(string endpointName, string resourceGroupName, string workspaceName, string skiptoken = null, CancellationToken cancellationToken = default)
        {
            if (endpointName == null)
            {
                throw new ArgumentNullException(nameof(endpointName));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            Page<OnlineDeploymentPropertiesTrackedResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(endpointName, resourceGroupName, workspaceName, skiptoken, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<OnlineDeploymentPropertiesTrackedResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OnlineDeploymentsOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, endpointName, resourceGroupName, workspaceName, skiptoken, cancellationToken);
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
    }
}
