// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The MediaStreamingStarted. </summary>
    public partial class MediaStreamingStarted
    {
        /// <summary> Initializes a new instance of <see cref="MediaStreamingStarted"/>. </summary>
        internal MediaStreamingStarted()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MediaStreamingStarted"/>. </summary>
        /// <param name="callConnectionId"> Call connection ID. </param>
        /// <param name="serverCallId"> Server call ID. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        /// <param name="operationContext"> Used by customers when calling answerCall action to correlate the request to the response event. </param>
        /// <param name="resultInformation"> Contains the resulting SIP code/sub-code and message from NGC services. </param>
        /// <param name="mediaStreamingUpdate"> Defines the result for MediaStreamingUpdate with the current status and the details about the status. </param>
        internal MediaStreamingStarted(string callConnectionId, string serverCallId, string correlationId, string operationContext, ResultInformation resultInformation, MediaStreamingUpdate mediaStreamingUpdate)
        {
            CallConnectionId = callConnectionId;
            ServerCallId = serverCallId;
            CorrelationId = correlationId;
            OperationContext = operationContext;
            ResultInformation = resultInformation;
            MediaStreamingUpdate = mediaStreamingUpdate;
        }
        /// <summary> Defines the result for MediaStreamingUpdate with the current status and the details about the status. </summary>
        public MediaStreamingUpdate MediaStreamingUpdate { get; }
    }
}
