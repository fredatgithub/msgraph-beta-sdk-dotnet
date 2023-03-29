using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class ManagedTenant : Entity, IParsable {
        /// <summary>Aggregate view of device compliance policies across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AggregatedPolicyCompliance>? AggregatedPolicyCompliances {
            get { return BackingStore?.Get<List<AggregatedPolicyCompliance>?>("aggregatedPolicyCompliances"); }
            set { BackingStore?.Set("aggregatedPolicyCompliances", value); }
        }
#nullable restore
#else
        public List<AggregatedPolicyCompliance> AggregatedPolicyCompliances {
            get { return BackingStore?.Get<List<AggregatedPolicyCompliance>>("aggregatedPolicyCompliances"); }
            set { BackingStore?.Set("aggregatedPolicyCompliances", value); }
        }
#endif
        /// <summary>The appPerformances property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppPerformance>? AppPerformances {
            get { return BackingStore?.Get<List<AppPerformance>?>("appPerformances"); }
            set { BackingStore?.Set("appPerformances", value); }
        }
#nullable restore
#else
        public List<AppPerformance> AppPerformances {
            get { return BackingStore?.Get<List<AppPerformance>>("appPerformances"); }
            set { BackingStore?.Set("appPerformances", value); }
        }
#endif
        /// <summary>The collection of audit events across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuditEvent>? AuditEvents {
            get { return BackingStore?.Get<List<AuditEvent>?>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
#nullable restore
#else
        public List<AuditEvent> AuditEvents {
            get { return BackingStore?.Get<List<AuditEvent>>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
#endif
        /// <summary>The collection of cloud PC connections across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcConnection>? CloudPcConnections {
            get { return BackingStore?.Get<List<CloudPcConnection>?>("cloudPcConnections"); }
            set { BackingStore?.Set("cloudPcConnections", value); }
        }
#nullable restore
#else
        public List<CloudPcConnection> CloudPcConnections {
            get { return BackingStore?.Get<List<CloudPcConnection>>("cloudPcConnections"); }
            set { BackingStore?.Set("cloudPcConnections", value); }
        }
#endif
        /// <summary>The collection of cloud PC devices across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcDevice>? CloudPcDevices {
            get { return BackingStore?.Get<List<CloudPcDevice>?>("cloudPcDevices"); }
            set { BackingStore?.Set("cloudPcDevices", value); }
        }
#nullable restore
#else
        public List<CloudPcDevice> CloudPcDevices {
            get { return BackingStore?.Get<List<CloudPcDevice>>("cloudPcDevices"); }
            set { BackingStore?.Set("cloudPcDevices", value); }
        }
#endif
        /// <summary>Overview of cloud PC information across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CloudPcOverview>? CloudPcsOverview {
            get { return BackingStore?.Get<List<CloudPcOverview>?>("cloudPcsOverview"); }
            set { BackingStore?.Set("cloudPcsOverview", value); }
        }
#nullable restore
#else
        public List<CloudPcOverview> CloudPcsOverview {
            get { return BackingStore?.Get<List<CloudPcOverview>>("cloudPcsOverview"); }
            set { BackingStore?.Set("cloudPcsOverview", value); }
        }
#endif
        /// <summary>Aggregate view of conditional access policy coverage across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConditionalAccessPolicyCoverage>? ConditionalAccessPolicyCoverages {
            get { return BackingStore?.Get<List<ConditionalAccessPolicyCoverage>?>("conditionalAccessPolicyCoverages"); }
            set { BackingStore?.Set("conditionalAccessPolicyCoverages", value); }
        }
#nullable restore
#else
        public List<ConditionalAccessPolicyCoverage> ConditionalAccessPolicyCoverages {
            get { return BackingStore?.Get<List<ConditionalAccessPolicyCoverage>>("conditionalAccessPolicyCoverages"); }
            set { BackingStore?.Set("conditionalAccessPolicyCoverages", value); }
        }
#endif
        /// <summary>Summary information for user registration for multi-factor authentication and self service password reset across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CredentialUserRegistrationsSummary>? CredentialUserRegistrationsSummaries {
            get { return BackingStore?.Get<List<CredentialUserRegistrationsSummary>?>("credentialUserRegistrationsSummaries"); }
            set { BackingStore?.Set("credentialUserRegistrationsSummaries", value); }
        }
