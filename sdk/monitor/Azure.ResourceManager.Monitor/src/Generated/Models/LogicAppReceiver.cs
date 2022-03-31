// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> A logic app receiver. </summary>
    public partial class LogicAppReceiver
    {
        /// <summary> Initializes a new instance of LogicAppReceiver. </summary>
        /// <param name="name"> The name of the logic app receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="resourceId"> The azure resource id of the logic app receiver. </param>
        /// <param name="callbackUri"> The callback url where http request sent to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="resourceId"/> or <paramref name="callbackUri"/> is null. </exception>
        public LogicAppReceiver(string name, string resourceId, Uri callbackUri)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (resourceId == null)
            {
                throw new ArgumentNullException(nameof(resourceId));
            }
            if (callbackUri == null)
            {
                throw new ArgumentNullException(nameof(callbackUri));
            }

            Name = name;
            ResourceId = resourceId;
            CallbackUri = callbackUri;
        }

        /// <summary> Initializes a new instance of LogicAppReceiver. </summary>
        /// <param name="name"> The name of the logic app receiver. Names must be unique across all receivers within an action group. </param>
        /// <param name="resourceId"> The azure resource id of the logic app receiver. </param>
        /// <param name="callbackUri"> The callback url where http request sent to. </param>
        /// <param name="useCommonAlertSchema"> Indicates whether to use common alert schema. </param>
        internal LogicAppReceiver(string name, string resourceId, Uri callbackUri, bool? useCommonAlertSchema)
        {
            Name = name;
            ResourceId = resourceId;
            CallbackUri = callbackUri;
            UseCommonAlertSchema = useCommonAlertSchema;
        }

        /// <summary> The name of the logic app receiver. Names must be unique across all receivers within an action group. </summary>
        public string Name { get; set; }
        /// <summary> The azure resource id of the logic app receiver. </summary>
        public string ResourceId { get; set; }
        /// <summary> The callback url where http request sent to. </summary>
        public Uri CallbackUri { get; set; }
        /// <summary> Indicates whether to use common alert schema. </summary>
        public bool? UseCommonAlertSchema { get; set; }
    }
}
