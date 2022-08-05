// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Migrate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Migrate
{
    /// <summary> A class representing the Group data model. </summary>
    public partial class GroupData : ResourceData
    {
        /// <summary> Initializes a new instance of GroupData. </summary>
        /// <param name="properties"> Properties of the group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public GroupData(GroupProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of GroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="eTag"> For optimistic concurrency control. </param>
        /// <param name="properties"> Properties of the group. </param>
        internal GroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? eTag, GroupProperties properties) : base(id, name, resourceType, systemData)
        {
            ETag = eTag;
            Properties = properties;
        }

        /// <summary> For optimistic concurrency control. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Properties of the group. </summary>
        public GroupProperties Properties { get; set; }
    }
}
