﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Azure.Messaging.EventHubs
{
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager(ResourcesNamespace.Current, typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The {0} value is expected to be a {1} bit signed integer. Actual value: &apos;{2}&apos;..
        /// </summary>
        internal static string CannotParseIntegerType
        {
            get
            {
                return ResourceManager.GetString("CannotParseIntegerType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to An event cannot be published using both a partition key and a partition identifier.  This operation specified partition key `{0}` and partition id `{1}`..
        /// </summary>
        internal static string CannotSendWithPartitionIdAndPartitionKey
        {
            get
            {
                return ResourceManager.GetString("CannotSendWithPartitionIdAndPartitionKey", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Cannot begin processing without {0} handler set..
        /// </summary>
        internal static string CannotStartEventProcessorWithoutHandler
        {
            get
            {
                return ResourceManager.GetString("CannotStartEventProcessorWithoutHandler", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The Event Hub client responsible for this information is not available.
        /// </summary>
        internal static string ClientNeededForThisInformationNotAvailable
        {
            get
            {
                return ResourceManager.GetString("ClientNeededForThisInformation", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} has already been closed and cannot perform the requested operation..
        /// </summary>
        internal static string ClosedConnectionCannotPerformOperation
        {
            get
            {
                return ResourceManager.GetString("ClosedConnectionCannotPerformOperation", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} has already been closed and cannot perform the requested operation..
        /// </summary>
        internal static string ClosedInstanceCannotPerformOperation
        {
            get
            {
                return ResourceManager.GetString("ClosedInstanceCannotPerformOperation", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The &apos;identifier&apos; parameter exceeds the maximum allowed size of {0} characters..
        /// </summary>
        internal static string ConsumerIdentifierOverMaxValue
        {
            get
            {
                return ResourceManager.GetString("ConsumerIdentifierOverMaxValue", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to acquire an access token using the provided credential..
        /// </summary>
        internal static string CouldNotAcquireAccessToken
        {
            get
            {
                return ResourceManager.GetString("CouldNotAcquireAccessToken", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to create the items needed to communicate with the Event Hubs service..
        /// </summary>
        internal static string CouldNotCreateLink
        {
            get
            {
                return ResourceManager.GetString("CouldNotCreateLink", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to An error was encountered while executing custom code, such as in an event handler..
        /// </summary>
        internal static string DeveloperCodeError
        {
            get
            {
                return ResourceManager.GetString("DeveloperCodeError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to [Developer Code Exception] : {0}..
        /// </summary>
        internal static string DeveloperCodeExceptionMessageMask
        {
            get
            {
                return ResourceManager.GetString("DeveloperCodeExceptionMessageMask", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The event batch is currently being used in communication with the Event Hubs service; events may not be added until the active operation is complete..
        /// </summary>
        internal static string EventBatchIsLocked
        {
            get
            {
                return ResourceManager.GetString("EventBatchIsLocked", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Could not create a reader of events for Event Hub: &apos;{0}&apos;, partition: &apos;{1}&apos;, consumer group: &apos;{2}&apos;..
        /// </summary>
        internal static string FailedToCreateReader
        {
            get
            {
                return ResourceManager.GetString("FailedToCreateReader", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Serialization failed due to an unsupported type, {0}..
        /// </summary>
        internal static string FailedToSerializeUnsupportedType
        {
            get
            {
                return ResourceManager.GetString("FailedToSerializeUnsupportedType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The connection string could not be parsed; either it was malformed or contains no well-known tokens..
        /// </summary>
        internal static string InvalidConnectionString
        {
            get
            {
                return ResourceManager.GetString("InvalidConnectionString", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The string has an invalid encoding format..
        /// </summary>
        internal static string InvalidEncoding
        {
            get
            {
                return ResourceManager.GetString("InvalidEncoding", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The event position is not valid for filtering.  It must have an offset, sequence number, or enqueued time available to filter against..
        /// </summary>
        internal static string InvalidEventPositionForFilter
        {
            get
            {
                return ResourceManager.GetString("InvalidEventPositionForFilter", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The value '{0}' is not a well-formed Event Hubs fully qualified namespace..
        /// </summary>
        internal static string InvalidFullyQualifiedNamespace
        {
            get
            {
                return ResourceManager.GetString("InvalidFullyQualifiedNamespace", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to An invalid message body was encountered.  Either the body was null or an incorrect type. Expected: {0}.
        /// </summary>
        internal static string InvalidMessageBody
        {
            get
            {
                return ResourceManager.GetString("InvalidMessageBody", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The shared access signature could not be parsed; it was either malformed or incorrectly encoded..
        /// </summary>
        internal static string InvalidSharedAccessSignature
        {
            get
            {
                return ResourceManager.GetString("InvalidSharedAccessSignature", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The endpoint address could not be parsed; it was either malformed or not using the `sb://` scheme..
        /// </summary>
        internal static string InvalidEndpointAddress
        {
            get
            {
                return ResourceManager.GetString("InvalidEndpointAddress", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The time period may not be Zero or Infinite..
        /// </summary>
        internal static string InvalidTimePeriod
        {
            get
            {
                return ResourceManager.GetString("InvalidTimePeriod", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The requested transport type, &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string InvalidTransportType
        {
            get
            {
                return ResourceManager.GetString("InvalidTransportType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The message (id:{0}, size:{1} bytes) is larger than is currently allowed ({2} bytes)..
        /// </summary>
        internal static string MessageSizeExceeded
        {
            get
            {
                return ResourceManager.GetString("MessageSizeExceeded", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The connection string used for an Event Hub client must specify the Event Hubs namespace host, and a Shared Access Signature (both the name and value) to be valid. The path to an Event Hub must be included in the connection string or specified separately..
        /// </summary>
        internal static string MissingConnectionInformation
        {
            get
            {
                return ResourceManager.GetString("MissingConnectionInformation", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The path to an Event Hub may be specified as part of the connection string or as a separate value, but not both..
        /// </summary>
        internal static string OnlyOneEventHubNameMayBeSpecified
        {
            get
            {
                return ResourceManager.GetString("OnlyOneEventHubNameMayBeSpecified", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A proxy may only be used for a web sockets connection..
        /// </summary>
        internal static string ProxyMustUseWebSockets
        {
            get
            {
                return ResourceManager.GetString("ProxyMustUseWebSockets", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The requested resource, &apos;{0}&apos;, does not match the resource of the shared access signature, &apos;{1}&apos;. A token cannot be issued..
        /// </summary>
        internal static string ResourceMustMatchSharedAccessSignature
        {
            get
            {
                return ResourceManager.GetString("ResourceMustMatchSharedAccessSignature", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Retry options must be specified; if no retry is desired, please set the maximum number of retries to 0. To provide a custom retry policy, please assign it on the client directly..
        /// </summary>
        internal static string RetryOptionsMustBeSet
        {
            get
            {
                return ResourceManager.GetString("RetryOptionsMustBeSet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The event processor is already running and needs to be stopped in order to perform this operation..
        /// </summary>
        internal static string RunningEventProcessorCannotPerformOperation
        {
            get
            {
                return ResourceManager.GetString("RunningEventProcessorCannotPerformOperation", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to In order to update the signature, a shared access key must have been provided when the shared access signature was created..
        /// </summary>
        internal static string SharedAccessKeyIsRequired
        {
            get
            {
                return ResourceManager.GetString("SharedAccessKeyIsRequired", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A shared key credential is unable to generate a token directly. Please use this credential when creating an Event Hub Client, for proper generation of shared key tokens..
        /// </summary>
        internal static string SharedKeyCredentialCannotGenerateTokens
        {
            get
            {
                return ResourceManager.GetString("SharedKeyCredentialCannotGenerateTokens", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A timeout value must be positive. To request using the default timeout, please use TimeSpan.Zero or null..
        /// </summary>
        internal static string TimeoutMustBePositive
        {
            get
            {
                return ResourceManager.GetString("TimeoutMustBePositive", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Argument {0} must be a non-negative timespan value. The provided value was {1}..
        /// </summary>
        internal static string TimeSpanMustBeNonNegative
        {
            get
            {
                return ResourceManager.GetString("TimeSpanMustBeNonNegative", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This information is only available when TrackLastEnqueuedEventProperties is set on the Event Hub consumer options..
        /// </summary>
        internal static string TrackLastEnqueuedEventPropertiesNotSet
        {
            get
            {
                return ResourceManager.GetString("TrackLastEnqueuedEventPropertiesNotSet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to An unknown error was encountered while communicating with the Event Hubs service..
        /// </summary>
        internal static string UnknownCommunicationException
        {
            get
            {
                return ResourceManager.GetString("UnknownCommunicationException", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The specified connection type, &quot;{0}&quot;, is not recognized as valid in this context..
        /// </summary>
        internal static string UnknownConnectionType
        {
            get
            {
                return ResourceManager.GetString("UnknownConnectionType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The requested retry mode, &apos;{0}&apos;, is not known; a retry delay cannot be determined..
        /// </summary>
        internal static string UnknownRetryMode
        {
            get
            {
                return ResourceManager.GetString("UnknownRetryMode", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to An unrecoverable exception was encountered that left the environment in a bad state..
        /// </summary>
        internal static string UnrecoverableException
        {
            get
            {
                return ResourceManager.GetString("UnrecoverableException", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The credential is not a known and supported credential type. Please use a JWT credential or shared key credential..
        /// </summary>
        internal static string UnsupportedCredential
        {
            get
            {
                return ResourceManager.GetString("UnsupportedCredential", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The requested transport event type, &apos;{0}&apos;, is not supported by the active transport client..
        /// </summary>
        internal static string UnsupportedTransportEventType
        {
            get
            {
                return ResourceManager.GetString("UnsupportedTransportEventType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The value supplied must be greater than or equal to {0}..
        /// </summary>
        internal static string ValueMustBeAtLeast
        {
            get
            {
                return ResourceManager.GetString("ValueMustBeAtLeast", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The value supplied must be between {0} and {1}..
        /// </summary>
        internal static string ValueOutOfRange
        {
            get
            {
                return ResourceManager.GetString("ValueOutOfRange", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The Azure Storage Blobs container or blob used by the Event Processor Client does not exist..
        /// </summary>
        internal static string BlobsResourceDoesNotExist
        {
            get
            {
                return ResourceManager.GetString("BlobsResourceDoesNotExist", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A checkpoint cannot be created or updated using an empty event..
        /// </summary>
        internal static string CannotCreateCheckpointForEmptyEvent
        {
            get
            {
                return ResourceManager.GetString("CannotCreateCheckpointForEmptyEvent", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Another handler has already been assigned to this event and there can be only one..
        /// </summary>
        internal static string HandlerHasAlreadyBeenAssigned
        {
            get
            {
                return ResourceManager.GetString("HandlerHasAlreadyBeenAssigned", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This handler has not been previously assigned to this event..
        /// </summary>
        internal static string HandlerHasNotBeenAssigned
        {
            get
            {
                return ResourceManager.GetString("HandlerHasNotBeenAssigned", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Retrieving list of ownership from the storage service..
        /// </summary>
        internal static string OperationListOwnership
        {
            get
            {
                return ResourceManager.GetString("OperationListOwnership", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Retrieving list of partition identifiers from a Consumer Client..
        /// </summary>
        internal static string OperationGetPartitionIds
        {
            get
            {
                return ResourceManager.GetString("OperationGetPartitionIds", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Retrieving list of checkpoints from the storage service..
        /// </summary>
        internal static string OperationListCheckpoints
        {
            get
            {
                return ResourceManager.GetString("OperationListCheckpoints", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Executing a load balancing cycle..
        /// </summary>
        internal static string OperationLoadBalancing
        {
            get
            {
                return ResourceManager.GetString("OperationLoadBalancing", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Attempting to claim a new ownership in the storage service..
        /// </summary>
        internal static string OperationClaimOwnership
        {
            get
            {
                return ResourceManager.GetString("OperationClaimOwnership", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Attempting to renew all of the processor's partition ownership in the storage service..
        /// </summary>
        internal static string OperationRenewOwnership
        {
            get
            {
                return ResourceManager.GetString("OperationRenewOwnership", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Reading events from the Event Hubs service..
        /// </summary>
        internal static string OperationReadEvents
        {
            get
            {
                return ResourceManager.GetString("OperationReadEvents", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Performing the main Event Processor loop..
        /// </summary>
        internal static string OperationEventProcessingLoop
        {
            get
            {
                return ResourceManager.GetString("OperationEventProcessingLoop", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Surrendering ownership of a partition..
        /// </summary>
        internal static string OperationSurrenderOwnership
        {
            get
            {
                return ResourceManager.GetString("OperationSurrenderOwnership", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The last enqueued event properties cannot be read when an event is not available..
        /// </summary>
        internal static string CannotReadLastEnqueuedEventPropertiesWithoutEvent
        {
            get
            {
                return ResourceManager.GetString("CannotReadLastEnqueuedEventPropertiesWithoutEvent", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to One or more exceptions occurred during event processing.  Please see the inner exceptions for more detail..
        /// </summary>
        internal static string AggregateEventProcessingExceptionMessage
        {
            get
            {
                return ResourceManager.GetString("AggregateEventProcessingExceptionMessage", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The authorization for a connection string may specifiy a shared key or precomputed shared access signature, but not both.  Please verify that your connection string does not have the `SharedAccessSignature` token if you are passing the  `SharedKeyName` and `SharedKey`..
        /// </summary>
        internal static string OnlyOneSharedAccessAuthorizationMayBeSpecified
        {
            get
            {
                return ResourceManager.GetString("OnlyOneSharedAccessAuthorizationMayBeSpecified", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The producer was configured to use features that require publishing to a specific partition.  Publishing with automatic routing or using a partition key is not supported by this producer..
        /// </summary>
        internal static string CannotPublishToGateway
        {
            get
            {
                return ResourceManager.GetString("CannotPublishToGateway", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to These events have already been successfully published.  When idempotent publishing is enabled, events that were acknowledged by the Event Hubs service may not be published again..
        /// </summary>
        internal static string IdempotentAlreadyPublished
        {
            get
            {
                return ResourceManager.GetString("IdempotentAlreadyPublished", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The ListCheckpointsAsync method has been superseded by GetCheckpointAsync and should no longer be called..
        /// </summary>
        internal static string ListCheckpointsAsyncObsolete
        {
            get
            {
                return ResourceManager.GetString("ListCheckpointsAsyncObsolete", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The type of AMQP body for the message could not be determined..
        /// </summary>
        internal static string UnknownAmqpBodyType
        {
            get
            {
                return ResourceManager.GetString("UnknownAmqpBodyType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The event body cannot be retrieved using the {1} property of {0}.  A body of type {2} can be accessed using the {3} method of {0} and inspecting the underlying AMQP message..
        /// </summary>
        internal static string RawAmqpBodyTypeMask
        {
            get
            {
                return ResourceManager.GetString("RawAmqpBodyTypeMask", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The given key '{0}' was not present in the dictionary..
        /// </summary>
        internal static string DictionaryKeyNotFoundMask
        {
            get
            {
                return ResourceManager.GetString("DictionaryKeyNotFoundMask", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} is not a supported value body type..
        /// </summary>
        internal static string InvalidAmqpMessageValueBodyMask
        {
            get
            {
                return ResourceManager.GetString("InvalidAmqpMessageValueBodyMask", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The {0} key `{1}` has a value of type `{2}` which is not supported for AMQP transport..
        /// </summary>
        internal static string InvalidAmqpMessageDictionaryTypeMask
        {
            get
            {
                return ResourceManager.GetString("InvalidAmqpMessageDictionaryTypeMask", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to This handler cannot be changed after an event has been enqueued; closing or disposing the producer will unregister any current hander..
        /// </summary>
        internal static string CannotChangeHandlersWhenPublishing
        {
            get
            {
                return ResourceManager.GetString("CannotChangeHandlersWhenPublishing", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A load balancing cycle has taken too long to complete.  A slow cycle can cause stability issues with partition ownership.  Consider investigating storage latency and thread pool health.  Common causes are soft delete being enabled for storage and too many partitions owned.  You may also want to consider increasing the 'PartitionOwnershipExpirationInterval' in the processor options.  Cycle Duration: '{0}' seconds.  Partition Ownership Interval '{1}' seconds..
        /// </summary>
        internal static string ProcessorLoadBalancingCycleSlowMask
        {
            get
            {
                return ResourceManager.GetString("ProcessorLoadBalancingCycleSlowMask", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Events cannot be enqueued processing without the {0} handler set..
        /// </summary>
        internal static string CannotEnqueueEventWithoutHandler
        {
            get
            {
                return ResourceManager.GetString("CannotEnqueueEventWithoutHandler", resourceCulture);
            }
        }
    }
}
