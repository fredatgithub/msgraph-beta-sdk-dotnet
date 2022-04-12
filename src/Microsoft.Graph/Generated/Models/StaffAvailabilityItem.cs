using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class StaffAvailabilityItem : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Each item in this collection indicates a slot and the status of the staff member.</summary>
        public List<AvailabilityItem> AvailabilityItems { get; set; }
        /// <summary>The ID of the staff member.</summary>
        public string StaffId { get; set; }
        /// <summary>
        /// Instantiates a new staffAvailabilityItem and sets the default values.
        /// </summary>
        public StaffAvailabilityItem() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static StaffAvailabilityItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StaffAvailabilityItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"availabilityItems", n => { AvailabilityItems = n.GetCollectionOfObjectValues<AvailabilityItem>(AvailabilityItem.CreateFromDiscriminatorValue).ToList(); } },
                {"staffId", n => { StaffId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AvailabilityItem>("availabilityItems", AvailabilityItems);
            writer.WriteStringValue("staffId", StaffId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
