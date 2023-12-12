﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;

namespace System.ClientModel.Primitives;

public partial class ClientPipeline
{
    /// <summary>
    /// Pipeline processor to advance through policies for pipeline customized
    /// per-request by passing RequestOptions to a protocol method.
    /// </summary>
    internal class RequestOptionsProcessor : IEnumerable<PipelinePolicy>
    {
        private readonly PolicyEnumerator _enumerator;

        public RequestOptionsProcessor(
            ReadOnlyMemory<PipelinePolicy> fixedPolicies,
            ReadOnlyMemory<PipelinePolicy> perCallPolicies,
            ReadOnlyMemory<PipelinePolicy> perTryPolicies,
            ReadOnlyMemory<PipelinePolicy> beforeTransportPolicies,
            int perCallIndex,
            int perTryIndex,
            int beforeTransportIndex)
        {
            if (perCallIndex > fixedPolicies.Length) throw new ArgumentOutOfRangeException(nameof(perCallIndex), "perCallIndex cannot be greater than pipeline length.");
            if (perTryIndex > fixedPolicies.Length) throw new ArgumentOutOfRangeException(nameof(perTryIndex), "perTryIndex cannot be greater than pipeline length.");
            if (beforeTransportIndex > fixedPolicies.Length) throw new ArgumentOutOfRangeException(nameof(beforeTransportIndex), "beforeTransportIndex cannot be greater than pipeline length.");
            if (perCallIndex > perTryIndex) throw new ArgumentOutOfRangeException(nameof(perCallIndex), "perCallIndex cannot be greater than perTryIndex.");
            if (perTryIndex > beforeTransportIndex) throw new ArgumentOutOfRangeException(nameof(perTryIndex), "perTryIndex cannot be greater than beforeTransportIndex.");

            _enumerator = new(fixedPolicies,
                perCallPolicies,
                perTryPolicies,
                beforeTransportPolicies,
                perCallIndex,
                perTryIndex,
                beforeTransportIndex);
        }

        public IEnumerator<PipelinePolicy> GetEnumerator()
            => _enumerator;

        IEnumerator IEnumerable.GetEnumerator()
            => _enumerator;

        private class PolicyEnumerator : IEnumerator<PipelinePolicy>
        {
            private readonly int _perCallIndex;
            private readonly int _perTryIndex;
            private readonly int _beforeTransportIndex;
            private readonly int _length;

            // Original client-scope pipeline.
            private readonly ReadOnlyMemory<PipelinePolicy> _fixedPolicies;

            // Custom per-call policies used for the scope of the method invocation.
            private readonly ReadOnlyMemory<PipelinePolicy> _customPerCallPolicies;

            // Custom per-try policies used for the scope of the method invocation.
            private readonly ReadOnlyMemory<PipelinePolicy> _customPerTryPolicies;

            // Custom per-try policies used for the scope of the method invocation.
            private readonly ReadOnlyMemory<PipelinePolicy> _customBeforeTransportPolicies;

            private int _currentIndex;
            private PipelinePolicy? _currentPolicy;

            public PolicyEnumerator(
                ReadOnlyMemory<PipelinePolicy> fixedPolicies,
                ReadOnlyMemory<PipelinePolicy> perCallPolicies,
                ReadOnlyMemory<PipelinePolicy> perTryPolicies,
                ReadOnlyMemory<PipelinePolicy> beforeTransportPolicies,
                int perCallIndex,
                int perTryIndex,
                int beforeTransportIndex)
            {
                _fixedPolicies = fixedPolicies;
                _customPerCallPolicies = perCallPolicies;
                _customPerTryPolicies = perTryPolicies;
                _customBeforeTransportPolicies = beforeTransportPolicies;

                _perCallIndex = perCallIndex;
                _perTryIndex = perTryIndex;
                _beforeTransportIndex = beforeTransportIndex;

                _length = _fixedPolicies.Length +
                    _customPerCallPolicies.Length +
                    _customPerTryPolicies.Length +
                    _customBeforeTransportPolicies.Length;
            }

            public PipelinePolicy Current => _currentPolicy!;

            object IEnumerator.Current => Current;

            public bool MoveNext() => TryGetNextPolicy(out _currentPolicy);

