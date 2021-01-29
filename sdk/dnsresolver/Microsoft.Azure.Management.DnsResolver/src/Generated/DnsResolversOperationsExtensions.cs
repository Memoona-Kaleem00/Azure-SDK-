// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DnsResolver
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DnsResolversOperations.
    /// </summary>
    public static partial class DnsResolversOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a DNS resolver.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the resource. Omit this value to always overwrite the current
            /// resource. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new resource to be created, but to prevent updating
            /// an existing resource. Other values will be ignored.
            /// </param>
            public static DnsResolverModel CreateOrUpdate(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, DnsResolverModel parameters, string ifMatch = default(string), string ifNoneMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, dnsResolverName, parameters, ifMatch, ifNoneMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a DNS resolver.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the resource. Omit this value to always overwrite the current
            /// resource. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new resource to be created, but to prevent updating
            /// an existing resource. Other values will be ignored.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DnsResolverModel> CreateOrUpdateAsync(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, DnsResolverModel parameters, string ifMatch = default(string), string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, dnsResolverName, parameters, ifMatch, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a DNS resolver.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update operation.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the resource. Omit this value to always overwrite the current
            /// resource. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            public static DnsResolverModel Update(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, DnsResolverModel parameters, string ifMatch = default(string))
            {
                return operations.UpdateAsync(resourceGroupName, dnsResolverName, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a DNS resolver.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update operation.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the resource. Omit this value to always overwrite the current
            /// resource. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DnsResolverModel> UpdateAsync(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, DnsResolverModel parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, dnsResolverName, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a DNS resolver. WARNING: This operation cannot be undone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the resource. Omit this value to always overwrite the current
            /// resource. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            public static void Delete(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, string ifMatch = default(string))
            {
                operations.DeleteAsync(resourceGroupName, dnsResolverName, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a DNS resolver. WARNING: This operation cannot be undone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the resource. Omit this value to always overwrite the current
            /// resource. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, dnsResolverName, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets properties of a DNS resolver.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            public static DnsResolverModel Get(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName)
            {
                return operations.GetAsync(resourceGroupName, dnsResolverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets properties of a DNS resolver.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DnsResolverModel> GetAsync(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, dnsResolverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists DNS resolvers within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='top'>
            /// The maximum number of results to return. If not specified, returns up to
            /// 100 results.
            /// </param>
            public static IPage<DnsResolverModel> ListByResourceGroup(this IDnsResolversOperations operations, string resourceGroupName, int? top = default(int?))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists DNS resolvers within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='top'>
            /// The maximum number of results to return. If not specified, returns up to
            /// 100 results.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DnsResolverModel>> ListByResourceGroupAsync(this IDnsResolversOperations operations, string resourceGroupName, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists DNS resolvers in all resource groups of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The maximum number of results to return. If not specified, returns up to
            /// 100 results.
            /// </param>
            public static IPage<DnsResolverModel> List(this IDnsResolversOperations operations, int? top = default(int?))
            {
                return operations.ListAsync(top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists DNS resolvers in all resource groups of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='top'>
            /// The maximum number of results to return. If not specified, returns up to
            /// 100 results.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DnsResolverModel>> ListAsync(this IDnsResolversOperations operations, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists DNS resolvers for a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='top'>
            /// The maximum number of results to return. If not specified, returns up to
            /// 100 results.
            /// </param>
            public static IPage<DnsResolverModel> ListByVirtualNetwork(this IDnsResolversOperations operations, string resourceGroupName, string virtualNetworkName, int? top = default(int?))
            {
                return operations.ListByVirtualNetworkAsync(resourceGroupName, virtualNetworkName, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists DNS resolvers for a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='virtualNetworkName'>
            /// The name of the virtual network.
            /// </param>
            /// <param name='top'>
            /// The maximum number of results to return. If not specified, returns up to
            /// 100 results.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DnsResolverModel>> ListByVirtualNetworkAsync(this IDnsResolversOperations operations, string resourceGroupName, string virtualNetworkName, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVirtualNetworkWithHttpMessagesAsync(resourceGroupName, virtualNetworkName, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a DNS resolver.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the resource. Omit this value to always overwrite the current
            /// resource. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new resource to be created, but to prevent updating
            /// an existing resource. Other values will be ignored.
            /// </param>
            public static DnsResolverModel BeginCreateOrUpdate(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, DnsResolverModel parameters, string ifMatch = default(string), string ifNoneMatch = default(string))
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, dnsResolverName, parameters, ifMatch, ifNoneMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a DNS resolver.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the resource. Omit this value to always overwrite the current
            /// resource. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new resource to be created, but to prevent updating
            /// an existing resource. Other values will be ignored.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DnsResolverModel> BeginCreateOrUpdateAsync(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, DnsResolverModel parameters, string ifMatch = default(string), string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, dnsResolverName, parameters, ifMatch, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a DNS resolver.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update operation.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the resource. Omit this value to always overwrite the current
            /// resource. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            public static DnsResolverModel BeginUpdate(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, DnsResolverModel parameters, string ifMatch = default(string))
            {
                return operations.BeginUpdateAsync(resourceGroupName, dnsResolverName, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a DNS resolver.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update operation.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the resource. Omit this value to always overwrite the current
            /// resource. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DnsResolverModel> BeginUpdateAsync(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, DnsResolverModel parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, dnsResolverName, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a DNS resolver. WARNING: This operation cannot be undone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the resource. Omit this value to always overwrite the current
            /// resource. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            public static void BeginDelete(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, string ifMatch = default(string))
            {
                operations.BeginDeleteAsync(resourceGroupName, dnsResolverName, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a DNS resolver. WARNING: This operation cannot be undone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='dnsResolverName'>
            /// The name of the DNS resolver.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the resource. Omit this value to always overwrite the current
            /// resource. Specify the last-seen ETag value to prevent accidentally
            /// overwriting any concurrent changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IDnsResolversOperations operations, string resourceGroupName, string dnsResolverName, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, dnsResolverName, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists DNS resolvers within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DnsResolverModel> ListByResourceGroupNext(this IDnsResolversOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists DNS resolvers within a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DnsResolverModel>> ListByResourceGroupNextAsync(this IDnsResolversOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists DNS resolvers in all resource groups of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DnsResolverModel> ListNext(this IDnsResolversOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists DNS resolvers in all resource groups of a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DnsResolverModel>> ListNextAsync(this IDnsResolversOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists DNS resolvers for a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DnsResolverModel> ListByVirtualNetworkNext(this IDnsResolversOperations operations, string nextPageLink)
            {
                return operations.ListByVirtualNetworkNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists DNS resolvers for a virtual network.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DnsResolverModel>> ListByVirtualNetworkNextAsync(this IDnsResolversOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVirtualNetworkNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
