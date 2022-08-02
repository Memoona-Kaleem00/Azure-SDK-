// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary> A class representing the ApiIssueComment data model. </summary>
    public partial class ApiIssueCommentData : ResourceData
    {
        /// <summary> Initializes a new instance of ApiIssueCommentData. </summary>
        public ApiIssueCommentData()
        {
        }

        /// <summary> Initializes a new instance of ApiIssueCommentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="text"> Comment text. </param>
        /// <param name="createdOn"> Date and time when the comment was created. </param>
        /// <param name="userId"> A resource identifier for the user who left the comment. </param>
        internal ApiIssueCommentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string text, DateTimeOffset? createdOn, ResourceIdentifier userId) : base(id, name, resourceType, systemData)
        {
            Text = text;
            CreatedOn = createdOn;
            UserId = userId;
        }

        /// <summary> Comment text. </summary>
        public string Text { get; set; }
        /// <summary> Date and time when the comment was created. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> A resource identifier for the user who left the comment. </summary>
        public ResourceIdentifier UserId { get; set; }
    }
}
