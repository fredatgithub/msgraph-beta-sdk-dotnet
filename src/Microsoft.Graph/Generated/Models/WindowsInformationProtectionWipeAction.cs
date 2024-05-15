// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Represents wipe requests issued by tenant admin for Bring-Your-Own-Device(BYOD) Windows devices.
    /// </summary>
    public class WindowsInformationProtectionWipeAction : Entity, IParsable
    {
        /// <summary>Last checkin time of the device that was targeted by this wipe action.</summary>
        public DateTimeOffset? LastCheckInDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastCheckInDateTime"); }
            set { BackingStore?.Set("lastCheckInDateTime", value); }
        }
        /// <summary>The status property</summary>
        public ActionState? Status
        {
            get { return BackingStore?.Get<ActionState?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>Targeted device Mac address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetedDeviceMacAddress
        {
            get { return BackingStore?.Get<string?>("targetedDeviceMacAddress"); }
            set { BackingStore?.Set("targetedDeviceMacAddress", value); }
        }
#nullable restore
#else
        public string TargetedDeviceMacAddress
        {
            get { return BackingStore?.Get<string>("targetedDeviceMacAddress"); }
            set { BackingStore?.Set("targetedDeviceMacAddress", value); }
        }
#endif
        /// <summary>Targeted device name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetedDeviceName
        {
            get { return BackingStore?.Get<string?>("targetedDeviceName"); }
            set { BackingStore?.Set("targetedDeviceName", value); }
        }
#nullable restore
#else
        public string TargetedDeviceName
        {
            get { return BackingStore?.Get<string>("targetedDeviceName"); }
            set { BackingStore?.Set("targetedDeviceName", value); }
        }
#endif
        /// <summary>The DeviceRegistrationId being targeted by this wipe action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetedDeviceRegistrationId
        {
            get { return BackingStore?.Get<string?>("targetedDeviceRegistrationId"); }
            set { BackingStore?.Set("targetedDeviceRegistrationId", value); }
        }
#nullable restore
#else
        public string TargetedDeviceRegistrationId
        {
            get { return BackingStore?.Get<string>("targetedDeviceRegistrationId"); }
            set { BackingStore?.Set("targetedDeviceRegistrationId", value); }
        }
#endif
        /// <summary>The UserId being targeted by this wipe action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetedUserId
        {
            get { return BackingStore?.Get<string?>("targetedUserId"); }
            set { BackingStore?.Set("targetedUserId", value); }
        }
#nullable restore
#else
        public string TargetedUserId
        {
            get { return BackingStore?.Get<string>("targetedUserId"); }
            set { BackingStore?.Set("targetedUserId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WindowsInformationProtectionWipeAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsInformationProtectionWipeAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionWipeAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "lastCheckInDateTime", n => { LastCheckInDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetEnumValue<ActionState>(); } },
                { "targetedDeviceMacAddress", n => { TargetedDeviceMacAddress = n.GetStringValue(); } },
                { "targetedDeviceName", n => { TargetedDeviceName = n.GetStringValue(); } },
                { "targetedDeviceRegistrationId", n => { TargetedDeviceRegistrationId = n.GetStringValue(); } },
                { "targetedUserId", n => { TargetedUserId = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("lastCheckInDateTime", LastCheckInDateTime);
            writer.WriteEnumValue<ActionState>("status", Status);
            writer.WriteStringValue("targetedDeviceMacAddress", TargetedDeviceMacAddress);
            writer.WriteStringValue("targetedDeviceName", TargetedDeviceName);
            writer.WriteStringValue("targetedDeviceRegistrationId", TargetedDeviceRegistrationId);
            writer.WriteStringValue("targetedUserId", TargetedUserId);
        }
    }
}
