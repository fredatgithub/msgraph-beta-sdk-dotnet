using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Me.WipeManagedAppRegistrationByDeviceTag {
    /// <summary>Provides operations to call the wipeManagedAppRegistrationByDeviceTag method.</summary>
    public class WipeManagedAppRegistrationByDeviceTagRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string DeviceTag { get; set; }
        /// <summary>
        /// Instantiates a new wipeManagedAppRegistrationByDeviceTagRequestBody and sets the default values.
        /// </summary>
        public WipeManagedAppRegistrationByDeviceTagRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WipeManagedAppRegistrationByDeviceTagRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WipeManagedAppRegistrationByDeviceTagRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceTag", (o,n) => { (o as WipeManagedAppRegistrationByDeviceTagRequestBody).DeviceTag = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceTag", DeviceTag);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
