// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Properties of the  Booolean script parameter.
    /// </summary>
    public class DeviceHealthScriptBooleanParameter : DeviceHealthScriptParameter, IParsable
    {
        /// <summary>The default value of boolean param</summary>
        public bool? DefaultValue
        {
            get { return BackingStore?.Get<bool?>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="DeviceHealthScriptBooleanParameter"/> and sets the default values.
        /// </summary>
        public DeviceHealthScriptBooleanParameter() : base()
        {
            OdataType = "#microsoft.graph.deviceHealthScriptBooleanParameter";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceHealthScriptBooleanParameter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceHealthScriptBooleanParameter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptBooleanParameter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "defaultValue", n => { DefaultValue = n.GetBoolValue(); } },
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
            writer.WriteBoolValue("defaultValue", DefaultValue);
        }
    }
}
