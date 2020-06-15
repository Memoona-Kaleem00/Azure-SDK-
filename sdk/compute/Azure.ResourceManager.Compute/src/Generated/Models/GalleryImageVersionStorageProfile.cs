// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the storage profile of a Gallery Image Version. </summary>
    public partial class GalleryImageVersionStorageProfile
    {
        /// <summary> Initializes a new instance of GalleryImageVersionStorageProfile. </summary>
        public GalleryImageVersionStorageProfile()
        {
        }

        /// <summary> Initializes a new instance of GalleryImageVersionStorageProfile. </summary>
        /// <param name="source"> The gallery artifact version source. </param>
        /// <param name="osDiskImage"> This is the disk image base class. </param>
        /// <param name="dataDiskImages"> A list of data disk images. </param>
        internal GalleryImageVersionStorageProfile(GalleryArtifactVersionSource source, GalleryDiskImage osDiskImage, IList<GalleryDataDiskImage> dataDiskImages)
        {
            Source = source;
            OsDiskImage = osDiskImage;
            DataDiskImages = dataDiskImages;
        }

        /// <summary> The gallery artifact version source. </summary>
        public GalleryArtifactVersionSource Source { get; set; }
        /// <summary> This is the disk image base class. </summary>
        public GalleryDiskImage OsDiskImage { get; set; }
        /// <summary> A list of data disk images. </summary>
        public IList<GalleryDataDiskImage> DataDiskImages { get; set; }
    }
}
