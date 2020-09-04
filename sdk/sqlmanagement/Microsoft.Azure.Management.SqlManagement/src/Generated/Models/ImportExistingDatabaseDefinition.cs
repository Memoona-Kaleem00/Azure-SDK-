// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains the information necessary to perform import operation for
    /// existing database.
    /// </summary>
    public partial class ImportExistingDatabaseDefinition
    {
        /// <summary>
        /// Initializes a new instance of the ImportExistingDatabaseDefinition
        /// class.
        /// </summary>
        public ImportExistingDatabaseDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportExistingDatabaseDefinition
        /// class.
        /// </summary>
        /// <param name="storageKeyType">Storage key type. Possible values
        /// include: 'SharedAccessKey', 'StorageAccessKey'</param>
        /// <param name="storageKey">Storage key.</param>
        /// <param name="storageUri">Storage Uri.</param>
        /// <param name="administratorLogin">Administrator login name.</param>
        /// <param name="administratorLoginPassword">Administrator login
        /// password.</param>
        /// <param name="authenticationType">Authentication type.</param>
        /// <param name="networkIsolation">Optional resource information to
        /// enable network isolation for request.</param>
        public ImportExistingDatabaseDefinition(StorageKeyType storageKeyType, string storageKey, string storageUri, string administratorLogin, string administratorLoginPassword, string authenticationType = default(string), NetworkIsolationSettings networkIsolation = default(NetworkIsolationSettings))
        {
            StorageKeyType = storageKeyType;
            StorageKey = storageKey;
            StorageUri = storageUri;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            AuthenticationType = authenticationType;
            NetworkIsolation = networkIsolation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage key type. Possible values include:
        /// 'SharedAccessKey', 'StorageAccessKey'
        /// </summary>
        [JsonProperty(PropertyName = "storageKeyType")]
        public StorageKeyType StorageKeyType { get; set; }

        /// <summary>
        /// Gets or sets storage key.
        /// </summary>
        [JsonProperty(PropertyName = "storageKey")]
        public string StorageKey { get; set; }

        /// <summary>
        /// Gets or sets storage Uri.
        /// </summary>
        [JsonProperty(PropertyName = "storageUri")]
        public string StorageUri { get; set; }

        /// <summary>
        /// Gets or sets administrator login name.
        /// </summary>
        [JsonProperty(PropertyName = "administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets administrator login password.
        /// </summary>
        [JsonProperty(PropertyName = "administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Gets or sets authentication type.
        /// </summary>
        [JsonProperty(PropertyName = "authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets optional resource information to enable network
        /// isolation for request.
        /// </summary>
        [JsonProperty(PropertyName = "networkIsolation")]
        public NetworkIsolationSettings NetworkIsolation { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageKey");
            }
            if (StorageUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageUri");
            }
            if (AdministratorLogin == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AdministratorLogin");
            }
            if (AdministratorLoginPassword == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AdministratorLoginPassword");
            }
        }
    }
}
