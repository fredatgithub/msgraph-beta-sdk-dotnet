// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// A security configuration task.
    /// </summary>
    public class SecurityConfigurationTask : DeviceAppManagementTask, IParsable
    {
        /// <summary>The endpoint security configuration applicable platform.</summary>
        public EndpointSecurityConfigurationApplicablePlatform? ApplicablePlatform
        {
            get { return BackingStore?.Get<EndpointSecurityConfigurationApplicablePlatform?>("applicablePlatform"); }
            set { BackingStore?.Set("applicablePlatform", value); }
        }
        /// <summary>The endpoint security policy type.</summary>
        public EndpointSecurityConfigurationType? EndpointSecurityPolicy
        {
            get { return BackingStore?.Get<EndpointSecurityConfigurationType?>("endpointSecurityPolicy"); }
            set { BackingStore?.Set("endpointSecurityPolicy", value); }
        }
        /// <summary>The endpoint security policy profile type.</summary>
        public EndpointSecurityConfigurationProfileType? EndpointSecurityPolicyProfile
        {
            get { return BackingStore?.Get<EndpointSecurityConfigurationProfileType?>("endpointSecurityPolicyProfile"); }
            set { BackingStore?.Set("endpointSecurityPolicyProfile", value); }
        }
        /// <summary>Information about the mitigation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Insights
        {
            get { return BackingStore?.Get<string?>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
#nullable restore
#else
        public string Insights
        {
            get { return BackingStore?.Get<string>("insights"); }
            set { BackingStore?.Set("insights", value); }
        }
#endif
        /// <summary>The intended settings and their values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? IntendedSettings
        {
            get { return BackingStore?.Get<List<KeyValuePair>?>("intendedSettings"); }
            set { BackingStore?.Set("intendedSettings", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> IntendedSettings
        {
            get { return BackingStore?.Get<List<KeyValuePair>>("intendedSettings"); }
            set { BackingStore?.Set("intendedSettings", value); }
        }
#endif
        /// <summary>The number of vulnerable devices. Valid values 0 to 65536</summary>
        public int? ManagedDeviceCount
        {
            get { return BackingStore?.Get<int?>("managedDeviceCount"); }
            set { BackingStore?.Set("managedDeviceCount", value); }
        }
        /// <summary>The vulnerable managed devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VulnerableManagedDevice>? ManagedDevices
        {
            get { return BackingStore?.Get<List<VulnerableManagedDevice>?>("managedDevices"); }
            set { BackingStore?.Set("managedDevices", value); }
        }
#nullable restore
#else
        public List<VulnerableManagedDevice> ManagedDevices
        {
            get { return BackingStore?.Get<List<VulnerableManagedDevice>>("managedDevices"); }
            set { BackingStore?.Set("managedDevices", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="SecurityConfigurationTask"/> and sets the default values.
        /// </summary>
        public SecurityConfigurationTask() : base()
        {
            OdataType = "#microsoft.graph.securityConfigurationTask";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SecurityConfigurationTask"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SecurityConfigurationTask CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityConfigurationTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "applicablePlatform", n => { ApplicablePlatform = n.GetEnumValue<EndpointSecurityConfigurationApplicablePlatform>(); } },
                { "endpointSecurityPolicy", n => { EndpointSecurityPolicy = n.GetEnumValue<EndpointSecurityConfigurationType>(); } },
                { "endpointSecurityPolicyProfile", n => { EndpointSecurityPolicyProfile = n.GetEnumValue<EndpointSecurityConfigurationProfileType>(); } },
                { "insights", n => { Insights = n.GetStringValue(); } },
                { "intendedSettings", n => { IntendedSettings = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                { "managedDeviceCount", n => { ManagedDeviceCount = n.GetIntValue(); } },
                { "managedDevices", n => { ManagedDevices = n.GetCollectionOfObjectValues<VulnerableManagedDevice>(VulnerableManagedDevice.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EndpointSecurityConfigurationApplicablePlatform>("applicablePlatform", ApplicablePlatform);
            writer.WriteEnumValue<EndpointSecurityConfigurationType>("endpointSecurityPolicy", EndpointSecurityPolicy);
            writer.WriteEnumValue<EndpointSecurityConfigurationProfileType>("endpointSecurityPolicyProfile", EndpointSecurityPolicyProfile);
            writer.WriteStringValue("insights", Insights);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("intendedSettings", IntendedSettings);
            writer.WriteIntValue("managedDeviceCount", ManagedDeviceCount);
            writer.WriteCollectionOfObjectValues<VulnerableManagedDevice>("managedDevices", ManagedDevices);
        }
    }
}
