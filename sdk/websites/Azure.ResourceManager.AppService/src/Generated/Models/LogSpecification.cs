// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary>
    /// Log Definition of a single resource metric.
    /// Serialized Name: LogSpecification
    /// </summary>
    public partial class LogSpecification
    {
        /// <summary> Initializes a new instance of LogSpecification. </summary>
        internal LogSpecification()
        {
        }

        /// <summary> Initializes a new instance of LogSpecification. </summary>
        /// <param name="name"> Serialized Name: LogSpecification.name. </param>
        /// <param name="displayName"> Serialized Name: LogSpecification.displayName. </param>
        /// <param name="blobDuration"> Serialized Name: LogSpecification.blobDuration. </param>
        /// <param name="logFilterPattern"> Serialized Name: LogSpecification.logFilterPattern. </param>
        internal LogSpecification(string name, string displayName, TimeSpan? blobDuration, string logFilterPattern)
        {
            Name = name;
            DisplayName = displayName;
            BlobDuration = blobDuration;
            LogFilterPattern = logFilterPattern;
        }

        /// <summary> Serialized Name: LogSpecification.name. </summary>
        public string Name { get; }
        /// <summary> Serialized Name: LogSpecification.displayName. </summary>
        public string DisplayName { get; }
        /// <summary> Serialized Name: LogSpecification.blobDuration. </summary>
        public TimeSpan? BlobDuration { get; }
        /// <summary> Serialized Name: LogSpecification.logFilterPattern. </summary>
        public string LogFilterPattern { get; }
    }
}
