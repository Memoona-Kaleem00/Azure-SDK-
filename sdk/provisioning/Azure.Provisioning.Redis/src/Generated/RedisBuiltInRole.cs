// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using System;
using System.ComponentModel;

namespace Azure.Provisioning.Redis;

/// <summary>
/// Built-in Redis roles that you can assign to users, groups, service
/// principals, and managed identities.
/// </summary>
/// <param name="value">The ID value of the role.</param>
public readonly struct RedisBuiltInRole(string value) : IEquatable<RedisBuiltInRole>
{
    private readonly string _value = value ?? throw new ArgumentNullException(nameof(value));

    /// <summary>
    /// Lets you manage Redis caches, but not access to them.
    /// </summary>
    public static RedisBuiltInRole RedisCacheContributor { get; } = new(RedisCacheContributorValue);
    internal const string RedisCacheContributorValue = "e0f68234-74aa-48ed-b826-c38b57376e17";

    /// <summary>
    /// Try to get the name of a built-in Redis role from its ID value.
    /// </summary>
    /// <param name="value">The role value.</param>
    /// <returns>
    /// The name of the built-in Redis role if known, otherwise the ID will be returned.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static string GetBuiltInRoleName(RedisBuiltInRole value) =>
        value._value switch
        {
            RedisCacheContributorValue => nameof(RedisCacheContributor),
            _ => value._value
        };

    /// <summary>
    /// Determines if two RedisBuiltInRole values are the same.
    /// </summary>
    /// <param name="left">The first RedisBuiltInRole to compare.</param>
    /// <param name="right">The second RedisBuiltInRole to compare.</param>
    /// <returns>True if <paramref name="left"/> and <paramref name="right"/> are the same; otherwise, false.</returns>
    public static bool operator ==(RedisBuiltInRole left, RedisBuiltInRole right) => left.Equals(right);

    /// <summary>
    /// Determines if two RedisBuiltInRole values are different.
    /// </summary>
    /// <param name="left">The first RedisBuiltInRole to compare.</param>
    /// <param name="right">The second RedisBuiltInRole to compare.</param>
    /// <returns>True if <paramref name="left"/> and <paramref name="right"/> are different; otherwise, false.</returns>
    public static bool operator !=(RedisBuiltInRole left, RedisBuiltInRole right) => !left.Equals(right);

    /// <summary>
    /// Converts a string to a RedisBuiltInRole.
    /// </summary>
    /// <param name="value">The string value to convert.</param>
    public static implicit operator RedisBuiltInRole(string value) => new(value);

    /// <inheritdoc/>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object? obj) => obj is RedisBuiltInRole other && Equals(other);

    /// <inheritdoc/>
    public bool Equals(RedisBuiltInRole other) => string.Equals(_value, other._value, StringComparison.Ordinal);

    /// <inheritdoc/>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() => _value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public override string ToString() => _value;
}
