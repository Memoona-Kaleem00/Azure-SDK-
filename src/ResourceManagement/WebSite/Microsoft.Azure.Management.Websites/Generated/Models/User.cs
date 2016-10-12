// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Represents user crendentials used for publishing activity
    /// </summary>
    public partial class User : Resource
    {
        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User() { }

        /// <summary>
        /// Initializes a new instance of the User class.
        /// </summary>
        public User(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string userName = default(string), string publishingUserName = default(string), string publishingPassword = default(string), string publishingPasswordHash = default(string), string publishingPasswordHashSalt = default(string))
            : base(location, id, name, kind, type, tags)
        {
            UserName = userName;
            PublishingUserName = publishingUserName;
            PublishingPassword = publishingPassword;
            PublishingPasswordHash = publishingPasswordHash;
            PublishingPasswordHashSalt = publishingPasswordHashSalt;
        }

        /// <summary>
        /// Username (internal)
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string UserName { get; set; }

        /// <summary>
        /// Username used for publishing
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingUserName")]
        public string PublishingUserName { get; set; }

        /// <summary>
        /// Password used for publishing
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPassword")]
        public string PublishingPassword { get; set; }

        /// <summary>
        /// PasswordHash used for publishing
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPasswordHash")]
        public string PublishingPasswordHash { get; set; }

        /// <summary>
        /// PasswordHashSalt used for publishing
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishingPasswordHashSalt")]
        public string PublishingPasswordHashSalt { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
