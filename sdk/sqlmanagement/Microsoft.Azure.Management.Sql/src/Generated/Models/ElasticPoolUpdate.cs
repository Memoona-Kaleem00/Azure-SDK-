// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An elastic pool update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ElasticPoolUpdate
    {
        /// <summary>
        /// Initializes a new instance of the ElasticPoolUpdate class.
        /// </summary>
        public ElasticPoolUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ElasticPoolUpdate class.
        /// </summary>
        /// <param name="maxSizeBytes">The storage limit for the database
        /// elastic pool in bytes.</param>
        /// <param name="perDatabaseSettings">The per database settings for the
        /// elastic pool.</param>
        /// <param name="zoneRedundant">Whether or not this elastic pool is
        /// zone redundant, which means the replicas of this elastic pool will
        /// be spread across multiple availability zones.</param>
        /// <param name="licenseType">The license type to apply for this
        /// elastic pool. Possible values include: 'LicenseIncluded',
        /// 'BasePrice'</param>
        /// <param name="maintenanceConfigurationId">Maintenance configuration
        /// id assigned to the elastic pool. This configuration defines the
        /// period when the maintenance updates will will occur.</param>
        /// <param name="tags">Resource tags.</param>
        public ElasticPoolUpdate(Sku sku = default(Sku), long? maxSizeBytes = default(long?), ElasticPoolPerDatabaseSettings perDatabaseSettings = default(ElasticPoolPerDatabaseSettings), bool? zoneRedundant = default(bool?), ElasticPoolLicenseType? licenseType = default(ElasticPoolLicenseType?), string maintenanceConfigurationId = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Sku = sku;
            MaxSizeBytes = maxSizeBytes;
            PerDatabaseSettings = perDatabaseSettings;
            ZoneRedundant = zoneRedundant;
            LicenseType = licenseType;
            MaintenanceConfigurationId = maintenanceConfigurationId;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the storage limit for the database elastic pool in
        /// bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSizeBytes")]
        public long? MaxSizeBytes { get; set; }

        /// <summary>
        /// Gets or sets the per database settings for the elastic pool.
        /// </summary>
        [JsonProperty(PropertyName = "properties.perDatabaseSettings")]
        public ElasticPoolPerDatabaseSettings PerDatabaseSettings { get; set; }

        /// <summary>
        /// Gets or sets whether or not this elastic pool is zone redundant,
        /// which means the replicas of this elastic pool will be spread across
        /// multiple availability zones.
        /// </summary>
        [JsonProperty(PropertyName = "properties.zoneRedundant")]
        public bool? ZoneRedundant { get; set; }

        /// <summary>
        /// Gets or sets the license type to apply for this elastic pool.
        /// Possible values include: 'LicenseIncluded', 'BasePrice'
        /// </summary>
        [JsonProperty(PropertyName = "properties.licenseType")]
        public ElasticPoolLicenseType? LicenseType { get; set; }

        /// <summary>
        /// Gets or sets maintenance configuration id assigned to the elastic
        /// pool. This configuration defines the period when the maintenance
        /// updates will will occur.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maintenanceConfigurationId")]
        public string MaintenanceConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
