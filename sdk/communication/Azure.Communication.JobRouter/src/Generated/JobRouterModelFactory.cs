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
        /// <summary> Initializes a new instance of <see cref="JobRouter.DistributionPolicy"/>. </summary>
        /// <param name="eTag"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="offerExpiresAfter"></param>
        /// <param name="mode">
        /// Please note <see cref="DistributionMode"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BestWorkerMode"/>, <see cref="LongestIdleMode"/> and <see cref="RoundRobinMode"/>.
        /// </param>
        /// <returns> A new <see cref="JobRouter.DistributionPolicy"/> instance for mocking. </returns>
        public static DistributionPolicy DistributionPolicy(ETag eTag = default, string id = null, string name = null, TimeSpan? offerExpiresAfter = null, DistributionMode mode = null)
        {
            return new DistributionPolicy(
                eTag,
                id,
                name,
                offerExpiresAfter,
                mode,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.FunctionRouterRule"/>. </summary>
        /// <param name="functionUri"></param>
        /// <param name="credential"></param>
        /// <returns> A new <see cref="JobRouter.FunctionRouterRule"/> instance for mocking. </returns>
        public static FunctionRouterRule FunctionRouterRule(Uri functionUri = null, FunctionRouterRuleCredential credential = null)
        {
            return new FunctionRouterRule(RouterRuleKind.Function, serializedAdditionalRawData: null, functionUri, credential);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.WebhookRouterRule"/>. </summary>
        /// <param name="authorizationServerUri"></param>
        /// <param name="clientCredential"></param>
        /// <param name="webhookUri"></param>
        /// <returns> A new <see cref="JobRouter.WebhookRouterRule"/> instance for mocking. </returns>
        public static WebhookRouterRule WebhookRouterRule(Uri authorizationServerUri = null, OAuth2WebhookClientCredential clientCredential = null, Uri webhookUri = null)
        {
            return new WebhookRouterRule(RouterRuleKind.Webhook, serializedAdditionalRawData: null, authorizationServerUri, clientCredential, webhookUri);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ClassificationPolicy"/>. </summary>
        /// <param name="eTag"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="fallbackQueueId"></param>
        /// <param name="queueSelectorAttachments">
        /// Please note <see cref="QueueSelectorAttachment"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobRouter.ConditionalQueueSelectorAttachment"/>, <see cref="JobRouter.PassThroughQueueSelectorAttachment"/>, <see cref="JobRouter.RuleEngineQueueSelectorAttachment"/>, <see cref="JobRouter.StaticQueueSelectorAttachment"/> and <see cref="JobRouter.WeightedAllocationQueueSelectorAttachment"/>.
        /// </param>
        /// <param name="prioritizationRule">
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <param name="workerSelectorAttachments">
        /// Please note <see cref="WorkerSelectorAttachment"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobRouter.ConditionalWorkerSelectorAttachment"/>, <see cref="JobRouter.PassThroughWorkerSelectorAttachment"/>, <see cref="JobRouter.RuleEngineWorkerSelectorAttachment"/>, <see cref="JobRouter.StaticWorkerSelectorAttachment"/> and <see cref="JobRouter.WeightedAllocationWorkerSelectorAttachment"/>.
        /// </param>
        /// <returns> A new <see cref="JobRouter.ClassificationPolicy"/> instance for mocking. </returns>
        public static ClassificationPolicy ClassificationPolicy(ETag eTag = default, string id = null, string name = null, string fallbackQueueId = null, IEnumerable<QueueSelectorAttachment> queueSelectorAttachments = null, RouterRule prioritizationRule = null, IEnumerable<WorkerSelectorAttachment> workerSelectorAttachments = null)
        {
            queueSelectorAttachments ??= new List<QueueSelectorAttachment>();
            workerSelectorAttachments ??= new List<WorkerSelectorAttachment>();

            return new ClassificationPolicy(
                eTag,
                id,
                name,
                fallbackQueueId,
                queueSelectorAttachments?.ToList(),
                prioritizationRule,
                workerSelectorAttachments?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ConditionalQueueSelectorAttachment"/>. </summary>
        /// <param name="condition">
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <param name="queueSelectors"></param>
        /// <returns> A new <see cref="JobRouter.ConditionalQueueSelectorAttachment"/> instance for mocking. </returns>
        public static ConditionalQueueSelectorAttachment ConditionalQueueSelectorAttachment(RouterRule condition = null, IEnumerable<RouterQueueSelector> queueSelectors = null)
        {
            queueSelectors ??= new List<RouterQueueSelector>();

            return new ConditionalQueueSelectorAttachment(QueueSelectorAttachmentKind.Conditional, serializedAdditionalRawData: null, condition, queueSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.PassThroughQueueSelectorAttachment"/>. </summary>
        /// <param name="key"></param>
        /// <param name="labelOperator"></param>
        /// <returns> A new <see cref="JobRouter.PassThroughQueueSelectorAttachment"/> instance for mocking. </returns>
        public static PassThroughQueueSelectorAttachment PassThroughQueueSelectorAttachment(string key = null, LabelOperator labelOperator = default)
        {
            return new PassThroughQueueSelectorAttachment(QueueSelectorAttachmentKind.PassThrough, serializedAdditionalRawData: null, key, labelOperator);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RuleEngineQueueSelectorAttachment"/>. </summary>
        /// <param name="rule">
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <returns> A new <see cref="JobRouter.RuleEngineQueueSelectorAttachment"/> instance for mocking. </returns>
        public static RuleEngineQueueSelectorAttachment RuleEngineQueueSelectorAttachment(RouterRule rule = null)
        {
            return new RuleEngineQueueSelectorAttachment(QueueSelectorAttachmentKind.RuleEngine, serializedAdditionalRawData: null, rule);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.StaticQueueSelectorAttachment"/>. </summary>
        /// <param name="queueSelector"></param>
        /// <returns> A new <see cref="JobRouter.StaticQueueSelectorAttachment"/> instance for mocking. </returns>
        public static StaticQueueSelectorAttachment StaticQueueSelectorAttachment(RouterQueueSelector queueSelector = null)
        {
            return new StaticQueueSelectorAttachment(QueueSelectorAttachmentKind.Static, serializedAdditionalRawData: null, queueSelector);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.WeightedAllocationQueueSelectorAttachment"/>. </summary>
        /// <param name="allocations"></param>
        /// <returns> A new <see cref="JobRouter.WeightedAllocationQueueSelectorAttachment"/> instance for mocking. </returns>
        public static WeightedAllocationQueueSelectorAttachment WeightedAllocationQueueSelectorAttachment(IEnumerable<QueueWeightedAllocation> allocations = null)
        {
            allocations ??= new List<QueueWeightedAllocation>();

            return new WeightedAllocationQueueSelectorAttachment(QueueSelectorAttachmentKind.WeightedAllocation, serializedAdditionalRawData: null, allocations?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.QueueWeightedAllocation"/>. </summary>
        /// <param name="weight"></param>
        /// <param name="queueSelectors"></param>
        /// <returns> A new <see cref="JobRouter.QueueWeightedAllocation"/> instance for mocking. </returns>
        public static QueueWeightedAllocation QueueWeightedAllocation(double weight = default, IEnumerable<RouterQueueSelector> queueSelectors = null)
        {
            queueSelectors ??= new List<RouterQueueSelector>();

            return new QueueWeightedAllocation(weight, queueSelectors?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ConditionalWorkerSelectorAttachment"/>. </summary>
        /// <param name="condition">
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <param name="workerSelectors"></param>
        /// <returns> A new <see cref="JobRouter.ConditionalWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static ConditionalWorkerSelectorAttachment ConditionalWorkerSelectorAttachment(RouterRule condition = null, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new ConditionalWorkerSelectorAttachment(WorkerSelectorAttachmentKind.Conditional, serializedAdditionalRawData: null, condition, workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.PassThroughWorkerSelectorAttachment"/>. </summary>
        /// <param name="key"></param>
        /// <param name="labelOperator"></param>
        /// <param name="expiresAfter"></param>
        /// <returns> A new <see cref="JobRouter.PassThroughWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static PassThroughWorkerSelectorAttachment PassThroughWorkerSelectorAttachment(string key = null, LabelOperator labelOperator = default, TimeSpan? expiresAfter = null)
        {
            return new PassThroughWorkerSelectorAttachment(WorkerSelectorAttachmentKind.PassThrough, serializedAdditionalRawData: null, key, labelOperator, expiresAfter);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RuleEngineWorkerSelectorAttachment"/>. </summary>
        /// <param name="rule">
        /// Please note <see cref="RouterRule"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DirectMapRouterRule"/>, <see cref="ExpressionRouterRule"/>, <see cref="JobRouter.FunctionRouterRule"/>, <see cref="StaticRouterRule"/> and <see cref="JobRouter.WebhookRouterRule"/>.
        /// </param>
        /// <returns> A new <see cref="JobRouter.RuleEngineWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static RuleEngineWorkerSelectorAttachment RuleEngineWorkerSelectorAttachment(RouterRule rule = null)
        {
            return new RuleEngineWorkerSelectorAttachment(WorkerSelectorAttachmentKind.RuleEngine, serializedAdditionalRawData: null, rule);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.StaticWorkerSelectorAttachment"/>. </summary>
        /// <param name="workerSelector"></param>
        /// <returns> A new <see cref="JobRouter.StaticWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static StaticWorkerSelectorAttachment StaticWorkerSelectorAttachment(RouterWorkerSelector workerSelector = null)
        {
            return new StaticWorkerSelectorAttachment(WorkerSelectorAttachmentKind.Static, serializedAdditionalRawData: null, workerSelector);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.WeightedAllocationWorkerSelectorAttachment"/>. </summary>
        /// <param name="allocations"></param>
        /// <returns> A new <see cref="JobRouter.WeightedAllocationWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static WeightedAllocationWorkerSelectorAttachment WeightedAllocationWorkerSelectorAttachment(IEnumerable<WorkerWeightedAllocation> allocations = null)
        {
            allocations ??= new List<WorkerWeightedAllocation>();

            return new WeightedAllocationWorkerSelectorAttachment(WorkerSelectorAttachmentKind.WeightedAllocation, serializedAdditionalRawData: null, allocations?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.WorkerWeightedAllocation"/>. </summary>
        /// <param name="weight"></param>
        /// <param name="workerSelectors"></param>
        /// <returns> A new <see cref="JobRouter.WorkerWeightedAllocation"/> instance for mocking. </returns>
        public static WorkerWeightedAllocation WorkerWeightedAllocation(double weight = default, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new WorkerWeightedAllocation(weight, workerSelectors?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ExceptionPolicy"/>. </summary>
        /// <param name="eTag"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="exceptionRules"></param>
        /// <returns> A new <see cref="JobRouter.ExceptionPolicy"/> instance for mocking. </returns>
        public static ExceptionPolicy ExceptionPolicy(ETag eTag = default, string id = null, string name = null, IEnumerable<ExceptionRule> exceptionRules = null)
        {
            exceptionRules ??= new List<ExceptionRule>();

            return new ExceptionPolicy(eTag, id, name, exceptionRules?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ExceptionRule"/>. </summary>
        /// <param name="id"></param>
        /// <param name="trigger">
        /// Please note <see cref="ExceptionTrigger"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobRouter.QueueLengthExceptionTrigger"/> and <see cref="WaitTimeExceptionTrigger"/>.
        /// </param>
        /// <param name="actions">
        /// Please note <see cref="JobRouter.ExceptionAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="JobRouter.CancelExceptionAction"/>, <see cref="JobRouter.ManualReclassifyExceptionAction"/> and <see cref="ReclassifyExceptionAction"/>.
        /// </param>
        /// <returns> A new <see cref="JobRouter.ExceptionRule"/> instance for mocking. </returns>
        public static ExceptionRule ExceptionRule(string id = null, ExceptionTrigger trigger = null, IEnumerable<ExceptionAction> actions = null)
        {
            actions ??= new List<ExceptionAction>();

            return new ExceptionRule(id, trigger, actions?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.QueueLengthExceptionTrigger"/>. </summary>
        /// <param name="threshold"></param>
        /// <returns> A new <see cref="JobRouter.QueueLengthExceptionTrigger"/> instance for mocking. </returns>
        public static QueueLengthExceptionTrigger QueueLengthExceptionTrigger(int threshold = default)
        {
            return new QueueLengthExceptionTrigger(ExceptionTriggerKind.QueueLength, serializedAdditionalRawData: null, threshold);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ExceptionAction"/>. </summary>
        /// <param name="id"></param>
        /// <param name="kind"></param>
        /// <returns> A new <see cref="JobRouter.ExceptionAction"/> instance for mocking. </returns>
        public static ExceptionAction ExceptionAction(string id = null, string kind = null)
        {
            return new UnknownExceptionAction(id, kind == null ? default : new ExceptionActionKind(kind), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.CancelExceptionAction"/>. </summary>
        /// <param name="id"></param>
        /// <param name="note"></param>
        /// <param name="dispositionCode"></param>
        /// <returns> A new <see cref="JobRouter.CancelExceptionAction"/> instance for mocking. </returns>
        public static CancelExceptionAction CancelExceptionAction(string id = null, string note = null, string dispositionCode = null)
        {
            return new CancelExceptionAction(id, ExceptionActionKind.Cancel, serializedAdditionalRawData: null, note, dispositionCode);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ManualReclassifyExceptionAction"/>. </summary>
        /// <param name="id"></param>
        /// <param name="queueId"></param>
        /// <param name="priority"></param>
        /// <param name="workerSelectors"></param>
        /// <returns> A new <see cref="JobRouter.ManualReclassifyExceptionAction"/> instance for mocking. </returns>
        public static ManualReclassifyExceptionAction ManualReclassifyExceptionAction(string id = null, string queueId = null, int? priority = null, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new ManualReclassifyExceptionAction(
                id,
                ExceptionActionKind.ManualReclassify,
                serializedAdditionalRawData: null,
                queueId,
                priority,
                workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterJobAssignment"/>. </summary>
        /// <param name="assignmentId"></param>
        /// <param name="workerId"></param>
        /// <param name="assignedAt"></param>
        /// <param name="completedAt"></param>
        /// <param name="closedAt"></param>
        /// <returns> A new <see cref="JobRouter.RouterJobAssignment"/> instance for mocking. </returns>
        public static RouterJobAssignment RouterJobAssignment(string assignmentId = null, string workerId = null, DateTimeOffset assignedAt = default, DateTimeOffset? completedAt = null, DateTimeOffset? closedAt = null)
        {
            return new RouterJobAssignment(
                assignmentId,
                workerId,
                assignedAt,
                completedAt,
                closedAt,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterJobNote"/>. </summary>
        /// <param name="message"></param>
        /// <param name="addedAt"></param>
        /// <returns> A new <see cref="JobRouter.RouterJobNote"/> instance for mocking. </returns>
        public static RouterJobNote RouterJobNote(string message = null, DateTimeOffset? addedAt = null)
        {
            return new RouterJobNote(message, addedAt, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ScheduleAndSuspendMode"/>. </summary>
        /// <param name="scheduleAt"></param>
        /// <returns> A new <see cref="JobRouter.ScheduleAndSuspendMode"/> instance for mocking. </returns>
        public static ScheduleAndSuspendMode ScheduleAndSuspendMode(DateTimeOffset scheduleAt = default)
        {
            return new ScheduleAndSuspendMode(JobMatchingModeKind.ScheduleAndSuspend, serializedAdditionalRawData: null, scheduleAt);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterJobPositionDetails"/>. </summary>
        /// <param name="jobId"></param>
        /// <param name="position"></param>
        /// <param name="queueId"></param>
        /// <param name="queueLength"></param>
        /// <param name="estimatedWaitTime"></param>
        /// <returns> A new <see cref="JobRouter.RouterJobPositionDetails"/> instance for mocking. </returns>
        public static RouterJobPositionDetails RouterJobPositionDetails(string jobId = null, int position = default, string queueId = null, int queueLength = default, TimeSpan estimatedWaitTime = default)
        {
            return new RouterJobPositionDetails(
                jobId,
                position,
                queueId,
                queueLength,
                estimatedWaitTime,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.UnassignJobResult"/>. </summary>
        /// <param name="jobId"></param>
        /// <param name="unassignmentCount"></param>
        /// <returns> A new <see cref="JobRouter.UnassignJobResult"/> instance for mocking. </returns>
        public static UnassignJobResult UnassignJobResult(string jobId = null, int unassignmentCount = default)
        {
            return new UnassignJobResult(jobId, unassignmentCount, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.AcceptJobOfferResult"/>. </summary>
        /// <param name="assignmentId"></param>
        /// <param name="jobId"></param>
        /// <param name="workerId"></param>
        /// <returns> A new <see cref="JobRouter.AcceptJobOfferResult"/> instance for mocking. </returns>
        public static AcceptJobOfferResult AcceptJobOfferResult(string assignmentId = null, string jobId = null, string workerId = null)
        {
            return new AcceptJobOfferResult(assignmentId, jobId, workerId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterQueueStatistics"/>. </summary>
        /// <param name="queueId"></param>
        /// <param name="length"></param>
        /// <param name="estimatedWaitTimes"></param>
        /// <param name="longestJobWaitTimeMinutes"></param>
        /// <returns> A new <see cref="JobRouter.RouterQueueStatistics"/> instance for mocking. </returns>
        public static RouterQueueStatistics RouterQueueStatistics(string queueId = null, int length = default, IDictionary<int, TimeSpan> estimatedWaitTimes = null, double? longestJobWaitTimeMinutes = null)
        {
            estimatedWaitTimes ??= new Dictionary<int, TimeSpan>();

            return new RouterQueueStatistics(queueId, length, estimatedWaitTimes, longestJobWaitTimeMinutes, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterChannel"/>. </summary>
        /// <param name="channelId"></param>
        /// <param name="capacityCostPerJob"></param>
        /// <param name="maxNumberOfJobs"></param>
        /// <returns> A new <see cref="JobRouter.RouterChannel"/> instance for mocking. </returns>
        public static RouterChannel RouterChannel(string channelId = null, int capacityCostPerJob = default, int? maxNumberOfJobs = null)
        {
            return new RouterChannel(channelId, capacityCostPerJob, maxNumberOfJobs, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterJobOffer"/>. </summary>
        /// <param name="offerId"></param>
        /// <param name="jobId"></param>
        /// <param name="capacityCost"></param>
        /// <param name="offeredAt"></param>
        /// <param name="expiresAt"></param>
        /// <returns> A new <see cref="JobRouter.RouterJobOffer"/> instance for mocking. </returns>
        public static RouterJobOffer RouterJobOffer(string offerId = null, string jobId = null, int capacityCost = default, DateTimeOffset? offeredAt = null, DateTimeOffset? expiresAt = null)
        {
            return new RouterJobOffer(
                offerId,
                jobId,
                capacityCost,
                offeredAt,
                expiresAt,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterWorkerAssignment"/>. </summary>
        /// <param name="assignmentId"></param>
        /// <param name="jobId"></param>
        /// <param name="capacityCost"></param>
        /// <param name="assignedAt"></param>
        /// <returns> A new <see cref="JobRouter.RouterWorkerAssignment"/> instance for mocking. </returns>
        public static RouterWorkerAssignment RouterWorkerAssignment(string assignmentId = null, string jobId = null, int capacityCost = default, DateTimeOffset assignedAt = default)
        {
            return new RouterWorkerAssignment(assignmentId, jobId, capacityCost, assignedAt, serializedAdditionalRawData: null);
        }
    }
}
