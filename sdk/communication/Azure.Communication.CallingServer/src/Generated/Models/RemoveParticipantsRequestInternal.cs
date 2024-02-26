// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication;

namespace Azure.Communication.CallingServer
{
    /// <summary> The remove participant by identifier request. </summary>
    internal partial class RemoveParticipantsRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="RemoveParticipantsRequestInternal"/>. </summary>
        /// <param name="participantsToRemove"> The participants to invite. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="participantsToRemove"/> is null. </exception>
        public RemoveParticipantsRequestInternal(IEnumerable<CommunicationIdentifierModel> participantsToRemove)
        {
            if (participantsToRemove == null)
            {
                throw new ArgumentNullException(nameof(participantsToRemove));
            }

            ParticipantsToRemove = participantsToRemove.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RemoveParticipantsRequestInternal"/>. </summary>
        /// <param name="participantsToRemove"> The participants to invite. </param>
        /// <param name="operationContext"> The operation context. </param>
        internal RemoveParticipantsRequestInternal(IList<CommunicationIdentifierModel> participantsToRemove, string operationContext)
        {
            ParticipantsToRemove = participantsToRemove;
            OperationContext = operationContext;
        }

        /// <summary> The participants to invite. </summary>
        public IList<CommunicationIdentifierModel> ParticipantsToRemove { get; }
        /// <summary> The operation context. </summary>
        public string OperationContext { get; set; }
    }
}
