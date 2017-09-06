// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationStorageClassificationMappingsOperations.
    /// </summary>
    public static partial class ReplicationStorageClassificationMappingsOperationsExtensions
    {
            /// <summary>
            /// Gets the details of a storage classification mapping.
            /// </summary>
            /// <remarks>
            /// Gets the details of the specified storage classification mapping.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classification name.
            /// </param>
            /// <param name='storageClassificationMappingName'>
            /// Storage classification mapping name.
            /// </param>
            public static StorageClassificationMapping Get(this IReplicationStorageClassificationMappingsOperations operations, string fabricName, string storageClassificationName, string storageClassificationMappingName)
            {
                return operations.GetAsync(fabricName, storageClassificationName, storageClassificationMappingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of a storage classification mapping.
            /// </summary>
            /// <remarks>
            /// Gets the details of the specified storage classification mapping.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classification name.
            /// </param>
            /// <param name='storageClassificationMappingName'>
            /// Storage classification mapping name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageClassificationMapping> GetAsync(this IReplicationStorageClassificationMappingsOperations operations, string fabricName, string storageClassificationName, string storageClassificationMappingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(fabricName, storageClassificationName, storageClassificationMappingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create storage classification mapping.
            /// </summary>
            /// <remarks>
            /// The operation to create a storage classification mapping.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classification name.
            /// </param>
            /// <param name='storageClassificationMappingName'>
            /// Storage classification mapping name.
            /// </param>
            /// <param name='pairingInput'>
            /// Pairing input.
            /// </param>
            public static StorageClassificationMapping Create(this IReplicationStorageClassificationMappingsOperations operations, string fabricName, string storageClassificationName, string storageClassificationMappingName, StorageClassificationMappingInput pairingInput)
            {
                return operations.CreateAsync(fabricName, storageClassificationName, storageClassificationMappingName, pairingInput).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create storage classification mapping.
            /// </summary>
            /// <remarks>
            /// The operation to create a storage classification mapping.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classification name.
            /// </param>
            /// <param name='storageClassificationMappingName'>
            /// Storage classification mapping name.
            /// </param>
            /// <param name='pairingInput'>
            /// Pairing input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageClassificationMapping> CreateAsync(this IReplicationStorageClassificationMappingsOperations operations, string fabricName, string storageClassificationName, string storageClassificationMappingName, StorageClassificationMappingInput pairingInput, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(fabricName, storageClassificationName, storageClassificationMappingName, pairingInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a storage classification mapping.
            /// </summary>
            /// <remarks>
            /// The operation to delete a storage classification mapping.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classification name.
            /// </param>
            /// <param name='storageClassificationMappingName'>
            /// Storage classification mapping name.
            /// </param>
            public static void Delete(this IReplicationStorageClassificationMappingsOperations operations, string fabricName, string storageClassificationName, string storageClassificationMappingName)
            {
                operations.DeleteAsync(fabricName, storageClassificationName, storageClassificationMappingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a storage classification mapping.
            /// </summary>
            /// <remarks>
            /// The operation to delete a storage classification mapping.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classification name.
            /// </param>
            /// <param name='storageClassificationMappingName'>
            /// Storage classification mapping name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IReplicationStorageClassificationMappingsOperations operations, string fabricName, string storageClassificationName, string storageClassificationMappingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(fabricName, storageClassificationName, storageClassificationMappingName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of storage classification mappings objects under a storage.
            /// </summary>
            /// <remarks>
            /// Lists the storage classification mappings for the fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classfication name.
            /// </param>
            public static IPage<StorageClassificationMapping> ListByReplicationStorageClassifications(this IReplicationStorageClassificationMappingsOperations operations, string fabricName, string storageClassificationName)
            {
                return operations.ListByReplicationStorageClassificationsAsync(fabricName, storageClassificationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of storage classification mappings objects under a storage.
            /// </summary>
            /// <remarks>
            /// Lists the storage classification mappings for the fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classfication name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageClassificationMapping>> ListByReplicationStorageClassificationsAsync(this IReplicationStorageClassificationMappingsOperations operations, string fabricName, string storageClassificationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationStorageClassificationsWithHttpMessagesAsync(fabricName, storageClassificationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of storage classification mappings objects under a vault.
            /// </summary>
            /// <remarks>
            /// Lists the storage classification mappings in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<StorageClassificationMapping> List(this IReplicationStorageClassificationMappingsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of storage classification mappings objects under a vault.
            /// </summary>
            /// <remarks>
            /// Lists the storage classification mappings in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageClassificationMapping>> ListAsync(this IReplicationStorageClassificationMappingsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create storage classification mapping.
            /// </summary>
            /// <remarks>
            /// The operation to create a storage classification mapping.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classification name.
            /// </param>
            /// <param name='storageClassificationMappingName'>
            /// Storage classification mapping name.
            /// </param>
            /// <param name='pairingInput'>
            /// Pairing input.
            /// </param>
            public static StorageClassificationMapping BeginCreate(this IReplicationStorageClassificationMappingsOperations operations, string fabricName, string storageClassificationName, string storageClassificationMappingName, StorageClassificationMappingInput pairingInput)
            {
                return operations.BeginCreateAsync(fabricName, storageClassificationName, storageClassificationMappingName, pairingInput).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create storage classification mapping.
            /// </summary>
            /// <remarks>
            /// The operation to create a storage classification mapping.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classification name.
            /// </param>
            /// <param name='storageClassificationMappingName'>
            /// Storage classification mapping name.
            /// </param>
            /// <param name='pairingInput'>
            /// Pairing input.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StorageClassificationMapping> BeginCreateAsync(this IReplicationStorageClassificationMappingsOperations operations, string fabricName, string storageClassificationName, string storageClassificationMappingName, StorageClassificationMappingInput pairingInput, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(fabricName, storageClassificationName, storageClassificationMappingName, pairingInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a storage classification mapping.
            /// </summary>
            /// <remarks>
            /// The operation to delete a storage classification mapping.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classification name.
            /// </param>
            /// <param name='storageClassificationMappingName'>
            /// Storage classification mapping name.
            /// </param>
            public static void BeginDelete(this IReplicationStorageClassificationMappingsOperations operations, string fabricName, string storageClassificationName, string storageClassificationMappingName)
            {
                operations.BeginDeleteAsync(fabricName, storageClassificationName, storageClassificationMappingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a storage classification mapping.
            /// </summary>
            /// <remarks>
            /// The operation to delete a storage classification mapping.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name.
            /// </param>
            /// <param name='storageClassificationName'>
            /// Storage classification name.
            /// </param>
            /// <param name='storageClassificationMappingName'>
            /// Storage classification mapping name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IReplicationStorageClassificationMappingsOperations operations, string fabricName, string storageClassificationName, string storageClassificationMappingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(fabricName, storageClassificationName, storageClassificationMappingName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the list of storage classification mappings objects under a storage.
            /// </summary>
            /// <remarks>
            /// Lists the storage classification mappings for the fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<StorageClassificationMapping> ListByReplicationStorageClassificationsNext(this IReplicationStorageClassificationMappingsOperations operations, string nextPageLink)
            {
                return operations.ListByReplicationStorageClassificationsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of storage classification mappings objects under a storage.
            /// </summary>
            /// <remarks>
            /// Lists the storage classification mappings for the fabric.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageClassificationMapping>> ListByReplicationStorageClassificationsNextAsync(this IReplicationStorageClassificationMappingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByReplicationStorageClassificationsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of storage classification mappings objects under a vault.
            /// </summary>
            /// <remarks>
            /// Lists the storage classification mappings in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<StorageClassificationMapping> ListNext(this IReplicationStorageClassificationMappingsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of storage classification mappings objects under a vault.
            /// </summary>
            /// <remarks>
            /// Lists the storage classification mappings in the vault.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<StorageClassificationMapping>> ListNextAsync(this IReplicationStorageClassificationMappingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
