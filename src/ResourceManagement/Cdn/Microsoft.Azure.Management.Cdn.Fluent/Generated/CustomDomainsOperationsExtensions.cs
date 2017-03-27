// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Cdn;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for CustomDomainsOperations.
    /// </summary>
    public static partial class CustomDomainsOperationsExtensions
    {
            /// <summary>
            /// Lists all of the existing custom domains within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            public static IPage<CustomDomainInner> ListByEndpoint(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                return operations.ListByEndpointAsync(resourceGroupName, profileName, endpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the existing custom domains within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CustomDomainInner>> ListByEndpointAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByEndpointWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an exisitng custom domain within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            public static CustomDomainInner Get(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName)
            {
                return operations.GetAsync(resourceGroupName, profileName, endpointName, customDomainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an exisitng custom domain within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomainInner> GetAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new custom domain within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            /// <param name='hostName'>
            /// The host name of the custom domain. Must be a domain name.
            /// </param>
            public static CustomDomainInner Create(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, string hostName)
            {
                return operations.CreateAsync(resourceGroupName, profileName, endpointName, customDomainName, hostName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new custom domain within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            /// <param name='hostName'>
            /// The host name of the custom domain. Must be a domain name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomainInner> CreateAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, string hostName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainName, hostName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing custom domain within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            public static CustomDomainInner Delete(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName)
            {
                return operations.DeleteAsync(resourceGroupName, profileName, endpointName, customDomainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing custom domain within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomainInner> DeleteAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Disable https delivery of the custom domain.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            public static CustomDomainInner DisableCustomHttps(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName)
            {
                return operations.DisableCustomHttpsAsync(resourceGroupName, profileName, endpointName, customDomainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Disable https delivery of the custom domain.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomainInner> DisableCustomHttpsAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DisableCustomHttpsWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Enable https delivery of the custom domain.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            public static CustomDomainInner EnableCustomHttps(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName)
            {
                return operations.EnableCustomHttpsAsync(resourceGroupName, profileName, endpointName, customDomainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Enable https delivery of the custom domain.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomainInner> EnableCustomHttpsAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.EnableCustomHttpsWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new custom domain within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            /// <param name='hostName'>
            /// The host name of the custom domain. Must be a domain name.
            /// </param>
            public static CustomDomainInner BeginCreate(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, string hostName)
            {
                return operations.BeginCreateAsync(resourceGroupName, profileName, endpointName, customDomainName, hostName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new custom domain within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            /// <param name='hostName'>
            /// The host name of the custom domain. Must be a domain name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomainInner> BeginCreateAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, string hostName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainName, hostName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing custom domain within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            public static CustomDomainInner BeginDelete(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, profileName, endpointName, customDomainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing custom domain within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='customDomainName'>
            /// Name of the custom domain within an endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CustomDomainInner> BeginDeleteAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the existing custom domains within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CustomDomainInner> ListByEndpointNext(this ICustomDomainsOperations operations, string nextPageLink)
            {
                return operations.ListByEndpointNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the existing custom domains within an endpoint.
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
            public static async Task<IPage<CustomDomainInner>> ListByEndpointNextAsync(this ICustomDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByEndpointNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
