
namespace Microsoft.Azure.Management.Cdn
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for CustomDomainsOperations.
    /// </summary>
    public static partial class CustomDomainsOperationsExtensions
    {
            /// <summary>
            /// Lists the existing CDN custom domains within an endpoint.
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
            public static Microsoft.Rest.Azure.IPage<CustomDomain> ListByEndpoint(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).ListByEndpointAsync(resourceGroupName, profileName, endpointName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the existing CDN custom domains within an endpoint.
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
            public static async Task<Microsoft.Rest.Azure.IPage<CustomDomain>> ListByEndpointAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByEndpointWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an existing CDN custom domain within an endpoint.
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
            public static CustomDomain Get(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).GetAsync(resourceGroupName, profileName, endpointName, customDomainName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an existing CDN custom domain within an endpoint.
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
            public static async System.Threading.Tasks.Task<CustomDomain> GetAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new CDN custom domain within an endpoint.
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
            /// <param name='customDomainProperties'>
            /// Custom domain properties required for creation.
            /// </param>
            public static CustomDomain Create(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, CustomDomainParameters customDomainProperties)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).CreateAsync(resourceGroupName, profileName, endpointName, customDomainName, customDomainProperties), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new CDN custom domain within an endpoint.
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
            /// <param name='customDomainProperties'>
            /// Custom domain properties required for creation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CustomDomain> CreateAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, CustomDomainParameters customDomainProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainName, customDomainProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new CDN custom domain within an endpoint.
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
            /// <param name='customDomainProperties'>
            /// Custom domain properties required for creation.
            /// </param>
            public static CustomDomain BeginCreate(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, CustomDomainParameters customDomainProperties)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).BeginCreateAsync(resourceGroupName, profileName, endpointName, customDomainName, customDomainProperties), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new CDN custom domain within an endpoint.
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
            /// <param name='customDomainProperties'>
            /// Custom domain properties required for creation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CustomDomain> BeginCreateAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, CustomDomainParameters customDomainProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainName, customDomainProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing CDN custom domain within an endpoint.
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
            public static CustomDomain Delete(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).DeleteAsync(resourceGroupName, profileName, endpointName, customDomainName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing CDN custom domain within an endpoint.
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
            public static async System.Threading.Tasks.Task<CustomDomain> DeleteAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing CDN custom domain within an endpoint.
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
            public static CustomDomain BeginDelete(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).BeginDeleteAsync(resourceGroupName, profileName, endpointName, customDomainName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing CDN custom domain within an endpoint.
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
            public static async System.Threading.Tasks.Task<CustomDomain> BeginDeleteAsync(this ICustomDomainsOperations operations, string resourceGroupName, string profileName, string endpointName, string customDomainName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the existing CDN custom domains within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<CustomDomain> ListByEndpointNext(this ICustomDomainsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ICustomDomainsOperations)s).ListByEndpointNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the existing CDN custom domains within an endpoint.
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
            public static async Task<Microsoft.Rest.Azure.IPage<CustomDomain>> ListByEndpointNextAsync(this ICustomDomainsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByEndpointNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
