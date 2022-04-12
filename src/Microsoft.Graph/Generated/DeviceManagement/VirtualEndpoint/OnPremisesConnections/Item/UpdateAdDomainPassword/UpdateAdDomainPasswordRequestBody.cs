using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.OnPremisesConnections.Item.UpdateAdDomainPassword {
    /// <summary>Provides operations to call the updateAdDomainPassword method.</summary>
    public class UpdateAdDomainPasswordRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The adDomainPassword property</summary>
        public string AdDomainPassword { get; set; }
        /// <summary>
        /// Instantiates a new updateAdDomainPasswordRequestBody and sets the default values.
        /// </summary>
        public UpdateAdDomainPasswordRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateAdDomainPasswordRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateAdDomainPasswordRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"adDomainPassword", n => { AdDomainPassword = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("adDomainPassword", AdDomainPassword);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
