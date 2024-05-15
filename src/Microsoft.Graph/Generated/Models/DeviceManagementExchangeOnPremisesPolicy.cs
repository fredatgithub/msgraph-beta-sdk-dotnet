// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Singleton entity which represents the Exchange OnPremises policy configured for a tenant.
    /// </summary>
    public class DeviceManagementExchangeOnPremisesPolicy : Entity, IParsable
    {
        /// <summary>The list of device access rules in Exchange. The access rules apply globally to the entire Exchange organization</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementExchangeAccessRule>? AccessRules
        {
            get { return BackingStore?.Get<List<DeviceManagementExchangeAccessRule>?>("accessRules"); }
            set { BackingStore?.Set("accessRules", value); }
        }
#nullable restore
#else
        public List<DeviceManagementExchangeAccessRule> AccessRules
        {
            get { return BackingStore?.Get<List<DeviceManagementExchangeAccessRule>>("accessRules"); }
            set { BackingStore?.Set("accessRules", value); }
        }
#endif
        /// <summary>The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnPremisesConditionalAccessSettings? ConditionalAccessSettings
        {
            get { return BackingStore?.Get<OnPremisesConditionalAccessSettings?>("conditionalAccessSettings"); }
            set { BackingStore?.Set("conditionalAccessSettings", value); }
        }
#nullable restore
#else
        public OnPremisesConditionalAccessSettings ConditionalAccessSettings
        {
            get { return BackingStore?.Get<OnPremisesConditionalAccessSettings>("conditionalAccessSettings"); }
            set { BackingStore?.Set("conditionalAccessSettings", value); }
        }
#endif
        /// <summary>Access Level in Exchange.</summary>
        public DeviceManagementExchangeAccessLevel? DefaultAccessLevel
        {
            get { return BackingStore?.Get<DeviceManagementExchangeAccessLevel?>("defaultAccessLevel"); }
            set { BackingStore?.Set("defaultAccessLevel", value); }
        }
        /// <summary>The list of device classes known to Exchange</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementExchangeDeviceClass>? KnownDeviceClasses
        {
            get { return BackingStore?.Get<List<DeviceManagementExchangeDeviceClass>?>("knownDeviceClasses"); }
            set { BackingStore?.Set("knownDeviceClasses", value); }
        }
#nullable restore
#else
        public List<DeviceManagementExchangeDeviceClass> KnownDeviceClasses
        {
            get { return BackingStore?.Get<List<DeviceManagementExchangeDeviceClass>>("knownDeviceClasses"); }
            set { BackingStore?.Set("knownDeviceClasses", value); }
        }
#endif
        /// <summary>Notification text that will be sent to users quarantined by this policy. This is UTF8 encoded byte array HTML.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? NotificationContent
        {
            get { return BackingStore?.Get<byte[]?>("notificationContent"); }
            set { BackingStore?.Set("notificationContent", value); }
        }
#nullable restore
#else
        public byte[] NotificationContent
        {
            get { return BackingStore?.Get<byte[]>("notificationContent"); }
            set { BackingStore?.Set("notificationContent", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementExchangeOnPremisesPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementExchangeOnPremisesPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementExchangeOnPremisesPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessRules", n => { AccessRules = n.GetCollectionOfObjectValues<DeviceManagementExchangeAccessRule>(DeviceManagementExchangeAccessRule.CreateFromDiscriminatorValue)?.ToList(); } },
                { "conditionalAccessSettings", n => { ConditionalAccessSettings = n.GetObjectValue<OnPremisesConditionalAccessSettings>(OnPremisesConditionalAccessSettings.CreateFromDiscriminatorValue); } },
                { "defaultAccessLevel", n => { DefaultAccessLevel = n.GetEnumValue<DeviceManagementExchangeAccessLevel>(); } },
                { "knownDeviceClasses", n => { KnownDeviceClasses = n.GetCollectionOfObjectValues<DeviceManagementExchangeDeviceClass>(DeviceManagementExchangeDeviceClass.CreateFromDiscriminatorValue)?.ToList(); } },
                { "notificationContent", n => { NotificationContent = n.GetByteArrayValue(); } },
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
            writer.WriteCollectionOfObjectValues<DeviceManagementExchangeAccessRule>("accessRules", AccessRules);
            writer.WriteObjectValue<OnPremisesConditionalAccessSettings>("conditionalAccessSettings", ConditionalAccessSettings);
            writer.WriteEnumValue<DeviceManagementExchangeAccessLevel>("defaultAccessLevel", DefaultAccessLevel);
            writer.WriteCollectionOfObjectValues<DeviceManagementExchangeDeviceClass>("knownDeviceClasses", KnownDeviceClasses);
            writer.WriteByteArrayValue("notificationContent", NotificationContent);
        }
    }
}
