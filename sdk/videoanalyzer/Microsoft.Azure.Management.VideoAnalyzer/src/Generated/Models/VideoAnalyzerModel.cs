// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.VideoAnalyzer.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Video Analyzer account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VideoAnalyzerModel : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the VideoAnalyzerModel class.
        /// </summary>
        public VideoAnalyzerModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoAnalyzerModel class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="storageAccounts">The storage accounts for this
        /// resource.</param>
        /// <param name="endpoints">The list of endpoints associated with this
        /// resource.</param>
        /// <param name="encryption">The account encryption properties.</param>
        /// <param name="systemData">The system data of the Video Analyzer
        /// account.</param>
        /// <param name="identity">The set of managed identities associated
        /// with the Video Analyzer resource.</param>
        public VideoAnalyzerModel(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<StorageAccount> storageAccounts = default(IList<StorageAccount>), IList<Endpoint> endpoints = default(IList<Endpoint>), AccountEncryption encryption = default(AccountEncryption), SystemData systemData = default(SystemData), VideoAnalyzerIdentity identity = default(VideoAnalyzerIdentity))
            : base(location, id, name, type, tags)
        {
            StorageAccounts = storageAccounts;
            Endpoints = endpoints;
            Encryption = encryption;
            SystemData = systemData;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the storage accounts for this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccounts")]
        public IList<StorageAccount> StorageAccounts { get; set; }

        /// <summary>
        /// Gets the list of endpoints associated with this resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endpoints")]
        public IList<Endpoint> Endpoints { get; private set; }

        /// <summary>
        /// Gets or sets the account encryption properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public AccountEncryption Encryption { get; set; }

        /// <summary>
        /// Gets the system data of the Video Analyzer account.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public SystemData SystemData { get; private set; }

        /// <summary>
        /// Gets or sets the set of managed identities associated with the
        /// Video Analyzer resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public VideoAnalyzerIdentity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (StorageAccounts != null)
            {
                foreach (var element in StorageAccounts)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Encryption != null)
            {
                Encryption.Validate();
            }
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}
