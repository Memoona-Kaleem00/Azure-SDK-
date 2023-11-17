// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.JobRouter
{
    /// <summary> Model factory for models. </summary>
    public static partial class JobRouterModelFactory
    {
        /// <summary> Initializes a new instance of FunctionRouterRule. </summary>
        /// <param name="functionUri"> URL for Azure Function. </param>
        /// <param name="credential"> Credentials used to access Azure function rule. </param>
        /// <returns> A new <see cref="JobRouter.FunctionRouterRule"/> instance for mocking. </returns>
        public static FunctionRouterRule FunctionRouterRule(Uri functionUri = null, FunctionRouterRuleCredential credential = null)
        {
            return new FunctionRouterRule(RouterRuleKind.Function, functionUri, credential);
        }

        /// <summary> Initializes a new instance of WebhookRouterRule. </summary>
        /// <param name="authorizationServerUri"> Uri for Authorization Server. </param>
        /// <param name="clientCredential"> OAuth2.0 Credentials used to Contoso's Authorization server. Reference: https://www.oauth.com/oauth2-servers/access-tokens/client-credentials/. </param>
        /// <param name="webhookUri"> Uri for Contoso's Web Server. </param>
        /// <returns> A new <see cref="JobRouter.WebhookRouterRule"/> instance for mocking. </returns>
        public static WebhookRouterRule WebhookRouterRule(Uri authorizationServerUri = null, OAuth2WebhookClientCredential clientCredential = null, Uri webhookUri = null)
        {
            return new WebhookRouterRule(RouterRuleKind.Webhook, authorizationServerUri, clientCredential, webhookUri);
        }

        /// <summary> Initializes a new instance of ConditionalQueueSelectorAttachment. </summary>
        /// <param name="condition"> The condition that must be true for the queue selectors to be attached. </param>
        /// <param name="queueSelectors"> The queue selectors to attach. </param>
        /// <returns> A new <see cref="JobRouter.ConditionalQueueSelectorAttachment"/> instance for mocking. </returns>
        public static ConditionalQueueSelectorAttachment ConditionalQueueSelectorAttachment(RouterRule condition = null, IEnumerable<RouterQueueSelector> queueSelectors = null)
        {
            queueSelectors ??= new List<RouterQueueSelector>();

            return new ConditionalQueueSelectorAttachment(QueueSelectorAttachmentKind.Conditional, condition, queueSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of PassThroughQueueSelectorAttachment. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value pass through. </param>
        /// <returns> A new <see cref="JobRouter.PassThroughQueueSelectorAttachment"/> instance for mocking. </returns>
        public static PassThroughQueueSelectorAttachment PassThroughQueueSelectorAttachment(string key = null, LabelOperator labelOperator = default)
        {
            return new PassThroughQueueSelectorAttachment(QueueSelectorAttachmentKind.PassThrough, key, labelOperator);
        }

        /// <summary> Initializes a new instance of RuleEngineQueueSelectorAttachment. </summary>
        /// <param name="rule"> A RouterRule that resolves a collection of queue selectors to attach. </param>
        /// <returns> A new <see cref="JobRouter.RuleEngineQueueSelectorAttachment"/> instance for mocking. </returns>
        public static RuleEngineQueueSelectorAttachment RuleEngineQueueSelectorAttachment(RouterRule rule = null)
        {
            return new RuleEngineQueueSelectorAttachment(QueueSelectorAttachmentKind.RuleEngine, rule);
        }

        /// <summary> Initializes a new instance of StaticQueueSelectorAttachment. </summary>
        /// <param name="queueSelector"> The queue selector to attach. </param>
        /// <returns> A new <see cref="JobRouter.StaticQueueSelectorAttachment"/> instance for mocking. </returns>
        public static StaticQueueSelectorAttachment StaticQueueSelectorAttachment(RouterQueueSelector queueSelector = null)
        {
            return new StaticQueueSelectorAttachment(QueueSelectorAttachmentKind.Static, queueSelector);
        }

        /// <summary> Initializes a new instance of WeightedAllocationQueueSelectorAttachment. </summary>
        /// <param name="allocations"> A collection of percentage based weighted allocations. </param>
        /// <returns> A new <see cref="JobRouter.WeightedAllocationQueueSelectorAttachment"/> instance for mocking. </returns>
        public static WeightedAllocationQueueSelectorAttachment WeightedAllocationQueueSelectorAttachment(IEnumerable<QueueWeightedAllocation> allocations = null)
        {
            allocations ??= new List<QueueWeightedAllocation>();

            return new WeightedAllocationQueueSelectorAttachment(QueueSelectorAttachmentKind.WeightedAllocation, allocations?.ToList());
        }

        /// <summary> Initializes a new instance of QueueWeightedAllocation. </summary>
        /// <param name="weight"> The percentage of this weight, expressed as a fraction of 1. </param>
        /// <param name="queueSelectors"> A collection of queue selectors that will be applied if this allocation is selected. </param>
        /// <returns> A new <see cref="JobRouter.QueueWeightedAllocation"/> instance for mocking. </returns>
        public static QueueWeightedAllocation QueueWeightedAllocation(double weight = default, IEnumerable<RouterQueueSelector> queueSelectors = null)
        {
            queueSelectors ??= new List<RouterQueueSelector>();

            return new QueueWeightedAllocation(weight, queueSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of ConditionalWorkerSelectorAttachment. </summary>
        /// <param name="condition"> The condition that must be true for the worker selectors to be attached. </param>
        /// <param name="workerSelectors"> The worker selectors to attach. </param>
        /// <returns> A new <see cref="JobRouter.ConditionalWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static ConditionalWorkerSelectorAttachment ConditionalWorkerSelectorAttachment(RouterRule condition = null, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new ConditionalWorkerSelectorAttachment(WorkerSelectorAttachmentKind.Conditional, condition, workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of RuleEngineWorkerSelectorAttachment. </summary>
        /// <param name="rule"> A RouterRule that resolves a collection of worker selectors to attach. </param>
        /// <returns> A new <see cref="JobRouter.RuleEngineWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static RuleEngineWorkerSelectorAttachment RuleEngineWorkerSelectorAttachment(RouterRule rule = null)
        {
            return new RuleEngineWorkerSelectorAttachment(WorkerSelectorAttachmentKind.RuleEngine, rule);
        }

        /// <summary> Initializes a new instance of StaticWorkerSelectorAttachment. </summary>
        /// <param name="workerSelector"> The worker selector to attach. </param>
        /// <returns> A new <see cref="JobRouter.StaticWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static StaticWorkerSelectorAttachment StaticWorkerSelectorAttachment(RouterWorkerSelector workerSelector = null)
        {
            return new StaticWorkerSelectorAttachment(WorkerSelectorAttachmentKind.Static, workerSelector);
        }

        /// <summary> Initializes a new instance of WeightedAllocationWorkerSelectorAttachment. </summary>
        /// <param name="allocations"> A collection of percentage based weighted allocations. </param>
        /// <returns> A new <see cref="JobRouter.WeightedAllocationWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static WeightedAllocationWorkerSelectorAttachment WeightedAllocationWorkerSelectorAttachment(IEnumerable<WorkerWeightedAllocation> allocations = null)
        {
            allocations ??= new List<WorkerWeightedAllocation>();

            return new WeightedAllocationWorkerSelectorAttachment(WorkerSelectorAttachmentKind.WeightedAllocation, allocations?.ToList());
        }

        /// <summary> Initializes a new instance of WorkerWeightedAllocation. </summary>
        /// <param name="weight"> The percentage of this weight, expressed as a fraction of 1. </param>
        /// <param name="workerSelectors"> A collection of worker selectors that will be applied if this allocation is selected. </param>
        /// <returns> A new <see cref="JobRouter.WorkerWeightedAllocation"/> instance for mocking. </returns>
        public static WorkerWeightedAllocation WorkerWeightedAllocation(double weight = default, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new WorkerWeightedAllocation(weight, workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of ExceptionRule. </summary>
        /// <param name="id"> Id of an exception rule. </param>
        /// <param name="trigger"> The trigger for this exception rule. </param>
        /// <param name="actions"> A collection of actions to perform once the exception is triggered. </param>
        /// <returns> A new <see cref="JobRouter.ExceptionRule"/> instance for mocking. </returns>
        public static ExceptionRule ExceptionRule(string id = null, ExceptionTrigger trigger = null, IEnumerable<ExceptionAction> actions = null)
        {
            actions ??= new List<ExceptionAction>();

            return new ExceptionRule(id, trigger, actions?.ToList());
        }

        /// <summary> Initializes a new instance of QueueLengthExceptionTrigger. </summary>
        /// <param name="threshold"> Threshold of number of jobs ahead in the queue to for this trigger to fire. </param>
        /// <returns> A new <see cref="JobRouter.QueueLengthExceptionTrigger"/> instance for mocking. </returns>
        public static QueueLengthExceptionTrigger QueueLengthExceptionTrigger(int threshold = default)
        {
            return new QueueLengthExceptionTrigger(ExceptionTriggerKind.QueueLength, threshold);
        }

        /// <summary> Initializes a new instance of ExceptionAction. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="kind"> The type discriminator describing a sub-type of ExceptionAction. </param>
        /// <returns> A new <see cref="JobRouter.ExceptionAction"/> instance for mocking. </returns>
        public static ExceptionAction ExceptionAction(string id = null, string kind = "Unknown")
        {
            return new UnknownExceptionAction(id, kind);
        }

        /// <summary> Initializes a new instance of CancelExceptionAction. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="note"> A note that will be appended to a job's notes collection with the current timestamp. </param>
        /// <param name="dispositionCode"> Indicates the outcome of a job, populate this field with your own custom values. </param>
        /// <returns> A new <see cref="JobRouter.CancelExceptionAction"/> instance for mocking. </returns>
        public static CancelExceptionAction CancelExceptionAction(string id = null, string note = null, string dispositionCode = null)
        {
            return new CancelExceptionAction(id, ExceptionActionKind.Cancel, note, dispositionCode);
        }

        /// <summary> Initializes a new instance of ManualReclassifyExceptionAction. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="queueId"> Updated QueueId. </param>
        /// <param name="priority"> Updated Priority. </param>
        /// <param name="workerSelectors"> Updated WorkerSelectors. </param>
        /// <returns> A new <see cref="JobRouter.ManualReclassifyExceptionAction"/> instance for mocking. </returns>
        public static ManualReclassifyExceptionAction ManualReclassifyExceptionAction(string id = null, string queueId = null, int? priority = null, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new ManualReclassifyExceptionAction(id, ExceptionActionKind.ManualReclassify, queueId, priority, workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of RouterJobAssignment. </summary>
        /// <param name="assignmentId"> Id of a job assignment. </param>
        /// <param name="workerId"> Id of the Worker assigned to the job. </param>
        /// <param name="assignedAt"> Timestamp when the job was assigned to a worker in UTC. </param>
        /// <param name="completedAt"> Timestamp when the job was marked as completed after being assigned in UTC. </param>
        /// <param name="closedAt"> Timestamp when the job was marked as closed after being completed in UTC. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobAssignment"/> instance for mocking. </returns>
        public static RouterJobAssignment RouterJobAssignment(string assignmentId = null, string workerId = null, DateTimeOffset assignedAt = default, DateTimeOffset? completedAt = null, DateTimeOffset? closedAt = null)
        {
            return new RouterJobAssignment(assignmentId, workerId, assignedAt, completedAt, closedAt);
        }

        /// <summary> Initializes a new instance of RouterJobNote. </summary>
        /// <param name="message"> The message contained in the note. </param>
        /// <param name="addedAt"> The time at which the note was added in UTC. If not provided, will default to the current time. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobNote"/> instance for mocking. </returns>
        public static RouterJobNote RouterJobNote(string message = null, DateTimeOffset? addedAt = null)
        {
            return new RouterJobNote(message, addedAt);
        }

        /// <summary> Initializes a new instance of ScheduleAndSuspendMode. </summary>
        /// <param name="scheduleAt"> Requested schedule time. </param>
        /// <returns> A new <see cref="JobRouter.ScheduleAndSuspendMode"/> instance for mocking. </returns>
        public static ScheduleAndSuspendMode ScheduleAndSuspendMode(DateTimeOffset scheduleAt = default)
        {
            return new ScheduleAndSuspendMode(JobMatchingModeKind.ScheduleAndSuspend, scheduleAt);
        }

        /// <summary> Initializes a new instance of UnassignJobResult. </summary>
        /// <param name="jobId"> Id of an unassigned job. </param>
        /// <param name="unassignmentCount"> The number of times a job is unassigned. At a maximum 3. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        /// <returns> A new <see cref="JobRouter.UnassignJobResult"/> instance for mocking. </returns>
        public static UnassignJobResult UnassignJobResult(string jobId = null, int unassignmentCount = default)
        {
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return new UnassignJobResult(jobId, unassignmentCount);
        }

        /// <summary> Initializes a new instance of AcceptJobOfferResult. </summary>
        /// <param name="assignmentId"> Id of job assignment that assigns a worker that has accepted an offer to a job. </param>
        /// <param name="jobId"> Id of the job assigned. </param>
        /// <param name="workerId"> Id of the worker that has been assigned this job. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/>, <paramref name="jobId"/> or <paramref name="workerId"/> is null. </exception>
        /// <returns> A new <see cref="JobRouter.AcceptJobOfferResult"/> instance for mocking. </returns>
        public static AcceptJobOfferResult AcceptJobOfferResult(string assignmentId = null, string jobId = null, string workerId = null)
        {
            if (assignmentId == null)
            {
                throw new ArgumentNullException(nameof(assignmentId));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }
            if (workerId == null)
            {
                throw new ArgumentNullException(nameof(workerId));
            }

            return new AcceptJobOfferResult(assignmentId, jobId, workerId);
        }

        /// <summary> Initializes a new instance of RouterChannel. </summary>
        /// <param name="channelId"> Id of a channel. </param>
        /// <param name="capacityCostPerJob"> The amount of capacity that an instance of a job of this channel will consume of the total worker capacity. </param>
        /// <param name="maxNumberOfJobs"> The maximum number of jobs that can be supported concurrently for this channel. </param>
        /// <returns> A new <see cref="JobRouter.RouterChannel"/> instance for mocking. </returns>
        public static RouterChannel RouterChannel(string channelId = null, int capacityCostPerJob = default, int? maxNumberOfJobs = null)
        {
            return new RouterChannel(channelId, capacityCostPerJob, maxNumberOfJobs);
        }

        /// <summary> Initializes a new instance of RouterJobOffer. </summary>
        /// <param name="offerId"> Id of an offer. </param>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="capacityCost"> The capacity cost consumed by the job offer. </param>
        /// <param name="offeredAt"> Timestamp when the offer was created in UTC. </param>
        /// <param name="expiresAt"> Timestamp when the offer will expire in UTC. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobOffer"/> instance for mocking. </returns>
        public static RouterJobOffer RouterJobOffer(string offerId = null, string jobId = null, int capacityCost = default, DateTimeOffset? offeredAt = null, DateTimeOffset? expiresAt = null)
        {
            return new RouterJobOffer(offerId, jobId, capacityCost, offeredAt, expiresAt);
        }

        /// <summary> Initializes a new instance of RouterWorkerAssignment. </summary>
        /// <param name="assignmentId"> Id of the assignment. </param>
        /// <param name="jobId"> Id of the job assigned. </param>
        /// <param name="capacityCost"> The amount of capacity this assignment has consumed on the worker. </param>
        /// <param name="assignedAt"> The assignment time of the job in UTC. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentId"/> or <paramref name="jobId"/> is null. </exception>
        /// <returns> A new <see cref="JobRouter.RouterWorkerAssignment"/> instance for mocking. </returns>
        public static RouterWorkerAssignment RouterWorkerAssignment(string assignmentId = null, string jobId = null, int capacityCost = default, DateTimeOffset assignedAt = default)
        {
            if (assignmentId == null)
            {
                throw new ArgumentNullException(nameof(assignmentId));
            }
            if (jobId == null)
            {
                throw new ArgumentNullException(nameof(jobId));
            }

            return new RouterWorkerAssignment(assignmentId, jobId, capacityCost, assignedAt);
        }
    }
}