#nullable restore
#else
        public List<CredentialUserRegistrationsSummary> CredentialUserRegistrationsSummaries {
            get { return BackingStore?.Get<List<CredentialUserRegistrationsSummary>>("credentialUserRegistrationsSummaries"); }
            set { BackingStore?.Set("credentialUserRegistrationsSummaries", value); }
        }
#endif
        /// <summary>The deviceAppPerformances property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceAppPerformance>? DeviceAppPerformances {
            get { return BackingStore?.Get<List<DeviceAppPerformance>?>("deviceAppPerformances"); }
            set { BackingStore?.Set("deviceAppPerformances", value); }
        }
#nullable restore
#else
        public List<DeviceAppPerformance> DeviceAppPerformances {
            get { return BackingStore?.Get<List<DeviceAppPerformance>>("deviceAppPerformances"); }
            set { BackingStore?.Set("deviceAppPerformances", value); }
        }
#endif
        /// <summary>Summary information for device compliance policy setting states across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCompliancePolicySettingStateSummary>? DeviceCompliancePolicySettingStateSummaries {
            get { return BackingStore?.Get<List<DeviceCompliancePolicySettingStateSummary>?>("deviceCompliancePolicySettingStateSummaries"); }
            set { BackingStore?.Set("deviceCompliancePolicySettingStateSummaries", value); }
        }
#nullable restore
#else
        public List<DeviceCompliancePolicySettingStateSummary> DeviceCompliancePolicySettingStateSummaries {
            get { return BackingStore?.Get<List<DeviceCompliancePolicySettingStateSummary>>("deviceCompliancePolicySettingStateSummaries"); }
            set { BackingStore?.Set("deviceCompliancePolicySettingStateSummaries", value); }
        }
#endif
        /// <summary>The deviceHealthStatuses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceHealthStatus>? DeviceHealthStatuses {
            get { return BackingStore?.Get<List<DeviceHealthStatus>?>("deviceHealthStatuses"); }
            set { BackingStore?.Set("deviceHealthStatuses", value); }
        }
#nullable restore
#else
        public List<DeviceHealthStatus> DeviceHealthStatuses {
            get { return BackingStore?.Get<List<DeviceHealthStatus>>("deviceHealthStatuses"); }
            set { BackingStore?.Set("deviceHealthStatuses", value); }
        }
#endif
        /// <summary>The collection of compliance for managed devices across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedDeviceCompliance>? ManagedDeviceCompliances {
            get { return BackingStore?.Get<List<ManagedDeviceCompliance>?>("managedDeviceCompliances"); }
            set { BackingStore?.Set("managedDeviceCompliances", value); }
        }
#nullable restore
#else
        public List<ManagedDeviceCompliance> ManagedDeviceCompliances {
            get { return BackingStore?.Get<List<ManagedDeviceCompliance>>("managedDeviceCompliances"); }
            set { BackingStore?.Set("managedDeviceCompliances", value); }
        }
#endif
        /// <summary>Trend insights for device compliance across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedDeviceComplianceTrend>? ManagedDeviceComplianceTrends {
            get { return BackingStore?.Get<List<ManagedDeviceComplianceTrend>?>("managedDeviceComplianceTrends"); }
            set { BackingStore?.Set("managedDeviceComplianceTrends", value); }
        }
#nullable restore
#else
        public List<ManagedDeviceComplianceTrend> ManagedDeviceComplianceTrends {
            get { return BackingStore?.Get<List<ManagedDeviceComplianceTrend>>("managedDeviceComplianceTrends"); }
            set { BackingStore?.Set("managedDeviceComplianceTrends", value); }
        }
#endif
        /// <summary>The managedTenantAlertLogs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedTenantAlertLog>? ManagedTenantAlertLogs {
            get { return BackingStore?.Get<List<ManagedTenantAlertLog>?>("managedTenantAlertLogs"); }
            set { BackingStore?.Set("managedTenantAlertLogs", value); }
        }
