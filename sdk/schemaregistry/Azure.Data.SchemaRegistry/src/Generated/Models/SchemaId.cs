// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Data.SchemaRegistry.Models
{
    /// <summary> Object received from the registry containing schema identifiers. </summary>
    internal readonly partial struct SchemaId
    {
        /// <summary> Initializes a new instance of SchemaId. </summary>
        /// <param name="id"> Schema ID that uniquely identifies a schema in the registry namespace. </param>
        internal SchemaId(string id)
        {
            Id = id;
        }

        /// <summary> Schema ID that uniquely identifies a schema in the registry namespace. </summary>
        public string Id { get; }
    }
}
