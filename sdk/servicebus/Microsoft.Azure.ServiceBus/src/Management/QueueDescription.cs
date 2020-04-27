﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.ServiceBus.Management
{
    using System;
    using System.Collections.Generic;
    using Primitives;

    /// <summary>
    /// Represents the metadata description of the queue.
    /// </summary>
    public class QueueDescription : IEquatable<QueueDescription>
    {
        internal TimeSpan duplicateDetectionHistoryTimeWindow = TimeSpan.FromMinutes(1);
        internal string path;
        private TimeSpan _lockDuration = TimeSpan.FromSeconds(60);
        private TimeSpan _defaultMessageTimeToLive = TimeSpan.MaxValue;
        private TimeSpan _autoDeleteOnIdle = TimeSpan.MaxValue;
        private int _maxDeliveryCount = 10;
        private string _forwardTo;
        private string _forwardDeadLetteredMessagesTo;
        private string _userMetadata;

        /// <summary>
        /// Initializes a new instance of QueueDescription class with the specified relative path.
        /// </summary>
        /// <param name="path">Path of the queue relative to the namespace base address.</param>
        public QueueDescription(string path)
        {
            Path = path;
        }

        /// <summary>
        /// Path of the queue relative to the namespace base address.
        /// </summary>
        /// <remarks>Max length is 260 chars. Cannot start or end with a slash.
        /// Cannot have restricted characters: '@','?','#','*'</remarks>
        public string Path
        {
            get => path;
            set
            {
                EntityNameHelper.CheckValidQueueName(value, nameof(Path));
                path = value;
            }
        }

        /// <summary>
        /// Duration of a peek lock receive. i.e., the amount of time that the message is locked by a given receiver so that
        /// no other receiver receives the same message.
        /// </summary>
        /// <remarks>Max value is 5 minutes. Default value is 60 seconds.</remarks>
        public TimeSpan LockDuration
        {
            get => _lockDuration;
            set
            {
                TimeoutHelper.ThrowIfNonPositiveArgument(value, nameof(LockDuration));
                _lockDuration = value;
            }
        }

        /// <summary>
        /// The maximum size of the queue in megabytes, which is the size of memory allocated for the queue.
        /// </summary>
        /// <remarks>Default value is 1024.</remarks>
        public long MaxSizeInMB { get; set; } = 1024;

        /// <summary>
        /// This value indicates if the queue requires guard against duplicate messages. If true, duplicate messages having same
        /// <see cref="Message.MessageId"/> and sent to queue within duration of <see cref="DuplicateDetectionHistoryTimeWindow"/>
        /// will be discarded.
        /// </summary>
        /// <remarks>Defaults to false.</remarks>
        public bool RequiresDuplicateDetection { get; set; } = false;

        /// <summary>
        /// This indicates whether the queue supports the concept of session. Sessionful-messages follow FIFO ordering.
        /// </summary>
        /// <remarks>
        /// If true, the receiver can only receive messages using <see cref="SessionClient.AcceptMessageSessionAsync()"/>.
        /// Defaults to false.
        /// </remarks>
        public bool RequiresSession { get; set; } = false;

        /// <summary>
        /// The default time to live value for the messages. This is the duration after which the message expires, starting from when
        /// the message is sent to Service Bus. </summary>
        /// <remarks>
        /// This is the default value used when <see cref="Message.TimeToLive"/> is not set on a
        ///  message itself. Messages older than their TimeToLive value will expire and no longer be retained in the message store.
        ///  Subscribers will be unable to receive expired messages.
        ///  Default value is <see cref="TimeSpan.MaxValue"/>.
        ///  </remarks>
        public TimeSpan DefaultMessageTimeToLive
        {
            get => _defaultMessageTimeToLive;
            set
            {
                if (value < ManagementClientConstants.MinimumAllowedTimeToLive || value > ManagementClientConstants.MaximumAllowedTimeToLive)
                {
                    throw new ArgumentOutOfRangeException(nameof(DefaultMessageTimeToLive),
                        $@"The value must be between {ManagementClientConstants.MinimumAllowedTimeToLive} and {ManagementClientConstants.MaximumAllowedTimeToLive}");
                }

                _defaultMessageTimeToLive = value;
            }
        }

        /// <summary>
        /// The <see cref="TimeSpan"/> idle interval after which the queue is automatically deleted.
        /// </summary>
        /// <remarks>The minimum duration is 5 minutes. Default value is <see cref="TimeSpan.MaxValue"/>.</remarks>
        public TimeSpan AutoDeleteOnIdle
        {
            get => _autoDeleteOnIdle;
            set
            {
                if (value < ManagementClientConstants.MinimumAllowedAutoDeleteOnIdle)
                {
                    throw new ArgumentOutOfRangeException(nameof(AutoDeleteOnIdle),
                        $@"The value must be greater than {ManagementClientConstants.MinimumAllowedAutoDeleteOnIdle}");
                }

                _autoDeleteOnIdle = value;
            }
        }

        /// <summary>
        /// Indicates whether this queue has dead letter support when a message expires.
        /// </summary>
        /// <remarks>If true, the expired messages are moved to dead-letter sub-queue. Default value is false.</remarks>
        public bool EnableDeadLetteringOnMessageExpiration { get; set; } = false;

        /// <summary>
        /// The <see cref="TimeSpan"/> duration of duplicate detection history that is maintained by the service.
        /// </summary>
        /// <remarks>
        /// The default value is 1 minute. Max value is 7 days and minimum is 20 seconds.
        /// </remarks>
        public TimeSpan DuplicateDetectionHistoryTimeWindow
        {
            get => duplicateDetectionHistoryTimeWindow;
            set
            {
                if (value < ManagementClientConstants.MinimumDuplicateDetectionHistoryTimeWindow || value > ManagementClientConstants.MaximumDuplicateDetectionHistoryTimeWindow)
                {
                    throw new ArgumentOutOfRangeException(nameof(DuplicateDetectionHistoryTimeWindow),
                        $@"The value must be between {ManagementClientConstants.MinimumDuplicateDetectionHistoryTimeWindow} and {ManagementClientConstants.MaximumDuplicateDetectionHistoryTimeWindow}");
                }

                duplicateDetectionHistoryTimeWindow = value;
            }
        }

        /// <summary>
        /// The maximum delivery count of a message before it is dead-lettered.
        /// </summary>
        /// <remarks>The delivery count is increased when a message is received in <see cref="ReceiveMode.PeekLock"/> mode
        /// and didn't complete the message before the message lock expired.
        /// Default value is 10. Minimum value is 1.</remarks>
        public int MaxDeliveryCount
        {
            get => _maxDeliveryCount;
            set
            {
                if (value < ManagementClientConstants.MinAllowedMaxDeliveryCount)
                {
                    throw new ArgumentOutOfRangeException(nameof(MaxDeliveryCount),
                        $@"The value must be greater than {ManagementClientConstants.MinAllowedMaxDeliveryCount}");
                }

                _maxDeliveryCount = value;
            }
        }

        /// <summary>
        /// Indicates whether server-side batched operations are enabled.
        /// </summary>
        /// <remarks>Defaults to true.</remarks>
        public bool EnableBatchedOperations { get; set; } = true;

        /// <summary>
        /// The <see cref="AuthorizationRules"/> on the queue to control user access at entity level.
        /// </summary>
        public AuthorizationRules AuthorizationRules { get; internal set; } = new AuthorizationRules();

        /// <summary>
        /// The current status of the queue (Enabled / Disabled).
        /// </summary>
        /// <remarks>When an entity is disabled, that entity cannot send or receive messages.</remarks>
        public EntityStatus Status { get; set; } = EntityStatus.Active;

        /// <summary>
        /// The path of the recipient entity to which all the messages sent to the queue are forwarded to.
        /// </summary>
        /// <remarks>If set, user cannot manually receive messages from this queue. The destination entity
        /// must be an already existing entity.</remarks>
        public string ForwardTo
        {
            get => _forwardTo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _forwardTo = value;
                    return;
                }

                EntityNameHelper.CheckValidQueueName(value, nameof(ForwardTo));
                if (path.Equals(value, StringComparison.CurrentCultureIgnoreCase))
                {
                    throw new InvalidOperationException("Entity cannot have auto-forwarding policy to itself");
                }

                _forwardTo = value;
            }
        }

        /// <summary>
        /// The path of the recipient entity to which all the dead-lettered messages of this queue are forwarded to.
        /// </summary>
        /// <remarks>If set, user cannot manually receive dead-lettered messages from this queue. The destination
        /// entity must already exist.</remarks>
        public string ForwardDeadLetteredMessagesTo
        {
            get => _forwardDeadLetteredMessagesTo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _forwardDeadLetteredMessagesTo = value;
                    return;
                }

                EntityNameHelper.CheckValidQueueName(value, nameof(ForwardDeadLetteredMessagesTo));
                if (path.Equals(value, StringComparison.CurrentCultureIgnoreCase))
                {
                    throw new InvalidOperationException("Entity cannot have auto-forwarding policy to itself");
                }

                _forwardDeadLetteredMessagesTo = value;
            }
        }

        /// <summary>
        /// Indicates whether the queue is to be partitioned across multiple message brokers.
        /// </summary>
        /// <remarks>Defaults to false.</remarks>
        public bool EnablePartitioning { get; set; } = false;

        /// <summary>
        /// Custom metdata that user can associate with the description.
        /// </summary>
        /// <remarks>Cannot be null. Max length is 1024 chars.</remarks>
        public string UserMetadata
        {
            get => _userMetadata;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(UserMetadata), $"Value cannot be null");
                }

                if (value.Length > ManagementClientConstants.MaxUserMetadataLength)
                {
                    throw new ArgumentOutOfRangeException(nameof(UserMetadata), $@"Length cannot cross {ManagementClientConstants.MaxUserMetadataLength} characters");
                }

                _userMetadata = value;
            }
        }

        /// <summary>
        /// List of properties that were retrieved using GetQueue but are not understood by this version of client is stored here.
        /// The list will be sent back when an already retrieved QueueDescription will be used in UpdateQueue call.
        /// </summary>
        internal List<object> UnknownProperties { get; set; }

        public override int GetHashCode()
        {
            return Path?.GetHashCode() ?? base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as QueueDescription;
            return Equals(other);
        }

        public bool Equals(QueueDescription otherDescription)
        {
            if (otherDescription is QueueDescription other
                && Path.Equals(other.Path, StringComparison.OrdinalIgnoreCase)
                && AutoDeleteOnIdle.Equals(other.AutoDeleteOnIdle)
                && DefaultMessageTimeToLive.Equals(other.DefaultMessageTimeToLive)
                && (!RequiresDuplicateDetection || DuplicateDetectionHistoryTimeWindow.Equals(other.DuplicateDetectionHistoryTimeWindow))
                && EnableBatchedOperations == other.EnableBatchedOperations
                && EnableDeadLetteringOnMessageExpiration == other.EnableDeadLetteringOnMessageExpiration
                && EnablePartitioning == other.EnablePartitioning
                && string.Equals(ForwardDeadLetteredMessagesTo, other.ForwardDeadLetteredMessagesTo, StringComparison.OrdinalIgnoreCase)
                && string.Equals(ForwardTo, other.ForwardTo, StringComparison.OrdinalIgnoreCase)
                && LockDuration.Equals(other.LockDuration)
                && MaxDeliveryCount == other.MaxDeliveryCount
                && MaxSizeInMB == other.MaxSizeInMB
                && RequiresDuplicateDetection.Equals(other.RequiresDuplicateDetection)
                && RequiresSession.Equals(other.RequiresSession)
                && Status.Equals(other.Status)
                && string.Equals(_userMetadata, other._userMetadata, StringComparison.OrdinalIgnoreCase)
                && (AuthorizationRules != null && other.AuthorizationRules != null
                    || AuthorizationRules == null && other.AuthorizationRules == null)
                && (AuthorizationRules == null || AuthorizationRules.Equals(other.AuthorizationRules)))
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(QueueDescription o1, QueueDescription o2)
        {
            if (ReferenceEquals(o1, o2))
            {
                return true;
            }

            if (ReferenceEquals(o1, null) || ReferenceEquals(o2, null))
            {
                return false;
            }

            return o1.Equals(o2);
        }

        public static bool operator !=(QueueDescription o1, QueueDescription o2)
        {
            return !(o1 == o2);
        }
    }
}
