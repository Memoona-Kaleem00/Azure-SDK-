// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.MixedReality.ObjectAnchors.Conversion
{
    /// <summary> Represents the status of an AOA asset conversion job. </summary>
    public partial class AssetConversionProperties
    {

        /// <summary> Initializes a new instance of AssetConversionProperties. </summary>
        /// <param name="clientErrorDetails"> Information about the cause of a ClientError JobStatus. </param>
        /// <param name="serverErrorDetails"> Information about the cause of a ServerError JobStatus. </param>
        /// <param name="errorCode"> The error code associated with the asset conversion job. </param>
        /// <param name="jobIdInternal"> Identifier for the AOA asset conversion job. </param>
        /// <param name="outputModelUriString"> The URI for downloading the generated AOA Model. </param>
        /// <param name="conversionStatus"> Status of the asset conversion job. </param>
        /// <param name="assetFileTypeString"> The file type of the original 3D asset. Examples include: &quot;ply&quot;, &quot;obj&quot;, &quot;fbx&quot;, &quot;glb&quot;, &quot;gltf&quot;, etc. </param>
        /// <param name="inputAssetUriString"> The Uri to the Asset to be ingested by the AOA asset conversion service. This asset needs to have been uploaded to the service using an endpoint provided from a call to the GetUploadUri API. </param>
        /// <param name="accountIdInternal"> Identifier for the Account owning the asset conversion job. </param>
        /// <param name="conversionConfiguration"> Configuration settings for the asset conversion job. </param>
        internal AssetConversionProperties(string clientErrorDetails, string serverErrorDetails, ConversionErrorCode errorCode, Guid? jobIdInternal, string outputModelUriString, AssetConversionStatus? conversionStatus, string assetFileTypeString, string inputAssetUriString, Guid? accountIdInternal, AssetConversionConfiguration conversionConfiguration)
        {
            ClientErrorDetails = clientErrorDetails;
            ServerErrorDetails = serverErrorDetails;
            ErrorCode = errorCode;
            JobIdInternal = jobIdInternal;
            OutputModelUriString = outputModelUriString;
            ConversionStatus = conversionStatus;
            AssetFileTypeString = assetFileTypeString;
            InputAssetUriString = inputAssetUriString;
            AccountIdInternal = accountIdInternal;
            ConversionConfiguration = conversionConfiguration;
        }

        /// <summary> Information about the cause of a ClientError JobStatus. </summary>
        public string ClientErrorDetails { get; }
        /// <summary> Information about the cause of a ServerError JobStatus. </summary>
        public string ServerErrorDetails { get; }
    }
}
