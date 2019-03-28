// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// HDInsight linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HDInsight")]
    [Rest.Serialization.JsonTransformation]
    public partial class HDInsightLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the HDInsightLinkedService class.
        /// </summary>
        public HDInsightLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HDInsightLinkedService class.
        /// </summary>
        /// <param name="clusterUri">HDInsight cluster URI. Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Dataset.</param>
        /// <param name="userName">HDInsight cluster user name. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="password">HDInsight cluster password.</param>
        /// <param name="linkedServiceName">The Azure Storage linked service
        /// reference.</param>
        /// <param name="hcatalogLinkedServiceName">A reference to the Azure
        /// SQL linked service that points to the HCatalog database.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="isEspEnabled">Specify if the HDInsight is created with
        /// ESP (Enterprise Security Package). Type: Boolean.</param>
        public HDInsightLinkedService(object clusterUri, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), object userName = default(object), SecretBase password = default(SecretBase), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), LinkedServiceReference hcatalogLinkedServiceName = default(LinkedServiceReference), object encryptedCredential = default(object), object isEspEnabled = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            ClusterUri = clusterUri;
            UserName = userName;
            Password = password;
            LinkedServiceName = linkedServiceName;
            HcatalogLinkedServiceName = hcatalogLinkedServiceName;
            EncryptedCredential = encryptedCredential;
            IsEspEnabled = isEspEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets hDInsight cluster URI. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clusterUri")]
        public object ClusterUri { get; set; }

        /// <summary>
        /// Gets or sets hDInsight cluster user name. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.userName")]
        public object UserName { get; set; }

        /// <summary>
        /// Gets or sets hDInsight cluster password.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets the Azure Storage linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.linkedServiceName")]
        public LinkedServiceReference LinkedServiceName { get; set; }

        /// <summary>
        /// Gets or sets a reference to the Azure SQL linked service that
        /// points to the HCatalog database.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.hcatalogLinkedServiceName")]
        public LinkedServiceReference HcatalogLinkedServiceName { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Gets or sets specify if the HDInsight is created with ESP
        /// (Enterprise Security Package). Type: Boolean.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.isEspEnabled")]
        public object IsEspEnabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ClusterUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClusterUri");
            }
            if (LinkedServiceName != null)
            {
                LinkedServiceName.Validate();
            }
            if (HcatalogLinkedServiceName != null)
            {
                HcatalogLinkedServiceName.Validate();
            }
        }
    }
}
