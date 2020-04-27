﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Azure.ServiceBus.Core;

namespace Microsoft.Azure.ServiceBus
{
    using System;

    /// <summary>Provides data for the <see cref="MessageHandlerOptions.ExceptionReceivedHandler" /> event.</summary>
    public sealed class ExceptionReceivedEventArgs : EventArgs
    {
        /// <summary>Initializes a new instance of the <see cref="ExceptionReceivedEventArgs" /> class.</summary>
        /// <param name="exception">The exception that this event data belongs to.</param>
        /// <param name="action">The action associated with the event.</param>
        /// <param name="endpoint">The endpoint used when this exception occurred.</param>
        /// <param name="entityName">The entity path used when this exception occurred.</param>
        /// <param name="clientId">The Client Id can be used to associate with the <see cref="QueueClient"/>, <see cref="SubscriptionClient"/>, <see cref="MessageSender"/> or <see cref="MessageReceiver"/>that encountered the exception.</param>
        public ExceptionReceivedEventArgs(Exception exception, string action, string endpoint, string entityName, string clientId)
        {
            Exception = exception;
            ExceptionReceivedContext = new ExceptionReceivedContext(action, endpoint, entityName, clientId);
        }

        /// <summary>Gets the parent class exception to which this event data belongs.</summary>
        /// <value>The exception, generated by the parent class, to which this event data belongs.</value>
        public Exception Exception { get; }

        /// <summary>
        /// Gets the context of the exception (action, namespace name, and entity path).
        /// </summary>
        public ExceptionReceivedContext ExceptionReceivedContext { get; }
    }
}