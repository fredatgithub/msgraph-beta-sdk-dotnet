using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Organization.Item.ActivateService {
    /// <summary>Provides operations to call the activateService method.</summary>
    public class ActivateServiceRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string Service { get; set; }
        public string ServicePlanId { get; set; }
        public string SkuId { get; set; }
        /// <summary>
        /// Instantiates a new activateServiceRequestBody and sets the default values.
        /// </summary>
        public ActivateServiceRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ActivateServiceRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActivateServiceRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"service", (o,n) => { (o as ActivateServiceRequestBody).Service = n.GetStringValue(); } },
                {"servicePlanId", (o,n) => { (o as ActivateServiceRequestBody).ServicePlanId = n.GetStringValue(); } },
                {"skuId", (o,n) => { (o as ActivateServiceRequestBody).SkuId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("service", Service);
            writer.WriteStringValue("servicePlanId", ServicePlanId);
            writer.WriteStringValue("skuId", SkuId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
