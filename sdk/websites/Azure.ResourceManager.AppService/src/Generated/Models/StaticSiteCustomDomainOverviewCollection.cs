// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Collection of static site custom domains.
    /// Serialized Name: StaticSiteCustomDomainOverviewCollection
    /// </summary>
    internal partial class StaticSiteCustomDomainOverviewCollection
    {
        /// <summary> Initializes a new instance of StaticSiteCustomDomainOverviewCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: StaticSiteCustomDomainOverviewCollection.value
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal StaticSiteCustomDomainOverviewCollection(IEnumerable<StaticSiteCustomDomainOverviewARMResourceData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of StaticSiteCustomDomainOverviewCollection. </summary>
        /// <param name="value">
        /// Collection of resources.
        /// Serialized Name: StaticSiteCustomDomainOverviewCollection.value
        /// </param>
        /// <param name="nextLink">
        /// Link to next page of resources.
        /// Serialized Name: StaticSiteCustomDomainOverviewCollection.nextLink
        /// </param>
        internal StaticSiteCustomDomainOverviewCollection(IReadOnlyList<StaticSiteCustomDomainOverviewARMResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Collection of resources.
        /// Serialized Name: StaticSiteCustomDomainOverviewCollection.value
        /// </summary>
        public IReadOnlyList<StaticSiteCustomDomainOverviewARMResourceData> Value { get; }
        /// <summary>
        /// Link to next page of resources.
        /// Serialized Name: StaticSiteCustomDomainOverviewCollection.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
