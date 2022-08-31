// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> IoT edge agent details is optional, this will be used for download system Agent module while bootstrapping IoT Role if specified. </summary>
    public partial class IoTEdgeAgentInfo
    {
        /// <summary> Initializes a new instance of IoTEdgeAgentInfo. </summary>
        /// <param name="imageName"> Name of the IoT edge agent image. </param>
        /// <param name="tag"> Image Tag. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> or <paramref name="tag"/> is null. </exception>
        public IoTEdgeAgentInfo(string imageName, string tag)
        {
            if (imageName == null)
            {
                throw new ArgumentNullException(nameof(imageName));
            }
            if (tag == null)
            {
                throw new ArgumentNullException(nameof(tag));
            }

            ImageName = imageName;
            Tag = tag;
        }

        /// <summary> Initializes a new instance of IoTEdgeAgentInfo. </summary>
        /// <param name="imageName"> Name of the IoT edge agent image. </param>
        /// <param name="tag"> Image Tag. </param>
        /// <param name="imageRepository"> Image repository details. </param>
        internal IoTEdgeAgentInfo(string imageName, string tag, ImageRepositoryCredential imageRepository)
        {
            ImageName = imageName;
            Tag = tag;
            ImageRepository = imageRepository;
        }

        /// <summary> Name of the IoT edge agent image. </summary>
        public string ImageName { get; set; }
        /// <summary> Image Tag. </summary>
        public string Tag { get; set; }
        /// <summary> Image repository details. </summary>
        public ImageRepositoryCredential ImageRepository { get; set; }
    }
}
