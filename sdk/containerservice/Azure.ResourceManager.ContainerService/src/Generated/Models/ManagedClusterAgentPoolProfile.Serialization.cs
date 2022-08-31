// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterAgentPoolProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count");
                writer.WriteNumberValue(Count.Value);
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize");
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(OSDiskSizeInGB))
            {
                writer.WritePropertyName("osDiskSizeGB");
                writer.WriteNumberValue(OSDiskSizeInGB.Value);
            }
            if (Optional.IsDefined(OSDiskType))
            {
                writer.WritePropertyName("osDiskType");
                writer.WriteStringValue(OSDiskType.Value.ToString());
            }
            if (Optional.IsDefined(KubeletDiskType))
            {
                writer.WritePropertyName("kubeletDiskType");
                writer.WriteStringValue(KubeletDiskType.Value.ToString());
            }
            if (Optional.IsDefined(WorkloadRuntime))
            {
                writer.WritePropertyName("workloadRuntime");
                writer.WriteStringValue(WorkloadRuntime.Value.ToString());
            }
            if (Optional.IsDefined(VnetSubnetId))
            {
                writer.WritePropertyName("vnetSubnetID");
                writer.WriteStringValue(VnetSubnetId);
            }
            if (Optional.IsDefined(PodSubnetId))
            {
                writer.WritePropertyName("podSubnetID");
                writer.WriteStringValue(PodSubnetId);
            }
            if (Optional.IsDefined(MaxPods))
            {
                writer.WritePropertyName("maxPods");
                writer.WriteNumberValue(MaxPods.Value);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType");
                writer.WriteStringValue(OSType.Value.ToString());
            }
            if (Optional.IsDefined(OSSku))
            {
                writer.WritePropertyName("osSKU");
                writer.WriteStringValue(OSSku.Value.ToString());
            }
            if (Optional.IsDefined(MaxCount))
            {
                writer.WritePropertyName("maxCount");
                writer.WriteNumberValue(MaxCount.Value);
            }
            if (Optional.IsDefined(MinCount))
            {
                writer.WritePropertyName("minCount");
                writer.WriteNumberValue(MinCount.Value);
            }
            if (Optional.IsDefined(EnableAutoScaling))
            {
                writer.WritePropertyName("enableAutoScaling");
                writer.WriteBooleanValue(EnableAutoScaling.Value);
            }
            if (Optional.IsDefined(ScaleDownMode))
            {
                writer.WritePropertyName("scaleDownMode");
                writer.WriteStringValue(ScaleDownMode.Value.ToString());
            }
            if (Optional.IsDefined(AgentPoolType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(AgentPoolType.Value.ToString());
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(OrchestratorVersion))
            {
                writer.WritePropertyName("orchestratorVersion");
                writer.WriteStringValue(OrchestratorVersion);
            }
            if (Optional.IsDefined(UpgradeSettings))
            {
                writer.WritePropertyName("upgradeSettings");
                writer.WriteObjectValue(UpgradeSettings);
            }
            if (Optional.IsDefined(PowerState))
            {
                writer.WritePropertyName("powerState");
                writer.WriteObjectValue(PowerState);
            }
            if (Optional.IsCollectionDefined(AvailabilityZones))
            {
                writer.WritePropertyName("availabilityZones");
                writer.WriteStartArray();
                foreach (var item in AvailabilityZones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableNodePublicIP))
            {
                writer.WritePropertyName("enableNodePublicIP");
                writer.WriteBooleanValue(EnableNodePublicIP.Value);
            }
            if (Optional.IsDefined(NodePublicIPPrefixId))
            {
                writer.WritePropertyName("nodePublicIPPrefixID");
                writer.WriteStringValue(NodePublicIPPrefixId);
            }
            if (Optional.IsDefined(ScaleSetPriority))
            {
                writer.WritePropertyName("scaleSetPriority");
                writer.WriteStringValue(ScaleSetPriority.Value.ToString());
            }
            if (Optional.IsDefined(ScaleSetEvictionPolicy))
            {
                writer.WritePropertyName("scaleSetEvictionPolicy");
                writer.WriteStringValue(ScaleSetEvictionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(SpotMaxPrice))
            {
                writer.WritePropertyName("spotMaxPrice");
                writer.WriteNumberValue(SpotMaxPrice.Value);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NodeLabels))
            {
                writer.WritePropertyName("nodeLabels");
                writer.WriteStartObject();
                foreach (var item in NodeLabels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(NodeTaints))
            {
                writer.WritePropertyName("nodeTaints");
                writer.WriteStartArray();
                foreach (var item in NodeTaints)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProximityPlacementGroupId))
            {
                writer.WritePropertyName("proximityPlacementGroupID");
                writer.WriteStringValue(ProximityPlacementGroupId);
            }
            if (Optional.IsDefined(KubeletConfig))
            {
                writer.WritePropertyName("kubeletConfig");
                writer.WriteObjectValue(KubeletConfig);
            }
            if (Optional.IsDefined(LinuxOSConfig))
            {
                writer.WritePropertyName("linuxOSConfig");
                writer.WriteObjectValue(LinuxOSConfig);
            }
            if (Optional.IsDefined(EnableEncryptionAtHost))
            {
                writer.WritePropertyName("enableEncryptionAtHost");
                writer.WriteBooleanValue(EnableEncryptionAtHost.Value);
            }
            if (Optional.IsDefined(EnableUltraSsd))
            {
                writer.WritePropertyName("enableUltraSSD");
                writer.WriteBooleanValue(EnableUltraSsd.Value);
            }
            if (Optional.IsDefined(EnableFips))
            {
                writer.WritePropertyName("enableFIPS");
                writer.WriteBooleanValue(EnableFips.Value);
            }
            if (Optional.IsDefined(GpuInstanceProfile))
            {
                writer.WritePropertyName("gpuInstanceProfile");
                writer.WriteStringValue(GpuInstanceProfile.Value.ToString());
            }
            if (Optional.IsDefined(CreationData))
            {
                writer.WritePropertyName("creationData");
                writer.WriteObjectValue(CreationData);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterAgentPoolProfile DeserializeManagedClusterAgentPoolProfile(JsonElement element)
        {
            string name = default;
            Optional<int> count = default;
            Optional<string> vmSize = default;
            Optional<int> osDiskSizeGB = default;
            Optional<ContainerServiceOSDiskType> osDiskType = default;
            Optional<KubeletDiskType> kubeletDiskType = default;
            Optional<WorkloadRuntime> workloadRuntime = default;
            Optional<ResourceIdentifier> vnetSubnetId = default;
            Optional<ResourceIdentifier> podSubnetId = default;
            Optional<int> maxPods = default;
            Optional<ContainerServiceOSType> osType = default;
            Optional<ContainerServiceOSSku> osSku = default;
            Optional<int> maxCount = default;
            Optional<int> minCount = default;
            Optional<bool> enableAutoScaling = default;
            Optional<ScaleDownMode> scaleDownMode = default;
            Optional<AgentPoolType> type = default;
            Optional<AgentPoolMode> mode = default;
            Optional<string> orchestratorVersion = default;
            Optional<string> currentOrchestratorVersion = default;
            Optional<string> nodeImageVersion = default;
            Optional<AgentPoolUpgradeSettings> upgradeSettings = default;
            Optional<string> provisioningState = default;
            Optional<ContainerServicePowerState> powerState = default;
            Optional<IList<string>> availabilityZones = default;
            Optional<bool> enableNodePublicIP = default;
            Optional<ResourceIdentifier> nodePublicIPPrefixId = default;
            Optional<ScaleSetPriority> scaleSetPriority = default;
            Optional<ScaleSetEvictionPolicy> scaleSetEvictionPolicy = default;
            Optional<float> spotMaxPrice = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IDictionary<string, string>> nodeLabels = default;
            Optional<IList<string>> nodeTaints = default;
            Optional<ResourceIdentifier> proximityPlacementGroupId = default;
            Optional<KubeletConfig> kubeletConfig = default;
            Optional<LinuxOSConfig> linuxOSConfig = default;
            Optional<bool> enableEncryptionAtHost = default;
            Optional<bool> enableUltraSsd = default;
            Optional<bool> enableFIPS = default;
            Optional<GpuInstanceProfile> gpuInstanceProfile = default;
            Optional<ContainerServiceCreationData> creationData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vmSize"))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osDiskSizeGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osDiskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osDiskType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osDiskType = new ContainerServiceOSDiskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kubeletDiskType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kubeletDiskType = new KubeletDiskType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("workloadRuntime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    workloadRuntime = new WorkloadRuntime(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vnetSubnetID"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vnetSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("podSubnetID"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    podSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxPods"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxPods = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("osType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osType = new ContainerServiceOSType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osSKU"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    osSku = new ContainerServiceOSSku(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    minCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("enableAutoScaling"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableAutoScaling = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("scaleDownMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scaleDownMode = new ScaleDownMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new AgentPoolType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    mode = new AgentPoolMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("orchestratorVersion"))
                {
                    orchestratorVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentOrchestratorVersion"))
                {
                    currentOrchestratorVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeImageVersion"))
                {
                    nodeImageVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("upgradeSettings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    upgradeSettings = AgentPoolUpgradeSettings.DeserializeAgentPoolUpgradeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("powerState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    powerState = ContainerServicePowerState.DeserializeContainerServicePowerState(property.Value);
                    continue;
                }
                if (property.NameEquals("availabilityZones"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    availabilityZones = array;
                    continue;
                }
                if (property.NameEquals("enableNodePublicIP"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableNodePublicIP = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nodePublicIPPrefixID"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nodePublicIPPrefixId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scaleSetPriority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scaleSetPriority = new ScaleSetPriority(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scaleSetEvictionPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    scaleSetEvictionPolicy = new ScaleSetEvictionPolicy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("spotMaxPrice"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    spotMaxPrice = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("nodeLabels"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    nodeLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("nodeTaints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    nodeTaints = array;
                    continue;
                }
                if (property.NameEquals("proximityPlacementGroupID"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    proximityPlacementGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kubeletConfig"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kubeletConfig = KubeletConfig.DeserializeKubeletConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("linuxOSConfig"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    linuxOSConfig = LinuxOSConfig.DeserializeLinuxOSConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("enableEncryptionAtHost"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableEncryptionAtHost = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableUltraSSD"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableUltraSsd = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableFIPS"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enableFIPS = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("gpuInstanceProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    gpuInstanceProfile = new GpuInstanceProfile(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("creationData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    creationData = ContainerServiceCreationData.DeserializeContainerServiceCreationData(property.Value);
                    continue;
                }
            }
            return new ManagedClusterAgentPoolProfile(Optional.ToNullable(count), vmSize.Value, Optional.ToNullable(osDiskSizeGB), Optional.ToNullable(osDiskType), Optional.ToNullable(kubeletDiskType), Optional.ToNullable(workloadRuntime), vnetSubnetId.Value, podSubnetId.Value, Optional.ToNullable(maxPods), Optional.ToNullable(osType), Optional.ToNullable(osSku), Optional.ToNullable(maxCount), Optional.ToNullable(minCount), Optional.ToNullable(enableAutoScaling), Optional.ToNullable(scaleDownMode), Optional.ToNullable(type), Optional.ToNullable(mode), orchestratorVersion.Value, currentOrchestratorVersion.Value, nodeImageVersion.Value, upgradeSettings.Value, provisioningState.Value, powerState.Value, Optional.ToList(availabilityZones), Optional.ToNullable(enableNodePublicIP), nodePublicIPPrefixId.Value, Optional.ToNullable(scaleSetPriority), Optional.ToNullable(scaleSetEvictionPolicy), Optional.ToNullable(spotMaxPrice), Optional.ToDictionary(tags), Optional.ToDictionary(nodeLabels), Optional.ToList(nodeTaints), proximityPlacementGroupId.Value, kubeletConfig.Value, linuxOSConfig.Value, Optional.ToNullable(enableEncryptionAtHost), Optional.ToNullable(enableUltraSsd), Optional.ToNullable(enableFIPS), Optional.ToNullable(gpuInstanceProfile), creationData.Value, name);
        }
    }
}
