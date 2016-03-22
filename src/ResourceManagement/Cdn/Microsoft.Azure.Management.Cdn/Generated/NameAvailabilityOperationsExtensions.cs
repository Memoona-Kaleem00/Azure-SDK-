// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class NameAvailabilityOperationsExtensions
    {
            /// <summary>
            /// Check the availability of a resource name without creating the resource.
            /// This is needed for resources where name is globally unique, such as a CDN
            /// endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// The resource name to validate.
            /// </param>
            /// <param name='type'>
            /// The type of the resource whose name is to be validated. Possible values
            /// for this property include: 'Microsoft.Cdn/Profiles/Endpoints'.
            /// </param>
            public static CheckNameAvailabilityOutput CheckNameAvailability(this INameAvailabilityOperations operations, string name, ResourceType? type)
            {
                return Task.Factory.StartNew(s => ((INameAvailabilityOperations)s).CheckNameAvailabilityAsync(name, type), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check the availability of a resource name without creating the resource.
            /// This is needed for resources where name is globally unique, such as a CDN
            /// endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// The resource name to validate.
            /// </param>
            /// <param name='type'>
            /// The type of the resource whose name is to be validated. Possible values
            /// for this property include: 'Microsoft.Cdn/Profiles/Endpoints'.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameAvailabilityOutput> CheckNameAvailabilityAsync( this INameAvailabilityOperations operations, string name, ResourceType? type, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(name, type, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

    }
}
