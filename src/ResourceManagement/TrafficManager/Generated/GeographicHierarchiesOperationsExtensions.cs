// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.TrafficManager.Fluent
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.TrafficManager;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GeographicHierarchiesOperations.
    /// </summary>
    public static partial class GeographicHierarchiesOperationsExtensions
    {
            /// <summary>
            /// Gets the default Geographic Hierarchy used by the Geographic traffic
            /// routing method.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static TrafficManagerGeographicHierarchyInner GetDefault(this IGeographicHierarchiesOperations operations)
            {
                return operations.GetDefaultAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the default Geographic Hierarchy used by the Geographic traffic
            /// routing method.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrafficManagerGeographicHierarchyInner> GetDefaultAsync(this IGeographicHierarchiesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDefaultWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
