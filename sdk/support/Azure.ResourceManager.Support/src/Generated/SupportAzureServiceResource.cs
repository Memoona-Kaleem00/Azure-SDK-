// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A Class representing a SupportAzureService along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SupportAzureServiceResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSupportAzureServiceResource method.
    /// Otherwise you can get one from its parent resource <see cref="TenantResource"/> using the GetSupportAzureService method.
    /// </summary>
    public partial class SupportAzureServiceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SupportAzureServiceResource"/> instance. </summary>
        /// <param name="serviceName"> The serviceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string serviceName)
        {
            var resourceId = $"/providers/Microsoft.Support/services/{serviceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _supportAzureServiceServicesClientDiagnostics;
        private readonly ServicesRestOperations _supportAzureServiceServicesRestClient;
        private readonly ClientDiagnostics _problemClassificationsNoSubscriptionClientDiagnostics;
        private readonly ProblemClassificationsNoSubscriptionRestOperations _problemClassificationsNoSubscriptionRestClient;
        private readonly SupportAzureServiceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Support/services";

        /// <summary> Initializes a new instance of the <see cref="SupportAzureServiceResource"/> class for mocking. </summary>
        protected SupportAzureServiceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SupportAzureServiceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SupportAzureServiceResource(ArmClient client, SupportAzureServiceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SupportAzureServiceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SupportAzureServiceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supportAzureServiceServicesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string supportAzureServiceServicesApiVersion);
            _supportAzureServiceServicesRestClient = new ServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportAzureServiceServicesApiVersion);
            _problemClassificationsNoSubscriptionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _problemClassificationsNoSubscriptionRestClient = new ProblemClassificationsNoSubscriptionRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SupportAzureServiceData Data
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

        /// <summary> Gets a collection of ProblemClassificationResources in the SupportAzureService. </summary>
        /// <returns> An object representing collection of ProblemClassificationResources and their operations over a ProblemClassificationResource. </returns>
        public virtual ProblemClassificationCollection GetProblemClassifications()
        {
            return GetCachedClient(client => new ProblemClassificationCollection(client, Id));
        }

        /// <summary>
        /// Get problem classification details for a specific Azure service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/services/{serviceName}/problemClassifications/{problemClassificationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProblemClassifications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProblemClassificationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="problemClassificationName"> Name of problem classification. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="problemClassificationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="problemClassificationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ProblemClassificationResource>> GetProblemClassificationAsync(string problemClassificationName, CancellationToken cancellationToken = default)
        {
            return await GetProblemClassifications().GetAsync(problemClassificationName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get problem classification details for a specific Azure service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/services/{serviceName}/problemClassifications/{problemClassificationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProblemClassifications_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ProblemClassificationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="problemClassificationName"> Name of problem classification. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="problemClassificationName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="problemClassificationName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ProblemClassificationResource> GetProblemClassification(string problemClassificationName, CancellationToken cancellationToken = default)
        {
            return GetProblemClassifications().Get(problemClassificationName, cancellationToken);
        }

        /// <summary>
        /// Gets a specific Azure service for support ticket creation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportAzureServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SupportAzureServiceResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _supportAzureServiceServicesClientDiagnostics.CreateScope("SupportAzureServiceResource.Get");
            scope.Start();
            try
            {
                var response = await _supportAzureServiceServicesRestClient.GetAsync(Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportAzureServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific Azure service for support ticket creation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/services/{serviceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Services_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SupportAzureServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SupportAzureServiceResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _supportAzureServiceServicesClientDiagnostics.CreateScope("SupportAzureServiceResource.Get");
            scope.Start();
            try
            {
                var response = _supportAzureServiceServicesRestClient.Get(Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportAzureServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Classify the right problem classifications (categories) available for a specific Azure service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/services/{problemServiceName}/classifyProblems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProblemClassificationsNoSubscription_classifyProblems</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<ServiceProblemClassificationListResult>> ClassifyServiceProblemAsync(ServiceProblemClassificationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _problemClassificationsNoSubscriptionClientDiagnostics.CreateScope("SupportAzureServiceResource.ClassifyServiceProblem");
            scope.Start();
            try
            {
                var response = await _problemClassificationsNoSubscriptionRestClient.ClassifyProblemsAsync(Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Classify the right problem classifications (categories) available for a specific Azure service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Support/services/{problemServiceName}/classifyProblems</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProblemClassificationsNoSubscription_classifyProblems</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-06-01-preview</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Input to check. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<ServiceProblemClassificationListResult> ClassifyServiceProblem(ServiceProblemClassificationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _problemClassificationsNoSubscriptionClientDiagnostics.CreateScope("SupportAzureServiceResource.ClassifyServiceProblem");
            scope.Start();
            try
            {
                var response = _problemClassificationsNoSubscriptionRestClient.ClassifyProblems(Id.Name, content, cancellationToken);
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
