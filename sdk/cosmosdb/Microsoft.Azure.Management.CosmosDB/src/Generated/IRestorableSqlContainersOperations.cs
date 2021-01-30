// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// RestorableSqlContainersOperations operations.
    /// </summary>
    public partial interface IRestorableSqlContainersOperations
    {
        /// <summary>
        /// Lists all the restorable Azure Cosmos DB SQL containers available
        /// for a specific database.
        /// </summary>
        /// <param name='location'>
        /// Cosmos DB region, with spaces between words and each word
        /// capitalized.
        /// </param>
        /// <param name='instanceId'>
        /// The instanceId GUID of a restorable database account.
        /// </param>
        /// <param name='restorableSqlDatabaseRid'>
        /// The resource id of the restorable SQL database.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DefaultErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<RestorableSqlContainerGetResult>>> ListWithHttpMessagesAsync(string location, string instanceId, string restorableSqlDatabaseRid = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
