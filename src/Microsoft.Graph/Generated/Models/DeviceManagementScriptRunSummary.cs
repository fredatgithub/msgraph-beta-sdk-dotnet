// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Contains properties for the run summary of a device management script.
    /// </summary>
    public class DeviceManagementScriptRunSummary : Entity, IParsable
    {
        /// <summary>Error device count.</summary>
        public int? ErrorDeviceCount
        {
            get { return BackingStore?.Get<int?>("errorDeviceCount"); }
            set { BackingStore?.Set("errorDeviceCount", value); }
        }
        /// <summary>Error user count.</summary>
        public int? ErrorUserCount
        {
            get { return BackingStore?.Get<int?>("errorUserCount"); }
            set { BackingStore?.Set("errorUserCount", value); }
        }
        /// <summary>Success device count.</summary>
        public int? SuccessDeviceCount
        {
            get { return BackingStore?.Get<int?>("successDeviceCount"); }
            set { BackingStore?.Set("successDeviceCount", value); }
        }
        /// <summary>Success user count.</summary>
        public int? SuccessUserCount
        {
            get { return BackingStore?.Get<int?>("successUserCount"); }
            set { BackingStore?.Set("successUserCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceManagementScriptRunSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementScriptRunSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementScriptRunSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                { "errorUserCount", n => { ErrorUserCount = n.GetIntValue(); } },
                { "successDeviceCount", n => { SuccessDeviceCount = n.GetIntValue(); } },
                { "successUserCount", n => { SuccessUserCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("errorUserCount", ErrorUserCount);
            writer.WriteIntValue("successDeviceCount", SuccessDeviceCount);
            writer.WriteIntValue("successUserCount", SuccessUserCount);
        }
    }
}
