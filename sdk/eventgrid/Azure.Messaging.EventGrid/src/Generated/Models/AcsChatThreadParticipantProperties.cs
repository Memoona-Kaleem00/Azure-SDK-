// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the chat thread participant. </summary>
    public partial class AcsChatThreadParticipantProperties
    {
        /// <summary> Initializes a new instance of <see cref="AcsChatThreadParticipantProperties"/>. </summary>
        internal AcsChatThreadParticipantProperties()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsChatThreadParticipantProperties"/>. </summary>
        /// <param name="displayName"> The name of the user. </param>
        /// <param name="participantCommunicationIdentifier"> The communication identifier of the user. </param>
        /// <param name="metadata"> The metadata of the user. </param>
        internal AcsChatThreadParticipantProperties(string displayName, CommunicationIdentifierModel participantCommunicationIdentifier, IReadOnlyDictionary<string, string> metadata)
        {
            DisplayName = displayName;
            ParticipantCommunicationIdentifier = participantCommunicationIdentifier;
            Metadata = metadata;
        }

        /// <summary> The name of the user. </summary>
        public string DisplayName { get; }
        /// <summary> The communication identifier of the user. </summary>
        public CommunicationIdentifierModel ParticipantCommunicationIdentifier { get; }
        /// <summary> The metadata of the user. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
