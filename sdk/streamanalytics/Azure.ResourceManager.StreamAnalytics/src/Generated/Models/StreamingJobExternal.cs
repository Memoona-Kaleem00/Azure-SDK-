// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The storage account where the custom code artifacts are located. </summary>
    public partial class StreamingJobExternal
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StreamingJobExternal"/>. </summary>
        public StreamingJobExternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamingJobExternal"/>. </summary>
        /// <param name="storageAccount"> The properties that are associated with an Azure Storage account. </param>
        /// <param name="container"> The UserCustomCode container. </param>
        /// <param name="path"> The UserCustomCode path. </param>
        /// <param name="refreshConfiguration"> The refresh parameters for any/all updatable user defined functions present in the job config. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingJobExternal(StreamAnalyticsStorageAccount storageAccount, string container, string path, StreamingJobRefreshConfiguration refreshConfiguration, Dictionary<string, BinaryData> rawData)
        {
            StorageAccount = storageAccount;
            Container = container;
            Path = path;
            RefreshConfiguration = refreshConfiguration;
            _rawData = rawData;
        }

        /// <summary> The properties that are associated with an Azure Storage account. </summary>
        public StreamAnalyticsStorageAccount StorageAccount { get; set; }
        /// <summary> The UserCustomCode container. </summary>
        public string Container { get; set; }
        /// <summary> The UserCustomCode path. </summary>
        public string Path { get; set; }
        /// <summary> The refresh parameters for any/all updatable user defined functions present in the job config. </summary>
        public StreamingJobRefreshConfiguration RefreshConfiguration { get; set; }
    }
}
