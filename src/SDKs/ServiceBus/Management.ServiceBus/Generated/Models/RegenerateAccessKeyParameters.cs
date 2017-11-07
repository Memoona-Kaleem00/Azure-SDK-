// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceBus.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Regenerate Authorization Rule operation,
    /// specifies which key neeeds to be reset.
    /// </summary>
    public partial class RegenerateAccessKeyParameters
    {
        /// <summary>
        /// Initializes a new instance of the RegenerateAccessKeyParameters
        /// class.
        /// </summary>
        public RegenerateAccessKeyParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegenerateAccessKeyParameters
        /// class.
        /// </summary>
        /// <param name="keyType">The access key to regenerate. Possible values
        /// include: 'PrimaryKey', 'SecondaryKey'</param>
        /// <param name="key">Optional, if the key value provided, is reset for
        /// KeyType value or autogenerate Key value set for keyType</param>
        public RegenerateAccessKeyParameters(KeyType keyType, string key = default(string))
        {
            KeyType = keyType;
            Key = key;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the access key to regenerate. Possible values include:
        /// 'PrimaryKey', 'SecondaryKey'
        /// </summary>
        [JsonProperty(PropertyName = "keyType")]
        public KeyType KeyType { get; set; }

        /// <summary>
        /// Gets or sets optional, if the key value provided, is reset for
        /// KeyType value or autogenerate Key value set for keyType
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
