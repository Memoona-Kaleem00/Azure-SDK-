
namespace Microsoft.Azure.Management.Cdn
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for EndpointsOperations.
    /// </summary>
    public static partial class EndpointsOperationsExtensions
    {
            /// <summary>
            /// Lists existing CDN endpoints.
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
            public static Microsoft.Rest.Azure.IPage<Endpoint> ListByProfile(this IEndpointsOperations operations, string resourceGroupName, string profileName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).ListByProfileAsync(resourceGroupName, profileName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists existing CDN endpoints.
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<Endpoint>> ListByProfileAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByProfileWithHttpMessagesAsync(resourceGroupName, profileName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an existing CDN endpoint with the specified endpoint name under the
            /// specified subscription, resource group and profile.
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
            public static Endpoint Get(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).GetAsync(resourceGroupName, profileName, endpointName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an existing CDN endpoint with the specified endpoint name under the
            /// specified subscription, resource group and profile.
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
            public static async System.Threading.Tasks.Task<Endpoint> GetAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new CDN endpoint with the specified parameters.
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
            /// <param name='endpoint'>
            /// Endpoint properties
            /// </param>
            public static Endpoint Create(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, Endpoint endpoint)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).CreateAsync(resourceGroupName, profileName, endpointName, endpoint), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new CDN endpoint with the specified parameters.
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
            /// <param name='endpoint'>
            /// Endpoint properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Endpoint> CreateAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, Endpoint endpoint, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, endpoint, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new CDN endpoint with the specified parameters.
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
            /// <param name='endpoint'>
            /// Endpoint properties
            /// </param>
            public static Endpoint BeginCreate(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, Endpoint endpoint)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).BeginCreateAsync(resourceGroupName, profileName, endpointName, endpoint), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new CDN endpoint with the specified parameters.
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
            /// <param name='endpoint'>
            /// Endpoint properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Endpoint> BeginCreateAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, Endpoint endpoint, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, endpoint, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing CDN endpoint with the specified parameters. Only tags
            /// and OriginHostHeader can be updated after creating an endpoint. To update
            /// origins, use the Update Origin operation. To update custom domains, use
            /// the Update Custom Domain operation.
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
            /// <param name='endpointUpdateProperties'>
            /// Endpoint update properties
            /// </param>
            public static Endpoint Update(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, EndpointUpdateParameters endpointUpdateProperties)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).UpdateAsync(resourceGroupName, profileName, endpointName, endpointUpdateProperties), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing CDN endpoint with the specified parameters. Only tags
            /// and OriginHostHeader can be updated after creating an endpoint. To update
            /// origins, use the Update Origin operation. To update custom domains, use
            /// the Update Custom Domain operation.
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
            /// <param name='endpointUpdateProperties'>
            /// Endpoint update properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Endpoint> UpdateAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, EndpointUpdateParameters endpointUpdateProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, endpointUpdateProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing CDN endpoint with the specified parameters. Only tags
            /// and OriginHostHeader can be updated after creating an endpoint. To update
            /// origins, use the Update Origin operation. To update custom domains, use
            /// the Update Custom Domain operation.
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
            /// <param name='endpointUpdateProperties'>
            /// Endpoint update properties
            /// </param>
            public static Endpoint BeginUpdate(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, EndpointUpdateParameters endpointUpdateProperties)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).BeginUpdateAsync(resourceGroupName, profileName, endpointName, endpointUpdateProperties), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing CDN endpoint with the specified parameters. Only tags
            /// and OriginHostHeader can be updated after creating an endpoint. To update
            /// origins, use the Update Origin operation. To update custom domains, use
            /// the Update Custom Domain operation.
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
            /// <param name='endpointUpdateProperties'>
            /// Endpoint update properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Endpoint> BeginUpdateAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, EndpointUpdateParameters endpointUpdateProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, endpointUpdateProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes an existing CDN endpoint with the specified parameters.
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
            public static void Delete(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).DeleteAsync(resourceGroupName, profileName, endpointName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing CDN endpoint with the specified parameters.
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
            public static async System.Threading.Tasks.Task DeleteAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Deletes an existing CDN endpoint with the specified parameters.
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
            public static void BeginDelete(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).BeginDeleteAsync(resourceGroupName, profileName, endpointName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing CDN endpoint with the specified parameters.
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
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Starts an existing stopped CDN endpoint.
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
            public static Endpoint Start(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).StartAsync(resourceGroupName, profileName, endpointName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts an existing stopped CDN endpoint.
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
            public static async System.Threading.Tasks.Task<Endpoint> StartAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.StartWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Starts an existing stopped CDN endpoint.
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
            public static Endpoint BeginStart(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).BeginStartAsync(resourceGroupName, profileName, endpointName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Starts an existing stopped CDN endpoint.
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
            public static async System.Threading.Tasks.Task<Endpoint> BeginStartAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginStartWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Stops an existing running CDN endpoint.
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
            public static Endpoint Stop(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).StopAsync(resourceGroupName, profileName, endpointName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops an existing running CDN endpoint.
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
            public static async System.Threading.Tasks.Task<Endpoint> StopAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.StopWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Stops an existing running CDN endpoint.
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
            public static Endpoint BeginStop(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).BeginStopAsync(resourceGroupName, profileName, endpointName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Stops an existing running CDN endpoint.
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
            public static async System.Threading.Tasks.Task<Endpoint> BeginStopAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginStopWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Forcibly purges CDN endpoint content.
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
            /// <param name='contentFilePaths'>
            /// The path to the content to be purged. Path can describe a file or
            /// directory using the wildcard. e.g. '/my/directory/*' or '/my/file.exe/'
            /// </param>
            public static void PurgeContent(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, PurgeParameters contentFilePaths)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).PurgeContentAsync(resourceGroupName, profileName, endpointName, contentFilePaths), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Forcibly purges CDN endpoint content.
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
            /// <param name='contentFilePaths'>
            /// The path to the content to be purged. Path can describe a file or
            /// directory using the wildcard. e.g. '/my/directory/*' or '/my/file.exe/'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task PurgeContentAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, PurgeParameters contentFilePaths, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.PurgeContentWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, contentFilePaths, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Forcibly purges CDN endpoint content.
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
            /// <param name='contentFilePaths'>
            /// The path to the content to be purged. Path can describe a file or
            /// directory using the wildcard. e.g. '/my/directory/*' or '/my/file.exe/'
            /// </param>
            public static void BeginPurgeContent(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, PurgeParameters contentFilePaths)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).BeginPurgeContentAsync(resourceGroupName, profileName, endpointName, contentFilePaths), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Forcibly purges CDN endpoint content.
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
            /// <param name='contentFilePaths'>
            /// The path to the content to be purged. Path can describe a file or
            /// directory using the wildcard. e.g. '/my/directory/*' or '/my/file.exe/'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginPurgeContentAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, PurgeParameters contentFilePaths, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginPurgeContentWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, contentFilePaths, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Forcibly pre-loads CDN endpoint content. Available for Verizon Profiles.
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
            /// <param name='contentFilePaths'>
            /// The path to the content to be loaded. Path should describe a file.
            /// </param>
            public static void LoadContent(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, LoadParameters contentFilePaths)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).LoadContentAsync(resourceGroupName, profileName, endpointName, contentFilePaths), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Forcibly pre-loads CDN endpoint content. Available for Verizon Profiles.
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
            /// <param name='contentFilePaths'>
            /// The path to the content to be loaded. Path should describe a file.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task LoadContentAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, LoadParameters contentFilePaths, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.LoadContentWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, contentFilePaths, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Forcibly pre-loads CDN endpoint content. Available for Verizon Profiles.
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
            /// <param name='contentFilePaths'>
            /// The path to the content to be loaded. Path should describe a file.
            /// </param>
            public static void BeginLoadContent(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, LoadParameters contentFilePaths)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).BeginLoadContentAsync(resourceGroupName, profileName, endpointName, contentFilePaths), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Forcibly pre-loads CDN endpoint content. Available for Verizon Profiles.
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
            /// <param name='contentFilePaths'>
            /// The path to the content to be loaded. Path should describe a file.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginLoadContentAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, LoadParameters contentFilePaths, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.BeginLoadContentWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, contentFilePaths, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Validates a custom domain mapping to ensure it maps to the correct CNAME
            /// in DNS.
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
            /// <param name='customDomainProperties'>
            /// Custom domain to validate.
            /// </param>
            public static ValidateCustomDomainOutput ValidateCustomDomain(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, ValidateCustomDomainInput customDomainProperties)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).ValidateCustomDomainAsync(resourceGroupName, profileName, endpointName, customDomainProperties), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validates a custom domain mapping to ensure it maps to the correct CNAME
            /// in DNS.
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
            /// <param name='customDomainProperties'>
            /// Custom domain to validate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ValidateCustomDomainOutput> ValidateCustomDomainAsync(this IEndpointsOperations operations, string resourceGroupName, string profileName, string endpointName, ValidateCustomDomainInput customDomainProperties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ValidateCustomDomainWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, customDomainProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists existing CDN endpoints.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<Endpoint> ListByProfileNext(this IEndpointsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IEndpointsOperations)s).ListByProfileNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists existing CDN endpoints.
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
            public static async Task<Microsoft.Rest.Azure.IPage<Endpoint>> ListByProfileNextAsync(this IEndpointsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListByProfileNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
