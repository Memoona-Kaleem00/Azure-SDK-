// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the TopLevelDomain data model. </summary>
    public partial class TopLevelDomainData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of TopLevelDomainData. </summary>
        public TopLevelDomainData()
        {
        }

        /// <summary> Initializes a new instance of TopLevelDomainData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="privacy"> If &lt;code&gt;true&lt;/code&gt;, then the top level domain supports domain privacy; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        internal TopLevelDomainData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string kind, bool? privacy) : base(id, name, type, systemData, kind)
        {
            Privacy = privacy;
        }

        /// <summary> If &lt;code&gt;true&lt;/code&gt;, then the top level domain supports domain privacy; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? Privacy { get; set; }
    }
}
