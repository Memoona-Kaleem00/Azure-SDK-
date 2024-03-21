// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Verticals.AgriFood.Farming
{
    // Data plane generated client.
    /// <summary> The FarmBeats service client. </summary>
    public partial class FarmBeatsClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://farmbeats.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of FarmBeatsClient for mocking. </summary>
        protected FarmBeatsClient()
        {
        }

        /// <summary> Initializes a new instance of FarmBeatsClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public FarmBeatsClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new FarmBeatsClientOptions())
        {
        }

        /// <summary> Initializes a new instance of FarmBeatsClient. </summary>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public FarmBeatsClient(Uri endpoint, TokenCredential credential, FarmBeatsClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new FarmBeatsClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
        }

        /// <summary> Initializes a new instance of ApplicationData. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual ApplicationData GetApplicationDataClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new ApplicationData(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Attachments. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Attachments GetAttachmentsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Attachments(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Boundaries. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Boundaries GetBoundariesClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Boundaries(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of CropProducts. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual CropProducts GetCropProductsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new CropProducts(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Crops. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Crops GetCropsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Crops(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of DeviceDataModels. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual DeviceDataModels GetDeviceDataModelsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new DeviceDataModels(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Devices. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Devices GetDevicesClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Devices(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of FarmOperationsDataIngestion. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual FarmOperationsDataIngestion GetFarmOperationsDataIngestionClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new FarmOperationsDataIngestion(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Farms. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Farms GetFarmsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Farms(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Fields. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Fields GetFieldsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Fields(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of HarvestData. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual HarvestData GetHarvestDataClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new HarvestData(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of ImageProcessing. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual ImageProcessing GetImageProcessingClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new ImageProcessing(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of InsightAttachments. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual InsightAttachments GetInsightAttachmentsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new InsightAttachments(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Insights. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Insights GetInsightsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Insights(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of ManagementZones. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual ManagementZones GetManagementZonesClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new ManagementZones(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of ModelInference. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual ModelInference GetModelInferenceClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new ModelInference(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of NutrientAnalyses. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual NutrientAnalyses GetNutrientAnalysesClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new NutrientAnalyses(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of OAuthProviders. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual OAuthProviders GetOAuthProvidersClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new OAuthProviders(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of FarmerOAuthTokens. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual FarmerOAuthTokens GetFarmerOAuthTokensClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new FarmerOAuthTokens(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Parties. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Parties GetPartiesClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Parties(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of PlantingData. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual PlantingData GetPlantingDataClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new PlantingData(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of PlantTissueAnalyses. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual PlantTissueAnalyses GetPlantTissueAnalysesClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new PlantTissueAnalyses(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of PrescriptionMaps. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual PrescriptionMaps GetPrescriptionMapsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new PrescriptionMaps(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Prescriptions. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Prescriptions GetPrescriptionsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Prescriptions(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Scenes. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Scenes GetScenesClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Scenes(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of SeasonalFields. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual SeasonalFields GetSeasonalFieldsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new SeasonalFields(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Seasons. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Seasons GetSeasonsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Seasons(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of SensorDataModels. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual SensorDataModels GetSensorDataModelsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new SensorDataModels(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of SensorEvents. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual SensorEvents GetSensorEventsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new SensorEvents(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of SensorMappings. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual SensorMappings GetSensorMappingsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new SensorMappings(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of SensorPartnerIntegrations. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual SensorPartnerIntegrations GetSensorPartnerIntegrationsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new SensorPartnerIntegrations(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Sensors. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Sensors GetSensorsClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Sensors(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of SolutionInference. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual SolutionInference GetSolutionInferenceClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new SolutionInference(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of TillageData. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual TillageData GetTillageDataClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new TillageData(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Weather. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Weather GetWeatherClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Weather(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of WeatherData. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual WeatherData GetWeatherDataClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new WeatherData(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }

        /// <summary> Initializes a new instance of Zones. </summary>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="apiVersion"/> is null. </exception>
        public virtual Zones GetZonesClient(string apiVersion = "2022-11-01-preview")
        {
            Argument.AssertNotNull(apiVersion, nameof(apiVersion));

            return new Zones(ClientDiagnostics, _pipeline, _tokenCredential, _endpoint, apiVersion);
        }
    }
}
