// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for WebSiteManagementClient.
    /// </summary>
    public static partial class WebSiteManagementClientExtensions
    {
            /// <summary>
            /// Gets publishing user
            /// </summary>
            /// <remarks>
            /// Gets publishing user
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static User GetPublishingUser(this IWebSiteManagementClient operations)
            {
                return operations.GetPublishingUserAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets publishing user
            /// </summary>
            /// <remarks>
            /// Gets publishing user
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> GetPublishingUserAsync(this IWebSiteManagementClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPublishingUserWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates publishing user
            /// </summary>
            /// <remarks>
            /// Updates publishing user
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userDetails'>
            /// Details of publishing user
            /// </param>
            public static User UpdatePublishingUser(this IWebSiteManagementClient operations, User userDetails)
            {
                return operations.UpdatePublishingUserAsync(userDetails).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates publishing user
            /// </summary>
            /// <remarks>
            /// Updates publishing user
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userDetails'>
            /// Details of publishing user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> UpdatePublishingUserAsync(this IWebSiteManagementClient operations, User userDetails, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdatePublishingUserWithHttpMessagesAsync(userDetails, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the source controls available for Azure websites.
            /// </summary>
            /// <remarks>
            /// Gets the source controls available for Azure websites.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<SourceControl> ListSourceControls(this IWebSiteManagementClient operations)
            {
                return operations.ListSourceControlsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the source controls available for Azure websites.
            /// </summary>
            /// <remarks>
            /// Gets the source controls available for Azure websites.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SourceControl>> ListSourceControlsAsync(this IWebSiteManagementClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSourceControlsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates source control token
            /// </summary>
            /// <remarks>
            /// Updates source control token
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sourceControlType'>
            /// Type of source control
            /// </param>
            /// <param name='requestMessage'>
            /// Source control token information
            /// </param>
            public static SourceControl UpdateSourceControl(this IWebSiteManagementClient operations, string sourceControlType, SourceControl requestMessage)
            {
                return operations.UpdateSourceControlAsync(sourceControlType, requestMessage).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates source control token
            /// </summary>
            /// <remarks>
            /// Updates source control token
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sourceControlType'>
            /// Type of source control
            /// </param>
            /// <param name='requestMessage'>
            /// Source control token information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SourceControl> UpdateSourceControlAsync(this IWebSiteManagementClient operations, string sourceControlType, SourceControl requestMessage, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateSourceControlWithHttpMessagesAsync(sourceControlType, requestMessage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Check if a resource name is available.
            /// </summary>
            /// <remarks>
            /// Check if a resource name is available.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Resource name to verify.
            /// </param>
            /// <param name='type'>
            /// Resource type used for verification. Possible values include: 'Site',
            /// 'Slot', 'HostingEnvironment'
            /// </param>
            /// <param name='isFqdn'>
            /// Is fully qualified domain name.
            /// </param>
            public static ResourceNameAvailability CheckNameAvailability(this IWebSiteManagementClient operations, string name, string type, bool? isFqdn = default(bool?))
            {
                return operations.CheckNameAvailabilityAsync(name, type, isFqdn).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check if a resource name is available.
            /// </summary>
            /// <remarks>
            /// Check if a resource name is available.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Resource name to verify.
            /// </param>
            /// <param name='type'>
            /// Resource type used for verification. Possible values include: 'Site',
            /// 'Slot', 'HostingEnvironment'
            /// </param>
            /// <param name='isFqdn'>
            /// Is fully qualified domain name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceNameAvailability> CheckNameAvailabilityAsync(this IWebSiteManagementClient operations, string name, string type, bool? isFqdn = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(name, type, isFqdn, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of available geographical regions.
            /// </summary>
            /// <remarks>
            /// Get a list of available geographical regions.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sku'>
            /// Name of SKU used to filter the regions. Possible values include: 'Free',
            /// 'Shared', 'Basic', 'Standard', 'Premium', 'Dynamic', 'Isolated'
            /// </param>
            /// <param name='linuxWorkersEnabled'>
            /// Specify &lt;code&gt;true&lt;/code&gt; if you want to filter to only regions
            /// that support Linux workers.
            /// </param>
            public static IPage<GeoRegion> ListGeoRegions(this IWebSiteManagementClient operations, string sku = default(string), bool? linuxWorkersEnabled = default(bool?))
            {
                return operations.ListGeoRegionsAsync(sku, linuxWorkersEnabled).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of available geographical regions.
            /// </summary>
            /// <remarks>
            /// Get a list of available geographical regions.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sku'>
            /// Name of SKU used to filter the regions. Possible values include: 'Free',
            /// 'Shared', 'Basic', 'Standard', 'Premium', 'Dynamic', 'Isolated'
            /// </param>
            /// <param name='linuxWorkersEnabled'>
            /// Specify &lt;code&gt;true&lt;/code&gt; if you want to filter to only regions
            /// that support Linux workers.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GeoRegion>> ListGeoRegionsAsync(this IWebSiteManagementClient operations, string sku = default(string), bool? linuxWorkersEnabled = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListGeoRegionsWithHttpMessagesAsync(sku, linuxWorkersEnabled, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all premier add-on offers.
            /// </summary>
            /// <remarks>
            /// List all premier add-on offers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<PremierAddOnOffer> ListPremierAddOnOffers(this IWebSiteManagementClient operations)
            {
                return operations.ListPremierAddOnOffersAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all premier add-on offers.
            /// </summary>
            /// <remarks>
            /// List all premier add-on offers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PremierAddOnOffer>> ListPremierAddOnOffersAsync(this IWebSiteManagementClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListPremierAddOnOffersWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all SKUs.
            /// </summary>
            /// <remarks>
            /// List all SKUs.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static SkuInfos ListSkus(this IWebSiteManagementClient operations)
            {
                return operations.ListSkusAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all SKUs.
            /// </summary>
            /// <remarks>
            /// List all SKUs.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SkuInfos> ListSkusAsync(this IWebSiteManagementClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSkusWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Verifies if this VNET is compatible with an App Service Environment.
            /// </summary>
            /// <remarks>
            /// Verifies if this VNET is compatible with an App Service Environment by
            /// analyzing the Network Security Group rules.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// VNET information
            /// </param>
            public static VnetValidationFailureDetails VerifyHostingEnvironmentVnet(this IWebSiteManagementClient operations, VnetParameters parameters)
            {
                return operations.VerifyHostingEnvironmentVnetAsync(parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Verifies if this VNET is compatible with an App Service Environment.
            /// </summary>
            /// <remarks>
            /// Verifies if this VNET is compatible with an App Service Environment by
            /// analyzing the Network Security Group rules.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// VNET information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VnetValidationFailureDetails> VerifyHostingEnvironmentVnetAsync(this IWebSiteManagementClient operations, VnetParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.VerifyHostingEnvironmentVnetWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Move resources between resource groups.
            /// </summary>
            /// <remarks>
            /// Move resources between resource groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='moveResourceEnvelope'>
            /// Object that represents the resource to move.
            /// </param>
            public static void Move(this IWebSiteManagementClient operations, string resourceGroupName, CsmMoveResourceEnvelope moveResourceEnvelope)
            {
                operations.MoveAsync(resourceGroupName, moveResourceEnvelope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Move resources between resource groups.
            /// </summary>
            /// <remarks>
            /// Move resources between resource groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='moveResourceEnvelope'>
            /// Object that represents the resource to move.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task MoveAsync(this IWebSiteManagementClient operations, string resourceGroupName, CsmMoveResourceEnvelope moveResourceEnvelope, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.MoveWithHttpMessagesAsync(resourceGroupName, moveResourceEnvelope, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Validate if a resource can be created.
            /// </summary>
            /// <remarks>
            /// Validate if a resource can be created.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='validateRequest'>
            /// Request with the resources to validate.
            /// </param>
            public static ValidateResponse Validate(this IWebSiteManagementClient operations, string resourceGroupName, ValidateRequest validateRequest)
            {
                return operations.ValidateAsync(resourceGroupName, validateRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validate if a resource can be created.
            /// </summary>
            /// <remarks>
            /// Validate if a resource can be created.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='validateRequest'>
            /// Request with the resources to validate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ValidateResponse> ValidateAsync(this IWebSiteManagementClient operations, string resourceGroupName, ValidateRequest validateRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidateWithHttpMessagesAsync(resourceGroupName, validateRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Validate whether a resource can be moved.
            /// </summary>
            /// <remarks>
            /// Validate whether a resource can be moved.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='moveResourceEnvelope'>
            /// Object that represents the resource to move.
            /// </param>
            public static void ValidateMove(this IWebSiteManagementClient operations, string resourceGroupName, CsmMoveResourceEnvelope moveResourceEnvelope)
            {
                operations.ValidateMoveAsync(resourceGroupName, moveResourceEnvelope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validate whether a resource can be moved.
            /// </summary>
            /// <remarks>
            /// Validate whether a resource can be moved.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='moveResourceEnvelope'>
            /// Object that represents the resource to move.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ValidateMoveAsync(this IWebSiteManagementClient operations, string resourceGroupName, CsmMoveResourceEnvelope moveResourceEnvelope, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.ValidateMoveWithHttpMessagesAsync(resourceGroupName, moveResourceEnvelope, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the source controls available for Azure websites.
            /// </summary>
            /// <remarks>
            /// Gets the source controls available for Azure websites.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SourceControl> ListSourceControlsNext(this IWebSiteManagementClient operations, string nextPageLink)
            {
                return operations.ListSourceControlsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the source controls available for Azure websites.
            /// </summary>
            /// <remarks>
            /// Gets the source controls available for Azure websites.
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
            public static async Task<IPage<SourceControl>> ListSourceControlsNextAsync(this IWebSiteManagementClient operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSourceControlsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of available geographical regions.
            /// </summary>
            /// <remarks>
            /// Get a list of available geographical regions.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<GeoRegion> ListGeoRegionsNext(this IWebSiteManagementClient operations, string nextPageLink)
            {
                return operations.ListGeoRegionsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of available geographical regions.
            /// </summary>
            /// <remarks>
            /// Get a list of available geographical regions.
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
            public static async Task<IPage<GeoRegion>> ListGeoRegionsNextAsync(this IWebSiteManagementClient operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListGeoRegionsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all premier add-on offers.
            /// </summary>
            /// <remarks>
            /// List all premier add-on offers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<PremierAddOnOffer> ListPremierAddOnOffersNext(this IWebSiteManagementClient operations, string nextPageLink)
            {
                return operations.ListPremierAddOnOffersNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all premier add-on offers.
            /// </summary>
            /// <remarks>
            /// List all premier add-on offers.
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
            public static async Task<IPage<PremierAddOnOffer>> ListPremierAddOnOffersNextAsync(this IWebSiteManagementClient operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListPremierAddOnOffersNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
