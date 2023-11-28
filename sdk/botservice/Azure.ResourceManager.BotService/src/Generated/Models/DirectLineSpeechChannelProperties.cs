// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The parameters to provide for the DirectLine Speech channel. </summary>
    public partial class DirectLineSpeechChannelProperties
    {
        /// <summary> Initializes a new instance of <see cref="DirectLineSpeechChannelProperties"/>. </summary>
        public DirectLineSpeechChannelProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DirectLineSpeechChannelProperties"/>. </summary>
        /// <param name="cognitiveServiceResourceId"> The cognitive service id with this channel registration. </param>
        /// <param name="cognitiveServiceRegion"> The cognitive service region with this channel registration. </param>
        /// <param name="cognitiveServiceSubscriptionKey"> The cognitive service subscription key to use with this channel registration. </param>
        /// <param name="isEnabled"> Whether this channel is enabled or not. </param>
        /// <param name="customVoiceDeploymentId"> Custom speech model id (optional). </param>
        /// <param name="customSpeechModelId"> Custom voice deployment id (optional). </param>
        /// <param name="isDefaultBotForCogSvcAccount"> Make this a default bot for chosen cognitive service account. </param>
        internal DirectLineSpeechChannelProperties(ResourceIdentifier cognitiveServiceResourceId, string cognitiveServiceRegion, string cognitiveServiceSubscriptionKey, bool? isEnabled, string customVoiceDeploymentId, string customSpeechModelId, bool? isDefaultBotForCogSvcAccount)
        {
            CognitiveServiceResourceId = cognitiveServiceResourceId;
            CognitiveServiceRegion = cognitiveServiceRegion;
            CognitiveServiceSubscriptionKey = cognitiveServiceSubscriptionKey;
            IsEnabled = isEnabled;
            CustomVoiceDeploymentId = customVoiceDeploymentId;
            CustomSpeechModelId = customSpeechModelId;
            IsDefaultBotForCogSvcAccount = isDefaultBotForCogSvcAccount;
        }

        /// <summary> The cognitive service id with this channel registration. </summary>
        public ResourceIdentifier CognitiveServiceResourceId { get; set; }
        /// <summary> The cognitive service region with this channel registration. </summary>
        public string CognitiveServiceRegion { get; set; }
        /// <summary> The cognitive service subscription key to use with this channel registration. </summary>
        public string CognitiveServiceSubscriptionKey { get; set; }
        /// <summary> Whether this channel is enabled or not. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Custom speech model id (optional). </summary>
        public string CustomVoiceDeploymentId { get; set; }
        /// <summary> Custom voice deployment id (optional). </summary>
        public string CustomSpeechModelId { get; set; }
        /// <summary> Make this a default bot for chosen cognitive service account. </summary>
        public bool? IsDefaultBotForCogSvcAccount { get; set; }
    }
}
