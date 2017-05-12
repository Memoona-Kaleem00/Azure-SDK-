// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ReplicationProtectionContainerMappingsOperations operations.
    /// </summary>
    public partial interface IReplicationProtectionContainerMappingsOperations
    {
        /// <summary>
        /// Remove protection container mapping.
        /// </summary>
        /// The operation to delete or remove a protection container mapping.
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='removalInput'>
        /// Removal input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string fabricName, string protectionContainerName, string mappingName, RemoveProtectionContainerMappingInput removalInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Remove protection container mapping.
        /// </summary>
        /// The operation to delete or remove a protection container mapping.
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='removalInput'>
        /// Removal input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string fabricName, string protectionContainerName, string mappingName, RemoveProtectionContainerMappingInput removalInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a protection container mapping/
        /// </summary>
        /// Gets the details of a protection container mapping.
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection Container mapping name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ProtectionContainerMapping>> GetWithHttpMessagesAsync(string fabricName, string protectionContainerName, string mappingName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create protection container mapping.
        /// </summary>
        /// The operation to create a protection container mapping.
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='creationInput'>
        /// Mapping creation input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ProtectionContainerMapping>> CreateWithHttpMessagesAsync(string fabricName, string protectionContainerName, string mappingName, CreateProtectionContainerMappingInput creationInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create protection container mapping.
        /// </summary>
        /// The operation to create a protection container mapping.
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='creationInput'>
        /// Mapping creation input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ProtectionContainerMapping>> BeginCreateWithHttpMessagesAsync(string fabricName, string protectionContainerName, string mappingName, CreateProtectionContainerMappingInput creationInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Purge protection container mapping.
        /// </summary>
        /// The operation to purge(force delete) a protection container mapping
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> PurgeWithHttpMessagesAsync(string fabricName, string protectionContainerName, string mappingName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Purge protection container mapping.
        /// </summary>
        /// The operation to purge(force delete) a protection container mapping
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='mappingName'>
        /// Protection container mapping name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginPurgeWithHttpMessagesAsync(string fabricName, string protectionContainerName, string mappingName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of protection container mappings for a protection
        /// container.
        /// </summary>
        /// Lists the protection container mappings for a protection container.
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ProtectionContainerMapping>>> ListByReplicationProtectionContainersWithHttpMessagesAsync(string fabricName, string protectionContainerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of all protection container mappings in a vault.
        /// </summary>
        /// Lists the protection container mappings in the vault.
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ProtectionContainerMapping>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of protection container mappings for a protection
        /// container.
        /// </summary>
        /// Lists the protection container mappings for a protection container.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ProtectionContainerMapping>>> ListByReplicationProtectionContainersNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of all protection container mappings in a vault.
        /// </summary>
        /// Lists the protection container mappings in the vault.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ProtectionContainerMapping>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
