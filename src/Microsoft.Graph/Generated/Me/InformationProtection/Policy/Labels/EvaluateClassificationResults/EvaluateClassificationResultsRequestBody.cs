using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Me.InformationProtection.Policy.Labels.EvaluateClassificationResults {
    /// <summary>Provides operations to call the evaluateClassificationResults method.</summary>
    public class EvaluateClassificationResultsRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ClassificationResult> ClassificationResults { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ContentInfo ContentInfo { get; set; }
        /// <summary>
        /// Instantiates a new evaluateClassificationResultsRequestBody and sets the default values.
        /// </summary>
        public EvaluateClassificationResultsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EvaluateClassificationResultsRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateClassificationResultsRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"classificationResults", (o,n) => { (o as EvaluateClassificationResultsRequestBody).ClassificationResults = n.GetCollectionOfObjectValues<ClassificationResult>(ClassificationResult.CreateFromDiscriminatorValue).ToList(); } },
                {"contentInfo", (o,n) => { (o as EvaluateClassificationResultsRequestBody).ContentInfo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ContentInfo>(MicrosoftGraphSdk.Models.Microsoft.Graph.ContentInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ClassificationResult>("classificationResults", ClassificationResults);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ContentInfo>("contentInfo", ContentInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
