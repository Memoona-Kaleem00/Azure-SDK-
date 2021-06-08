// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NewResources
{
    public partial class DeploymentProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Template))
            {
                writer.WritePropertyName("template");
                writer.WriteObjectValue(Template);
            }
            if (Optional.IsDefined(TemplateLink))
            {
                writer.WritePropertyName("templateLink");
                writer.WriteObjectValue(TemplateLink);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteObjectValue(Parameters);
            }
            if (Optional.IsDefined(ParametersLink))
            {
                writer.WritePropertyName("parametersLink");
                writer.WriteObjectValue(ParametersLink);
            }
            writer.WritePropertyName("mode");
            writer.WriteStringValue(Mode.ToSerialString());
            if (Optional.IsDefined(DebugSetting))
            {
                writer.WritePropertyName("debugSetting");
                writer.WriteObjectValue(DebugSetting);
            }
            if (Optional.IsDefined(OnErrorDeployment))
            {
                writer.WritePropertyName("onErrorDeployment");
                writer.WriteObjectValue(OnErrorDeployment);
            }
            if (Optional.IsDefined(ExpressionEvaluationOptions))
            {
                writer.WritePropertyName("expressionEvaluationOptions");
                writer.WriteObjectValue(ExpressionEvaluationOptions);
            }
            writer.WriteEndObject();
        }
    }
}
