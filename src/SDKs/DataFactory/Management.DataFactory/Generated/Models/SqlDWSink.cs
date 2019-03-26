// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity SQL Data Warehouse sink.
    /// </summary>
    public partial class SqlDWSink : CopySink
    {
        /// <summary>
        /// Initializes a new instance of the SqlDWSink class.
        /// </summary>
        public SqlDWSink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlDWSink class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="writeBatchSize">Write batch size. Type: integer (or
        /// Expression with resultType integer), minimum: 0.</param>
        /// <param name="writeBatchTimeout">Write batch timeout. Type: string
        /// (or Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="sinkRetryCount">Sink retry count. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="sinkRetryWait">Sink retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the sink data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="preCopyScript">SQL pre-copy script. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="allowPolyBase">Indicates to use PolyBase to copy data
        /// into SQL Data Warehouse when applicable. Type: boolean (or
        /// Expression with resultType boolean).</param>
        /// <param name="polyBaseSettings">Specifies PolyBase-related settings
        /// when allowPolyBase is true.</param>
        public SqlDWSink(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object writeBatchSize = default(object), object writeBatchTimeout = default(object), object sinkRetryCount = default(object), object sinkRetryWait = default(object), object maxConcurrentConnections = default(object), object preCopyScript = default(object), object allowPolyBase = default(object), PolybaseSettings polyBaseSettings = default(PolybaseSettings))
            : base(additionalProperties, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections)
        {
            PreCopyScript = preCopyScript;
            AllowPolyBase = allowPolyBase;
            PolyBaseSettings = polyBaseSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SQL pre-copy script. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "preCopyScript")]
        public object PreCopyScript { get; set; }

        /// <summary>
        /// Gets or sets indicates to use PolyBase to copy data into SQL Data
        /// Warehouse when applicable. Type: boolean (or Expression with
        /// resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "allowPolyBase")]
        public object AllowPolyBase { get; set; }

        /// <summary>
        /// Gets or sets specifies PolyBase-related settings when allowPolyBase
        /// is true.
        /// </summary>
        [JsonProperty(PropertyName = "polyBaseSettings")]
        public PolybaseSettings PolyBaseSettings { get; set; }

    }
}
