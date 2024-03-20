// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Retrieves an existing remote device adapter. </summary>
    public partial class RemoteDeviceAdapterGetRequest : MethodRequestEmptyBodyBase
    {
        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapterGetRequest"/>. </summary>
        /// <param name="name"> Resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public RemoteDeviceAdapterGetRequest(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            MethodName = "remoteDeviceAdapterGet";
        }

        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapterGetRequest"/>. </summary>
        /// <param name="methodName"> Direct method method name. </param>
        /// <param name="apiVersion"> Video Analyzer API version. </param>
        /// <param name="name"> Resource name. </param>
        internal RemoteDeviceAdapterGetRequest(string methodName, string apiVersion, string name) : base(methodName, apiVersion, name)
        {
            MethodName = methodName ?? "remoteDeviceAdapterGet";
        }
    }
}
