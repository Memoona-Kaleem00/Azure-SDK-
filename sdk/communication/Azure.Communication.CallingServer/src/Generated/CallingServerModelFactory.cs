// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.CallingServer
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class CallingServerModelFactory
    {
        /// <summary> Initializes new instance of PlayAudioResult class. </summary>
        /// <param name="operationId"> The operation id. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="resultInfo"> The result info for the operation. </param>
        /// <returns> A new <see cref="CallingServer.PlayAudioResult"/> instance for mocking. </returns>
        public static PlayAudioResult PlayAudioResult(string operationId = default, OperationStatus status = default, string operationContext = default, ResultInfo resultInfo = default)
        {
            return new PlayAudioResult(operationId, status, operationContext, resultInfo);
        }

        /// <summary> Initializes new instance of ResultInfo class. </summary>
        /// <param name="code"> The result code associated with the operation. </param>
        /// <param name="subcode"> The subcode that further classifies the result. </param>
        /// <param name="message"> The message is a detail explanation of subcode. </param>
        /// <returns> A new <see cref="CallingServer.ResultInfo"/> instance for mocking. </returns>
        public static ResultInfo ResultInfo(int code = default, int subcode = default, string message = default)
        {
            return new ResultInfo(code, subcode, message);
        }

        /// <summary> Initializes new instance of CancelAllMediaOperationsResult class. </summary>
        /// <param name="operationId"> The operation id. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        /// <param name="resultInfo"> The result info for the operation. </param>
        /// <returns> A new <see cref="CallingServer.CancelAllMediaOperationsResult"/> instance for mocking. </returns>
        public static CancelAllMediaOperationsResult CancelAllMediaOperationsResult(string operationId = default, OperationStatus status = default, string operationContext = default, ResultInfo resultInfo = default)
        {
            return new CancelAllMediaOperationsResult(operationId, status, operationContext, resultInfo);
        }

        /// <summary> Initializes new instance of AddParticipantResult class. </summary>
        /// <param name="participantId"> The id of the added participant. </param>
        /// <returns> A new <see cref="CallingServer.AddParticipantResult"/> instance for mocking. </returns>
        public static AddParticipantResult AddParticipantResult(string participantId = default)
        {
            return new AddParticipantResult(participantId);
        }

        /// <summary> Initializes new instance of StartCallRecordingResult class. </summary>
        /// <param name="recordingId"> The recording id of the started recording. </param>
        /// <returns> A new <see cref="CallingServer.StartCallRecordingResult"/> instance for mocking. </returns>
        public static StartCallRecordingResult StartCallRecordingResult(string recordingId = default)
        {
            return new StartCallRecordingResult(recordingId);
        }

        /// <summary> Initializes new instance of CallRecordingProperties class. </summary>
        /// <param name="recordingState"> The state of the recording. </param>
        /// <returns> A new <see cref="CallingServer.CallRecordingProperties"/> instance for mocking. </returns>
        public static CallRecordingProperties CallRecordingProperties(CallRecordingState recordingState = default)
        {
            return new CallRecordingProperties(recordingState);
        }

        /// <summary> Initializes new instance of CallConnectionStateChangedEvent class. </summary>
        /// <param name="serverCallId"> The server call.id. </param>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="callConnectionState"> The call connection state. </param>
        /// <returns> A new <see cref="CallingServer.CallConnectionStateChangedEvent"/> instance for mocking. </returns>
        public static CallConnectionStateChangedEvent CallConnectionStateChangedEvent(string serverCallId = default, string callConnectionId = default, CallConnectionState callConnectionState = default)
        {
            return new CallConnectionStateChangedEvent(serverCallId, callConnectionId, callConnectionState);
        }

        /// <summary> Initializes new instance of CallRecordingStateChangeEvent class. </summary>
        /// <param name="recordingId"> The call recording id. </param>
        /// <param name="state"> The state of the recording. </param>
        /// <param name="startDateTime"> The time of the recording started. </param>
        /// <param name="serverCallId"> The server call.id. </param>
        /// <returns> A new <see cref="CallingServer.CallRecordingStateChangeEvent"/> instance for mocking. </returns>
        public static CallRecordingStateChangeEvent CallRecordingStateChangeEvent(string recordingId = default, CallRecordingState state = default, DateTimeOffset startDateTime = default, string serverCallId = default)
        {
            return new CallRecordingStateChangeEvent(recordingId, state, startDateTime, serverCallId);
        }

        /// <summary> Initializes new instance of AddParticipantResultEvent class. </summary>
        /// <param name="resultInfo"> The result details. </param>
        /// <param name="operationContext"> The operation context. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <returns> A new <see cref="CallingServer.AddParticipantResultEvent"/> instance for mocking. </returns>
        public static AddParticipantResultEvent AddParticipantResultEvent(ResultInfo resultInfo = default, string operationContext = default, OperationStatus status = default)
        {
            return new AddParticipantResultEvent(resultInfo, operationContext, status);
        }

        /// <summary> Initializes new instance of PlayAudioResultEvent class. </summary>
        /// <param name="resultInfo"> The result details. </param>
        /// <param name="operationContext"> The operation context. </param>
        /// <param name="status"> The status of the operation. </param>
        /// <returns> A new <see cref="CallingServer.PlayAudioResultEvent"/> instance for mocking. </returns>
        public static PlayAudioResultEvent PlayAudioResultEvent(ResultInfo resultInfo = default, string operationContext = default, OperationStatus status = default)
        {
            return new PlayAudioResultEvent(resultInfo, operationContext, status);
        }

        /// <summary> Initializes new instance of ToneReceivedEvent class. </summary>
        /// <param name="toneInfo"> The tone info. </param>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <returns> A new <see cref="CallingServer.ToneReceivedEvent"/> instance for mocking. </returns>
        public static ToneReceivedEvent ToneReceivedEvent(ToneInfo toneInfo = default, string callConnectionId = default)
        {
            return new ToneReceivedEvent(toneInfo, callConnectionId);
        }

        /// <summary> Initializes new instance of ToneInfo class. </summary>
        /// <param name="sequenceId"> The sequence id which can be used to determine if the same tone was played multiple times or if any tones were missed. </param>
        /// <param name="tone"> The tone value. </param>
        /// <returns> A new <see cref="CallingServer.ToneInfo"/> instance for mocking. </returns>
        public static ToneInfo ToneInfo(int sequenceId = default, ToneValue tone = default)
        {
            return new ToneInfo(sequenceId, tone);
        }
    }
}
