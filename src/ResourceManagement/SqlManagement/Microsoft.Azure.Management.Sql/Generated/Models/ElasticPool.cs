// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a database elastic pool.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ElasticPool : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ElasticPool class.
        /// </summary>
        public ElasticPool() { }

        /// <summary>
        /// Initializes a new instance of the ElasticPool class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="creationDate">The creation date of the elastic pool
        /// (ISO8601 format).</param>
        /// <param name="state">The state of the elastic pool. Possible values
        /// include: 'Creating', 'Ready', 'Disabled'</param>
        /// <param name="edition">The edition of the elastic pool. Possible
        /// values include: 'Basic', 'Standard', 'Premium'</param>
        /// <param name="dtu">The total shared DTU for the database elastic
        /// pool.</param>
        /// <param name="databaseDtuMax">The maximum DTU any one database can
        /// consume.</param>
        /// <param name="databaseDtuMin">The minimum DTU all databases are
        /// guaranteed.</param>
        /// <param name="storageMB">Gets storage limit for the database elastic
        /// pool in MB.</param>
        /// <param name="kind">Kind of elastic pool.  This is metadata used for
        /// the Azure portal experience.</param>
        public ElasticPool(string location, string name = default(string), string id = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? creationDate = default(System.DateTime?), string state = default(string), string edition = default(string), int? dtu = default(int?), int? databaseDtuMax = default(int?), int? databaseDtuMin = default(int?), int? storageMB = default(int?), string kind = default(string))
            : base(location, name, id, type, tags)
        {
            CreationDate = creationDate;
            State = state;
            Edition = edition;
            Dtu = dtu;
            DatabaseDtuMax = databaseDtuMax;
            DatabaseDtuMin = databaseDtuMin;
            StorageMB = storageMB;
            Kind = kind;
        }

        /// <summary>
        /// Gets the creation date of the elastic pool (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets the state of the elastic pool. Possible values include:
        /// 'Creating', 'Ready', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets or sets the edition of the elastic pool. Possible values
        /// include: 'Basic', 'Standard', 'Premium'
        /// </summary>
        [JsonProperty(PropertyName = "properties.edition")]
        public string Edition { get; set; }

        /// <summary>
        /// Gets or sets the total shared DTU for the database elastic pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dtu")]
        public int? Dtu { get; set; }

        /// <summary>
        /// Gets or sets the maximum DTU any one database can consume.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseDtuMax")]
        public int? DatabaseDtuMax { get; set; }

        /// <summary>
        /// Gets or sets the minimum DTU all databases are guaranteed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseDtuMin")]
        public int? DatabaseDtuMin { get; set; }

        /// <summary>
        /// Gets storage limit for the database elastic pool in MB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageMB")]
        public int? StorageMB { get; set; }

        /// <summary>
        /// Gets kind of elastic pool.  This is metadata used for the Azure
        /// portal experience.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
