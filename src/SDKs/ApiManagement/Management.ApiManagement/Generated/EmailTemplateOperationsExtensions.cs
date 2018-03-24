// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for EmailTemplateOperations.
    /// </summary>
    public static partial class EmailTemplateOperationsExtensions
    {
            /// <summary>
            /// Lists a collection of properties defined within a service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='top'>
            /// Number of records to return.
            /// </param>
            /// <param name='skip'>
            /// Number of records to skip.
            /// </param>
            public static IPage<EmailTemplateContract> ListByService(this IEmailTemplateOperations operations, string resourceGroupName, string serviceName, int? top = default(int?), int? skip = default(int?))
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName, top, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of properties defined within a service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='top'>
            /// Number of records to return.
            /// </param>
            /// <param name='skip'>
            /// Number of records to skip.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EmailTemplateContract>> ListByServiceAsync(this IEmailTemplateOperations operations, string resourceGroupName, string serviceName, int? top = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the email template specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='templateName'>
            /// Email Template Name Identifier. Possible values include:
            /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
            /// 'quotaLimitApproachingDeveloperNotificationMessage',
            /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
            /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
            /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
            /// 'purchaseDeveloperNotificationMessage', 'passwordResetIdentityDefault',
            /// 'passwordResetByAdminNotificationMessage',
            /// 'rejectDeveloperNotificationMessage', 'requestDeveloperNotificationMessage'
            /// </param>
            public static EmailTemplateGetEntityTagHeaders GetEntityTag(this IEmailTemplateOperations operations, string resourceGroupName, string serviceName, string templateName)
            {
                return operations.GetEntityTagAsync(resourceGroupName, serviceName, templateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the entity state (Etag) version of the email template specified by its
            /// identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='templateName'>
            /// Email Template Name Identifier. Possible values include:
            /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
            /// 'quotaLimitApproachingDeveloperNotificationMessage',
            /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
            /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
            /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
            /// 'purchaseDeveloperNotificationMessage', 'passwordResetIdentityDefault',
            /// 'passwordResetByAdminNotificationMessage',
            /// 'rejectDeveloperNotificationMessage', 'requestDeveloperNotificationMessage'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EmailTemplateGetEntityTagHeaders> GetEntityTagAsync(this IEmailTemplateOperations operations, string resourceGroupName, string serviceName, string templateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEntityTagWithHttpMessagesAsync(resourceGroupName, serviceName, templateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets the details of the email template specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='templateName'>
            /// Email Template Name Identifier. Possible values include:
            /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
            /// 'quotaLimitApproachingDeveloperNotificationMessage',
            /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
            /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
            /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
            /// 'purchaseDeveloperNotificationMessage', 'passwordResetIdentityDefault',
            /// 'passwordResetByAdminNotificationMessage',
            /// 'rejectDeveloperNotificationMessage', 'requestDeveloperNotificationMessage'
            /// </param>
            public static EmailTemplateContract Get(this IEmailTemplateOperations operations, string resourceGroupName, string serviceName, string templateName)
            {
                return operations.GetAsync(resourceGroupName, serviceName, templateName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of the email template specified by its identifier.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='templateName'>
            /// Email Template Name Identifier. Possible values include:
            /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
            /// 'quotaLimitApproachingDeveloperNotificationMessage',
            /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
            /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
            /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
            /// 'purchaseDeveloperNotificationMessage', 'passwordResetIdentityDefault',
            /// 'passwordResetByAdminNotificationMessage',
            /// 'rejectDeveloperNotificationMessage', 'requestDeveloperNotificationMessage'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EmailTemplateContract> GetAsync(this IEmailTemplateOperations operations, string resourceGroupName, string serviceName, string templateName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serviceName, templateName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an Email Template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='templateName'>
            /// Email Template Name Identifier. Possible values include:
            /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
            /// 'quotaLimitApproachingDeveloperNotificationMessage',
            /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
            /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
            /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
            /// 'purchaseDeveloperNotificationMessage', 'passwordResetIdentityDefault',
            /// 'passwordResetByAdminNotificationMessage',
            /// 'rejectDeveloperNotificationMessage', 'requestDeveloperNotificationMessage'
            /// </param>
            /// <param name='parameters'>
            /// Email Template update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            public static EmailTemplateContract CreateOrUpdate(this IEmailTemplateOperations operations, string resourceGroupName, string serviceName, string templateName, EmailTemplateUpdateParameters parameters, string ifMatch = default(string))
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serviceName, templateName, parameters, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an Email Template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='templateName'>
            /// Email Template Name Identifier. Possible values include:
            /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
            /// 'quotaLimitApproachingDeveloperNotificationMessage',
            /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
            /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
            /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
            /// 'purchaseDeveloperNotificationMessage', 'passwordResetIdentityDefault',
            /// 'passwordResetByAdminNotificationMessage',
            /// 'rejectDeveloperNotificationMessage', 'requestDeveloperNotificationMessage'
            /// </param>
            /// <param name='parameters'>
            /// Email Template update parameters.
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. Not required when creating an entity, but required when
            /// updating an entity.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<EmailTemplateContract> CreateOrUpdateAsync(this IEmailTemplateOperations operations, string resourceGroupName, string serviceName, string templateName, EmailTemplateUpdateParameters parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serviceName, templateName, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the specific Email Template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='templateName'>
            /// Email Template Name Identifier. Possible values include:
            /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
            /// 'quotaLimitApproachingDeveloperNotificationMessage',
            /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
            /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
            /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
            /// 'purchaseDeveloperNotificationMessage', 'passwordResetIdentityDefault',
            /// 'passwordResetByAdminNotificationMessage',
            /// 'rejectDeveloperNotificationMessage', 'requestDeveloperNotificationMessage'
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            public static void Update(this IEmailTemplateOperations operations, string resourceGroupName, string serviceName, string templateName, EmailTemplateUpdateParameters parameters)
            {
                operations.UpdateAsync(resourceGroupName, serviceName, templateName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specific Email Template.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='templateName'>
            /// Email Template Name Identifier. Possible values include:
            /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
            /// 'quotaLimitApproachingDeveloperNotificationMessage',
            /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
            /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
            /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
            /// 'purchaseDeveloperNotificationMessage', 'passwordResetIdentityDefault',
            /// 'passwordResetByAdminNotificationMessage',
            /// 'rejectDeveloperNotificationMessage', 'requestDeveloperNotificationMessage'
            /// </param>
            /// <param name='parameters'>
            /// Update parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IEmailTemplateOperations operations, string resourceGroupName, string serviceName, string templateName, EmailTemplateUpdateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serviceName, templateName, parameters, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Reset the Email Template to default template provided by the API Management
            /// service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='templateName'>
            /// Email Template Name Identifier. Possible values include:
            /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
            /// 'quotaLimitApproachingDeveloperNotificationMessage',
            /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
            /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
            /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
            /// 'purchaseDeveloperNotificationMessage', 'passwordResetIdentityDefault',
            /// 'passwordResetByAdminNotificationMessage',
            /// 'rejectDeveloperNotificationMessage', 'requestDeveloperNotificationMessage'
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            public static void Delete(this IEmailTemplateOperations operations, string resourceGroupName, string serviceName, string templateName, string ifMatch)
            {
                operations.DeleteAsync(resourceGroupName, serviceName, templateName, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Reset the Email Template to default template provided by the API Management
            /// service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='templateName'>
            /// Email Template Name Identifier. Possible values include:
            /// 'applicationApprovedNotificationMessage', 'accountClosedDeveloper',
            /// 'quotaLimitApproachingDeveloperNotificationMessage',
            /// 'newDeveloperNotificationMessage', 'emailChangeIdentityDefault',
            /// 'inviteUserNotificationMessage', 'newCommentNotificationMessage',
            /// 'confirmSignUpIdentityDefault', 'newIssueNotificationMessage',
            /// 'purchaseDeveloperNotificationMessage', 'passwordResetIdentityDefault',
            /// 'passwordResetByAdminNotificationMessage',
            /// 'rejectDeveloperNotificationMessage', 'requestDeveloperNotificationMessage'
            /// </param>
            /// <param name='ifMatch'>
            /// ETag of the Entity. ETag should match the current entity state from the
            /// header response of the GET request or it should be * for unconditional
            /// update.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IEmailTemplateOperations operations, string resourceGroupName, string serviceName, string templateName, string ifMatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serviceName, templateName, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists a collection of properties defined within a service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EmailTemplateContract> ListByServiceNext(this IEmailTemplateOperations operations, string nextPageLink)
            {
                return operations.ListByServiceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists a collection of properties defined within a service instance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<EmailTemplateContract>> ListByServiceNextAsync(this IEmailTemplateOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
