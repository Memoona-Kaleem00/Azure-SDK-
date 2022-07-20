﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary>
    /// The call connected event.
    /// </summary>
    [CodeGenModel("CallConnectedEvent", Usage = new string[] { "output" }, Formats = new string[] { "json" })]
    public partial class CallConnectedEvent: CallingServerEventBase
    {
        /// <summary>
        /// Deserialize <see cref="CallConnectedEvent"/> event.
        /// </summary>
        /// <param name="content">The json content.</param>
        /// <returns>The new <see cref="CallConnectedEvent"/> object.</returns>
        public static CallConnectedEvent Deserialize(string content)
        {
            using var document = JsonDocument.Parse(content);
            JsonElement element = document.RootElement;

            return DeserializeCallConnectedEvent(element);
        }
    }
}
