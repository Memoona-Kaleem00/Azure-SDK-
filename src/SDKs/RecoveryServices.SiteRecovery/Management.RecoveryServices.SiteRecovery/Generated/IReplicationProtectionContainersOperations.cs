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
    /// ReplicationProtectionContainersOperations operations.
    /// </summary>
    public partial interface IReplicationProtectionContainersOperations
    {
        /// <summary>
        /// Switches protection from one container to another or one
        /// replication provider to
        /// another.
        /// </summary>
        /// Operation to switch protection from one container to another or
        /// one replication
        /// provider to another.
        /// <param name='fabricName'>
        /// Unique fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='switchInput'>
        /// Switch protection input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ProtectionContainer>> SwitchProtectionWithHttpMessagesAsync(string fabricName, string protectionContainerName, SwitchProtectionInput switchInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Switches protection from one container to another or one
        /// replication provider to
        /// another.
        /// </summary>
        /// Operation to switch protection from one container to another or
        /// one replication
        /// provider to another.
        /// <param name='fabricName'>
        /// Unique fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Protection container name.
        /// </param>
        /// <param name='switchInput'>
        /// Switch protection input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ProtectionContainer>> BeginSwitchProtectionWithHttpMessagesAsync(string fabricName, string protectionContainerName, SwitchProtectionInput switchInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes a protection container.
        /// </summary>
        /// Operation to remove a protection container.
        /// <param name='fabricName'>
        /// Unique fabric ARM name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Unique protection container ARM name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string fabricName, string protectionContainerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes a protection container.
        /// </summary>
        /// Operation to remove a protection container.
        /// <param name='fabricName'>
        /// Unique fabric ARM name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Unique protection container ARM name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string fabricName, string protectionContainerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a protectable item to the replication protection container.
        /// </summary>
        /// The operation to a add a protectable item to a protection
        /// container(Add physical server.)
        /// <param name='fabricName'>
        /// The name of the fabric.
        /// </param>
        /// <param name='protectionContainerName'>
        /// The name of the protection container.
        /// </param>
        /// <param name='discoverProtectableItemRequest'>
        /// The request object to add a protectable
        /// item.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ProtectionContainer>> DiscoverProtectableItemWithHttpMessagesAsync(string fabricName, string protectionContainerName, DiscoverProtectableItemRequest discoverProtectableItemRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a protectable item to the replication protection container.
        /// </summary>
        /// The operation to a add a protectable item to a protection
        /// container(Add physical server.)
        /// <param name='fabricName'>
        /// The name of the fabric.
        /// </param>
        /// <param name='protectionContainerName'>
        /// The name of the protection container.
        /// </param>
        /// <param name='discoverProtectableItemRequest'>
        /// The request object to add a protectable
        /// item.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ProtectionContainer>> BeginDiscoverProtectableItemWithHttpMessagesAsync(string fabricName, string protectionContainerName, DiscoverProtectableItemRequest discoverProtectableItemRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the protection container details.
        /// </summary>
        /// Gets the details of a protection container.
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
        Task<AzureOperationResponse<ProtectionContainer>> GetWithHttpMessagesAsync(string fabricName, string protectionContainerName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a protection container.
        /// </summary>
        /// Operation to create a protection container.
        /// <param name='fabricName'>
        /// Unique fabric ARM name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Unique protection container ARM name.
        /// </param>
        /// <param name='creationInput'>
        /// Creation input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ProtectionContainer>> CreateWithHttpMessagesAsync(string fabricName, string protectionContainerName, CreateProtectionContainerInput creationInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a protection container.
        /// </summary>
        /// Operation to create a protection container.
        /// <param name='fabricName'>
        /// Unique fabric ARM name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// Unique protection container ARM name.
        /// </param>
        /// <param name='creationInput'>
        /// Creation input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ProtectionContainer>> BeginCreateWithHttpMessagesAsync(string fabricName, string protectionContainerName, CreateProtectionContainerInput creationInput, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of protection container for a fabric.
        /// </summary>
        /// Lists the protection containers in the specified fabric.
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ProtectionContainer>>> ListByReplicationFabricsWithHttpMessagesAsync(string fabricName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of all protection containers in a vault.
        /// </summary>
        /// Lists the protection containers in a vault.
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ProtectionContainer>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of protection container for a fabric.
        /// </summary>
        /// Lists the protection containers in the specified fabric.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ProtectionContainer>>> ListByReplicationFabricsNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of all protection containers in a vault.
        /// </summary>
        /// Lists the protection containers in a vault.
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ProtectionContainer>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
