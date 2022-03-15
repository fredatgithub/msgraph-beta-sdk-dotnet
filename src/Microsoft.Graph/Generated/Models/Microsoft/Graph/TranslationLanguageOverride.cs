using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class TranslationLanguageOverride : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The language to apply the override.Returned by default. Not nullable.</summary>
        public string LanguageTag { get; set; }
        /// <summary>The translation override behavior for the language, if any.Returned by default. Not nullable.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.TranslationBehavior? TranslationBehavior { get; set; }
        /// <summary>
        /// Instantiates a new translationLanguageOverride and sets the default values.
        /// </summary>
        public TranslationLanguageOverride() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TranslationLanguageOverride CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TranslationLanguageOverride();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"languageTag", (o,n) => { (o as TranslationLanguageOverride).LanguageTag = n.GetStringValue(); } },
                {"translationBehavior", (o,n) => { (o as TranslationLanguageOverride).TranslationBehavior = n.GetEnumValue<TranslationBehavior>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteEnumValue<TranslationBehavior>("translationBehavior", TranslationBehavior);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
