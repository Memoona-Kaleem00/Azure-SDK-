// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class RecommendationsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of recommendations associated with the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='featured'>
            /// If set, this API returns only the most critical recommendation among the
            /// others. Otherwise this API returns all recommendations available
            /// </param>
            /// <param name='filter'>
            /// Return only channels specified in the filter. Filter is specified by using
            /// OData syntax. Example: $filter=channels eq 'Api' or channel eq
            /// 'Notification'
            /// </param>
            public static IList<Recommendation> GetRecommendationBySubscription(this IRecommendationsOperations operations, bool? featured = default(bool?), string filter = default(string))
            {
                return Task.Factory.StartNew(s => ((IRecommendationsOperations)s).GetRecommendationBySubscriptionAsync(featured, filter), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of recommendations associated with the specified subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='featured'>
            /// If set, this API returns only the most critical recommendation among the
            /// others. Otherwise this API returns all recommendations available
            /// </param>
            /// <param name='filter'>
            /// Return only channels specified in the filter. Filter is specified by using
            /// OData syntax. Example: $filter=channels eq 'Api' or channel eq
            /// 'Notification'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Recommendation>> GetRecommendationBySubscriptionAsync( this IRecommendationsOperations operations, bool? featured = default(bool?), string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRecommendationBySubscriptionWithHttpMessagesAsync(featured, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the detailed properties of the recommendation object for the
            /// specified web site.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name
            /// </param>
            /// <param name='siteName'>
            /// Site name
            /// </param>
            /// <param name='name'>
            /// Recommendation rule name
            /// </param>
            /// <param name='updateSeen'>
            /// If true, the backend updates the last seen timestamp of the recommendation
            /// object.
            /// </param>
            public static RecommendationRule GetRuleDetailsBySiteName(this IRecommendationsOperations operations, string resourceGroupName, string siteName, string name, bool? updateSeen = default(bool?))
            {
                return Task.Factory.StartNew(s => ((IRecommendationsOperations)s).GetRuleDetailsBySiteNameAsync(resourceGroupName, siteName, name, updateSeen), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the detailed properties of the recommendation object for the
            /// specified web site.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name
            /// </param>
            /// <param name='siteName'>
            /// Site name
            /// </param>
            /// <param name='name'>
            /// Recommendation rule name
            /// </param>
            /// <param name='updateSeen'>
            /// If true, the backend updates the last seen timestamp of the recommendation
            /// object.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RecommendationRule> GetRuleDetailsBySiteNameAsync( this IRecommendationsOperations operations, string resourceGroupName, string siteName, string name, bool? updateSeen = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRuleDetailsBySiteNameWithHttpMessagesAsync(resourceGroupName, siteName, name, updateSeen, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of recommendations associated with the specified web site.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name
            /// </param>
            /// <param name='siteName'>
            /// Site name
            /// </param>
            /// <param name='featured'>
            /// If set, this API returns only the most critical recommendation among the
            /// others. Otherwise this API returns all recommendations available
            /// </param>
            /// <param name='siteSku'>
            /// The name of site SKU.
            /// </param>
            /// <param name='numSlots'>
            /// The number of site slots associated to the site
            /// </param>
            /// <param name='liveHours'>
            /// If greater than zero, this API scans the last active live site symptoms,
            /// dynamically generate on-the-fly recommendations
            /// </param>
            public static IList<Recommendation> GetRecommendedRulesForSite(this IRecommendationsOperations operations, string resourceGroupName, string siteName, bool? featured = default(bool?), string siteSku = default(string), int? numSlots = default(int?), int? liveHours = default(int?))
            {
                return Task.Factory.StartNew(s => ((IRecommendationsOperations)s).GetRecommendedRulesForSiteAsync(resourceGroupName, siteName, featured, siteSku, numSlots, liveHours), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of recommendations associated with the specified web site.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name
            /// </param>
            /// <param name='siteName'>
            /// Site name
            /// </param>
            /// <param name='featured'>
            /// If set, this API returns only the most critical recommendation among the
            /// others. Otherwise this API returns all recommendations available
            /// </param>
            /// <param name='siteSku'>
            /// The name of site SKU.
            /// </param>
            /// <param name='numSlots'>
            /// The number of site slots associated to the site
            /// </param>
            /// <param name='liveHours'>
            /// If greater than zero, this API scans the last active live site symptoms,
            /// dynamically generate on-the-fly recommendations
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Recommendation>> GetRecommendedRulesForSiteAsync( this IRecommendationsOperations operations, string resourceGroupName, string siteName, bool? featured = default(bool?), string siteSku = default(string), int? numSlots = default(int?), int? liveHours = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRecommendedRulesForSiteWithHttpMessagesAsync(resourceGroupName, siteName, featured, siteSku, numSlots, liveHours, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of past recommendations optionally specified by the time
            /// range.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name
            /// </param>
            /// <param name='siteName'>
            /// Site name
            /// </param>
            /// <param name='startTime'>
            /// The start time of a time range to query, e.g. $filter=startTime eq
            /// '2015-01-01T00:00:00Z' and endTime eq '2015-01-02T00:00:00Z'
            /// </param>
            /// <param name='endTime'>
            /// The end time of a time range to query, e.g. $filter=startTime eq
            /// '2015-01-01T00:00:00Z' and endTime eq '2015-01-02T00:00:00Z'
            /// </param>
            public static IList<Recommendation> GetRecommendationHistoryForSite(this IRecommendationsOperations operations, string resourceGroupName, string siteName, string startTime = default(string), string endTime = default(string))
            {
                return Task.Factory.StartNew(s => ((IRecommendationsOperations)s).GetRecommendationHistoryForSiteAsync(resourceGroupName, siteName, startTime, endTime), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of past recommendations optionally specified by the time
            /// range.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name
            /// </param>
            /// <param name='siteName'>
            /// Site name
            /// </param>
            /// <param name='startTime'>
            /// The start time of a time range to query, e.g. $filter=startTime eq
            /// '2015-01-01T00:00:00Z' and endTime eq '2015-01-02T00:00:00Z'
            /// </param>
            /// <param name='endTime'>
            /// The end time of a time range to query, e.g. $filter=startTime eq
            /// '2015-01-01T00:00:00Z' and endTime eq '2015-01-02T00:00:00Z'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Recommendation>> GetRecommendationHistoryForSiteAsync( this IRecommendationsOperations operations, string resourceGroupName, string siteName, string startTime = default(string), string endTime = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRecommendationHistoryForSiteWithHttpMessagesAsync(resourceGroupName, siteName, startTime, endTime, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
