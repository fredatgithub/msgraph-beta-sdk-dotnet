using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.ApprovalWorkflowProviders.Item.BusinessFlowsWithRequestsAwaitingMyDecision.Item.RecordDecisions {
    /// <summary>Provides operations to call the recordDecisions method.</summary>
    public class RecordDecisionsRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The justification property</summary>
        public string Justification { get; set; }
        /// <summary>The reviewResult property</summary>
        public string ReviewResult { get; set; }
        /// <summary>
        /// Instantiates a new recordDecisionsRequestBody and sets the default values.
        /// </summary>
        public RecordDecisionsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RecordDecisionsRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecordDecisionsRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"reviewResult", n => { ReviewResult = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("justification", Justification);
            writer.WriteStringValue("reviewResult", ReviewResult);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