            public void Reset()
            {
                _currentIndex = 0;
                _currentPolicy = null;
            }

            public void Dispose() { }

            /// <summary>
            /// This custom pipeline is divided into seven segments by the per-call,
            /// per-try, and before-transport indexes:
            ///
            /// [FixedPerCall] [CustomPerCall][FixedPerTry] [CustomPerTry][FixedPerTransport] [CustomBeforeTransport][Transport]
            ///               ^_perCallIndex               ^_perTryIndex                     ^_beforeTransport
            ///
            /// This method returns the next policy in the customized pipeline
            /// sequence and maintains state by incrementing the _current counter
            /// after each "next policy" is returned.
            /// </summary>
            private bool TryGetNextPolicy(out PipelinePolicy policy)
            {
                if (TryGetFixedPerCallPolicy(out policy))
                {
                    return true;
                }

                if (TryGetCustomPerCallPolicy(out policy))
                {
                    return true;
                }

                if (TryGetFixedPerTryPolicy(out policy))
                {
                    return true;
                }

                if (TryGetCustomPerTryPolicy(out policy))
                {
                    return true;
                }

                if (TryGetFixedPerTransportPolicy(out policy))
                {
                    return true;
                }

                if (TryGetCustomBeforeTransportPolicy(out policy))
                {
                    return true;
                }

                if (TryGetFixedTransportPolicy(out policy))
                {
                    return true;
                }

                policy = default!;
                return false;
            }

            private bool TryGetFixedPerCallPolicy(out PipelinePolicy policy)
            {
                if (_currentIndex < _perCallIndex)
                {
                    policy = _fixedPolicies.Span[_currentIndex++];
                    return true;
                }

                policy = default!;
                return false;
            }

            private bool TryGetCustomPerCallPolicy(out PipelinePolicy policy)
            {
                if (_currentIndex < _perCallIndex + _customPerCallPolicies.Length)
                {
                    policy = _customPerCallPolicies.Span[_currentIndex++ - _perCallIndex];
                    return true;
                }

                policy = default!;
                return false;
            }

            private bool TryGetFixedPerTryPolicy(out PipelinePolicy policy)
            {
                if (_currentIndex < _perTryIndex + _customPerCallPolicies.Length)
                {
                    policy = _fixedPolicies.Span[_currentIndex++ - _customPerCallPolicies.Length];
                    return true;
                }

                policy = default!;
                return false;
            }

            private bool TryGetCustomPerTryPolicy(out PipelinePolicy policy)
            {
                if (_currentIndex < _perTryIndex +
                               _customPerCallPolicies.Length +
                               _customPerTryPolicies.Length)
                {
                    policy = _customPerTryPolicies.Span[_currentIndex++ - (_perTryIndex + _customPerCallPolicies.Length)];
                    return true;
                }

                policy = default!;
                return false;
            }

            private bool TryGetFixedPerTransportPolicy(out PipelinePolicy policy)
            {
                if (_currentIndex < _perTryIndex + _customPerCallPolicies.Length + _customPerTryPolicies.Length)
                {
                    policy = _fixedPolicies.Span[_currentIndex++ - (_customPerCallPolicies.Length + _customPerTryPolicies.Length)];
                    return true;
                }

                policy = default!;
                return false;
            }

            private bool TryGetCustomBeforeTransportPolicy(out PipelinePolicy policy)
            {
                if (_currentIndex < _perTryIndex +
                               _customPerCallPolicies.Length +
                               _customPerTryPolicies.Length +
                               _customBeforeTransportPolicies.Length)
                {
                    policy = _customPerTryPolicies.Span[_currentIndex++ - (_beforeTransportIndex + _customPerCallPolicies.Length + _customPerTryPolicies.Length)];
                    return true;
                }

                policy = default!;
                return false;
            }

            private bool TryGetFixedTransportPolicy(out PipelinePolicy policy)
            {
                if (_currentIndex < _length)
                {
                    policy = _fixedPolicies.Span[_currentIndex++ - (_customPerCallPolicies.Length + _customPerTryPolicies.Length + _customBeforeTransportPolicies.Length)];
                    return true;
                }

                policy = default!;
                return false;
            }
        }
    }
}
