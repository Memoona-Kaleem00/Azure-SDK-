﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel.Primitives;

namespace Azure.Core
{
    /// <summary>
    /// A type that analyzes an HTTP message and determines if the response it holds
    /// should be treated as an error response. A classifier of this type may use information
    /// from the request, the response, or other message property to decide
    /// whether and how to classify the message.
    /// <para/>
    /// This type's <code>TryClassify</code> method allows chaining together handlers before
    /// applying default classifier logic.
    /// If a handler in the chain returns false from <code>TryClassify</code>,
    /// the next handler will be tried, and so on.  The first handler that returns true
    /// will determine whether the response is an error.
    /// </summary>
    public class ResponseClassificationHandler : MessageClassificationHandler
    {
        /// <summary>
        /// Populates the <code>isError</code> out parameter to indicate whether or not
        /// to classify the message's response as an error.
        /// </summary>
        /// <param name="message">The message to classify.</param>
        /// <param name="isError">Whether the message's response should be considered an error.</param>
        /// <returns><code>true</code> if the handler had a classification for this message; <code>false</code> otherwise.</returns>
        public virtual bool TryClassify(HttpMessage message, out bool isError)
            => base.TryClassify(message, out isError);

        /// <summary>
        /// TBD.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="isError"></param>
        /// <returns></returns>
        public override sealed bool TryClassify(PipelineMessage message, out bool isError)
        {
            HttpMessage httpMessage = AssertHttpMessage(message);

            return TryClassify(httpMessage, out isError);
        }

        // TODO: remove duplication with this and retry policy version
        private static HttpMessage AssertHttpMessage(PipelineMessage message)
        {
            if (message is not HttpMessage httpMessage)
            {
                throw new InvalidOperationException($"Invalid type for PipelineMessage: '{message?.GetType()}'.");
            }

            return httpMessage;
        }

        /// <summary>
        /// TBD.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="isRetriable"></param>
        /// <returns></returns>
        public virtual bool TryClassify(HttpMessage message, Exception? exception, out bool isRetriable)
            => base.TryClassify(message, exception, out isRetriable);

        /// <summary>
        /// TBD.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        /// <param name="isRetriable"></param>
        /// <returns></returns>
        public override bool TryClassify(PipelineMessage message, Exception? exception, out bool isRetriable)
        {
            HttpMessage httpMessage = AssertHttpMessage(message);

            return TryClassify(httpMessage, exception, out isRetriable);
        }
    }
}
