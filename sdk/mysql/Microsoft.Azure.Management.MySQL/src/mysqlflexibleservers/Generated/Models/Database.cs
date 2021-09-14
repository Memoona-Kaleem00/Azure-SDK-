// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.MySQL.FlexibleServers.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Represents a Database.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Database : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Database class.
        /// </summary>
        public Database()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Database class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="charset">The charset of the database.</param>
        /// <param name="collation">The collation of the database.</param>
        public Database(string id = default(string), string name = default(string), string type = default(string), string charset = default(string), string collation = default(string))
            : base(id, name, type)
        {
            Charset = charset;
            Collation = collation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the charset of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.charset")]
        public string Charset { get; set; }

        /// <summary>
        /// Gets or sets the collation of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.collation")]
        public string Collation { get; set; }

    }
}
