// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> vCenter Single Sign On Identity Source. </summary>
    public partial class SingleSignOnIdentitySource
    {
        /// <summary> Initializes a new instance of SingleSignOnIdentitySource. </summary>
        public SingleSignOnIdentitySource()
        {
        }

        /// <summary> Initializes a new instance of SingleSignOnIdentitySource. </summary>
        /// <param name="name"> The name of the identity source. </param>
        /// <param name="alias"> The domain&apos;s NetBIOS name. </param>
        /// <param name="domain"> The domain&apos;s dns name. </param>
        /// <param name="baseUserDN"> The base distinguished name for users. </param>
        /// <param name="baseGroupDN"> The base distinguished name for groups. </param>
        /// <param name="primaryServer"> Primary server URL. </param>
        /// <param name="secondaryServer"> Secondary server URL. </param>
        /// <param name="ssl"> Protect LDAP communication using SSL certificate (LDAPS). </param>
        /// <param name="username"> The ID of an Active Directory user with a minimum of read-only access to Base DN for users and group. </param>
        /// <param name="password"> The password of the Active Directory user with a minimum of read-only access to Base DN for users and groups. </param>
        internal SingleSignOnIdentitySource(string name, string @alias, string domain, string baseUserDN, string baseGroupDN, string primaryServer, string secondaryServer, SslCertificateStatus? ssl, string username, string password)
        {
            Name = name;
            Alias = @alias;
            Domain = domain;
            BaseUserDN = baseUserDN;
            BaseGroupDN = baseGroupDN;
            PrimaryServer = primaryServer;
            SecondaryServer = secondaryServer;
            Ssl = ssl;
            Username = username;
            Password = password;
        }

        /// <summary> The name of the identity source. </summary>
        public string Name { get; set; }
        /// <summary> The domain&apos;s NetBIOS name. </summary>
        public string Alias { get; set; }
        /// <summary> The domain&apos;s dns name. </summary>
        public string Domain { get; set; }
        /// <summary> The base distinguished name for users. </summary>
        public string BaseUserDN { get; set; }
        /// <summary> The base distinguished name for groups. </summary>
        public string BaseGroupDN { get; set; }
        /// <summary> Primary server URL. </summary>
        public string PrimaryServer { get; set; }
        /// <summary> Secondary server URL. </summary>
        public string SecondaryServer { get; set; }
        /// <summary> Protect LDAP communication using SSL certificate (LDAPS). </summary>
        public SslCertificateStatus? Ssl { get; set; }
        /// <summary> The ID of an Active Directory user with a minimum of read-only access to Base DN for users and group. </summary>
        public string Username { get; set; }
        /// <summary> The password of the Active Directory user with a minimum of read-only access to Base DN for users and groups. </summary>
        public string Password { get; set; }
    }
}
