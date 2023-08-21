// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Response for the ListAvailableContacts API service call. </summary>
    public partial class OrbitalAvailableContactsResult
    {
        /// <summary> Initializes a new instance of OrbitalAvailableContactsResult. </summary>
        internal OrbitalAvailableContactsResult()
        {
            Values = new Core.ChangeTrackingList<OrbitalAvailableContact>();
        }

        /// <summary> Initializes a new instance of OrbitalAvailableContactsResult. </summary>
        /// <param name="values"> A list of available contacts. </param>
        internal OrbitalAvailableContactsResult(IReadOnlyList<OrbitalAvailableContact> values)
        {
            Values = values;
        }

        /// <summary> A list of available contacts. </summary>
        public IReadOnlyList<OrbitalAvailableContact> Values { get; }
    }
}
