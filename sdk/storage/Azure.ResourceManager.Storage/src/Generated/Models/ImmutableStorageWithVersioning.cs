// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Object level immutability properties of the container. </summary>
    public partial class ImmutableStorageWithVersioning
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ImmutableStorageWithVersioning"/>. </summary>
        public ImmutableStorageWithVersioning()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImmutableStorageWithVersioning"/>. </summary>
        /// <param name="isEnabled"> This is an immutable property, when set to true it enables object level immutability at the container level. </param>
        /// <param name="timeStamp"> Returns the date and time the object level immutability was enabled. </param>
        /// <param name="migrationState"> This property denotes the container level immutability to object level immutability migration state. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ImmutableStorageWithVersioning(bool? isEnabled, DateTimeOffset? timeStamp, ImmutableStorageWithVersioningMigrationState? migrationState, Dictionary<string, BinaryData> rawData)
        {
            IsEnabled = isEnabled;
            TimeStamp = timeStamp;
            MigrationState = migrationState;
            _rawData = rawData;
        }

        /// <summary> This is an immutable property, when set to true it enables object level immutability at the container level. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Returns the date and time the object level immutability was enabled. </summary>
        public DateTimeOffset? TimeStamp { get; }
        /// <summary> This property denotes the container level immutability to object level immutability migration state. </summary>
        public ImmutableStorageWithVersioningMigrationState? MigrationState { get; }
    }
}
