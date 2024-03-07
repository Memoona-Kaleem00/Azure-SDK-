// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> The authentication options for Azure OpenAI On Your Data when using a user-assigned managed identity. </summary>
    public partial class OnYourDataUserAssignedManagedIdentityAuthenticationOptions : OnYourDataAuthenticationOptions
    {
        /// <summary> Initializes a new instance of <see cref="OnYourDataUserAssignedManagedIdentityAuthenticationOptions"/>. </summary>
        /// <param name="managedIdentityResourceId"> The resource ID of the user-assigned managed identity to use for authentication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="managedIdentityResourceId"/> is null. </exception>
        public OnYourDataUserAssignedManagedIdentityAuthenticationOptions(string managedIdentityResourceId)
        {
            Argument.AssertNotNull(managedIdentityResourceId, nameof(managedIdentityResourceId));

            Type = OnYourDataAuthenticationType.UserAssignedManagedIdentity;
            ManagedIdentityResourceId = managedIdentityResourceId;
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataUserAssignedManagedIdentityAuthenticationOptions"/>. </summary>
        /// <param name="type"> The authentication type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="managedIdentityResourceId"> The resource ID of the user-assigned managed identity to use for authentication. </param>
        internal OnYourDataUserAssignedManagedIdentityAuthenticationOptions(OnYourDataAuthenticationType type, IDictionary<string, BinaryData> serializedAdditionalRawData, string managedIdentityResourceId) : base(type, serializedAdditionalRawData)
        {
            ManagedIdentityResourceId = managedIdentityResourceId;
        }

        /// <summary> Initializes a new instance of <see cref="OnYourDataUserAssignedManagedIdentityAuthenticationOptions"/> for deserialization. </summary>
        internal OnYourDataUserAssignedManagedIdentityAuthenticationOptions()
        {
        }

        /// <summary> The resource ID of the user-assigned managed identity to use for authentication. </summary>
        public string ManagedIdentityResourceId { get; }
    }
}
