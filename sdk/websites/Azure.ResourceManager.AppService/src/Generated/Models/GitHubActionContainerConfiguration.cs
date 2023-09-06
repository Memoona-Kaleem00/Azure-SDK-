// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The GitHub action container configuration. </summary>
    public partial class GitHubActionContainerConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GitHubActionContainerConfiguration"/>. </summary>
        public GitHubActionContainerConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubActionContainerConfiguration"/>. </summary>
        /// <param name="serverUri"> The server URL for the container registry where the build will be hosted. </param>
        /// <param name="imageName"> The image name for the build. </param>
        /// <param name="username"> The username used to upload the image to the container registry. </param>
        /// <param name="password"> The password used to upload the image to the container registry. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GitHubActionContainerConfiguration(Uri serverUri, string imageName, string username, string password, Dictionary<string, BinaryData> rawData)
        {
            ServerUri = serverUri;
            ImageName = imageName;
            Username = username;
            Password = password;
            _rawData = rawData;
        }

        /// <summary> The server URL for the container registry where the build will be hosted. </summary>
        public Uri ServerUri { get; set; }
        /// <summary> The image name for the build. </summary>
        public string ImageName { get; set; }
        /// <summary> The username used to upload the image to the container registry. </summary>
        public string Username { get; set; }
        /// <summary> The password used to upload the image to the container registry. </summary>
        public string Password { get; set; }
    }
}
