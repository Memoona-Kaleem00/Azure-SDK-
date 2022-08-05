// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Migrate.Models
{
    /// <summary> If machine is not ready to be migrated, this explains the reasons and mitigation steps. </summary>
    public readonly partial struct AzureVmSuitabilityExplanation : IEquatable<AzureVmSuitabilityExplanation>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AzureVmSuitabilityExplanation"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AzureVmSuitabilityExplanation(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string NotApplicableValue = "NotApplicable";
        private const string GuestOperatingSystemArchitectureNotSupportedValue = "GuestOperatingSystemArchitectureNotSupported";
        private const string GuestOperatingSystemNotSupportedValue = "GuestOperatingSystemNotSupported";
        private const string BootTypeNotSupportedValue = "BootTypeNotSupported";
        private const string MoreDisksThanSupportedValue = "MoreDisksThanSupported";
        private const string NoSuitableVmSizeFoundValue = "NoSuitableVmSizeFound";
        private const string OneOrMoreDisksNotSuitableValue = "OneOrMoreDisksNotSuitable";
        private const string OneOrMoreAdaptersNotSuitableValue = "OneOrMoreAdaptersNotSuitable";
        private const string InternalErrorOccurredDuringComputeEvaluationValue = "InternalErrorOccurredDuringComputeEvaluation";
        private const string InternalErrorOccurredDuringStorageEvaluationValue = "InternalErrorOccurredDuringStorageEvaluation";
        private const string InternalErrorOccurredDuringNetworkEvaluationValue = "InternalErrorOccurredDuringNetworkEvaluation";
        private const string NoVmSizeSupportsStoragePerformanceValue = "NoVmSizeSupportsStoragePerformance";
        private const string NoVmSizeSupportsNetworkPerformanceValue = "NoVmSizeSupportsNetworkPerformance";
        private const string NoVmSizeForSelectedPricingTierValue = "NoVmSizeForSelectedPricingTier";
        private const string NoVmSizeForSelectedAzureLocationValue = "NoVmSizeForSelectedAzureLocation";
        private const string CheckRedHatLinuxVersionValue = "CheckRedHatLinuxVersion";
        private const string CheckOpenSuseLinuxVersionValue = "CheckOpenSuseLinuxVersion";
        private const string CheckWindowsServer2008R2VersionValue = "CheckWindowsServer2008R2Version";
        private const string CheckCentOSVersionValue = "CheckCentOsVersion";
        private const string CheckDebianLinuxVersionValue = "CheckDebianLinuxVersion";
        private const string CheckSuseLinuxVersionValue = "CheckSuseLinuxVersion";
        private const string CheckOracleLinuxVersionValue = "CheckOracleLinuxVersion";
        private const string CheckUbuntuLinuxVersionValue = "CheckUbuntuLinuxVersion";
        private const string CheckCoreOSLinuxVersionValue = "CheckCoreOsLinuxVersion";
        private const string WindowsServerVersionConditionallySupportedValue = "WindowsServerVersionConditionallySupported";
        private const string NoGuestOperatingSystemConditionallySupportedValue = "NoGuestOperatingSystemConditionallySupported";
        private const string WindowsClientVersionsConditionallySupportedValue = "WindowsClientVersionsConditionallySupported";
        private const string BootTypeUnknownValue = "BootTypeUnknown";
        private const string GuestOperatingSystemUnknownValue = "GuestOperatingSystemUnknown";
        private const string WindowsServerVersionsSupportedWithCaveatValue = "WindowsServerVersionsSupportedWithCaveat";
        private const string WindowsOSNoLongerUnderMSSupportValue = "WindowsOSNoLongerUnderMSSupport";
        private const string EndorsedWithConditionsLinuxDistributionsValue = "EndorsedWithConditionsLinuxDistributions";
        private const string UnendorsedLinuxDistributionsValue = "UnendorsedLinuxDistributions";
        private const string NoVmSizeForStandardPricingTierValue = "NoVmSizeForStandardPricingTier";
        private const string NoVmSizeForBasicPricingTierValue = "NoVmSizeForBasicPricingTier";

        /// <summary> Unknown. </summary>
        public static AzureVmSuitabilityExplanation Unknown { get; } = new AzureVmSuitabilityExplanation(UnknownValue);
        /// <summary> NotApplicable. </summary>
        public static AzureVmSuitabilityExplanation NotApplicable { get; } = new AzureVmSuitabilityExplanation(NotApplicableValue);
        /// <summary> GuestOperatingSystemArchitectureNotSupported. </summary>
        public static AzureVmSuitabilityExplanation GuestOperatingSystemArchitectureNotSupported { get; } = new AzureVmSuitabilityExplanation(GuestOperatingSystemArchitectureNotSupportedValue);
        /// <summary> GuestOperatingSystemNotSupported. </summary>
        public static AzureVmSuitabilityExplanation GuestOperatingSystemNotSupported { get; } = new AzureVmSuitabilityExplanation(GuestOperatingSystemNotSupportedValue);
        /// <summary> BootTypeNotSupported. </summary>
        public static AzureVmSuitabilityExplanation BootTypeNotSupported { get; } = new AzureVmSuitabilityExplanation(BootTypeNotSupportedValue);
        /// <summary> MoreDisksThanSupported. </summary>
        public static AzureVmSuitabilityExplanation MoreDisksThanSupported { get; } = new AzureVmSuitabilityExplanation(MoreDisksThanSupportedValue);
        /// <summary> NoSuitableVmSizeFound. </summary>
        public static AzureVmSuitabilityExplanation NoSuitableVmSizeFound { get; } = new AzureVmSuitabilityExplanation(NoSuitableVmSizeFoundValue);
        /// <summary> OneOrMoreDisksNotSuitable. </summary>
        public static AzureVmSuitabilityExplanation OneOrMoreDisksNotSuitable { get; } = new AzureVmSuitabilityExplanation(OneOrMoreDisksNotSuitableValue);
        /// <summary> OneOrMoreAdaptersNotSuitable. </summary>
        public static AzureVmSuitabilityExplanation OneOrMoreAdaptersNotSuitable { get; } = new AzureVmSuitabilityExplanation(OneOrMoreAdaptersNotSuitableValue);
        /// <summary> InternalErrorOccurredDuringComputeEvaluation. </summary>
        public static AzureVmSuitabilityExplanation InternalErrorOccurredDuringComputeEvaluation { get; } = new AzureVmSuitabilityExplanation(InternalErrorOccurredDuringComputeEvaluationValue);
        /// <summary> InternalErrorOccurredDuringStorageEvaluation. </summary>
        public static AzureVmSuitabilityExplanation InternalErrorOccurredDuringStorageEvaluation { get; } = new AzureVmSuitabilityExplanation(InternalErrorOccurredDuringStorageEvaluationValue);
        /// <summary> InternalErrorOccurredDuringNetworkEvaluation. </summary>
        public static AzureVmSuitabilityExplanation InternalErrorOccurredDuringNetworkEvaluation { get; } = new AzureVmSuitabilityExplanation(InternalErrorOccurredDuringNetworkEvaluationValue);
        /// <summary> NoVmSizeSupportsStoragePerformance. </summary>
        public static AzureVmSuitabilityExplanation NoVmSizeSupportsStoragePerformance { get; } = new AzureVmSuitabilityExplanation(NoVmSizeSupportsStoragePerformanceValue);
        /// <summary> NoVmSizeSupportsNetworkPerformance. </summary>
        public static AzureVmSuitabilityExplanation NoVmSizeSupportsNetworkPerformance { get; } = new AzureVmSuitabilityExplanation(NoVmSizeSupportsNetworkPerformanceValue);
        /// <summary> NoVmSizeForSelectedPricingTier. </summary>
        public static AzureVmSuitabilityExplanation NoVmSizeForSelectedPricingTier { get; } = new AzureVmSuitabilityExplanation(NoVmSizeForSelectedPricingTierValue);
        /// <summary> NoVmSizeForSelectedAzureLocation. </summary>
        public static AzureVmSuitabilityExplanation NoVmSizeForSelectedAzureLocation { get; } = new AzureVmSuitabilityExplanation(NoVmSizeForSelectedAzureLocationValue);
        /// <summary> CheckRedHatLinuxVersion. </summary>
        public static AzureVmSuitabilityExplanation CheckRedHatLinuxVersion { get; } = new AzureVmSuitabilityExplanation(CheckRedHatLinuxVersionValue);
        /// <summary> CheckOpenSuseLinuxVersion. </summary>
        public static AzureVmSuitabilityExplanation CheckOpenSuseLinuxVersion { get; } = new AzureVmSuitabilityExplanation(CheckOpenSuseLinuxVersionValue);
        /// <summary> CheckWindowsServer2008R2Version. </summary>
        public static AzureVmSuitabilityExplanation CheckWindowsServer2008R2Version { get; } = new AzureVmSuitabilityExplanation(CheckWindowsServer2008R2VersionValue);
        /// <summary> CheckCentOsVersion. </summary>
        public static AzureVmSuitabilityExplanation CheckCentOSVersion { get; } = new AzureVmSuitabilityExplanation(CheckCentOSVersionValue);
        /// <summary> CheckDebianLinuxVersion. </summary>
        public static AzureVmSuitabilityExplanation CheckDebianLinuxVersion { get; } = new AzureVmSuitabilityExplanation(CheckDebianLinuxVersionValue);
        /// <summary> CheckSuseLinuxVersion. </summary>
        public static AzureVmSuitabilityExplanation CheckSuseLinuxVersion { get; } = new AzureVmSuitabilityExplanation(CheckSuseLinuxVersionValue);
        /// <summary> CheckOracleLinuxVersion. </summary>
        public static AzureVmSuitabilityExplanation CheckOracleLinuxVersion { get; } = new AzureVmSuitabilityExplanation(CheckOracleLinuxVersionValue);
        /// <summary> CheckUbuntuLinuxVersion. </summary>
        public static AzureVmSuitabilityExplanation CheckUbuntuLinuxVersion { get; } = new AzureVmSuitabilityExplanation(CheckUbuntuLinuxVersionValue);
        /// <summary> CheckCoreOsLinuxVersion. </summary>
        public static AzureVmSuitabilityExplanation CheckCoreOSLinuxVersion { get; } = new AzureVmSuitabilityExplanation(CheckCoreOSLinuxVersionValue);
        /// <summary> WindowsServerVersionConditionallySupported. </summary>
        public static AzureVmSuitabilityExplanation WindowsServerVersionConditionallySupported { get; } = new AzureVmSuitabilityExplanation(WindowsServerVersionConditionallySupportedValue);
        /// <summary> NoGuestOperatingSystemConditionallySupported. </summary>
        public static AzureVmSuitabilityExplanation NoGuestOperatingSystemConditionallySupported { get; } = new AzureVmSuitabilityExplanation(NoGuestOperatingSystemConditionallySupportedValue);
        /// <summary> WindowsClientVersionsConditionallySupported. </summary>
        public static AzureVmSuitabilityExplanation WindowsClientVersionsConditionallySupported { get; } = new AzureVmSuitabilityExplanation(WindowsClientVersionsConditionallySupportedValue);
        /// <summary> BootTypeUnknown. </summary>
        public static AzureVmSuitabilityExplanation BootTypeUnknown { get; } = new AzureVmSuitabilityExplanation(BootTypeUnknownValue);
        /// <summary> GuestOperatingSystemUnknown. </summary>
        public static AzureVmSuitabilityExplanation GuestOperatingSystemUnknown { get; } = new AzureVmSuitabilityExplanation(GuestOperatingSystemUnknownValue);
        /// <summary> WindowsServerVersionsSupportedWithCaveat. </summary>
        public static AzureVmSuitabilityExplanation WindowsServerVersionsSupportedWithCaveat { get; } = new AzureVmSuitabilityExplanation(WindowsServerVersionsSupportedWithCaveatValue);
        /// <summary> WindowsOSNoLongerUnderMSSupport. </summary>
        public static AzureVmSuitabilityExplanation WindowsOSNoLongerUnderMSSupport { get; } = new AzureVmSuitabilityExplanation(WindowsOSNoLongerUnderMSSupportValue);
        /// <summary> EndorsedWithConditionsLinuxDistributions. </summary>
        public static AzureVmSuitabilityExplanation EndorsedWithConditionsLinuxDistributions { get; } = new AzureVmSuitabilityExplanation(EndorsedWithConditionsLinuxDistributionsValue);
        /// <summary> UnendorsedLinuxDistributions. </summary>
        public static AzureVmSuitabilityExplanation UnendorsedLinuxDistributions { get; } = new AzureVmSuitabilityExplanation(UnendorsedLinuxDistributionsValue);
        /// <summary> NoVmSizeForStandardPricingTier. </summary>
        public static AzureVmSuitabilityExplanation NoVmSizeForStandardPricingTier { get; } = new AzureVmSuitabilityExplanation(NoVmSizeForStandardPricingTierValue);
        /// <summary> NoVmSizeForBasicPricingTier. </summary>
        public static AzureVmSuitabilityExplanation NoVmSizeForBasicPricingTier { get; } = new AzureVmSuitabilityExplanation(NoVmSizeForBasicPricingTierValue);
        /// <summary> Determines if two <see cref="AzureVmSuitabilityExplanation"/> values are the same. </summary>
        public static bool operator ==(AzureVmSuitabilityExplanation left, AzureVmSuitabilityExplanation right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AzureVmSuitabilityExplanation"/> values are not the same. </summary>
        public static bool operator !=(AzureVmSuitabilityExplanation left, AzureVmSuitabilityExplanation right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AzureVmSuitabilityExplanation"/>. </summary>
        public static implicit operator AzureVmSuitabilityExplanation(string value) => new AzureVmSuitabilityExplanation(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AzureVmSuitabilityExplanation other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AzureVmSuitabilityExplanation other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
