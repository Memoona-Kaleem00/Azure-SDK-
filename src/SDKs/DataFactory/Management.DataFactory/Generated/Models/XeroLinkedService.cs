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
    /// Xero Service linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Xero")]
    [Rest.Serialization.JsonTransformation]
    public partial class XeroLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the XeroLinkedService class.
        /// </summary>
        public XeroLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the XeroLinkedService class.
        /// </summary>
        /// <param name="host">The endpoint of the Xero server. (i.e.
        /// api.xero.com)</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="parameters">Parameters for linked service.</param>
        /// <param name="annotations">List of tags that can be used for
        /// describing the Dataset.</param>
        /// <param name="consumerKey">The consumer key associated with the Xero
        /// application.</param>
        /// <param name="privateKey">The private key from the .pem file that
        /// was generated for your Xero private application. You must include
        /// all the text from the .pem file, including the Unix line endings(
        /// ).</param>
        /// <param name="useEncryptedEndpoints">Specifies whether the data
        /// source endpoints are encrypted using HTTPS. The default value is
        /// true.</param>
        /// <param name="useHostVerification">Specifies whether to require the
        /// host name in the server's certificate to match the host name of the
        /// server when connecting over SSL. The default value is true.</param>
        /// <param name="usePeerVerification">Specifies whether to verify the
        /// identity of the server when connecting over SSL. The default value
        /// is true.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public XeroLinkedService(object host, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), IList<object> annotations = default(IList<object>), SecretBase consumerKey = default(SecretBase), SecretBase privateKey = default(SecretBase), object useEncryptedEndpoints = default(object), object useHostVerification = default(object), object usePeerVerification = default(object), object encryptedCredential = default(object))
            : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            Host = host;
            ConsumerKey = consumerKey;
            PrivateKey = privateKey;
            UseEncryptedEndpoints = useEncryptedEndpoints;
            UseHostVerification = useHostVerification;
            UsePeerVerification = usePeerVerification;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the endpoint of the Xero server. (i.e. api.xero.com)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.host")]
        public object Host { get; set; }

        /// <summary>
        /// Gets or sets the consumer key associated with the Xero application.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.consumerKey")]
        public SecretBase ConsumerKey { get; set; }

        /// <summary>
        /// Gets or sets the private key from the .pem file that was generated
        /// for your Xero private application. You must include all the text
        /// from the .pem file, including the Unix line endings(
        /// ).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.privateKey")]
        public SecretBase PrivateKey { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the data source endpoints are
        /// encrypted using HTTPS. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useEncryptedEndpoints")]
        public object UseEncryptedEndpoints { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to require the host name in the
        /// server's certificate to match the host name of the server when
        /// connecting over SSL. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useHostVerification")]
        public object UseHostVerification { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to verify the identity of the server
        /// when connecting over SSL. The default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.usePeerVerification")]
        public object UsePeerVerification { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Host == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Host");
            }
        }
    }
}
