// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Monitor.Management
{
    using Microsoft.Azure;
    using Microsoft.Azure.Monitor;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DiagnosticSettingsOperations.
    /// </summary>
    public static partial class DiagnosticSettingsOperationsExtensions
    {
            /// <summary>
            /// Gets the active diagnostic settings for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='name'>
            /// The name of the diagnostic setting.
            /// </param>
            public static DiagnosticSettingsResource Get(this IDiagnosticSettingsOperations operations, string resourceUri, string name)
            {
                return operations.GetAsync(resourceUri, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the active diagnostic settings for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='name'>
            /// The name of the diagnostic setting.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiagnosticSettingsResource> GetAsync(this IDiagnosticSettingsOperations operations, string resourceUri, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceUri, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates diagnostic settings for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='name'>
            /// The name of the diagnostic setting.
            /// </param>
            public static DiagnosticSettingsResource CreateOrUpdate(this IDiagnosticSettingsOperations operations, string resourceUri, DiagnosticSettingsResource parameters, string name)
            {
                return operations.CreateOrUpdateAsync(resourceUri, parameters, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates diagnostic settings for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='name'>
            /// The name of the diagnostic setting.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiagnosticSettingsResource> CreateOrUpdateAsync(this IDiagnosticSettingsOperations operations, string resourceUri, DiagnosticSettingsResource parameters, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceUri, parameters, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes existing diagnostic settings for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='name'>
            /// The name of the diagnostic setting.
            /// </param>
            public static void Delete(this IDiagnosticSettingsOperations operations, string resourceUri, string name)
            {
                operations.DeleteAsync(resourceUri, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes existing diagnostic settings for the specified resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='name'>
            /// The name of the diagnostic setting.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDiagnosticSettingsOperations operations, string resourceUri, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceUri, name, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates an existing DiagnosticSettingsResource tags. To update other fields
            /// use the CreateOrUpdate method.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='diagnosticSettingResource'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='name'>
            /// The name of the diagnostic setting.
            /// </param>
            public static DiagnosticSettingsResource Update(this IDiagnosticSettingsOperations operations, string resourceUri, DiagnosticSettingsResource diagnosticSettingResource, string name)
            {
                return operations.UpdateAsync(resourceUri, diagnosticSettingResource, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing DiagnosticSettingsResource tags. To update other fields
            /// use the CreateOrUpdate method.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceUri'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='diagnosticSettingResource'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='name'>
            /// The name of the diagnostic setting.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiagnosticSettingsResource> UpdateAsync(this IDiagnosticSettingsOperations operations, string resourceUri, DiagnosticSettingsResource diagnosticSettingResource, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceUri, diagnosticSettingResource, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