#nullable restore
#else
        public List<ManagedTenantAlertLog> ManagedTenantAlertLogs {
            get { return BackingStore?.Get<List<ManagedTenantAlertLog>>("managedTenantAlertLogs"); }
            set { BackingStore?.Set("managedTenantAlertLogs", value); }
        }
#endif
        /// <summary>The managedTenantAlertRuleDefinitions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedTenantAlertRuleDefinition>? ManagedTenantAlertRuleDefinitions {
            get { return BackingStore?.Get<List<ManagedTenantAlertRuleDefinition>?>("managedTenantAlertRuleDefinitions"); }
            set { BackingStore?.Set("managedTenantAlertRuleDefinitions", value); }
        }
#nullable restore
#else
        public List<ManagedTenantAlertRuleDefinition> ManagedTenantAlertRuleDefinitions {
            get { return BackingStore?.Get<List<ManagedTenantAlertRuleDefinition>>("managedTenantAlertRuleDefinitions"); }
            set { BackingStore?.Set("managedTenantAlertRuleDefinitions", value); }
        }
#endif
        /// <summary>The managedTenantAlertRules property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedTenantAlertRule>? ManagedTenantAlertRules {
            get { return BackingStore?.Get<List<ManagedTenantAlertRule>?>("managedTenantAlertRules"); }
            set { BackingStore?.Set("managedTenantAlertRules", value); }
        }
#nullable restore
#else
        public List<ManagedTenantAlertRule> ManagedTenantAlertRules {
            get { return BackingStore?.Get<List<ManagedTenantAlertRule>>("managedTenantAlertRules"); }
            set { BackingStore?.Set("managedTenantAlertRules", value); }
        }
#endif
        /// <summary>The managedTenantAlerts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedTenantAlert>? ManagedTenantAlerts {
            get { return BackingStore?.Get<List<ManagedTenantAlert>?>("managedTenantAlerts"); }
            set { BackingStore?.Set("managedTenantAlerts", value); }
        }
#nullable restore
#else
        public List<ManagedTenantAlert> ManagedTenantAlerts {
            get { return BackingStore?.Get<List<ManagedTenantAlert>>("managedTenantAlerts"); }
            set { BackingStore?.Set("managedTenantAlerts", value); }
        }
#endif
        /// <summary>The managedTenantApiNotifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedTenantApiNotification>? ManagedTenantApiNotifications {
            get { return BackingStore?.Get<List<ManagedTenantApiNotification>?>("managedTenantApiNotifications"); }
            set { BackingStore?.Set("managedTenantApiNotifications", value); }
        }
#nullable restore
#else
        public List<ManagedTenantApiNotification> ManagedTenantApiNotifications {
            get { return BackingStore?.Get<List<ManagedTenantApiNotification>>("managedTenantApiNotifications"); }
            set { BackingStore?.Set("managedTenantApiNotifications", value); }
        }
#endif
        /// <summary>The managedTenantEmailNotifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedTenantEmailNotification>? ManagedTenantEmailNotifications {
            get { return BackingStore?.Get<List<ManagedTenantEmailNotification>?>("managedTenantEmailNotifications"); }
            set { BackingStore?.Set("managedTenantEmailNotifications", value); }
        }
#nullable restore
#else
        public List<ManagedTenantEmailNotification> ManagedTenantEmailNotifications {
            get { return BackingStore?.Get<List<ManagedTenantEmailNotification>>("managedTenantEmailNotifications"); }
            set { BackingStore?.Set("managedTenantEmailNotifications", value); }
        }
#endif
        /// <summary>The managedTenantTicketingEndpoints property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedTenantTicketingEndpoint>? ManagedTenantTicketingEndpoints {
            get { return BackingStore?.Get<List<ManagedTenantTicketingEndpoint>?>("managedTenantTicketingEndpoints"); }
            set { BackingStore?.Set("managedTenantTicketingEndpoints", value); }
        }
#nullable restore
#else
        public List<ManagedTenantTicketingEndpoint> ManagedTenantTicketingEndpoints {
            get { return BackingStore?.Get<List<ManagedTenantTicketingEndpoint>>("managedTenantTicketingEndpoints"); }
            set { BackingStore?.Set("managedTenantTicketingEndpoints", value); }
        }
