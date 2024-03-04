// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update an Azure Cosmos DB SQL Role Definition. </summary>
    public partial class CosmosDBSqlRoleDefinitionCreateOrUpdateContent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlRoleDefinitionCreateOrUpdateContent"/>. </summary>
        public CosmosDBSqlRoleDefinitionCreateOrUpdateContent()
        {
            AssignableScopes = new ChangeTrackingList<string>();
            Permissions = new ChangeTrackingList<CosmosDBSqlRolePermission>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBSqlRoleDefinitionCreateOrUpdateContent"/>. </summary>
        /// <param name="roleName"> A user-friendly name for the Role Definition. Must be unique for the database account. </param>
        /// <param name="roleDefinitionType"> Indicates whether the Role Definition was built-in or user created. </param>
        /// <param name="assignableScopes"> A set of fully qualified Scopes at or below which Role Assignments may be created using this Role Definition. This will allow application of this Role Definition on the entire database account or any underlying Database / Collection. Must have at least one element. Scopes higher than Database account are not enforceable as assignable Scopes. Note that resources referenced in assignable Scopes need not exist. </param>
        /// <param name="permissions"> The set of operations allowed through this Role Definition. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBSqlRoleDefinitionCreateOrUpdateContent(string roleName, CosmosDBSqlRoleDefinitionType? roleDefinitionType, IList<string> assignableScopes, IList<CosmosDBSqlRolePermission> permissions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RoleName = roleName;
            RoleDefinitionType = roleDefinitionType;
            AssignableScopes = assignableScopes;
            Permissions = permissions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A user-friendly name for the Role Definition. Must be unique for the database account. </summary>
        [WirePath("properties.roleName")]
        public string RoleName { get; set; }
        /// <summary> Indicates whether the Role Definition was built-in or user created. </summary>
        [WirePath("properties.type")]
        public CosmosDBSqlRoleDefinitionType? RoleDefinitionType { get; set; }
        /// <summary> A set of fully qualified Scopes at or below which Role Assignments may be created using this Role Definition. This will allow application of this Role Definition on the entire database account or any underlying Database / Collection. Must have at least one element. Scopes higher than Database account are not enforceable as assignable Scopes. Note that resources referenced in assignable Scopes need not exist. </summary>
        [WirePath("properties.assignableScopes")]
        public IList<string> AssignableScopes { get; }
        /// <summary> The set of operations allowed through this Role Definition. </summary>
        [WirePath("properties.permissions")]
        public IList<CosmosDBSqlRolePermission> Permissions { get; }
    }
}
