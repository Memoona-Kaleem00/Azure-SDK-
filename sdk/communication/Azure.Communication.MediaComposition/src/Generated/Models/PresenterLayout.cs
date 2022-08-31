// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Communication.MediaComposition.Models;

namespace Azure.Communication.MediaComposition
{
    /// <summary> Configure the presenter layout. </summary>
    public partial class PresenterLayout : MediaCompositionLayout
    {
        /// <summary> Initializes a new instance of PresenterLayout. </summary>
        /// <param name="presenterId"> Id of the presenter input. </param>
        /// <param name="supportId"> Id of the support input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="presenterId"/> or <paramref name="supportId"/> is null. </exception>
        public PresenterLayout(string presenterId, string supportId)
        {
            if (presenterId == null)
            {
                throw new ArgumentNullException(nameof(presenterId));
            }
            if (supportId == null)
            {
                throw new ArgumentNullException(nameof(supportId));
            }

            PresenterId = presenterId;
            SupportId = supportId;
            Kind = LayoutType.Presenter;
        }

        /// <summary> Initializes a new instance of PresenterLayout. </summary>
        /// <param name="kind"> Kind of layout. </param>
        /// <param name="resolution"> The dimensions of the scene or objects in the scene. </param>
        /// <param name="placeholderImageUri"> Set global placeholder image. </param>
        /// <param name="presenterId"> Id of the presenter input. </param>
        /// <param name="supportId"> Id of the support input. </param>
        /// <param name="supportPosition"> Position of the support stream. </param>
        /// <param name="supportAspectRatio"> Aspect ratio of the support stream. </param>
        internal PresenterLayout(LayoutType kind, LayoutResolution resolution, string placeholderImageUri, string presenterId, string supportId, SupportPosition? supportPosition, double? supportAspectRatio) : base(kind, resolution, placeholderImageUri)
        {
            PresenterId = presenterId;
            SupportId = supportId;
            SupportPosition = supportPosition;
            SupportAspectRatio = supportAspectRatio;
            Kind = kind;
        }

        /// <summary> Id of the presenter input. </summary>
        public string PresenterId { get; set; }
        /// <summary> Id of the support input. </summary>
        public string SupportId { get; set; }
        /// <summary> Position of the support stream. </summary>
        public SupportPosition? SupportPosition { get; set; }
        /// <summary> Aspect ratio of the support stream. </summary>
        public double? SupportAspectRatio { get; set; }
    }
}
