﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Azure.Core.Pipeline
{
    internal static class TaskExtensions
    {
        public static T EnsureCompleted<T>(this Task<T> task)
        {
#if DEBUG
            VerifyTaskCompleted(task.IsCompleted);
#endif
#pragma warning disable AZC0102
            return task.GetAwaiter().GetResult();
#pragma warning restore AZC0102
        }

        public static void EnsureCompleted(this Task task)
        {
#if DEBUG
            VerifyTaskCompleted(task.IsCompleted);
#endif
#pragma warning disable AZC0102
            task.GetAwaiter().GetResult();
#pragma warning restore AZC0102
        }

        public static T EnsureCompleted<T>(this ValueTask<T> task)
        {
#if DEBUG
            VerifyTaskCompleted(task.IsCompleted);
#endif
#pragma warning disable AZC0102
            return task.GetAwaiter().GetResult();
#pragma warning restore AZC0102
        }

        public static void EnsureCompleted(this ValueTask task)
        {
#if DEBUG
            VerifyTaskCompleted(task.IsCompleted);
#endif
#pragma warning disable AZC0102
            task.GetAwaiter().GetResult();
#pragma warning restore AZC0102
        }

        public static ConfiguredValueTaskAwaitable<T> EnsureCompleted<T>(this ConfiguredValueTaskAwaitable<T> task, bool async)
        {
#pragma warning disable AZC0109
            Debug.Assert(async || task.GetAwaiter().IsCompleted);
#pragma warning restore AZC0109
            return task;
        }

        public static ConfiguredValueTaskAwaitable EnsureCompleted(this ConfiguredValueTaskAwaitable task, bool async)
        {
#pragma warning disable AZC0109
            Debug.Assert(async || task.GetAwaiter().IsCompleted);
#pragma warning restore AZC0109
            return task;
        }

        [Conditional("DEBUG")]
        private static void VerifyTaskCompleted(bool isCompleted)
        {
            if (!isCompleted)
            {
                // Throw an InvalidOperationException instead of using
                // Debug.Assert because that brings down nUnit immediately
                throw new InvalidOperationException("Task is not completed");
            }
        }
    }
}
