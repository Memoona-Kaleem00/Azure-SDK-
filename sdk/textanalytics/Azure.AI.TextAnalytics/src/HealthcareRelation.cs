﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Azure.AI.TextAnalytics.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    public partial class HealthcareRelation
    {
        /// <summary> Initializes a new instance of HealthcareRelation. </summary>
        /// <param name="relationType"> Type of relation. Examples include: `DosageOfMedication` or &apos;FrequencyOfMedication&apos;, etc. </param>
        /// <param name="bidirectional"> If true the relation between the entities is bidirectional, otherwise directionality is source to target. </param>
        /// <param name="source"> Reference link to the source entity. </param>
        /// <param name="target"> Reference link to the target entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="relationType"/>, <paramref name="source"/>, or <paramref name="target"/> is null. </exception>
        internal HealthcareRelation(string relationType, bool bidirectional, HealthcareEntity source, HealthcareEntity target)
        {
            if (relationType == null)
            {
                throw new ArgumentNullException(nameof(relationType));
            }
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            RelationType = relationType;
            Bidirectional = bidirectional;
            Source = source;
            Target = target;
        }

        private static Regex _healthcareEntityRegex = new Regex(@"\#/results/documents\/(?<documentIndex>\d*)\/entities\/(?<entityIndex>\d*)$", RegexOptions.Compiled, TimeSpan.FromSeconds(2));

        internal static HealthcareEntity ResolveHealthcareEntity(IEnumerable<HealthcareEntity> entities, string reference)
        {
            var healthcareEntityMatch = _healthcareEntityRegex.Match(reference);
            if (healthcareEntityMatch.Success)
            {
                int entityIndex = int.Parse(healthcareEntityMatch.Groups["entityIndex"].Value, CultureInfo.InvariantCulture);
                //int entityIndex = int.Parse(healthcareEntityMatch.Groups[2].Value, CultureInfo.InvariantCulture);

                if (entityIndex < entities.Count())
                {
                    var entity = entities.ElementAt(entityIndex);
                    return new HealthcareEntity(entity.Text, entity.Category,
                        entity.Offset, entity.Length, entity.ConfidenceScore,
                        entity.IsNegated);
                }
            }

            throw new InvalidOperationException($"Failed to parse element reference: {reference}");
        }
        /// <summary>
        /// Source Entity
        /// </summary>
        public HealthcareEntity Source { get; }

        /// <summary>
        /// Target Entity
        /// </summary>
        public HealthcareEntity Target { get; }

        /// <summary> Type of relation. Examples include: `DosageOfMedication` or &apos;FrequencyOfMedication&apos;, etc. </summary>
        public string RelationType { get; }
        /// <summary> If true the relation between the entities is bidirectional, otherwise directionality is source to target. </summary>
        public bool Bidirectional { get; }
    }
}
