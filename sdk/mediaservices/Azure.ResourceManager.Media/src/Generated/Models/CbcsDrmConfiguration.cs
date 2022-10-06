// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class to specify DRM configurations of CommonEncryptionCbcs scheme in Streaming Policy. </summary>
    public partial class CbcsDrmConfiguration
    {
        /// <summary> Initializes a new instance of CbcsDrmConfiguration. </summary>
        public CbcsDrmConfiguration()
        {
        }

        /// <summary> Initializes a new instance of CbcsDrmConfiguration. </summary>
        /// <param name="fairPlay"> FairPlay configurations. </param>
        /// <param name="playReady"> PlayReady configurations. </param>
        /// <param name="widevine"> Widevine configurations. </param>
        internal CbcsDrmConfiguration(StreamingPolicyFairPlayConfiguration fairPlay, StreamingPolicyPlayReadyConfiguration playReady, StreamingPolicyWidevineConfiguration widevine)
        {
            FairPlay = fairPlay;
            PlayReady = playReady;
            Widevine = widevine;
        }

        /// <summary> FairPlay configurations. </summary>
        public StreamingPolicyFairPlayConfiguration FairPlay { get; set; }
        /// <summary> PlayReady configurations. </summary>
        public StreamingPolicyPlayReadyConfiguration PlayReady { get; set; }
        /// <summary> Widevine configurations. </summary>
        internal StreamingPolicyWidevineConfiguration Widevine { get; set; }
        /// <summary> Template for the URL of the custom service delivering licenses to end user players.  Not required when using Azure Media Services for issuing licenses.  The template supports replaceable tokens that the service will update at runtime with the value specific to the request.  The currently supported token values are {AlternativeMediaId}, which is replaced with the value of StreamingLocatorId.AlternativeMediaId, and {ContentKeyId}, which is replaced with the value of identifier of the key being requested. </summary>
        public string WidevineCustomLicenseAcquisitionUriTemplate
        {
            get => Widevine is null ? default : Widevine.CustomLicenseAcquisitionUriTemplate;
            set
            {
                if (Widevine is null)
                    Widevine = new StreamingPolicyWidevineConfiguration();
                Widevine.CustomLicenseAcquisitionUriTemplate = value;
            }
        }
    }
}
