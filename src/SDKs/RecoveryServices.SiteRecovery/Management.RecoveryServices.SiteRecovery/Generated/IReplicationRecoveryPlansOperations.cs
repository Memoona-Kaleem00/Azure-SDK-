// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ReplicationRecoveryPlansOperations operations.
    /// </summary>
    public partial interface IReplicationRecoveryPlansOperations
    {
        /// <summary>
        /// Execute reprotect of the recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to reprotect(reverse replicate) a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> ReprotectWithHttpMessagesAsync(string recoveryPlanName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute commit failover of the recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to commit the fail over of a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> FailoverCommitWithHttpMessagesAsync(string recoveryPlanName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute test failover cleanup of the recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to cleanup test failover of a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Test failover cleanup input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> TestFailoverCleanupWithHttpMessagesAsync(string recoveryPlanName, RecoveryPlanTestFailoverCleanupInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute test failover of the recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to start the test failover of a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Failover input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> TestFailoverWithHttpMessagesAsync(string recoveryPlanName, RecoveryPlanTestFailoverInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute unplanned failover of the recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to start the failover of a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Failover input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> UnplannedFailoverWithHttpMessagesAsync(string recoveryPlanName, RecoveryPlanUnplannedFailoverInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute planned failover of the recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to start the planned failover of a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Failover input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> PlannedFailoverWithHttpMessagesAsync(string recoveryPlanName, RecoveryPlanPlannedFailoverInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the requested recovery plan.
        /// </summary>
        /// <remarks>
        /// Gets the details of the recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Name of the recovery plan.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> GetWithHttpMessagesAsync(string recoveryPlanName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a recovery plan with the given details.
        /// </summary>
        /// <remarks>
        /// The operation to create a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Recovery Plan creation input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> CreateWithHttpMessagesAsync(string recoveryPlanName, CreateRecoveryPlanInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified recovery plan.
        /// </summary>
        /// <remarks>
        /// Delete a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string recoveryPlanName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the given recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to update a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Update recovery plan input
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> UpdateWithHttpMessagesAsync(string recoveryPlanName, UpdateRecoveryPlanInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of recovery plans.
        /// </summary>
        /// <remarks>
        /// Lists the recovery plans in the vault.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecoveryPlan>>> ListWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute reprotect of the recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to reprotect(reverse replicate) a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> BeginReprotectWithHttpMessagesAsync(string recoveryPlanName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute commit failover of the recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to commit the fail over of a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> BeginFailoverCommitWithHttpMessagesAsync(string recoveryPlanName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute test failover cleanup of the recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to cleanup test failover of a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Test failover cleanup input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> BeginTestFailoverCleanupWithHttpMessagesAsync(string recoveryPlanName, RecoveryPlanTestFailoverCleanupInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute test failover of the recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to start the test failover of a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Failover input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> BeginTestFailoverWithHttpMessagesAsync(string recoveryPlanName, RecoveryPlanTestFailoverInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute unplanned failover of the recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to start the failover of a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Failover input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> BeginUnplannedFailoverWithHttpMessagesAsync(string recoveryPlanName, RecoveryPlanUnplannedFailoverInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Execute planned failover of the recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to start the planned failover of a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Failover input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> BeginPlannedFailoverWithHttpMessagesAsync(string recoveryPlanName, RecoveryPlanPlannedFailoverInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a recovery plan with the given details.
        /// </summary>
        /// <remarks>
        /// The operation to create a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Recovery Plan creation input.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> BeginCreateWithHttpMessagesAsync(string recoveryPlanName, CreateRecoveryPlanInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes the specified recovery plan.
        /// </summary>
        /// <remarks>
        /// Delete a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string recoveryPlanName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the given recovery plan.
        /// </summary>
        /// <remarks>
        /// The operation to update a recovery plan.
        /// </remarks>
        /// <param name='recoveryPlanName'>
        /// Recovery plan name.
        /// </param>
        /// <param name='input'>
        /// Update recovery plan input
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<RecoveryPlan>> BeginUpdateWithHttpMessagesAsync(string recoveryPlanName, UpdateRecoveryPlanInput input, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the list of recovery plans.
        /// </summary>
        /// <remarks>
        /// Lists the recovery plans in the vault.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<RecoveryPlan>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
