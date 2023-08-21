// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceProviderCapabilities. </summary>
    public partial class ResourceProviderCapabilities
    {
        /// <summary> Initializes a new instance of ResourceProviderCapabilities. </summary>
        /// <param name="quotaId"></param>
        /// <param name="effect"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaId"/> is null. </exception>
        public ResourceProviderCapabilities(string quotaId, ResourceProviderCapabilitiesEffect effect)
        {
            Argument.AssertNotNull(quotaId, nameof(quotaId));

            QuotaId = quotaId;
            Effect = effect;
            RequiredFeatures = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ResourceProviderCapabilities. </summary>
        /// <param name="quotaId"></param>
        /// <param name="effect"></param>
        /// <param name="requiredFeatures"></param>
        internal ResourceProviderCapabilities(string quotaId, ResourceProviderCapabilitiesEffect effect, IList<string> requiredFeatures)
        {
            QuotaId = quotaId;
            Effect = effect;
            RequiredFeatures = requiredFeatures;
        }

        /// <summary> Gets or sets the quota id. </summary>
        public string QuotaId { get; set; }
        /// <summary> Gets or sets the effect. </summary>
        public ResourceProviderCapabilitiesEffect Effect { get; set; }
        /// <summary> Gets the required features. </summary>
        public IList<string> RequiredFeatures { get; }
    }
}
