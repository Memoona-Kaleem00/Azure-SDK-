// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MediaJobErrorCode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MediaJobErrorCode
    {
        /// <summary>
        /// Fatal service error, please contact support.
        /// </summary>
        [EnumMember(Value = "ServiceError")]
        ServiceError,
        /// <summary>
        /// Transient error, please retry, if retry is unsuccessful, please
        /// contact support.
        /// </summary>
        [EnumMember(Value = "ServiceTransientError")]
        ServiceTransientError,
        /// <summary>
        /// While trying to download the input files, the files were not
        /// accessible, please check the availability of the source.
        /// </summary>
        [EnumMember(Value = "DownloadNotAccessible")]
        DownloadNotAccessible,
        /// <summary>
        /// While trying to download the input files, there was an issue during
        /// transfer (storage service, network errors), see details and check
        /// your source.
        /// </summary>
        [EnumMember(Value = "DownloadTransientError")]
        DownloadTransientError,
        /// <summary>
        /// While trying to upload the output files, the destination was not
        /// reachable, please check the availability of the destination.
        /// </summary>
        [EnumMember(Value = "UploadNotAccessible")]
        UploadNotAccessible,
        /// <summary>
        /// While trying to upload the output files, there was an issue during
        /// transfer (storage service, network errors), see details and check
        /// your destination.
        /// </summary>
        [EnumMember(Value = "UploadTransientError")]
        UploadTransientError,
        /// <summary>
        /// There was a problem with the combination of input files and the
        /// configuration settings applied, fix the configuration settings and
        /// retry with the same input, or change input to match the
        /// configuration.
        /// </summary>
        [EnumMember(Value = "ConfigurationUnsupported")]
        ConfigurationUnsupported,
        /// <summary>
        /// There was a problem with the input content (for example: zero byte
        /// files, or corrupt/non-decodable files), check the input files.
        /// </summary>
        [EnumMember(Value = "ContentMalformed")]
        ContentMalformed,
        /// <summary>
        /// There was a problem with the format of the input (not valid media
        /// file, or an unsupported file/codec), check the validity of the
        /// input files.
        /// </summary>
        [EnumMember(Value = "ContentUnsupported")]
        ContentUnsupported
    }
    internal static class MediaJobErrorCodeEnumExtension
    {
        internal static string ToSerializedValue(this MediaJobErrorCode? value)
        {
            return value == null ? null : ((MediaJobErrorCode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MediaJobErrorCode value)
        {
            switch( value )
            {
                case MediaJobErrorCode.ServiceError:
                    return "ServiceError";
                case MediaJobErrorCode.ServiceTransientError:
                    return "ServiceTransientError";
                case MediaJobErrorCode.DownloadNotAccessible:
                    return "DownloadNotAccessible";
                case MediaJobErrorCode.DownloadTransientError:
                    return "DownloadTransientError";
                case MediaJobErrorCode.UploadNotAccessible:
                    return "UploadNotAccessible";
                case MediaJobErrorCode.UploadTransientError:
                    return "UploadTransientError";
                case MediaJobErrorCode.ConfigurationUnsupported:
                    return "ConfigurationUnsupported";
                case MediaJobErrorCode.ContentMalformed:
                    return "ContentMalformed";
                case MediaJobErrorCode.ContentUnsupported:
                    return "ContentUnsupported";
            }
            return null;
        }

        internal static MediaJobErrorCode? ParseMediaJobErrorCode(this string value)
        {
            switch( value )
            {
                case "ServiceError":
                    return MediaJobErrorCode.ServiceError;
                case "ServiceTransientError":
                    return MediaJobErrorCode.ServiceTransientError;
                case "DownloadNotAccessible":
                    return MediaJobErrorCode.DownloadNotAccessible;
                case "DownloadTransientError":
                    return MediaJobErrorCode.DownloadTransientError;
                case "UploadNotAccessible":
                    return MediaJobErrorCode.UploadNotAccessible;
                case "UploadTransientError":
                    return MediaJobErrorCode.UploadTransientError;
                case "ConfigurationUnsupported":
                    return MediaJobErrorCode.ConfigurationUnsupported;
                case "ContentMalformed":
                    return MediaJobErrorCode.ContentMalformed;
                case "ContentUnsupported":
                    return MediaJobErrorCode.ContentUnsupported;
            }
            return null;
        }
    }
}
