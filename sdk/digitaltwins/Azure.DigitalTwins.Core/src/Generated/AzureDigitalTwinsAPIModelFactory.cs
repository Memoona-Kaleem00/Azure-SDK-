// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.DigitalTwins.Core
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class AzureDigitalTwinsAPIModelFactory
    {
        /// <summary> Initializes new instance of DigitalTwinsModelData class. </summary>
        /// <param name="languageDisplayNames"> A language map that contains the localized display names as specified in the model definition. </param>
        /// <param name="languageDescriptions"> A language map that contains the localized descriptions as specified in the model definition. </param>
        /// <param name="id"> The id of the model as specified in the model definition. </param>
        /// <param name="uploadedOn"> The time the model was uploaded to the service. </param>
        /// <param name="decommissioned"> Indicates if the model is decommissioned. Decommissioned models cannot be referenced by newly created digital twins. </param>
        /// <param name="dtdlModel"> The model definition. </param>
        /// <returns> A new <see cref="Core.DigitalTwinsModelData"/> instance for mocking. </returns>
        public static DigitalTwinsModelData DigitalTwinsModelData(IReadOnlyDictionary<string, string> languageDisplayNames = default, IReadOnlyDictionary<string, string> languageDescriptions = default, string id = default, DateTimeOffset? uploadedOn = default, bool? decommissioned = default, string dtdlModel = default)
        {
            languageDisplayNames ??= new Dictionary<string, string>();
            languageDescriptions ??= new Dictionary<string, string>();
            return new DigitalTwinsModelData(languageDisplayNames, languageDescriptions, id, uploadedOn, decommissioned, dtdlModel);
        }

        /// <summary> Initializes new instance of IncomingRelationship class. </summary>
        /// <param name="relationshipId"> A user-provided string representing the id of this relationship, unique in the context of the source digital twin, i.e. sourceId + relationshipId is unique in the context of the service. </param>
        /// <param name="sourceId"> The id of the source digital twin. </param>
        /// <param name="relationshipName"> The name of the relationship. </param>
        /// <param name="relationshipLink"> Link to the relationship, to be used for deletion. </param>
        /// <returns> A new <see cref="Core.IncomingRelationship"/> instance for mocking. </returns>
        public static IncomingRelationship IncomingRelationship(string relationshipId = default, string sourceId = default, string relationshipName = default, string relationshipLink = default)
        {
            return new IncomingRelationship(relationshipId, sourceId, relationshipName, relationshipLink);
        }

        /// <summary> Initializes new instance of DigitalTwinsEventRoute class. </summary>
        /// <param name="id"> The id of the event route. </param>
        /// <param name="endpointName"> The name of the endpoint this event route is bound to. </param>
        /// <param name="filter"> An expression which describes the events which are routed to the endpoint. </param>
        /// <returns> A new <see cref="Core.DigitalTwinsEventRoute"/> instance for mocking. </returns>
        public static DigitalTwinsEventRoute DigitalTwinsEventRoute(string id = default, string endpointName = default, string filter = default)
        {
            return new DigitalTwinsEventRoute(id, endpointName, filter);
        }
    }
}
