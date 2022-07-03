// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary> A class representing the NotificationContract data model. </summary>
    public partial class NotificationContractData : ResourceData
    {
        /// <summary> Initializes a new instance of NotificationContractData. </summary>
        public NotificationContractData()
        {
        }

        /// <summary> Initializes a new instance of NotificationContractData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="title"> Title of the Notification. </param>
        /// <param name="description"> Description of the Notification. </param>
        /// <param name="recipients"> Recipient Parameter values. </param>
        internal NotificationContractData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string title, string description, RecipientsContractProperties recipients) : base(id, name, resourceType, systemData)
        {
            Title = title;
            Description = description;
            Recipients = recipients;
        }

        /// <summary> Title of the Notification. </summary>
        public string Title { get; set; }
        /// <summary> Description of the Notification. </summary>
        public string Description { get; set; }
        /// <summary> Recipient Parameter values. </summary>
        public RecipientsContractProperties Recipients { get; set; }
    }
}
