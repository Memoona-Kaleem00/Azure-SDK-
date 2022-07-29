// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// The list of application resources.
    /// Serialized Name: ApplicationResourceList
    /// </summary>
    internal partial class ServiceFabricApplicationList
    {
        /// <summary> Initializes a new instance of ServiceFabricApplicationList. </summary>
        internal ServiceFabricApplicationList()
        {
            Value = new ChangeTrackingList<ServiceFabricApplicationResourceData>();
        }

        /// <summary> Initializes a new instance of ServiceFabricApplicationList. </summary>
        /// <param name="value"> Serialized Name: ApplicationResourceList.value. </param>
        /// <param name="nextLink">
        /// URL to get the next set of application list results if there are any.
        /// Serialized Name: ApplicationResourceList.nextLink
        /// </param>
        internal ServiceFabricApplicationList(IReadOnlyList<ServiceFabricApplicationResourceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Serialized Name: ApplicationResourceList.value. </summary>
        public IReadOnlyList<ServiceFabricApplicationResourceData> Value { get; }
        /// <summary>
        /// URL to get the next set of application list results if there are any.
        /// Serialized Name: ApplicationResourceList.nextLink
        /// </summary>
        public string NextLink { get; }
    }
}
