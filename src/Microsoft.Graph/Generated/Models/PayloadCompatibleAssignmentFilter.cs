// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// A class containing the properties used for Payload Compatible Assignment Filter.
    /// </summary>
    public class PayloadCompatibleAssignmentFilter : DeviceAndAppManagementAssignmentFilter, IParsable
    {
        /// <summary>Represents the payload type AssignmentFilter is being assigned to.</summary>
        public AssignmentFilterPayloadType? PayloadType
        {
            get { return BackingStore?.Get<AssignmentFilterPayloadType?>("payloadType"); }
            set { BackingStore?.Set("payloadType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="PayloadCompatibleAssignmentFilter"/> and sets the default values.
        /// </summary>
        public PayloadCompatibleAssignmentFilter() : base()
        {
            OdataType = "#microsoft.graph.payloadCompatibleAssignmentFilter";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PayloadCompatibleAssignmentFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PayloadCompatibleAssignmentFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PayloadCompatibleAssignmentFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "payloadType", n => { PayloadType = n.GetEnumValue<AssignmentFilterPayloadType>(); } },
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
            writer.WriteEnumValue<AssignmentFilterPayloadType>("payloadType", PayloadType);
        }
    }
}
