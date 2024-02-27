// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class NetworkAccessRoot : Microsoft.Graph.Beta.Models.Entity, IParsable {
        /// <summary>The alerts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Alert>? Alerts {
            get { return BackingStore?.Get<List<Alert>?>("alerts"); }
            set { BackingStore?.Set("alerts", value); }
        }
#nullable restore
#else
        public List<Alert> Alerts {
            get { return BackingStore?.Get<List<Alert>>("alerts"); }
            set { BackingStore?.Set("alerts", value); }
        }
#endif
        /// <summary>Connectivity represents all the connectivity components in Global Secure Access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.Connectivity? Connectivity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Connectivity?>("connectivity"); }
            set { BackingStore?.Set("connectivity", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.Connectivity Connectivity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Connectivity>("connectivity"); }
            set { BackingStore?.Set("connectivity", value); }
        }
#endif
        /// <summary>A filtering policy defines the specific traffic that is allowed or blocked through the Global Secure Access services for a filtering profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FilteringPolicy>? FilteringPolicies {
            get { return BackingStore?.Get<List<FilteringPolicy>?>("filteringPolicies"); }
            set { BackingStore?.Set("filteringPolicies", value); }
        }
#nullable restore
#else
        public List<FilteringPolicy> FilteringPolicies {
            get { return BackingStore?.Get<List<FilteringPolicy>>("filteringPolicies"); }
            set { BackingStore?.Set("filteringPolicies", value); }
        }
#endif
        /// <summary>A filtering profile associates network access policies with Microsoft Entra ID Conditional Access policies, so that access policies can be applied to users and groups.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FilteringProfile>? FilteringProfiles {
            get { return BackingStore?.Get<List<FilteringProfile>?>("filteringProfiles"); }
            set { BackingStore?.Set("filteringProfiles", value); }
        }
#nullable restore
#else
        public List<FilteringProfile> FilteringProfiles {
            get { return BackingStore?.Get<List<FilteringProfile>>("filteringProfiles"); }
            set { BackingStore?.Set("filteringProfiles", value); }
        }
#endif
        /// <summary>A forwarding policy defines the specific traffic that is routed through the Global Secure Access Service. It&apos;s then added to a forwarding profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ForwardingPolicy>? ForwardingPolicies {
            get { return BackingStore?.Get<List<ForwardingPolicy>?>("forwardingPolicies"); }
            set { BackingStore?.Set("forwardingPolicies", value); }
        }
#nullable restore
#else
        public List<ForwardingPolicy> ForwardingPolicies {
            get { return BackingStore?.Get<List<ForwardingPolicy>>("forwardingPolicies"); }
            set { BackingStore?.Set("forwardingPolicies", value); }
        }
#endif
        /// <summary>A forwarding profile determines which types of traffic are routed through the Global Secure Access services and which ones are skipped. The handling of specific traffic is determined by the forwarding policies that are added to the forwarding profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ForwardingProfile>? ForwardingProfiles {
            get { return BackingStore?.Get<List<ForwardingProfile>?>("forwardingProfiles"); }
            set { BackingStore?.Set("forwardingProfiles", value); }
        }
#nullable restore
#else
        public List<ForwardingProfile> ForwardingProfiles {
            get { return BackingStore?.Get<List<ForwardingProfile>>("forwardingProfiles"); }
            set { BackingStore?.Set("forwardingProfiles", value); }
        }
#endif
        /// <summary>Represents network connections that are routed through Global Secure Access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.Logs? Logs {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Logs?>("logs"); }
            set { BackingStore?.Set("logs", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.Logs Logs {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Logs>("logs"); }
            set { BackingStore?.Set("logs", value); }
        }
#endif
        /// <summary>Represents the status of the Global Secure Access services for the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.Reports? Reports {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Reports?>("reports"); }
            set { BackingStore?.Set("reports", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.Reports Reports {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Reports>("reports"); }
            set { BackingStore?.Set("reports", value); }
        }
#endif
        /// <summary>Global Secure Access settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.Settings? Settings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Settings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.Settings Settings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.Settings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>Represents the status of the Global Secure Access services for the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus? TenantStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus?>("tenantStatus"); }
            set { BackingStore?.Set("tenantStatus", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus TenantStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus>("tenantStatus"); }
            set { BackingStore?.Set("tenantStatus", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="NetworkAccessRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new NetworkAccessRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NetworkAccessRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alerts", n => { Alerts = n.GetCollectionOfObjectValues<Alert>(Alert.CreateFromDiscriminatorValue)?.ToList(); } },
                {"connectivity", n => { Connectivity = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Connectivity>(Microsoft.Graph.Beta.Models.Networkaccess.Connectivity.CreateFromDiscriminatorValue); } },
                {"filteringPolicies", n => { FilteringPolicies = n.GetCollectionOfObjectValues<FilteringPolicy>(FilteringPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"filteringProfiles", n => { FilteringProfiles = n.GetCollectionOfObjectValues<FilteringProfile>(FilteringProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"forwardingPolicies", n => { ForwardingPolicies = n.GetCollectionOfObjectValues<ForwardingPolicy>(ForwardingPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"forwardingProfiles", n => { ForwardingProfiles = n.GetCollectionOfObjectValues<ForwardingProfile>(ForwardingProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"logs", n => { Logs = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Logs>(Microsoft.Graph.Beta.Models.Networkaccess.Logs.CreateFromDiscriminatorValue); } },
                {"reports", n => { Reports = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Reports>(Microsoft.Graph.Beta.Models.Networkaccess.Reports.CreateFromDiscriminatorValue); } },
                {"settings", n => { Settings = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Settings>(Microsoft.Graph.Beta.Models.Networkaccess.Settings.CreateFromDiscriminatorValue); } },
                {"tenantStatus", n => { TenantStatus = n.GetObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus>(Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Alert>("alerts", Alerts);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Connectivity>("connectivity", Connectivity);
            writer.WriteCollectionOfObjectValues<FilteringPolicy>("filteringPolicies", FilteringPolicies);
            writer.WriteCollectionOfObjectValues<FilteringProfile>("filteringProfiles", FilteringProfiles);
            writer.WriteCollectionOfObjectValues<ForwardingPolicy>("forwardingPolicies", ForwardingPolicies);
            writer.WriteCollectionOfObjectValues<ForwardingProfile>("forwardingProfiles", ForwardingProfiles);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Logs>("logs", Logs);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Reports>("reports", Reports);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.Settings>("settings", Settings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Networkaccess.TenantStatus>("tenantStatus", TenantStatus);
        }
    }
}
