// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search
{
    using Azure;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SynonymMapsOperations.
    /// </summary>
    public static partial class SynonymMapsOperationsExtensions
    {
            /// <summary>
            /// Creates a new Azure Search synonym map or updates a synonym map if it
            /// already exists.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Update-Synonym-Map" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='synonymMapName'>
            /// The name of the synonym map to create or update.
            /// </param>
            /// <param name='synonymMap'>
            /// The definition of the synonym map to create or update.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            public static SynonymMap CreateOrUpdate(this ISynonymMapsOperations operations, string synonymMapName, SynonymMap synonymMap, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition))
            {
                return operations.CreateOrUpdateAsync(synonymMapName, synonymMap, searchRequestOptions, accessCondition).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Azure Search synonym map or updates a synonym map if it
            /// already exists.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Update-Synonym-Map" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='synonymMapName'>
            /// The name of the synonym map to create or update.
            /// </param>
            /// <param name='synonymMap'>
            /// The definition of the synonym map to create or update.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SynonymMap> CreateOrUpdateAsync(this ISynonymMapsOperations operations, string synonymMapName, SynonymMap synonymMap, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(synonymMapName, synonymMap, searchRequestOptions, accessCondition, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an Azure Search synonym map.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Delete-Synonym-Map" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='synonymMapName'>
            /// The name of the synonym map to delete.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            public static void Delete(this ISynonymMapsOperations operations, string synonymMapName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition))
            {
                operations.DeleteAsync(synonymMapName, searchRequestOptions, accessCondition).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an Azure Search synonym map.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Delete-Synonym-Map" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='synonymMapName'>
            /// The name of the synonym map to delete.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISynonymMapsOperations operations, string synonymMapName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(synonymMapName, searchRequestOptions, accessCondition, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Retrieves a synonym map definition from Azure Search.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Get-Synonym-Map" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='synonymMapName'>
            /// The name of the synonym map to retrieve.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SynonymMap Get(this ISynonymMapsOperations operations, string synonymMapName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.GetAsync(synonymMapName, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves a synonym map definition from Azure Search.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Get-Synonym-Map" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='synonymMapName'>
            /// The name of the synonym map to retrieve.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SynonymMap> GetAsync(this ISynonymMapsOperations operations, string synonymMapName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(synonymMapName, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all synonym maps available for an Azure Search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/List-Synonym-Maps" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SynonymMapListResult List(this ISynonymMapsOperations operations, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.ListAsync(searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all synonym maps available for an Azure Search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/List-Synonym-Maps" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SynonymMapListResult> ListAsync(this ISynonymMapsOperations operations, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new Azure Search synonym map.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Create-Synonym-Map" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='synonymMap'>
            /// The definition of the synonym map to create.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static SynonymMap Create(this ISynonymMapsOperations operations, SynonymMap synonymMap, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.CreateAsync(synonymMap, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Azure Search synonym map.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Create-Synonym-Map" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='synonymMap'>
            /// The definition of the synonym map to create.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SynonymMap> CreateAsync(this ISynonymMapsOperations operations, SynonymMap synonymMap, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(synonymMap, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

