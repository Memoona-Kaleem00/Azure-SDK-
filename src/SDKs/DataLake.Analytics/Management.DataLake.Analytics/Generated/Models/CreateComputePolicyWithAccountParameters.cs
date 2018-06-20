// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters used to create a new compute policy while creating a new
    /// Data Lake Analytics account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CreateComputePolicyWithAccountParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CreateComputePolicyWithAccountParameters class.
        /// </summary>
        public CreateComputePolicyWithAccountParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CreateComputePolicyWithAccountParameters class.
        /// </summary>
        /// <param name="name">The unique name of the compute policy to
        /// create.</param>
        /// <param name="objectId">The AAD object identifier for the entity to
        /// create a policy for.</param>
        /// <param name="objectType">The type of AAD object the object
        /// identifier refers to. Possible values include: 'User', 'Group',
        /// 'ServicePrincipal'</param>
        /// <param name="maxDegreeOfParallelismPerJob">The maximum degree of
        /// parallelism per job this user can use to submit jobs. This
        /// property, the min priority per job property, or both must be
        /// passed.</param>
        /// <param name="minPriorityPerJob">The minimum priority per job this
        /// user can use to submit jobs. This property, the max degree of
        /// parallelism per job property, or both must be passed.</param>
        public CreateComputePolicyWithAccountParameters(string name, System.Guid objectId, string objectType, int? maxDegreeOfParallelismPerJob = default(int?), int? minPriorityPerJob = default(int?))
        {
            Name = name;
            ObjectId = objectId;
            ObjectType = objectType;
            MaxDegreeOfParallelismPerJob = maxDegreeOfParallelismPerJob;
            MinPriorityPerJob = minPriorityPerJob;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique name of the compute policy to create.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the AAD object identifier for the entity to create a
        /// policy for.
        /// </summary>
        [JsonProperty(PropertyName = "properties.objectId")]
        public System.Guid ObjectId { get; set; }

        /// <summary>
        /// Gets or sets the type of AAD object the object identifier refers
        /// to. Possible values include: 'User', 'Group', 'ServicePrincipal'
        /// </summary>
        [JsonProperty(PropertyName = "properties.objectType")]
        public string ObjectType { get; set; }

        /// <summary>
        /// Gets or sets the maximum degree of parallelism per job this user
        /// can use to submit jobs. This property, the min priority per job
        /// property, or both must be passed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxDegreeOfParallelismPerJob")]
        public int? MaxDegreeOfParallelismPerJob { get; set; }

        /// <summary>
        /// Gets or sets the minimum priority per job this user can use to
        /// submit jobs. This property, the max degree of parallelism per job
        /// property, or both must be passed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.minPriorityPerJob")]
        public int? MinPriorityPerJob { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (ObjectType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ObjectType");
            }
            if (MaxDegreeOfParallelismPerJob < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDegreeOfParallelismPerJob", 1);
            }
            if (MinPriorityPerJob < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinPriorityPerJob", 1);
            }
        }
    }
}
