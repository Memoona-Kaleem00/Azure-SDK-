// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region SBNamespace
        /// <summary> Gets an object representing a SBNamespace along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SBNamespace" /> object. </returns>
        public static SBNamespace GetSBNamespace(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SBNamespace(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region PrivateEndpointConnection
        /// <summary> Gets an object representing a PrivateEndpointConnection along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PrivateEndpointConnection" /> object. </returns>
        public static PrivateEndpointConnection GetPrivateEndpointConnection(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new PrivateEndpointConnection(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ArmDisasterRecovery
        /// <summary> Gets an object representing a ArmDisasterRecovery along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArmDisasterRecovery" /> object. </returns>
        public static ArmDisasterRecovery GetArmDisasterRecovery(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ArmDisasterRecovery(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region MigrationConfigProperties
        /// <summary> Gets an object representing a MigrationConfigProperties along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MigrationConfigProperties" /> object. </returns>
        public static MigrationConfigProperties GetMigrationConfigProperties(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new MigrationConfigProperties(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SBAuthorizationRuleNamespace
        /// <summary> Gets an object representing a SBAuthorizationRuleNamespace along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SBAuthorizationRuleNamespace" /> object. </returns>
        public static SBAuthorizationRuleNamespace GetSBAuthorizationRuleNamespace(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SBAuthorizationRuleNamespace(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SBAuthorizationRuleQueue
        /// <summary> Gets an object representing a SBAuthorizationRuleQueue along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SBAuthorizationRuleQueue" /> object. </returns>
        public static SBAuthorizationRuleQueue GetSBAuthorizationRuleQueue(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SBAuthorizationRuleQueue(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SBQueue
        /// <summary> Gets an object representing a SBQueue along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SBQueue" /> object. </returns>
        public static SBQueue GetSBQueue(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SBQueue(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SBAuthorizationRuleTopic
        /// <summary> Gets an object representing a SBAuthorizationRuleTopic along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SBAuthorizationRuleTopic" /> object. </returns>
        public static SBAuthorizationRuleTopic GetSBAuthorizationRuleTopic(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SBAuthorizationRuleTopic(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SBTopic
        /// <summary> Gets an object representing a SBTopic along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SBTopic" /> object. </returns>
        public static SBTopic GetSBTopic(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SBTopic(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Rule
        /// <summary> Gets an object representing a Rule along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Rule" /> object. </returns>
        public static Rule GetRule(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Rule(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SBSubscription
        /// <summary> Gets an object representing a SBSubscription along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SBSubscription" /> object. </returns>
        public static SBSubscription GetSBSubscription(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SBSubscription(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
