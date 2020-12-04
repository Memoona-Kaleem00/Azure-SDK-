// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Spark job definition. </summary>
    public partial class SparkJobDefinition : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of SparkJobDefinition. </summary>
        /// <param name="targetBigDataPool"> Big data pool reference. </param>
        /// <param name="jobProperties"> The properties of the Spark job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetBigDataPool"/> or <paramref name="jobProperties"/> is null. </exception>
        public SparkJobDefinition(BigDataPoolReference targetBigDataPool, SparkJobProperties jobProperties)
        {
            if (targetBigDataPool == null)
            {
                throw new ArgumentNullException(nameof(targetBigDataPool));
            }
            if (jobProperties == null)
            {
                throw new ArgumentNullException(nameof(jobProperties));
            }

            TargetBigDataPool = targetBigDataPool;
            JobProperties = jobProperties;
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of SparkJobDefinition. </summary>
        /// <param name="description"> The description of the Spark job definition. </param>
        /// <param name="targetBigDataPool"> Big data pool reference. </param>
        /// <param name="requiredSparkVersion"> The required Spark version of the application. </param>
        /// <param name="language"> The language of the Spark application. </param>
        /// <param name="jobProperties"> The properties of the Spark job. </param>
        /// <param name="additionalProperties"> . </param>
        internal SparkJobDefinition(string description, BigDataPoolReference targetBigDataPool, string requiredSparkVersion, string language, SparkJobProperties jobProperties, IDictionary<string, object> additionalProperties)
        {
            Description = description;
            TargetBigDataPool = targetBigDataPool;
            RequiredSparkVersion = requiredSparkVersion;
            Language = language;
            JobProperties = jobProperties;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The description of the Spark job definition. </summary>
        public string Description { get; set; }
        /// <summary> Big data pool reference. </summary>
        public BigDataPoolReference TargetBigDataPool { get; set; }
        /// <summary> The required Spark version of the application. </summary>
        public string RequiredSparkVersion { get; set; }
        /// <summary> The language of the Spark application. </summary>
        public string Language { get; set; }
        /// <summary> The properties of the Spark job. </summary>
        public SparkJobProperties JobProperties { get; set; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc cref="ICollection{T}.Count"/>
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc cref="ICollection{T}.IsReadOnly"/>
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc cref="ICollection{T}.Add"/>
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc cref="ICollection{T}.Remove"/>
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc cref="ICollection{T}.Contains"/>
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc cref="ICollection{T}.CopyTo"/>
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc cref="ICollection{T}.Clear"/>
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
