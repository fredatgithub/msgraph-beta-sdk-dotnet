using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MeetingRegistrationBase : Entity, IParsable {
        /// <summary>Specifies who can register for the meeting.</summary>
        public MeetingAudience? AllowedRegistrant { get; set; }
        /// <summary>Registrants of the online meeting.</summary>
        public List<MeetingRegistrantBase> Registrants { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MeetingRegistrationBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingRegistrationBase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedRegistrant", n => { AllowedRegistrant = n.GetEnumValue<MeetingAudience>(); } },
                {"registrants", n => { Registrants = n.GetCollectionOfObjectValues<MeetingRegistrantBase>(MeetingRegistrantBase.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MeetingAudience>("allowedRegistrant", AllowedRegistrant);
            writer.WriteCollectionOfObjectValues<MeetingRegistrantBase>("registrants", Registrants);
        }
    }
}
