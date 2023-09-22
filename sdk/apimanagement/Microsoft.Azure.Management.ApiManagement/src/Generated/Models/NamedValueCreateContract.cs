// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// NamedValue details.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class NamedValueCreateContract : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the NamedValueCreateContract class.
        /// </summary>
        public NamedValueCreateContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NamedValueCreateContract class.
        /// </summary>
        /// <param name="displayName">Unique name of NamedValue. It may contain
        /// only letters, digits, period, dash, and underscore
        /// characters.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Optional tags that when provided can be used to
        /// filter the NamedValue list.</param>
        /// <param name="secret">Determines whether the value is a secret and
        /// should be encrypted or not. Default value is false.</param>
        /// <param name="value">Value of the NamedValue. Can contain policy
        /// expressions. It may not be empty or consist only of whitespace.
        /// This property will not be filled on 'GET' operations! Use
        /// '/listSecrets' POST request to get the value.</param>
        /// <param name="keyVault">KeyVault location details of the
        /// namedValue.</param>
        public NamedValueCreateContract(string displayName, string id = default(string), string name = default(string), string type = default(string), IList<string> tags = default(IList<string>), bool? secret = default(bool?), string value = default(string), KeyVaultContractCreateProperties keyVault = default(KeyVaultContractCreateProperties))
            : base(id, name, type)
        {
            Tags = tags;
            Secret = secret;
            DisplayName = displayName;
            Value = value;
            KeyVault = keyVault;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional tags that when provided can be used to filter
        /// the NamedValue list.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets determines whether the value is a secret and should be
        /// encrypted or not. Default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secret")]
        public bool? Secret { get; set; }

        /// <summary>
        /// Gets or sets unique name of NamedValue. It may contain only
        /// letters, digits, period, dash, and underscore characters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets value of the NamedValue. Can contain policy
        /// expressions. It may not be empty or consist only of whitespace.
        /// This property will not be filled on 'GET' operations! Use
        /// '/listSecrets' POST request to get the value.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets keyVault location details of the namedValue.
        /// </summary>
        [JsonProperty(PropertyName = "properties.keyVault")]
        public KeyVaultContractCreateProperties KeyVault { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Tags != null)
            {
                if (Tags.Count > 32)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "Tags", 32);
                }
            }
            if (DisplayName != null)
            {
                if (DisplayName.Length > 256)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "DisplayName", 256);
                }
                if (DisplayName.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "DisplayName", 1);
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(DisplayName, "^[A-Za-z0-9-._]+$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "DisplayName", "^[A-Za-z0-9-._]+$");
                }
            }
            if (Value != null)
            {
                if (Value.Length > 4096)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Value", 4096);
                }
            }
        }
    }
}
