// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Invitation data transfer object.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Invitation : ProxyDto
    {
        /// <summary>
        /// Initializes a new instance of the Invitation class.
        /// </summary>
        public Invitation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Invitation class.
        /// </summary>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="systemData">System Data of the Azure resource.</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="expirationDate">The expiration date for the invitation
        /// and share subscription.</param>
        /// <param name="invitationId">unique invitation id</param>
        /// <param name="invitationStatus">The status of the invitation.
        /// Possible values include: 'Pending', 'Accepted', 'Rejected',
        /// 'Withdrawn'</param>
        /// <param name="respondedAt">The time the recipient responded to the
        /// invitation.</param>
        /// <param name="sentAt">Gets the time at which the invitation was
        /// sent.</param>
        /// <param name="targetActiveDirectoryId">The target Azure AD Id. Can't
        /// be combined with email.</param>
        /// <param name="targetEmail">The email the invitation is directed
        /// to.</param>
        /// <param name="targetObjectId">The target user or application Id that
        /// invitation is being sent to.
        /// Must be specified along TargetActiveDirectoryId. This enables
        /// sending
        /// invitations to specific users or applications in an AD
        /// tenant.</param>
        /// <param name="userEmail">Email of the user who created the
        /// resource</param>
        /// <param name="userName">Name of the user who created the
        /// resource</param>
        public Invitation(string id = default(string), string name = default(string), SystemData systemData = default(SystemData), string type = default(string), System.DateTime? expirationDate = default(System.DateTime?), string invitationId = default(string), string invitationStatus = default(string), System.DateTime? respondedAt = default(System.DateTime?), System.DateTime? sentAt = default(System.DateTime?), string targetActiveDirectoryId = default(string), string targetEmail = default(string), string targetObjectId = default(string), string userEmail = default(string), string userName = default(string))
            : base(id, name, systemData, type)
        {
            ExpirationDate = expirationDate;
            InvitationId = invitationId;
            InvitationStatus = invitationStatus;
            RespondedAt = respondedAt;
            SentAt = sentAt;
            TargetActiveDirectoryId = targetActiveDirectoryId;
            TargetEmail = targetEmail;
            TargetObjectId = targetObjectId;
            UserEmail = userEmail;
            UserName = userName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the expiration date for the invitation and share
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationDate")]
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets unique invitation id
        /// </summary>
        [JsonProperty(PropertyName = "properties.invitationId")]
        public string InvitationId { get; private set; }

        /// <summary>
        /// Gets the status of the invitation. Possible values include:
        /// 'Pending', 'Accepted', 'Rejected', 'Withdrawn'
        /// </summary>
        [JsonProperty(PropertyName = "properties.invitationStatus")]
        public string InvitationStatus { get; private set; }

        /// <summary>
        /// Gets the time the recipient responded to the invitation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.respondedAt")]
        public System.DateTime? RespondedAt { get; private set; }

        /// <summary>
        /// Gets the time at which the invitation was sent.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sentAt")]
        public System.DateTime? SentAt { get; private set; }

        /// <summary>
        /// Gets or sets the target Azure AD Id. Can't be combined with email.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetActiveDirectoryId")]
        public string TargetActiveDirectoryId { get; set; }

        /// <summary>
        /// Gets or sets the email the invitation is directed to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetEmail")]
        public string TargetEmail { get; set; }

        /// <summary>
        /// Gets or sets the target user or application Id that invitation is
        /// being sent to.
        /// Must be specified along TargetActiveDirectoryId. This enables
        /// sending
        /// invitations to specific users or applications in an AD tenant.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetObjectId")]
        public string TargetObjectId { get; set; }

        /// <summary>
        /// Gets email of the user who created the resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.userEmail")]
        public string UserEmail { get; private set; }

        /// <summary>
        /// Gets name of the user who created the resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; private set; }

    }
}
