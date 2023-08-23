// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class RecognizeRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("recognizeInputType"u8);
            writer.WriteStringValue(RecognizeInputType.ToString());
            if (Optional.IsDefined(PlayPrompt))
            {
                writer.WritePropertyName("playPrompt"u8);
                writer.WriteObjectValue(PlayPrompt);
            }
            if (Optional.IsDefined(InterruptCallMediaOperation))
            {
                writer.WritePropertyName("interruptCallMediaOperation"u8);
                writer.WriteBooleanValue(InterruptCallMediaOperation.Value);
            }
            writer.WritePropertyName("recognizeOptions"u8);
            writer.WriteObjectValue(RecognizeOptions);
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            if (Optional.IsDefined(CallbackUri))
            {
                writer.WritePropertyName("callbackUri"u8);
                writer.WriteStringValue(CallbackUri);
            }
            writer.WriteEndObject();
        }
    }
}
