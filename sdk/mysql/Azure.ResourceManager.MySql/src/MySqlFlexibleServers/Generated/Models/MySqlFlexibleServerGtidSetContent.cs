// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    /// <summary> Server Gtid set parameters. </summary>
    public partial class MySqlFlexibleServerGtidSetContent
    {
        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerGtidSetContent"/>. </summary>
        public MySqlFlexibleServerGtidSetContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MySqlFlexibleServerGtidSetContent"/>. </summary>
        /// <param name="gtidSet"> The Gtid set of server. </param>
        internal MySqlFlexibleServerGtidSetContent(string gtidSet)
        {
            GtidSet = gtidSet;
        }

        /// <summary> The Gtid set of server. </summary>
        public string GtidSet { get; set; }
    }
}