#endif
        /// <summary>The collection of baseline management actions across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementAction>? ManagementActions {
            get { return BackingStore?.Get<List<ManagementAction>?>("managementActions"); }
            set { BackingStore?.Set("managementActions", value); }
        }
#nullable restore
#else
        public List<ManagementAction> ManagementActions {
            get { return BackingStore?.Get<List<ManagementAction>>("managementActions"); }
            set { BackingStore?.Set("managementActions", value); }
        }
#endif
        /// <summary>The tenant level status of management actions across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementActionTenantDeploymentStatus>? ManagementActionTenantDeploymentStatuses {
            get { return BackingStore?.Get<List<ManagementActionTenantDeploymentStatus>?>("managementActionTenantDeploymentStatuses"); }
            set { BackingStore?.Set("managementActionTenantDeploymentStatuses", value); }
        }
#nullable restore
#else
        public List<ManagementActionTenantDeploymentStatus> ManagementActionTenantDeploymentStatuses {
            get { return BackingStore?.Get<List<ManagementActionTenantDeploymentStatus>>("managementActionTenantDeploymentStatuses"); }
            set { BackingStore?.Set("managementActionTenantDeploymentStatuses", value); }
        }
#endif
        /// <summary>The collection of baseline management intents across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementIntent>? ManagementIntents {
            get { return BackingStore?.Get<List<ManagementIntent>?>("managementIntents"); }
            set { BackingStore?.Set("managementIntents", value); }
        }
#nullable restore
#else
        public List<ManagementIntent> ManagementIntents {
            get { return BackingStore?.Get<List<ManagementIntent>>("managementIntents"); }
            set { BackingStore?.Set("managementIntents", value); }
        }
#endif
        /// <summary>The managementTemplateCollections property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementTemplateCollection>? ManagementTemplateCollections {
            get { return BackingStore?.Get<List<ManagementTemplateCollection>?>("managementTemplateCollections"); }
            set { BackingStore?.Set("managementTemplateCollections", value); }
        }
#nullable restore
#else
        public List<ManagementTemplateCollection> ManagementTemplateCollections {
            get { return BackingStore?.Get<List<ManagementTemplateCollection>>("managementTemplateCollections"); }
            set { BackingStore?.Set("managementTemplateCollections", value); }
        }
#endif
        /// <summary>The managementTemplateCollectionTenantSummaries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementTemplateCollectionTenantSummary>? ManagementTemplateCollectionTenantSummaries {
            get { return BackingStore?.Get<List<ManagementTemplateCollectionTenantSummary>?>("managementTemplateCollectionTenantSummaries"); }
            set { BackingStore?.Set("managementTemplateCollectionTenantSummaries", value); }
        }
#nullable restore
#else
        public List<ManagementTemplateCollectionTenantSummary> ManagementTemplateCollectionTenantSummaries {
            get { return BackingStore?.Get<List<ManagementTemplateCollectionTenantSummary>>("managementTemplateCollectionTenantSummaries"); }
            set { BackingStore?.Set("managementTemplateCollectionTenantSummaries", value); }
        }
#endif
        /// <summary>The collection of baseline management templates across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementTemplate>? ManagementTemplates {
            get { return BackingStore?.Get<List<ManagementTemplate>?>("managementTemplates"); }
            set { BackingStore?.Set("managementTemplates", value); }
        }
#nullable restore
#else
        public List<ManagementTemplate> ManagementTemplates {
            get { return BackingStore?.Get<List<ManagementTemplate>>("managementTemplates"); }
            set { BackingStore?.Set("managementTemplates", value); }
        }
#endif
        /// <summary>The managementTemplateSteps property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementTemplateStep>? ManagementTemplateSteps {
            get { return BackingStore?.Get<List<ManagementTemplateStep>?>("managementTemplateSteps"); }
            set { BackingStore?.Set("managementTemplateSteps", value); }
        }
#nullable restore
#else
        public List<ManagementTemplateStep> ManagementTemplateSteps {
            get { return BackingStore?.Get<List<ManagementTemplateStep>>("managementTemplateSteps"); }
            set { BackingStore?.Set("managementTemplateSteps", value); }
        }
