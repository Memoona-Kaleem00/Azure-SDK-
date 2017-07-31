// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies characteristics for a temporary 'auto pool'. The Batch
    /// service will create this auto pool when the job is submitted.
    /// </summary>
    public partial class AutoPoolSpecification
    {
        /// <summary>
        /// Initializes a new instance of the AutoPoolSpecification class.
        /// </summary>
        public AutoPoolSpecification() { }

        /// <summary>
        /// Initializes a new instance of the AutoPoolSpecification class.
        /// </summary>
        /// <param name="poolLifetimeOption">The minimum lifetime of created
        /// auto pools, and how multiple jobs on a schedule are assigned to
        /// pools.</param>
        /// <param name="autoPoolIdPrefix">A prefix to be added to the unique
        /// identifier when a pool is automatically created.</param>
        /// <param name="keepAlive">Whether to keep an auto pool alive after
        /// its lifetime expires.</param>
        /// <param name="pool">The pool specification for the auto
        /// pool.</param>
        public AutoPoolSpecification(PoolLifetimeOption poolLifetimeOption, string autoPoolIdPrefix = default(string), bool? keepAlive = default(bool?), PoolSpecification pool = default(PoolSpecification))
        {
            this.AutoPoolIdPrefix = autoPoolIdPrefix;
            this.PoolLifetimeOption = poolLifetimeOption;
            this.KeepAlive = keepAlive;
            this.Pool = pool;
        }

        /// <summary>
        /// Gets or sets a prefix to be added to the unique identifier when a
        /// pool is automatically created.
        /// </summary>
        /// <remarks>
        /// The Batch service assigns each auto pool a unique identifier on
        /// creation. To distinguish between pools created for different
        /// purposes, you can specify this element to add a prefix to the id
        /// that is assigned. The prefix can be up to 20 characters long.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autoPoolIdPrefix")]
        public string AutoPoolIdPrefix { get; set; }

        /// <summary>
        /// Gets or sets the minimum lifetime of created auto pools, and how
        /// multiple jobs on a schedule are assigned to pools.
        /// </summary>
        /// <remarks>
        /// When the pool lifetime scope is jobSchedule level, the Batch
        /// service keeps track of the last autopool created for the job
        /// schedule, and deletes that pool when the job schedule completes.
        /// Batch will also delete this pool if the user updates the auto pool
        /// specification in a way that changes this lifetime. Possible values
        /// include: 'jobSchedule', 'job'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "poolLifetimeOption")]
        public PoolLifetimeOption PoolLifetimeOption { get; set; }

        /// <summary>
        /// Gets or sets whether to keep an auto pool alive after its lifetime
        /// expires.
        /// </summary>
        /// <remarks>
        /// If false, the Batch service deletes the pool once its lifetime (as
        /// determined by the poolLifetimeOption setting) expires; that is,
        /// when the job or job schedule completes. If true, the Batch service
        /// does not delete the pool automatically. It is up to the user to
        /// delete auto pools created with this option.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "keepAlive")]
        public bool? KeepAlive { get; set; }

        /// <summary>
        /// Gets or sets the pool specification for the auto pool.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "pool")]
        public PoolSpecification Pool { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Pool != null)
            {
                this.Pool.Validate();
            }
        }
    }
}
