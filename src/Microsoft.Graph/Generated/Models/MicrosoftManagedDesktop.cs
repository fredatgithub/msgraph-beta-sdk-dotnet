using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftManagedDesktop : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the Microsoft Managed Desktop profile that the Windows 365 Cloud PC is associated with.</summary>
        public string Profile { get; set; }
        /// <summary>Indicates whether the provisioning policy enables Microsoft Managed Desktop. It indicates the type of plan under which the device is managed if the provisioning policy is enabled. Possible values are: notManaged, premiumManaged, standardManaged, starterManaged, unknownFutureValue.</summary>
        public MicrosoftManagedDesktopType? Type { get; set; }
        /// <summary>
        /// Instantiates a new microsoftManagedDesktop and sets the default values.
        /// </summary>
        public MicrosoftManagedDesktop() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MicrosoftManagedDesktop CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftManagedDesktop();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"profile", n => { Profile = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<MicrosoftManagedDesktopType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("profile", Profile);
            writer.WriteEnumValue<MicrosoftManagedDesktopType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
