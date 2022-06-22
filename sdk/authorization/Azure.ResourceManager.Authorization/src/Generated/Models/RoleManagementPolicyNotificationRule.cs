// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    /// <summary> The role management policy notification rule. </summary>
    public partial class RoleManagementPolicyNotificationRule : RoleManagementPolicyRule
    {
        /// <summary> Initializes a new instance of RoleManagementPolicyNotificationRule. </summary>
        public RoleManagementPolicyNotificationRule()
        {
            NotificationRecipients = new ChangeTrackingList<string>();
            RuleType = RoleManagementPolicyRuleType.RoleManagementPolicyNotificationRule;
        }

        /// <summary> Initializes a new instance of RoleManagementPolicyNotificationRule. </summary>
        /// <param name="id"> The id of the rule. </param>
        /// <param name="ruleType"> The type of rule. </param>
        /// <param name="target"> The target of the current rule. </param>
        /// <param name="notificationType"> The type of notification. </param>
        /// <param name="notificationLevel"> The notification level. </param>
        /// <param name="recipientType"> The recipient type. </param>
        /// <param name="notificationRecipients"> The list of notification recipients. </param>
        /// <param name="isDefaultRecipientsEnabled"> Determines if the notification will be sent to the recipient type specified in the policy rule. </param>
        internal RoleManagementPolicyNotificationRule(string id, RoleManagementPolicyRuleType ruleType, RoleManagementPolicyRuleTarget target, NotificationDeliveryMechanism? notificationType, NotificationLevel? notificationLevel, RecipientType? recipientType, IList<string> notificationRecipients, bool? isDefaultRecipientsEnabled) : base(id, ruleType, target)
        {
            NotificationType = notificationType;
            NotificationLevel = notificationLevel;
            RecipientType = recipientType;
            NotificationRecipients = notificationRecipients;
            IsDefaultRecipientsEnabled = isDefaultRecipientsEnabled;
            RuleType = ruleType;
        }

        /// <summary> The type of notification. </summary>
        public NotificationDeliveryMechanism? NotificationType { get; set; }
        /// <summary> The notification level. </summary>
        public NotificationLevel? NotificationLevel { get; set; }
        /// <summary> The recipient type. </summary>
        public RecipientType? RecipientType { get; set; }
        /// <summary> The list of notification recipients. </summary>
        public IList<string> NotificationRecipients { get; }
        /// <summary> Determines if the notification will be sent to the recipient type specified in the policy rule. </summary>
        public bool? IsDefaultRecipientsEnabled { get; set; }
    }
}
