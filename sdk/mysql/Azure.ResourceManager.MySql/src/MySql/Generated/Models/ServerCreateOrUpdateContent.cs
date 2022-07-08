// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> Represents a server to be created. </summary>
    public partial class ServerCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of ServerCreateOrUpdateContent. </summary>
        /// <param name="properties">
        /// Properties of the server.
        /// Please note <see cref="ServerPropertiesForCreate"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ServerPropertiesForDefaultCreate"/>, <see cref="ServerPropertiesForGeoRestore"/>, <see cref="ServerPropertiesForRestore"/> and <see cref="ServerPropertiesForReplica"/>.
        /// </param>
        /// <param name="location"> The location the resource resides in. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public ServerCreateOrUpdateContent(ServerPropertiesForCreate properties, AzureLocation location)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
            Location = location;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The Azure Active Directory identity of the server. </summary>
        public ResourceIdentity Identity { get; set; }
        /// <summary> The SKU (pricing tier) of the server. </summary>
        public MySqlSku Sku { get; set; }
        /// <summary>
        /// Properties of the server.
        /// Please note <see cref="ServerPropertiesForCreate"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ServerPropertiesForDefaultCreate"/>, <see cref="ServerPropertiesForGeoRestore"/>, <see cref="ServerPropertiesForRestore"/> and <see cref="ServerPropertiesForReplica"/>.
        /// </summary>
        public ServerPropertiesForCreate Properties { get; }
        /// <summary> The location the resource resides in. </summary>
        public AzureLocation Location { get; }
        /// <summary> Application-specific metadata in the form of key-value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
