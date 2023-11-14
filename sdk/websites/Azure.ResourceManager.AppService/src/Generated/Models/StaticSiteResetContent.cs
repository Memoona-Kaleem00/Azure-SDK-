// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Static Site Reset Properties ARM resource. </summary>
    public partial class StaticSiteResetContent : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StaticSiteResetContent"/>. </summary>
        public StaticSiteResetContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StaticSiteResetContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="repositoryToken"> The token which proves admin privileges to the repository. </param>
        /// <param name="shouldUpdateRepository"> Determines whether the repository should be updated with the new properties. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StaticSiteResetContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string repositoryToken, bool? shouldUpdateRepository, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            RepositoryToken = repositoryToken;
            ShouldUpdateRepository = shouldUpdateRepository;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The token which proves admin privileges to the repository. </summary>
        public string RepositoryToken { get; set; }
        /// <summary> Determines whether the repository should be updated with the new properties. </summary>
        public bool? ShouldUpdateRepository { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