#endif
        /// <summary>The managementTemplateStepTenantSummaries property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementTemplateStepTenantSummary>? ManagementTemplateStepTenantSummaries {
            get { return BackingStore?.Get<List<ManagementTemplateStepTenantSummary>?>("managementTemplateStepTenantSummaries"); }
            set { BackingStore?.Set("managementTemplateStepTenantSummaries", value); }
        }
#nullable restore
#else
        public List<ManagementTemplateStepTenantSummary> ManagementTemplateStepTenantSummaries {
            get { return BackingStore?.Get<List<ManagementTemplateStepTenantSummary>>("managementTemplateStepTenantSummaries"); }
            set { BackingStore?.Set("managementTemplateStepTenantSummaries", value); }
        }
#endif
        /// <summary>The managementTemplateStepVersions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagementTemplateStepVersion>? ManagementTemplateStepVersions {
            get { return BackingStore?.Get<List<ManagementTemplateStepVersion>?>("managementTemplateStepVersions"); }
            set { BackingStore?.Set("managementTemplateStepVersions", value); }
        }
#nullable restore
#else
        public List<ManagementTemplateStepVersion> ManagementTemplateStepVersions {
            get { return BackingStore?.Get<List<ManagementTemplateStepVersion>>("managementTemplateStepVersions"); }
            set { BackingStore?.Set("managementTemplateStepVersions", value); }
        }
#endif
        /// <summary>The collection of role assignments to a signed-in user for a managed tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MyRole>? MyRoles {
            get { return BackingStore?.Get<List<MyRole>?>("myRoles"); }
            set { BackingStore?.Set("myRoles", value); }
        }
#nullable restore
#else
        public List<MyRole> MyRoles {
            get { return BackingStore?.Get<List<MyRole>>("myRoles"); }
            set { BackingStore?.Set("myRoles", value); }
        }
#endif
        /// <summary>The collection of a logical grouping of managed tenants used by the multi-tenant management platform.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TenantGroup>? TenantGroups {
            get { return BackingStore?.Get<List<TenantGroup>?>("tenantGroups"); }
            set { BackingStore?.Set("tenantGroups", value); }
        }
#nullable restore
#else
        public List<TenantGroup> TenantGroups {
            get { return BackingStore?.Get<List<TenantGroup>>("tenantGroups"); }
            set { BackingStore?.Set("tenantGroups", value); }
        }
#endif
        /// <summary>The collection of tenants associated with the managing entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Tenant>? Tenants {
            get { return BackingStore?.Get<List<Tenant>?>("tenants"); }
            set { BackingStore?.Set("tenants", value); }
        }
#nullable restore
#else
        public List<Tenant> Tenants {
            get { return BackingStore?.Get<List<Tenant>>("tenants"); }
            set { BackingStore?.Set("tenants", value); }
        }
#endif
        /// <summary>The collection of tenant level customized information across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TenantCustomizedInformation>? TenantsCustomizedInformation {
            get { return BackingStore?.Get<List<TenantCustomizedInformation>?>("tenantsCustomizedInformation"); }
            set { BackingStore?.Set("tenantsCustomizedInformation", value); }
        }
#nullable restore
#else
        public List<TenantCustomizedInformation> TenantsCustomizedInformation {
            get { return BackingStore?.Get<List<TenantCustomizedInformation>>("tenantsCustomizedInformation"); }
            set { BackingStore?.Set("tenantsCustomizedInformation", value); }
        }
#endif
        /// <summary>The collection tenant level detailed information across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TenantDetailedInformation>? TenantsDetailedInformation {
            get { return BackingStore?.Get<List<TenantDetailedInformation>?>("tenantsDetailedInformation"); }
            set { BackingStore?.Set("tenantsDetailedInformation", value); }
        }
#nullable restore
#else
        public List<TenantDetailedInformation> TenantsDetailedInformation {
            get { return BackingStore?.Get<List<TenantDetailedInformation>>("tenantsDetailedInformation"); }
            set { BackingStore?.Set("tenantsDetailedInformation", value); }
        }
