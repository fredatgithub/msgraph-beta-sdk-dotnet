using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceConfiguration : Entity, IParsable {
        /// <summary>The list of assignments for the device configuration profile.</summary>
        public List<DeviceConfigurationAssignment> Assignments {
            get { return BackingStore?.Get<List<DeviceConfigurationAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Admin provided description of the Device Configuration.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The device mode applicability rule for this Policy.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleDeviceMode DeviceManagementApplicabilityRuleDeviceMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleDeviceMode>("deviceManagementApplicabilityRuleDeviceMode"); }
            set { BackingStore?.Set("deviceManagementApplicabilityRuleDeviceMode", value); }
        }
        /// <summary>The OS edition applicability for this Policy.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsEdition DeviceManagementApplicabilityRuleOsEdition {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsEdition>("deviceManagementApplicabilityRuleOsEdition"); }
            set { BackingStore?.Set("deviceManagementApplicabilityRuleOsEdition", value); }
        }
        /// <summary>The OS version applicability rule for this Policy.</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsVersion DeviceManagementApplicabilityRuleOsVersion {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsVersion>("deviceManagementApplicabilityRuleOsVersion"); }
            set { BackingStore?.Set("deviceManagementApplicabilityRuleOsVersion", value); }
        }
        /// <summary>Device Configuration Setting State Device Summary</summary>
        public List<SettingStateDeviceSummary> DeviceSettingStateSummaries {
            get { return BackingStore?.Get<List<SettingStateDeviceSummary>>("deviceSettingStateSummaries"); }
            set { BackingStore?.Set("deviceSettingStateSummaries", value); }
        }
        /// <summary>Device configuration installation status by device.</summary>
        public List<DeviceConfigurationDeviceStatus> DeviceStatuses {
            get { return BackingStore?.Get<List<DeviceConfigurationDeviceStatus>>("deviceStatuses"); }
            set { BackingStore?.Set("deviceStatuses", value); }
        }
        /// <summary>Device Configuration devices status overview</summary>
        public DeviceConfigurationDeviceOverview DeviceStatusOverview {
            get { return BackingStore?.Get<DeviceConfigurationDeviceOverview>("deviceStatusOverview"); }
            set { BackingStore?.Set("deviceStatusOverview", value); }
        }
        /// <summary>Admin provided name of the device configuration.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The list of group assignments for the device configuration profile.</summary>
        public List<DeviceConfigurationGroupAssignment> GroupAssignments {
            get { return BackingStore?.Get<List<DeviceConfigurationGroupAssignment>>("groupAssignments"); }
            set { BackingStore?.Set("groupAssignments", value); }
        }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
        public List<string> RoleScopeTagIds {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
        /// <summary>Indicates whether or not the underlying Device Configuration supports the assignment of scope tags. Assigning to the ScopeTags property is not allowed when this value is false and entities will not be visible to scoped users. This occurs for Legacy policies created in Silverlight and can be resolved by deleting and recreating the policy in the Azure Portal. This property is read-only.</summary>
        public bool? SupportsScopeTags {
            get { return BackingStore?.Get<bool?>("supportsScopeTags"); }
            set { BackingStore?.Set("supportsScopeTags", value); }
        }
        /// <summary>Device configuration installation status by user.</summary>
        public List<DeviceConfigurationUserStatus> UserStatuses {
            get { return BackingStore?.Get<List<DeviceConfigurationUserStatus>>("userStatuses"); }
            set { BackingStore?.Set("userStatuses", value); }
        }
        /// <summary>Device Configuration users status overview</summary>
        public DeviceConfigurationUserOverview UserStatusOverview {
            get { return BackingStore?.Get<DeviceConfigurationUserOverview>("userStatusOverview"); }
            set { BackingStore?.Set("userStatusOverview", value); }
        }
        /// <summary>Version of the device configuration.</summary>
        public int? Version {
            get { return BackingStore?.Get<int?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Instantiates a new DeviceConfiguration and sets the default values.
        /// </summary>
        public DeviceConfiguration() : base() {
            OdataType = "#microsoft.graph.deviceConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidCertificateProfileBase" => new AndroidCertificateProfileBase(),
                "#microsoft.graph.androidCustomConfiguration" => new AndroidCustomConfiguration(),
                "#microsoft.graph.androidDeviceOwnerCertificateProfileBase" => new AndroidDeviceOwnerCertificateProfileBase(),
                "#microsoft.graph.androidDeviceOwnerDerivedCredentialAuthenticationConfiguration" => new AndroidDeviceOwnerDerivedCredentialAuthenticationConfiguration(),
                "#microsoft.graph.androidDeviceOwnerEnterpriseWiFiConfiguration" => new AndroidDeviceOwnerEnterpriseWiFiConfiguration(),
                "#microsoft.graph.androidDeviceOwnerGeneralDeviceConfiguration" => new AndroidDeviceOwnerGeneralDeviceConfiguration(),
                "#microsoft.graph.androidDeviceOwnerImportedPFXCertificateProfile" => new AndroidDeviceOwnerImportedPFXCertificateProfile(),
                "#microsoft.graph.androidDeviceOwnerPkcsCertificateProfile" => new AndroidDeviceOwnerPkcsCertificateProfile(),
                "#microsoft.graph.androidDeviceOwnerScepCertificateProfile" => new AndroidDeviceOwnerScepCertificateProfile(),
                "#microsoft.graph.androidDeviceOwnerTrustedRootCertificate" => new AndroidDeviceOwnerTrustedRootCertificate(),
                "#microsoft.graph.androidDeviceOwnerVpnConfiguration" => new AndroidDeviceOwnerVpnConfiguration(),
                "#microsoft.graph.androidDeviceOwnerWiFiConfiguration" => new AndroidDeviceOwnerWiFiConfiguration(),
                "#microsoft.graph.androidEasEmailProfileConfiguration" => new AndroidEasEmailProfileConfiguration(),
                "#microsoft.graph.androidEnterpriseWiFiConfiguration" => new AndroidEnterpriseWiFiConfiguration(),
                "#microsoft.graph.androidForWorkCertificateProfileBase" => new AndroidForWorkCertificateProfileBase(),
                "#microsoft.graph.androidForWorkCustomConfiguration" => new AndroidForWorkCustomConfiguration(),
                "#microsoft.graph.androidForWorkEasEmailProfileBase" => new AndroidForWorkEasEmailProfileBase(),
                "#microsoft.graph.androidForWorkEnterpriseWiFiConfiguration" => new AndroidForWorkEnterpriseWiFiConfiguration(),
                "#microsoft.graph.androidForWorkGeneralDeviceConfiguration" => new AndroidForWorkGeneralDeviceConfiguration(),
                "#microsoft.graph.androidForWorkGmailEasConfiguration" => new AndroidForWorkGmailEasConfiguration(),
                "#microsoft.graph.androidForWorkImportedPFXCertificateProfile" => new AndroidForWorkImportedPFXCertificateProfile(),
                "#microsoft.graph.androidForWorkNineWorkEasConfiguration" => new AndroidForWorkNineWorkEasConfiguration(),
                "#microsoft.graph.androidForWorkPkcsCertificateProfile" => new AndroidForWorkPkcsCertificateProfile(),
                "#microsoft.graph.androidForWorkScepCertificateProfile" => new AndroidForWorkScepCertificateProfile(),
                "#microsoft.graph.androidForWorkTrustedRootCertificate" => new AndroidForWorkTrustedRootCertificate(),
                "#microsoft.graph.androidForWorkVpnConfiguration" => new AndroidForWorkVpnConfiguration(),
                "#microsoft.graph.androidForWorkWiFiConfiguration" => new AndroidForWorkWiFiConfiguration(),
                "#microsoft.graph.androidGeneralDeviceConfiguration" => new AndroidGeneralDeviceConfiguration(),
                "#microsoft.graph.androidImportedPFXCertificateProfile" => new AndroidImportedPFXCertificateProfile(),
                "#microsoft.graph.androidOmaCpConfiguration" => new AndroidOmaCpConfiguration(),
                "#microsoft.graph.androidPkcsCertificateProfile" => new AndroidPkcsCertificateProfile(),
                "#microsoft.graph.androidScepCertificateProfile" => new AndroidScepCertificateProfile(),
                "#microsoft.graph.androidTrustedRootCertificate" => new AndroidTrustedRootCertificate(),
                "#microsoft.graph.androidVpnConfiguration" => new AndroidVpnConfiguration(),
                "#microsoft.graph.androidWiFiConfiguration" => new AndroidWiFiConfiguration(),
                "#microsoft.graph.androidWorkProfileCertificateProfileBase" => new AndroidWorkProfileCertificateProfileBase(),
                "#microsoft.graph.androidWorkProfileCustomConfiguration" => new AndroidWorkProfileCustomConfiguration(),
                "#microsoft.graph.androidWorkProfileEasEmailProfileBase" => new AndroidWorkProfileEasEmailProfileBase(),
                "#microsoft.graph.androidWorkProfileEnterpriseWiFiConfiguration" => new AndroidWorkProfileEnterpriseWiFiConfiguration(),
                "#microsoft.graph.androidWorkProfileGeneralDeviceConfiguration" => new AndroidWorkProfileGeneralDeviceConfiguration(),
                "#microsoft.graph.androidWorkProfileGmailEasConfiguration" => new AndroidWorkProfileGmailEasConfiguration(),
                "#microsoft.graph.androidWorkProfileNineWorkEasConfiguration" => new AndroidWorkProfileNineWorkEasConfiguration(),
                "#microsoft.graph.androidWorkProfilePkcsCertificateProfile" => new AndroidWorkProfilePkcsCertificateProfile(),
                "#microsoft.graph.androidWorkProfileScepCertificateProfile" => new AndroidWorkProfileScepCertificateProfile(),
                "#microsoft.graph.androidWorkProfileTrustedRootCertificate" => new AndroidWorkProfileTrustedRootCertificate(),
                "#microsoft.graph.androidWorkProfileVpnConfiguration" => new AndroidWorkProfileVpnConfiguration(),
                "#microsoft.graph.androidWorkProfileWiFiConfiguration" => new AndroidWorkProfileWiFiConfiguration(),
                "#microsoft.graph.aospDeviceOwnerCertificateProfileBase" => new AospDeviceOwnerCertificateProfileBase(),
                "#microsoft.graph.aospDeviceOwnerDeviceConfiguration" => new AospDeviceOwnerDeviceConfiguration(),
                "#microsoft.graph.aospDeviceOwnerEnterpriseWiFiConfiguration" => new AospDeviceOwnerEnterpriseWiFiConfiguration(),
                "#microsoft.graph.aospDeviceOwnerPkcsCertificateProfile" => new AospDeviceOwnerPkcsCertificateProfile(),
                "#microsoft.graph.aospDeviceOwnerScepCertificateProfile" => new AospDeviceOwnerScepCertificateProfile(),
                "#microsoft.graph.aospDeviceOwnerTrustedRootCertificate" => new AospDeviceOwnerTrustedRootCertificate(),
                "#microsoft.graph.aospDeviceOwnerWiFiConfiguration" => new AospDeviceOwnerWiFiConfiguration(),
                "#microsoft.graph.appleDeviceFeaturesConfigurationBase" => new AppleDeviceFeaturesConfigurationBase(),
                "#microsoft.graph.appleExpeditedCheckinConfigurationBase" => new AppleExpeditedCheckinConfigurationBase(),
                "#microsoft.graph.appleVpnConfiguration" => new AppleVpnConfiguration(),
                "#microsoft.graph.easEmailProfileConfigurationBase" => new EasEmailProfileConfigurationBase(),
                "#microsoft.graph.editionUpgradeConfiguration" => new EditionUpgradeConfiguration(),
                "#microsoft.graph.iosCertificateProfile" => new IosCertificateProfile(),
                "#microsoft.graph.iosCertificateProfileBase" => new IosCertificateProfileBase(),
                "#microsoft.graph.iosCustomConfiguration" => new IosCustomConfiguration(),
                "#microsoft.graph.iosDerivedCredentialAuthenticationConfiguration" => new IosDerivedCredentialAuthenticationConfiguration(),
                "#microsoft.graph.iosDeviceFeaturesConfiguration" => new IosDeviceFeaturesConfiguration(),
                "#microsoft.graph.iosEasEmailProfileConfiguration" => new IosEasEmailProfileConfiguration(),
                "#microsoft.graph.iosEducationDeviceConfiguration" => new IosEducationDeviceConfiguration(),
                "#microsoft.graph.iosEduDeviceConfiguration" => new IosEduDeviceConfiguration(),
                "#microsoft.graph.iosEnterpriseWiFiConfiguration" => new IosEnterpriseWiFiConfiguration(),
                "#microsoft.graph.iosExpeditedCheckinConfiguration" => new IosExpeditedCheckinConfiguration(),
                "#microsoft.graph.iosGeneralDeviceConfiguration" => new IosGeneralDeviceConfiguration(),
                "#microsoft.graph.iosikEv2VpnConfiguration" => new IosikEv2VpnConfiguration(),
                "#microsoft.graph.iosImportedPFXCertificateProfile" => new IosImportedPFXCertificateProfile(),
                "#microsoft.graph.iosPkcsCertificateProfile" => new IosPkcsCertificateProfile(),
                "#microsoft.graph.iosScepCertificateProfile" => new IosScepCertificateProfile(),
                "#microsoft.graph.iosTrustedRootCertificate" => new IosTrustedRootCertificate(),
                "#microsoft.graph.iosUpdateConfiguration" => new IosUpdateConfiguration(),
                "#microsoft.graph.iosVpnConfiguration" => new IosVpnConfiguration(),
                "#microsoft.graph.iosWiFiConfiguration" => new IosWiFiConfiguration(),
                "#microsoft.graph.macOSCertificateProfileBase" => new MacOSCertificateProfileBase(),
                "#microsoft.graph.macOSCustomAppConfiguration" => new MacOSCustomAppConfiguration(),
                "#microsoft.graph.macOSCustomConfiguration" => new MacOSCustomConfiguration(),
                "#microsoft.graph.macOSDeviceFeaturesConfiguration" => new MacOSDeviceFeaturesConfiguration(),
                "#microsoft.graph.macOSEndpointProtectionConfiguration" => new MacOSEndpointProtectionConfiguration(),
                "#microsoft.graph.macOSEnterpriseWiFiConfiguration" => new MacOSEnterpriseWiFiConfiguration(),
                "#microsoft.graph.macOSExtensionsConfiguration" => new MacOSExtensionsConfiguration(),
                "#microsoft.graph.macOSGeneralDeviceConfiguration" => new MacOSGeneralDeviceConfiguration(),
                "#microsoft.graph.macOSImportedPFXCertificateProfile" => new MacOSImportedPFXCertificateProfile(),
                "#microsoft.graph.macOSPkcsCertificateProfile" => new MacOSPkcsCertificateProfile(),
                "#microsoft.graph.macOSScepCertificateProfile" => new MacOSScepCertificateProfile(),
                "#microsoft.graph.macOSSoftwareUpdateConfiguration" => new MacOSSoftwareUpdateConfiguration(),
                "#microsoft.graph.macOSTrustedRootCertificate" => new MacOSTrustedRootCertificate(),
                "#microsoft.graph.macOSVpnConfiguration" => new MacOSVpnConfiguration(),
                "#microsoft.graph.macOSWiFiConfiguration" => new MacOSWiFiConfiguration(),
                "#microsoft.graph.macOSWiredNetworkConfiguration" => new MacOSWiredNetworkConfiguration(),
                "#microsoft.graph.sharedPCConfiguration" => new SharedPCConfiguration(),
                "#microsoft.graph.unsupportedDeviceConfiguration" => new UnsupportedDeviceConfiguration(),
                "#microsoft.graph.vpnConfiguration" => new VpnConfiguration(),
                "#microsoft.graph.windows10CertificateProfileBase" => new Windows10CertificateProfileBase(),
                "#microsoft.graph.windows10CustomConfiguration" => new Windows10CustomConfiguration(),
                "#microsoft.graph.windows10DeviceFirmwareConfigurationInterface" => new Windows10DeviceFirmwareConfigurationInterface(),
                "#microsoft.graph.windows10EasEmailProfileConfiguration" => new Windows10EasEmailProfileConfiguration(),
                "#microsoft.graph.windows10EndpointProtectionConfiguration" => new Windows10EndpointProtectionConfiguration(),
                "#microsoft.graph.windows10EnterpriseModernAppManagementConfiguration" => new Windows10EnterpriseModernAppManagementConfiguration(),
                "#microsoft.graph.windows10GeneralConfiguration" => new Windows10GeneralConfiguration(),
                "#microsoft.graph.windows10ImportedPFXCertificateProfile" => new Windows10ImportedPFXCertificateProfile(),
                "#microsoft.graph.windows10NetworkBoundaryConfiguration" => new Windows10NetworkBoundaryConfiguration(),
                "#microsoft.graph.windows10PFXImportCertificateProfile" => new Windows10PFXImportCertificateProfile(),
                "#microsoft.graph.windows10PkcsCertificateProfile" => new Windows10PkcsCertificateProfile(),
                "#microsoft.graph.windows10SecureAssessmentConfiguration" => new Windows10SecureAssessmentConfiguration(),
                "#microsoft.graph.windows10TeamGeneralConfiguration" => new Windows10TeamGeneralConfiguration(),
                "#microsoft.graph.windows10VpnConfiguration" => new Windows10VpnConfiguration(),
                "#microsoft.graph.windows81CertificateProfileBase" => new Windows81CertificateProfileBase(),
                "#microsoft.graph.windows81GeneralConfiguration" => new Windows81GeneralConfiguration(),
                "#microsoft.graph.windows81SCEPCertificateProfile" => new Windows81SCEPCertificateProfile(),
                "#microsoft.graph.windows81TrustedRootCertificate" => new Windows81TrustedRootCertificate(),
                "#microsoft.graph.windows81VpnConfiguration" => new Windows81VpnConfiguration(),
                "#microsoft.graph.windows81WifiImportConfiguration" => new Windows81WifiImportConfiguration(),
                "#microsoft.graph.windowsCertificateProfileBase" => new WindowsCertificateProfileBase(),
                "#microsoft.graph.windowsDefenderAdvancedThreatProtectionConfiguration" => new WindowsDefenderAdvancedThreatProtectionConfiguration(),
                "#microsoft.graph.windowsDeliveryOptimizationConfiguration" => new WindowsDeliveryOptimizationConfiguration(),
                "#microsoft.graph.windowsDomainJoinConfiguration" => new WindowsDomainJoinConfiguration(),
                "#microsoft.graph.windowsHealthMonitoringConfiguration" => new WindowsHealthMonitoringConfiguration(),
                "#microsoft.graph.windowsIdentityProtectionConfiguration" => new WindowsIdentityProtectionConfiguration(),
                "#microsoft.graph.windowsKioskConfiguration" => new WindowsKioskConfiguration(),
                "#microsoft.graph.windowsPhone81CertificateProfileBase" => new WindowsPhone81CertificateProfileBase(),
                "#microsoft.graph.windowsPhone81CustomConfiguration" => new WindowsPhone81CustomConfiguration(),
                "#microsoft.graph.windowsPhone81GeneralConfiguration" => new WindowsPhone81GeneralConfiguration(),
                "#microsoft.graph.windowsPhone81ImportedPFXCertificateProfile" => new WindowsPhone81ImportedPFXCertificateProfile(),
                "#microsoft.graph.windowsPhone81SCEPCertificateProfile" => new WindowsPhone81SCEPCertificateProfile(),
                "#microsoft.graph.windowsPhone81TrustedRootCertificate" => new WindowsPhone81TrustedRootCertificate(),
                "#microsoft.graph.windowsPhone81VpnConfiguration" => new WindowsPhone81VpnConfiguration(),
                "#microsoft.graph.windowsPhoneEASEmailProfileConfiguration" => new WindowsPhoneEASEmailProfileConfiguration(),
                "#microsoft.graph.windowsUpdateForBusinessConfiguration" => new WindowsUpdateForBusinessConfiguration(),
                "#microsoft.graph.windowsVpnConfiguration" => new WindowsVpnConfiguration(),
                "#microsoft.graph.windowsWifiConfiguration" => new WindowsWifiConfiguration(),
                "#microsoft.graph.windowsWifiEnterpriseEAPConfiguration" => new WindowsWifiEnterpriseEAPConfiguration(),
                "#microsoft.graph.windowsWiredNetworkConfiguration" => new WindowsWiredNetworkConfiguration(),
                _ => new DeviceConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceConfigurationAssignment>(DeviceConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceManagementApplicabilityRuleDeviceMode", n => { DeviceManagementApplicabilityRuleDeviceMode = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleDeviceMode>(Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleDeviceMode.CreateFromDiscriminatorValue); } },
                {"deviceManagementApplicabilityRuleOsEdition", n => { DeviceManagementApplicabilityRuleOsEdition = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsEdition>(Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsEdition.CreateFromDiscriminatorValue); } },
                {"deviceManagementApplicabilityRuleOsVersion", n => { DeviceManagementApplicabilityRuleOsVersion = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsVersion>(Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsVersion.CreateFromDiscriminatorValue); } },
                {"deviceSettingStateSummaries", n => { DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<SettingStateDeviceSummary>(SettingStateDeviceSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatuses", n => { DeviceStatuses = n.GetCollectionOfObjectValues<DeviceConfigurationDeviceStatus>(DeviceConfigurationDeviceStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceStatusOverview", n => { DeviceStatusOverview = n.GetObjectValue<DeviceConfigurationDeviceOverview>(DeviceConfigurationDeviceOverview.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"groupAssignments", n => { GroupAssignments = n.GetCollectionOfObjectValues<DeviceConfigurationGroupAssignment>(DeviceConfigurationGroupAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"supportsScopeTags", n => { SupportsScopeTags = n.GetBoolValue(); } },
                {"userStatuses", n => { UserStatuses = n.GetCollectionOfObjectValues<DeviceConfigurationUserStatus>(DeviceConfigurationUserStatus.CreateFromDiscriminatorValue).ToList(); } },
                {"userStatusOverview", n => { UserStatusOverview = n.GetObjectValue<DeviceConfigurationUserOverview>(DeviceConfigurationUserOverview.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleDeviceMode>("deviceManagementApplicabilityRuleDeviceMode", DeviceManagementApplicabilityRuleDeviceMode);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsEdition>("deviceManagementApplicabilityRuleOsEdition", DeviceManagementApplicabilityRuleOsEdition);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementApplicabilityRuleOsVersion>("deviceManagementApplicabilityRuleOsVersion", DeviceManagementApplicabilityRuleOsVersion);
            writer.WriteCollectionOfObjectValues<SettingStateDeviceSummary>("deviceSettingStateSummaries", DeviceSettingStateSummaries);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteObjectValue<DeviceConfigurationDeviceOverview>("deviceStatusOverview", DeviceStatusOverview);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationGroupAssignment>("groupAssignments", GroupAssignments);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteBoolValue("supportsScopeTags", SupportsScopeTags);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationUserStatus>("userStatuses", UserStatuses);
            writer.WriteObjectValue<DeviceConfigurationUserOverview>("userStatusOverview", UserStatusOverview);
            writer.WriteIntValue("version", Version);
        }
    }
}
