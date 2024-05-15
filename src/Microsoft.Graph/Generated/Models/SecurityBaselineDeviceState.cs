// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The security baseline compliance state summary of the security baseline for a device.
    /// </summary>
    public class SecurityBaselineDeviceState : Entity, IParsable
    {
        /// <summary>Display name of the device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceDisplayName
        {
            get { return BackingStore?.Get<string?>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
#nullable restore
#else
        public string DeviceDisplayName
        {
            get { return BackingStore?.Get<string>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
#endif
        /// <summary>Last modified date time of the policy report</summary>
        public DateTimeOffset? LastReportedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastReportedDateTime"); }
            set { BackingStore?.Set("lastReportedDateTime", value); }
        }
        /// <summary>Intune device id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceId
        {
            get { return BackingStore?.Get<string?>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#nullable restore
#else
        public string ManagedDeviceId
        {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#endif
        /// <summary>Security Baseline Compliance State</summary>
        public SecurityBaselineComplianceState? State
        {
            get { return BackingStore?.Get<SecurityBaselineComplianceState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>User Principal Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName
        {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName
        {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="SecurityBaselineDeviceState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SecurityBaselineDeviceState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityBaselineDeviceState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                { "lastReportedDateTime", n => { LastReportedDateTime = n.GetDateTimeOffsetValue(); } },
                { "managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                { "state", n => { State = n.GetEnumValue<SecurityBaselineComplianceState>(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteDateTimeOffsetValue("lastReportedDateTime", LastReportedDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteEnumValue<SecurityBaselineComplianceState>("state", State);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
