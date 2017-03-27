// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Graph;
    using Microsoft.Azure.Management.Graph.RBAC;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// The Graph RBAC Management Client
    /// </summary>
    public partial interface IGraphRbacManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Client API version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// The tenant ID.
        /// </summary>
        string TenantID { get; set; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is generated
        /// and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IObjectsOperations.
        /// </summary>
        IObjectsOperations Objects { get; }

        /// <summary>
        /// Gets the IApplicationsOperations.
        /// </summary>
        IApplicationsOperations Applications { get; }

        /// <summary>
        /// Gets the IGroupsOperations.
        /// </summary>
        IGroupsOperations Groups { get; }

        /// <summary>
        /// Gets the IServicePrincipalsOperations.
        /// </summary>
        IServicePrincipalsOperations ServicePrincipals { get; }

        /// <summary>
        /// Gets the IUsersOperations.
        /// </summary>
        IUsersOperations Users { get; }

    }
}
