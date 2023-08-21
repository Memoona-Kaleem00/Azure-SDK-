// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> State details. </summary>
    public partial class AvailableProvidersListState
    {
        /// <summary> Initializes a new instance of AvailableProvidersListState. </summary>
        internal AvailableProvidersListState()
        {
            Providers = new Core.ChangeTrackingList<string>();
            Cities = new Core.ChangeTrackingList<AvailableProvidersListCity>();
        }

        /// <summary> Initializes a new instance of AvailableProvidersListState. </summary>
        /// <param name="stateName"> The state name. </param>
        /// <param name="providers"> A list of Internet service providers. </param>
        /// <param name="cities"> List of available cities or towns in the state. </param>
        internal AvailableProvidersListState(string stateName, IReadOnlyList<string> providers, IReadOnlyList<AvailableProvidersListCity> cities)
        {
            StateName = stateName;
            Providers = providers;
            Cities = cities;
        }

        /// <summary> The state name. </summary>
        public string StateName { get; }
        /// <summary> A list of Internet service providers. </summary>
        public IReadOnlyList<string> Providers { get; }
        /// <summary> List of available cities or towns in the state. </summary>
        public IReadOnlyList<AvailableProvidersListCity> Cities { get; }
    }
}
