﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Threading;
using Azure.Storage.DataMovement.Models;

namespace Azure.Storage.DataMovement
{
    /// <summary>
    /// Provides data for <see cref="TransferProgressHandler.FilesFailedTransferred"/>
    /// event.
    /// </summary>
    public class PathTransferSkippedEventArgs : SyncAsyncEventArgs
    {
        /// <summary>
        /// Gets the <see cref="TransferJobInternal"/> of an action that failed to
        /// complete.  The value might be null.
        /// </summary>
        public StorageTransferJobDetails Job { get; }

        /// <summary>
        /// Gets the <see cref="IOException"/> caused by an action that failed to
        /// complete.  The value might be null.
        /// </summary>
        public IOException Exception { get; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PathTransferFailedEventArgs"/> class.
        /// </summary>
        /// <param name="job">
        /// The <see cref="TransferJobInternal"/> raising the event.
        /// </param>
        /// <param name="exception">
        /// the <see cref="IOException"/> caused by an action that failed to
        /// complete.
        /// </param>
        /// <param name="isRunningSynchronously">
        /// A value indicating whether the event handler was invoked
        /// synchronously or asynchronously.  Please see
        /// <see cref="Azure.Core.SyncAsyncEventHandler{T}"/> for more details.
        /// </param>
        /// <param name="cancellationToken">
        /// A cancellation token related to the original operation that raised
        /// the event.  It's important for your handler to pass this token
        /// along to any asynchronous or long-running synchronous operations
        /// that take a token so cancellation will correctly propagate.  The
        /// default value is <see cref="CancellationToken.None"/>.
        /// </param>
        public PathTransferSkippedEventArgs(
            StorageTransferJobDetails job,
            IOException exception,
            bool isRunningSynchronously,
            CancellationToken cancellationToken = default)
            : base(isRunningSynchronously, cancellationToken)
        {
            // Do not validate - either might be null
            Job = job;
            Exception = exception;
        }
    }
}
