using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class ColumnValidation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Default BCP 47 language tag for the description.</summary>
        public string DefaultLanguage { get; set; }
        /// <summary>Localized messages that explain what is needed for this column's value to be considered valid. User will be prompted with this message if validation fails.</summary>
        public List<DisplayNameLocalization> Descriptions { get; set; }
        /// <summary>The formula to validate column value. For examples, see Examples of common formulas in lists.</summary>
        public string Formula { get; set; }
        /// <summary>
        /// Instantiates a new columnValidation and sets the default values.
        /// </summary>
        public ColumnValidation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ColumnValidation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ColumnValidation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"defaultLanguage", (o,n) => { (o as ColumnValidation).DefaultLanguage = n.GetStringValue(); } },
                {"descriptions", (o,n) => { (o as ColumnValidation).Descriptions = n.GetCollectionOfObjectValues<DisplayNameLocalization>(DisplayNameLocalization.CreateFromDiscriminatorValue).ToList(); } },
                {"formula", (o,n) => { (o as ColumnValidation).Formula = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultLanguage", DefaultLanguage);
            writer.WriteCollectionOfObjectValues<DisplayNameLocalization>("descriptions", Descriptions);
            writer.WriteStringValue("formula", Formula);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
