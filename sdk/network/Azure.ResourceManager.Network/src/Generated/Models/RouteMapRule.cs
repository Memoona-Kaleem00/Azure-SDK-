// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> A RouteMap Rule. </summary>
    public partial class RouteMapRule
    {
        /// <summary> Initializes a new instance of RouteMapRule. </summary>
        public RouteMapRule()
        {
            MatchCriteria = new Core.ChangeTrackingList<RouteCriterion>();
            Actions = new Core.ChangeTrackingList<RouteMapAction>();
        }

        /// <summary> Initializes a new instance of RouteMapRule. </summary>
        /// <param name="name"> The unique name for the rule. </param>
        /// <param name="matchCriteria"> List of matching criterion which will be applied to traffic. </param>
        /// <param name="actions"> List of actions which will be applied on a match. </param>
        /// <param name="nextStepIfMatched"> Next step after rule is evaluated. Current supported behaviors are 'Continue'(to next rule) and 'Terminate'. </param>
        internal RouteMapRule(string name, IList<RouteCriterion> matchCriteria, IList<RouteMapAction> actions, RouteMapNextStepBehavior? nextStepIfMatched)
        {
            Name = name;
            MatchCriteria = matchCriteria;
            Actions = actions;
            NextStepIfMatched = nextStepIfMatched;
        }

        /// <summary> The unique name for the rule. </summary>
        public string Name { get; set; }
        /// <summary> List of matching criterion which will be applied to traffic. </summary>
        public IList<RouteCriterion> MatchCriteria { get; }
        /// <summary> List of actions which will be applied on a match. </summary>
        public IList<RouteMapAction> Actions { get; }
        /// <summary> Next step after rule is evaluated. Current supported behaviors are 'Continue'(to next rule) and 'Terminate'. </summary>
        public RouteMapNextStepBehavior? NextStepIfMatched { get; set; }
    }
}
