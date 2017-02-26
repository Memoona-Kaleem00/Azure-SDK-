// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.OperationalInsights
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// DataSourcesOperations operations.
    /// </summary>
    public partial interface IDataSourcesOperations
    {
        /// <summary>
        /// Create or update a data source.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data source.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the parent workspace that will contain the data source
        /// </param>
        /// <param name='name'>
        /// The parameters required to create or update a data source.
        /// </param>
        /// <param name='parameters'>
        /// The parameters required to create or update a data source.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DataSource>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string workspaceName, string name, DataSource parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a data source instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data source.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace that contains the data source.
        /// </param>
        /// <param name='dataSourceName'>
        /// Name of the data source.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string workspaceName, string dataSourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a data source instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data source.
        /// </param>
        /// <param name='workspaceName'>
        /// The name of the workspace that contains the data source.
        /// </param>
        /// <param name='dataSourceName'>
        /// Name of the data source
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<DataSource>> GetWithHttpMessagesAsync(string resourceGroupName, string workspaceName, string dataSourceName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of data source instances in a workspace with
        /// the link to the next page.
        /// </summary>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The resource group name of the data sources.
        /// </param>
        /// <param name='workspaceName'>
        /// The workspace that contains the data sources.
        /// </param>
        /// <param name='skiptoken'>
        /// Token for paging support.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<DataSource>>> ListInWorkspaceWithHttpMessagesAsync(ODataQuery<DataSourceFilter> odataQuery, string resourceGroupName, string workspaceName, string skiptoken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the first page of data source instances in a workspace with
        /// the link to the next page.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<DataSource>>> ListInWorkspaceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
