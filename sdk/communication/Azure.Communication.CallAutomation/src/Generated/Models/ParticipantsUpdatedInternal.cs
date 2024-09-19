// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The participants updated in a call event. </summary>
    internal partial class ParticipantsUpdatedInternal
    {
        /// <summary> Initializes a new instance of <see cref="ParticipantsUpdatedInternal"/>. </summary>
        internal ParticipantsUpdatedInternal()
        {
            Participants = new ChangeTrackingList<CallParticipantInternal>();
        }

        /// <summary> Initializes a new instance of <see cref="ParticipantsUpdatedInternal"/>. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="sequenceNumber"> The Sequence Number of the event. </param>
        /// <param name="participants"> The list of participants in the call. </param>
        internal ParticipantsUpdatedInternal(string callConnectionId, string serverCallId, string correlationId, int? sequenceNumber, IReadOnlyList<CallParticipantInternal> participants)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            SequenceNumber = sequenceNumber;
            Participants = participants;
        }

        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
        /// <summary> The Sequence Number of the event. </summary>
        public int? SequenceNumber { get; }
        /// <summary> The list of participants in the call. </summary>
        public IReadOnlyList<CallParticipantInternal> Participants { get; }
    }
}
