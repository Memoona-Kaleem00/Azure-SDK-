// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> A static site user provided function. </summary>
    public partial class StaticSiteUserProvidedFunctionApp : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of StaticSiteUserProvidedFunctionApp. </summary>
        public StaticSiteUserProvidedFunctionApp()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteUserProvidedFunctionApp. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="functionAppResourceId"> The resource id of the function app registered with the static site. </param>
        /// <param name="functionAppRegion"> The region of the function app registered with the static site. </param>
        /// <param name="createdOn"> The date and time on which the function app was registered with the static site. </param>
        internal StaticSiteUserProvidedFunctionApp(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, string kind, string functionAppResourceId, string functionAppRegion, DateTimeOffset? createdOn) : base(id, name, type, systemData, kind)
        {
            FunctionAppResourceId = functionAppResourceId;
            FunctionAppRegion = functionAppRegion;
            CreatedOn = createdOn;
        }

        /// <summary> The resource id of the function app registered with the static site. </summary>
        public string FunctionAppResourceId { get; set; }
        /// <summary> The region of the function app registered with the static site. </summary>
        public string FunctionAppRegion { get; set; }
        /// <summary> The date and time on which the function app was registered with the static site. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
