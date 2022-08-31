// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Describes a receiver that should be resubscribed. </summary>
    public partial class ActionGroupEnableContent
    {
        /// <summary> Initializes a new instance of ActionGroupEnableContent. </summary>
        /// <param name="receiverName"> The name of the receiver to resubscribe. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="receiverName"/> is null. </exception>
        public ActionGroupEnableContent(string receiverName)
        {
            if (receiverName == null)
            {
                throw new ArgumentNullException(nameof(receiverName));
            }

            ReceiverName = receiverName;
        }

        /// <summary> The name of the receiver to resubscribe. </summary>
        public string ReceiverName { get; }
    }
}
