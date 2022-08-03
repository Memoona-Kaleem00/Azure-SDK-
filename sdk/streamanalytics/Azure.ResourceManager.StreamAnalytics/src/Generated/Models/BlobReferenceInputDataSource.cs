// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// Describes a blob input data source that contains reference data.
    /// Serialized Name: BlobReferenceInputDataSource
    /// </summary>
    public partial class BlobReferenceInputDataSource : ReferenceInputDataSource
    {
        /// <summary> Initializes a new instance of BlobReferenceInputDataSource. </summary>
        public BlobReferenceInputDataSource()
        {
            StorageAccounts = new ChangeTrackingList<StorageAccount>();
            ReferenceInputDataSourceType = "Microsoft.Storage/Blob";
        }

        /// <summary> Initializes a new instance of BlobReferenceInputDataSource. </summary>
        /// <param name="referenceInputDataSourceType">
        /// Indicates the type of input data source containing reference data. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: ReferenceInputDataSource.type
        /// </param>
        /// <param name="storageAccounts">
        /// A list of one or more Azure Storage accounts. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: BlobReferenceInputDataSource.properties.storageAccounts
        /// </param>
        /// <param name="container">
        /// The name of a container within the associated Storage account. This container contains either the blob(s) to be read from or written to. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: BlobReferenceInputDataSource.properties.container
        /// </param>
        /// <param name="pathPattern">
        /// The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job. See https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input or https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for a more detailed explanation and example.
        /// Serialized Name: BlobReferenceInputDataSource.properties.pathPattern
        /// </param>
        /// <param name="dateFormat">
        /// The date format. Wherever {date} appears in pathPattern, the value of this property is used as the date format instead.
        /// Serialized Name: BlobReferenceInputDataSource.properties.dateFormat
        /// </param>
        /// <param name="timeFormat">
        /// The time format. Wherever {time} appears in pathPattern, the value of this property is used as the time format instead.
        /// Serialized Name: BlobReferenceInputDataSource.properties.timeFormat
        /// </param>
        /// <param name="authenticationMode">
        /// Authentication Mode.
        /// Serialized Name: BlobReferenceInputDataSource.properties.authenticationMode
        /// </param>
        /// <param name="blobName">
        /// The name of the blob input.
        /// Serialized Name: BlobReferenceInputDataSource.properties.blobName
        /// </param>
        /// <param name="deltaPathPattern">
        /// The path pattern of the delta snapshot.
        /// Serialized Name: BlobReferenceInputDataSource.properties.deltaPathPattern
        /// </param>
        /// <param name="sourcePartitionCount">
        /// The partition count of the blob input data source. Range 1 - 256.
        /// Serialized Name: BlobReferenceInputDataSource.properties.sourcePartitionCount
        /// </param>
        /// <param name="fullSnapshotRefreshRate">
        /// The refresh interval of the blob input data source.
        /// Serialized Name: BlobReferenceInputDataSource.properties.fullSnapshotRefreshRate
        /// </param>
        /// <param name="deltaSnapshotRefreshRate">
        /// The interval that the user generates a delta snapshot of this reference blob input data source.
        /// Serialized Name: BlobReferenceInputDataSource.properties.deltaSnapshotRefreshRate
        /// </param>
        internal BlobReferenceInputDataSource(string referenceInputDataSourceType, IList<StorageAccount> storageAccounts, string container, string pathPattern, string dateFormat, string timeFormat, AuthenticationMode? authenticationMode, string blobName, string deltaPathPattern, int? sourcePartitionCount, string fullSnapshotRefreshRate, string deltaSnapshotRefreshRate) : base(referenceInputDataSourceType)
        {
            StorageAccounts = storageAccounts;
            Container = container;
            PathPattern = pathPattern;
            DateFormat = dateFormat;
            TimeFormat = timeFormat;
            AuthenticationMode = authenticationMode;
            BlobName = blobName;
            DeltaPathPattern = deltaPathPattern;
            SourcePartitionCount = sourcePartitionCount;
            FullSnapshotRefreshRate = fullSnapshotRefreshRate;
            DeltaSnapshotRefreshRate = deltaSnapshotRefreshRate;
            ReferenceInputDataSourceType = referenceInputDataSourceType ?? "Microsoft.Storage/Blob";
        }

        /// <summary>
        /// A list of one or more Azure Storage accounts. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: BlobReferenceInputDataSource.properties.storageAccounts
        /// </summary>
        public IList<StorageAccount> StorageAccounts { get; }
        /// <summary>
        /// The name of a container within the associated Storage account. This container contains either the blob(s) to be read from or written to. Required on PUT (CreateOrReplace) requests.
        /// Serialized Name: BlobReferenceInputDataSource.properties.container
        /// </summary>
        public string Container { get; set; }
        /// <summary>
        /// The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job. See https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input or https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for a more detailed explanation and example.
        /// Serialized Name: BlobReferenceInputDataSource.properties.pathPattern
        /// </summary>
        public string PathPattern { get; set; }
        /// <summary>
        /// The date format. Wherever {date} appears in pathPattern, the value of this property is used as the date format instead.
        /// Serialized Name: BlobReferenceInputDataSource.properties.dateFormat
        /// </summary>
        public string DateFormat { get; set; }
        /// <summary>
        /// The time format. Wherever {time} appears in pathPattern, the value of this property is used as the time format instead.
        /// Serialized Name: BlobReferenceInputDataSource.properties.timeFormat
        /// </summary>
        public string TimeFormat { get; set; }
        /// <summary>
        /// Authentication Mode.
        /// Serialized Name: BlobReferenceInputDataSource.properties.authenticationMode
        /// </summary>
        public AuthenticationMode? AuthenticationMode { get; set; }
        /// <summary>
        /// The name of the blob input.
        /// Serialized Name: BlobReferenceInputDataSource.properties.blobName
        /// </summary>
        public string BlobName { get; set; }
        /// <summary>
        /// The path pattern of the delta snapshot.
        /// Serialized Name: BlobReferenceInputDataSource.properties.deltaPathPattern
        /// </summary>
        public string DeltaPathPattern { get; set; }
        /// <summary>
        /// The partition count of the blob input data source. Range 1 - 256.
        /// Serialized Name: BlobReferenceInputDataSource.properties.sourcePartitionCount
        /// </summary>
        public int? SourcePartitionCount { get; set; }
        /// <summary>
        /// The refresh interval of the blob input data source.
        /// Serialized Name: BlobReferenceInputDataSource.properties.fullSnapshotRefreshRate
        /// </summary>
        public string FullSnapshotRefreshRate { get; set; }
        /// <summary>
        /// The interval that the user generates a delta snapshot of this reference blob input data source.
        /// Serialized Name: BlobReferenceInputDataSource.properties.deltaSnapshotRefreshRate
        /// </summary>
        public string DeltaSnapshotRefreshRate { get; set; }
    }
}
