// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Credential details of the shares in account.
    /// </summary>
    public partial class ShareCredentialDetails
    {
        /// <summary>
        /// Initializes a new instance of the ShareCredentialDetails class.
        /// </summary>
        public ShareCredentialDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ShareCredentialDetails class.
        /// </summary>
        /// <param name="shareName">Name of the share.</param>
        /// <param name="shareType">Type of the share. Possible values include:
        /// 'UnknownType', 'HCS', 'BlockBlob', 'PageBlob', 'AzureFile',
        /// 'ManagedDisk', 'AzurePremiumFiles'</param>
        /// <param name="userName">User name for the share.</param>
        /// <param name="password">Password for the share.</param>
        /// <param name="supportedAccessProtocols">Access protocols supported
        /// on the device.</param>
        public ShareCredentialDetails(string shareName = default(string), ShareDestinationFormatType? shareType = default(ShareDestinationFormatType?), string userName = default(string), string password = default(string), IList<AccessProtocol?> supportedAccessProtocols = default(IList<AccessProtocol?>))
        {
            ShareName = shareName;
            ShareType = shareType;
            UserName = userName;
            Password = password;
            SupportedAccessProtocols = supportedAccessProtocols;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the share.
        /// </summary>
        [JsonProperty(PropertyName = "shareName")]
        public string ShareName { get; private set; }

        /// <summary>
        /// Gets type of the share. Possible values include: 'UnknownType',
        /// 'HCS', 'BlockBlob', 'PageBlob', 'AzureFile', 'ManagedDisk',
        /// 'AzurePremiumFiles'
        /// </summary>
        [JsonProperty(PropertyName = "shareType")]
        public ShareDestinationFormatType? ShareType { get; private set; }

        /// <summary>
        /// Gets user name for the share.
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; private set; }

        /// <summary>
        /// Gets password for the share.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; private set; }

        /// <summary>
        /// Gets access protocols supported on the device.
        /// </summary>
        [JsonProperty(PropertyName = "supportedAccessProtocols")]
        public IList<AccessProtocol?> SupportedAccessProtocols { get; private set; }

    }
}
