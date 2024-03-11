// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// Format read settings.
    /// Please note <see cref="FormatReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BinaryReadSettings"/>, <see cref="DelimitedTextReadSettings"/>, <see cref="JsonReadSettings"/> and <see cref="XmlReadSettings"/>.
    /// </summary>
    public abstract partial class FormatReadSettings
    {
        /// <summary> Initializes a new instance of <see cref="FormatReadSettings"/>. </summary>
        protected FormatReadSettings()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="FormatReadSettings"/>. </summary>
        /// <param name="type"> The read setting type. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal FormatReadSettings(string type, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The read setting type. </summary>
        internal string Type { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
