// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> The CollectorProperties. </summary>
    public partial class CollectorProperties
    {
        /// <summary> Initializes a new instance of CollectorProperties. </summary>
        public CollectorProperties()
        {
        }

        /// <summary> Initializes a new instance of CollectorProperties. </summary>
        /// <param name="discoverySiteId"> The ARM id of the discovery service site. </param>
        /// <param name="createdTimestamp"> Time when this collector was created. Date-Time represented in ISO-8601 format. </param>
        /// <param name="updatedTimestamp"> Time when this collector was updated. Date-Time represented in ISO-8601 format. </param>
        /// <param name="agentProperties"></param>
        internal CollectorProperties(string discoverySiteId, string createdTimestamp, string updatedTimestamp, CollectorAgentProperties agentProperties)
        {
            DiscoverySiteId = discoverySiteId;
            CreatedTimestamp = createdTimestamp;
            UpdatedTimestamp = updatedTimestamp;
            AgentProperties = agentProperties;
        }

        /// <summary> The ARM id of the discovery service site. </summary>
        public string DiscoverySiteId { get; set; }
        /// <summary> Time when this collector was created. Date-Time represented in ISO-8601 format. </summary>
        public string CreatedTimestamp { get; }
        /// <summary> Time when this collector was updated. Date-Time represented in ISO-8601 format. </summary>
        public string UpdatedTimestamp { get; }
        /// <summary> Gets or sets the agent properties. </summary>
        public CollectorAgentProperties AgentProperties { get; set; }
    }
}
