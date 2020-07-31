// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Files not tiering error object
    /// </summary>
    public partial class FilesNotTieringError
    {
        /// <summary>
        /// Initializes a new instance of the FilesNotTieringError class.
        /// </summary>
        public FilesNotTieringError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FilesNotTieringError class.
        /// </summary>
        /// <param name="errorCode">Error code (HResult)</param>
        /// <param name="fileCount">Count of files with this error</param>
        public FilesNotTieringError(int? errorCode = default(int?), long? fileCount = default(long?))
        {
            ErrorCode = errorCode;
            FileCount = fileCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets error code (HResult)
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public int? ErrorCode { get; private set; }

        /// <summary>
        /// Gets count of files with this error
        /// </summary>
        [JsonProperty(PropertyName = "fileCount")]
        public long? FileCount { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FileCount < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "FileCount", 0);
            }
        }
    }
}
