﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.ServiceBus
{
    using System;
    using Primitives;

    /// <summary>
    /// RetryPolicy implementation where the delay between retries will grow in a staggered exponential manner.
    /// RetryIntervals will be computed using a retryFactor which is a function of deltaBackOff (MaximumBackoff - MinimumBackoff) and MaximumRetryCount.
    /// <remarks>RetryPolicy will not be applied when an ambient transaction is found.</remarks>
    /// </summary>
    public sealed class RetryExponential : RetryPolicy
    {
        /// <summary>
        /// Returns a new RetryExponential retry policy object.
        /// </summary>
        /// <param name="minimumBackoff">Minimum backoff interval.</param>
        /// <param name="maximumBackoff">Maximum backoff interval.</param>
        public RetryExponential(TimeSpan minimumBackoff, TimeSpan maximumBackoff, int maximumRetryCount)
            : this(minimumBackoff, maximumBackoff, Constants.DefaultRetryDeltaBackoff, maximumRetryCount)
        {
        }

        internal RetryExponential(TimeSpan minBackoff, TimeSpan maxBackoff, TimeSpan deltaBackoff, int maxRetryCount)
        {
            TimeoutHelper.ThrowIfNonPositiveArgument(deltaBackoff, nameof(deltaBackoff));
            TimeoutHelper.ThrowIfNegativeArgument(minBackoff, nameof(minBackoff));
            TimeoutHelper.ThrowIfNonPositiveArgument(maxBackoff, nameof(maxBackoff));

            if (maxRetryCount <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(maxRetryCount),
                    Resources.ArgumentMustBePositive.FormatForUser(nameof(maxRetryCount)));
            }

            if (minBackoff >= maxBackoff)
            {
                throw new ArgumentException(Resources.ExponentialRetryBackoffRange.FormatForUser(minBackoff, maxBackoff));
            }

            MinimalBackoff = minBackoff;
            MaximumBackoff = maxBackoff;
            DeltaBackoff = deltaBackoff;
            MaxRetryCount = maxRetryCount;
        }

        /// <summary>
        /// Minimum backoff interval.
        /// </summary>
        /// <value>The minimum backoff interval.</value>
        public TimeSpan MinimalBackoff { get; }

        /// <summary>
        /// Gets or sets the maximum backoff interval.
        /// </summary>
        /// <value>The maximum backoff interval.</value>
        public TimeSpan MaximumBackoff { get; }

        /// <summary>
        /// Gets or sets the backoff interval associated with the retry.
        /// </summary>
        /// <value>The backoff interval associated with the retry.</value>
        public TimeSpan DeltaBackoff { get; }

        /// <summary>
        /// Gets or sets the maximum number of allowed retries.
        /// </summary>
        /// <value>The maximum number of allowed retries.</value>
        public int MaxRetryCount { get; }

        /// <summary>
        /// Called to see if a retry should be performed.
        /// </summary>
        /// <param name="remainingTime">The remaining time before the timeout expires.</param>
        /// <param name="currentRetryCount">The number of attempts that have been processed.</param>
        /// <param name="retryInterval">The amount of time to delay before retry.</param>
        protected override bool OnShouldRetry(TimeSpan remainingTime, int currentRetryCount, out TimeSpan retryInterval)
        {
            if (currentRetryCount > MaxRetryCount)
            {
                retryInterval = TimeSpan.Zero;
                return false;
            }

            // Logic: - first use currentRetryCount to calculate the size of the interval.
            //        - then get the interval in terms of sleep time (between min and max sleep time)
            //        - if interval to large to fit inside remainingTime, we quit.
            var randomizedInterval = ConcurrentRandom.Next((int)(DeltaBackoff.TotalMilliseconds * 0.8), (int)(DeltaBackoff.TotalMilliseconds * 1.2));
            double increment = (Math.Pow(2, currentRetryCount) - 1) * randomizedInterval;
            double timeToSleepMsec = Math.Min(MinimalBackoff.TotalMilliseconds + increment, MaximumBackoff.TotalMilliseconds);
            retryInterval = TimeSpan.FromMilliseconds(timeToSleepMsec);

            return true;
        }
    }
}