#endif
        /// <summary>The collection of tenant tags across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TenantTag>? TenantTags {
            get { return BackingStore?.Get<List<TenantTag>?>("tenantTags"); }
            set { BackingStore?.Set("tenantTags", value); }
        }
#nullable restore
#else
        public List<TenantTag> TenantTags {
            get { return BackingStore?.Get<List<TenantTag>>("tenantTags"); }
            set { BackingStore?.Set("tenantTags", value); }
        }
#endif
        /// <summary>The state of malware for Windows devices, registered with Microsoft Endpoint Manager, across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsDeviceMalwareState>? WindowsDeviceMalwareStates {
            get { return BackingStore?.Get<List<WindowsDeviceMalwareState>?>("windowsDeviceMalwareStates"); }
            set { BackingStore?.Set("windowsDeviceMalwareStates", value); }
        }
#nullable restore
#else
        public List<WindowsDeviceMalwareState> WindowsDeviceMalwareStates {
            get { return BackingStore?.Get<List<WindowsDeviceMalwareState>>("windowsDeviceMalwareStates"); }
            set { BackingStore?.Set("windowsDeviceMalwareStates", value); }
        }
#endif
        /// <summary>The protection state for Windows devices, registered with Microsoft Endpoint Manager, across managed tenants.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsProtectionState>? WindowsProtectionStates {
            get { return BackingStore?.Get<List<WindowsProtectionState>?>("windowsProtectionStates"); }
            set { BackingStore?.Set("windowsProtectionStates", value); }
        }
