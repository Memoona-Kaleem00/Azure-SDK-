// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes Protocol and thumbprint of Windows Remote Management listener. </summary>
    public partial class WinRMListener
    {
        /// <summary> Initializes a new instance of WinRMListener. </summary>
        public WinRMListener()
        {
        }

        /// <summary> Initializes a new instance of WinRMListener. </summary>
        /// <param name="protocol"> Specifies the protocol of WinRM listener. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;**http** &lt;br&gt;&lt;br&gt; **https**. </param>
        /// <param name="certificateUri"> This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault, see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8: &lt;br&gt;&lt;br&gt; {&lt;br&gt;  &quot;data&quot;:&quot;&lt;Base64-encoded-certificate&gt;&quot;,&lt;br&gt;  &quot;dataType&quot;:&quot;pfx&quot;,&lt;br&gt;  &quot;password&quot;:&quot;&lt;pfx-file-password&gt;&quot;&lt;br&gt;} &lt;br&gt; To install certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows). </param>
        internal WinRMListener(ProtocolTypes? protocol, Uri certificateUri)
        {
            Protocol = protocol;
            CertificateUri = certificateUri;
        }

        /// <summary> Specifies the protocol of WinRM listener. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;**http** &lt;br&gt;&lt;br&gt; **https**. </summary>
        public ProtocolTypes? Protocol { get; set; }
        /// <summary> This is the URL of a certificate that has been uploaded to Key Vault as a secret. For adding a secret to the Key Vault, see [Add a key or secret to the key vault](https://docs.microsoft.com/azure/key-vault/key-vault-get-started/#add). In this case, your certificate needs to be It is the Base64 encoding of the following JSON Object which is encoded in UTF-8: &lt;br&gt;&lt;br&gt; {&lt;br&gt;  &quot;data&quot;:&quot;&lt;Base64-encoded-certificate&gt;&quot;,&lt;br&gt;  &quot;dataType&quot;:&quot;pfx&quot;,&lt;br&gt;  &quot;password&quot;:&quot;&lt;pfx-file-password&gt;&quot;&lt;br&gt;} &lt;br&gt; To install certificates on a virtual machine it is recommended to use the [Azure Key Vault virtual machine extension for Linux](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-linux) or the [Azure Key Vault virtual machine extension for Windows](https://docs.microsoft.com/azure/virtual-machines/extensions/key-vault-windows). </summary>
        public Uri CertificateUri { get; set; }
    }
}
