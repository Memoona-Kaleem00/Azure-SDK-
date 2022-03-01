// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RecoveryPointsOperations.
    /// </summary>
    public static partial class RecoveryPointsOperationsExtensions
    {
            /// <summary>
            /// Returns the Access token for communication between BMS and Protection
            /// service
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the container.
            /// </param>
            /// <param name='containerName'>
            /// Name of the container.
            /// </param>
            /// <param name='protectedItemName'>
            /// Name of the Protected Item.
            /// </param>
            /// <param name='recoveryPointId'>
            /// Recovery Point Id
            /// </param>
            /// <param name='parameters'>
            /// Get Access Token request
            /// </param>
            public static CrrAccessTokenResource GetAccessToken(this IRecoveryPointsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, AADPropertiesResource parameters)
            {
                return operations.GetAccessTokenAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, recoveryPointId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the Access token for communication between BMS and Protection
            /// service
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the recovery services vault.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group where the recovery services vault is
            /// present.
            /// </param>
            /// <param name='fabricName'>
            /// Fabric name associated with the container.
            /// </param>
            /// <param name='containerName'>
            /// Name of the container.
            /// </param>
            /// <param name='protectedItemName'>
            /// Name of the Protected Item.
            /// </param>
            /// <param name='recoveryPointId'>
            /// Recovery Point Id
            /// </param>
            /// <param name='parameters'>
            /// Get Access Token request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CrrAccessTokenResource> GetAccessTokenAsync(this IRecoveryPointsOperations operations, string vaultName, string resourceGroupName, string fabricName, string containerName, string protectedItemName, string recoveryPointId, AADPropertiesResource parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAccessTokenWithHttpMessagesAsync(vaultName, resourceGroupName, fabricName, containerName, protectedItemName, recoveryPointId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