#nullable restore
#else
        public List<WindowsProtectionState> WindowsProtectionStates {
            get { return BackingStore?.Get<List<WindowsProtectionState>>("windowsProtectionStates"); }
            set { BackingStore?.Set("windowsProtectionStates", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedTenant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedTenant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"aggregatedPolicyCompliances", n => { AggregatedPolicyCompliances = n.GetCollectionOfObjectValues<AggregatedPolicyCompliance>(AggregatedPolicyCompliance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"appPerformances", n => { AppPerformances = n.GetCollectionOfObjectValues<AppPerformance>(AppPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<AuditEvent>(AuditEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cloudPcConnections", n => { CloudPcConnections = n.GetCollectionOfObjectValues<CloudPcConnection>(CloudPcConnection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cloudPcDevices", n => { CloudPcDevices = n.GetCollectionOfObjectValues<CloudPcDevice>(CloudPcDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cloudPcsOverview", n => { CloudPcsOverview = n.GetCollectionOfObjectValues<CloudPcOverview>(CloudPcOverview.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditionalAccessPolicyCoverages", n => { ConditionalAccessPolicyCoverages = n.GetCollectionOfObjectValues<ConditionalAccessPolicyCoverage>(ConditionalAccessPolicyCoverage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"credentialUserRegistrationsSummaries", n => { CredentialUserRegistrationsSummaries = n.GetCollectionOfObjectValues<CredentialUserRegistrationsSummary>(CredentialUserRegistrationsSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceAppPerformances", n => { DeviceAppPerformances = n.GetCollectionOfObjectValues<DeviceAppPerformance>(DeviceAppPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCompliancePolicySettingStateSummaries", n => { DeviceCompliancePolicySettingStateSummaries = n.GetCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>(DeviceCompliancePolicySettingStateSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceHealthStatuses", n => { DeviceHealthStatuses = n.GetCollectionOfObjectValues<DeviceHealthStatus>(DeviceHealthStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedDeviceCompliances", n => { ManagedDeviceCompliances = n.GetCollectionOfObjectValues<ManagedDeviceCompliance>(ManagedDeviceCompliance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedDeviceComplianceTrends", n => { ManagedDeviceComplianceTrends = n.GetCollectionOfObjectValues<ManagedDeviceComplianceTrend>(ManagedDeviceComplianceTrend.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantAlertLogs", n => { ManagedTenantAlertLogs = n.GetCollectionOfObjectValues<ManagedTenantAlertLog>(ManagedTenantAlertLog.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantAlertRuleDefinitions", n => { ManagedTenantAlertRuleDefinitions = n.GetCollectionOfObjectValues<ManagedTenantAlertRuleDefinition>(ManagedTenantAlertRuleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantAlertRules", n => { ManagedTenantAlertRules = n.GetCollectionOfObjectValues<ManagedTenantAlertRule>(ManagedTenantAlertRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantAlerts", n => { ManagedTenantAlerts = n.GetCollectionOfObjectValues<ManagedTenantAlert>(ManagedTenantAlert.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantApiNotifications", n => { ManagedTenantApiNotifications = n.GetCollectionOfObjectValues<ManagedTenantApiNotification>(ManagedTenantApiNotification.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantEmailNotifications", n => { ManagedTenantEmailNotifications = n.GetCollectionOfObjectValues<ManagedTenantEmailNotification>(ManagedTenantEmailNotification.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenantTicketingEndpoints", n => { ManagedTenantTicketingEndpoints = n.GetCollectionOfObjectValues<ManagedTenantTicketingEndpoint>(ManagedTenantTicketingEndpoint.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementActions", n => { ManagementActions = n.GetCollectionOfObjectValues<ManagementAction>(ManagementAction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementActionTenantDeploymentStatuses", n => { ManagementActionTenantDeploymentStatuses = n.GetCollectionOfObjectValues<ManagementActionTenantDeploymentStatus>(ManagementActionTenantDeploymentStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementIntents", n => { ManagementIntents = n.GetCollectionOfObjectValues<ManagementIntent>(ManagementIntent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementTemplateCollections", n => { ManagementTemplateCollections = n.GetCollectionOfObjectValues<ManagementTemplateCollection>(ManagementTemplateCollection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementTemplateCollectionTenantSummaries", n => { ManagementTemplateCollectionTenantSummaries = n.GetCollectionOfObjectValues<ManagementTemplateCollectionTenantSummary>(ManagementTemplateCollectionTenantSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementTemplates", n => { ManagementTemplates = n.GetCollectionOfObjectValues<ManagementTemplate>(ManagementTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementTemplateSteps", n => { ManagementTemplateSteps = n.GetCollectionOfObjectValues<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementTemplateStepTenantSummaries", n => { ManagementTemplateStepTenantSummaries = n.GetCollectionOfObjectValues<ManagementTemplateStepTenantSummary>(ManagementTemplateStepTenantSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managementTemplateStepVersions", n => { ManagementTemplateStepVersions = n.GetCollectionOfObjectValues<ManagementTemplateStepVersion>(ManagementTemplateStepVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"myRoles", n => { MyRoles = n.GetCollectionOfObjectValues<MyRole>(MyRole.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantGroups", n => { TenantGroups = n.GetCollectionOfObjectValues<TenantGroup>(TenantGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenants", n => { Tenants = n.GetCollectionOfObjectValues<Tenant>(Tenant.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantsCustomizedInformation", n => { TenantsCustomizedInformation = n.GetCollectionOfObjectValues<TenantCustomizedInformation>(TenantCustomizedInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantsDetailedInformation", n => { TenantsDetailedInformation = n.GetCollectionOfObjectValues<TenantDetailedInformation>(TenantDetailedInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantTags", n => { TenantTags = n.GetCollectionOfObjectValues<TenantTag>(TenantTag.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsDeviceMalwareStates", n => { WindowsDeviceMalwareStates = n.GetCollectionOfObjectValues<WindowsDeviceMalwareState>(WindowsDeviceMalwareState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsProtectionStates", n => { WindowsProtectionStates = n.GetCollectionOfObjectValues<WindowsProtectionState>(WindowsProtectionState.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AggregatedPolicyCompliance>("aggregatedPolicyCompliances", AggregatedPolicyCompliances);
            writer.WriteCollectionOfObjectValues<AppPerformance>("appPerformances", AppPerformances);
            writer.WriteCollectionOfObjectValues<AuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<CloudPcConnection>("cloudPcConnections", CloudPcConnections);
            writer.WriteCollectionOfObjectValues<CloudPcDevice>("cloudPcDevices", CloudPcDevices);
            writer.WriteCollectionOfObjectValues<CloudPcOverview>("cloudPcsOverview", CloudPcsOverview);
            writer.WriteCollectionOfObjectValues<ConditionalAccessPolicyCoverage>("conditionalAccessPolicyCoverages", ConditionalAccessPolicyCoverages);
            writer.WriteCollectionOfObjectValues<CredentialUserRegistrationsSummary>("credentialUserRegistrationsSummaries", CredentialUserRegistrationsSummaries);
            writer.WriteCollectionOfObjectValues<DeviceAppPerformance>("deviceAppPerformances", DeviceAppPerformances);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>("deviceCompliancePolicySettingStateSummaries", DeviceCompliancePolicySettingStateSummaries);
            writer.WriteCollectionOfObjectValues<DeviceHealthStatus>("deviceHealthStatuses", DeviceHealthStatuses);
            writer.WriteCollectionOfObjectValues<ManagedDeviceCompliance>("managedDeviceCompliances", ManagedDeviceCompliances);
            writer.WriteCollectionOfObjectValues<ManagedDeviceComplianceTrend>("managedDeviceComplianceTrends", ManagedDeviceComplianceTrends);
            writer.WriteCollectionOfObjectValues<ManagedTenantAlertLog>("managedTenantAlertLogs", ManagedTenantAlertLogs);
            writer.WriteCollectionOfObjectValues<ManagedTenantAlertRuleDefinition>("managedTenantAlertRuleDefinitions", ManagedTenantAlertRuleDefinitions);
            writer.WriteCollectionOfObjectValues<ManagedTenantAlertRule>("managedTenantAlertRules", ManagedTenantAlertRules);
            writer.WriteCollectionOfObjectValues<ManagedTenantAlert>("managedTenantAlerts", ManagedTenantAlerts);
            writer.WriteCollectionOfObjectValues<ManagedTenantApiNotification>("managedTenantApiNotifications", ManagedTenantApiNotifications);
            writer.WriteCollectionOfObjectValues<ManagedTenantEmailNotification>("managedTenantEmailNotifications", ManagedTenantEmailNotifications);
            writer.WriteCollectionOfObjectValues<ManagedTenantTicketingEndpoint>("managedTenantTicketingEndpoints", ManagedTenantTicketingEndpoints);
            writer.WriteCollectionOfObjectValues<ManagementAction>("managementActions", ManagementActions);
            writer.WriteCollectionOfObjectValues<ManagementActionTenantDeploymentStatus>("managementActionTenantDeploymentStatuses", ManagementActionTenantDeploymentStatuses);
            writer.WriteCollectionOfObjectValues<ManagementIntent>("managementIntents", ManagementIntents);
            writer.WriteCollectionOfObjectValues<ManagementTemplateCollection>("managementTemplateCollections", ManagementTemplateCollections);
            writer.WriteCollectionOfObjectValues<ManagementTemplateCollectionTenantSummary>("managementTemplateCollectionTenantSummaries", ManagementTemplateCollectionTenantSummaries);
            writer.WriteCollectionOfObjectValues<ManagementTemplate>("managementTemplates", ManagementTemplates);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStep>("managementTemplateSteps", ManagementTemplateSteps);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStepTenantSummary>("managementTemplateStepTenantSummaries", ManagementTemplateStepTenantSummaries);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStepVersion>("managementTemplateStepVersions", ManagementTemplateStepVersions);
            writer.WriteCollectionOfObjectValues<MyRole>("myRoles", MyRoles);
            writer.WriteCollectionOfObjectValues<TenantGroup>("tenantGroups", TenantGroups);
            writer.WriteCollectionOfObjectValues<Tenant>("tenants", Tenants);
            writer.WriteCollectionOfObjectValues<TenantCustomizedInformation>("tenantsCustomizedInformation", TenantsCustomizedInformation);
            writer.WriteCollectionOfObjectValues<TenantDetailedInformation>("tenantsDetailedInformation", TenantsDetailedInformation);
            writer.WriteCollectionOfObjectValues<TenantTag>("tenantTags", TenantTags);
            writer.WriteCollectionOfObjectValues<WindowsDeviceMalwareState>("windowsDeviceMalwareStates", WindowsDeviceMalwareStates);
            writer.WriteCollectionOfObjectValues<WindowsProtectionState>("windowsProtectionStates", WindowsProtectionStates);
        }
    }
}
