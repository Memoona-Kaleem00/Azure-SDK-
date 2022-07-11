// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the Deployment data model. </summary>
    public partial class DeploymentData : ResourceData
    {
        /// <summary> Initializes a new instance of DeploymentData. </summary>
        public DeploymentData()
        {
        }

        /// <summary> Initializes a new instance of DeploymentData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status">
        /// Deployment status.
        /// Serialized Name: Deployment.properties.status
        /// </param>
        /// <param name="message">
        /// Details about deployment status.
        /// Serialized Name: Deployment.properties.message
        /// </param>
        /// <param name="author">
        /// Who authored the deployment.
        /// Serialized Name: Deployment.properties.author
        /// </param>
        /// <param name="deployer">
        /// Who performed the deployment.
        /// Serialized Name: Deployment.properties.deployer
        /// </param>
        /// <param name="authorEmail">
        /// Author email.
        /// Serialized Name: Deployment.properties.author_email
        /// </param>
        /// <param name="startOn">
        /// Start time.
        /// Serialized Name: Deployment.properties.start_time
        /// </param>
        /// <param name="endOn">
        /// End time.
        /// Serialized Name: Deployment.properties.end_time
        /// </param>
        /// <param name="isActive">
        /// True if deployment is currently active, false if completed and null if not started.
        /// Serialized Name: Deployment.properties.active
        /// </param>
        /// <param name="details">
        /// Details on deployment.
        /// Serialized Name: Deployment.properties.details
        /// </param>
        /// <param name="kind">
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </param>
        internal DeploymentData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? status, string message, string author, string deployer, string authorEmail, DateTimeOffset? startOn, DateTimeOffset? endOn, bool? isActive, string details, string kind) : base(id, name, resourceType, systemData)
        {
            Status = status;
            Message = message;
            Author = author;
            Deployer = deployer;
            AuthorEmail = authorEmail;
            StartOn = startOn;
            EndOn = endOn;
            IsActive = isActive;
            Details = details;
            Kind = kind;
        }

        /// <summary>
        /// Deployment status.
        /// Serialized Name: Deployment.properties.status
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// Details about deployment status.
        /// Serialized Name: Deployment.properties.message
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Who authored the deployment.
        /// Serialized Name: Deployment.properties.author
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Who performed the deployment.
        /// Serialized Name: Deployment.properties.deployer
        /// </summary>
        public string Deployer { get; set; }
        /// <summary>
        /// Author email.
        /// Serialized Name: Deployment.properties.author_email
        /// </summary>
        public string AuthorEmail { get; set; }
        /// <summary>
        /// Start time.
        /// Serialized Name: Deployment.properties.start_time
        /// </summary>
        public DateTimeOffset? StartOn { get; set; }
        /// <summary>
        /// End time.
        /// Serialized Name: Deployment.properties.end_time
        /// </summary>
        public DateTimeOffset? EndOn { get; set; }
        /// <summary>
        /// True if deployment is currently active, false if completed and null if not started.
        /// Serialized Name: Deployment.properties.active
        /// </summary>
        public bool? IsActive { get; set; }
        /// <summary>
        /// Details on deployment.
        /// Serialized Name: Deployment.properties.details
        /// </summary>
        public string Details { get; set; }
        /// <summary>
        /// Kind of resource.
        /// Serialized Name: ProxyOnlyResource.kind
        /// </summary>
        public string Kind { get; set; }
    }
}
