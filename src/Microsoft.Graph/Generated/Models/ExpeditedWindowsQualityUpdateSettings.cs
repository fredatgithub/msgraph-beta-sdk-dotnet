using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A complex type to store the expedited quality update settings such as release date and days until forced reboot.</summary>
    public class ExpeditedWindowsQualityUpdateSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of days after installation that forced reboot will happen.</summary>
        public int? DaysUntilForcedReboot { get; set; }
        /// <summary>The release date to identify a quality update.</summary>
        public string QualityUpdateRelease { get; set; }
        /// <summary>
        /// Instantiates a new expeditedWindowsQualityUpdateSettings and sets the default values.
        /// </summary>
        public ExpeditedWindowsQualityUpdateSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExpeditedWindowsQualityUpdateSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExpeditedWindowsQualityUpdateSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"daysUntilForcedReboot", n => { DaysUntilForcedReboot = n.GetIntValue(); } },
                {"qualityUpdateRelease", n => { QualityUpdateRelease = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("daysUntilForcedReboot", DaysUntilForcedReboot);
            writer.WriteStringValue("qualityUpdateRelease", QualityUpdateRelease);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
