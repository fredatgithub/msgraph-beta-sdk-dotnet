using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Users.Item.ManagedDevices.MoveDevicesToOU {
    /// <summary>Provides operations to call the moveDevicesToOU method.</summary>
    public class MoveDevicesToOURequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<string> DeviceIds { get; set; }
        public string OrganizationalUnitPath { get; set; }
        /// <summary>
        /// Instantiates a new moveDevicesToOURequestBody and sets the default values.
        /// </summary>
        public MoveDevicesToOURequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MoveDevicesToOURequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MoveDevicesToOURequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceIds", (o,n) => { (o as MoveDevicesToOURequestBody).DeviceIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"organizationalUnitPath", (o,n) => { (o as MoveDevicesToOURequestBody).OrganizationalUnitPath = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("deviceIds", DeviceIds);
            writer.WriteStringValue("organizationalUnitPath", OrganizationalUnitPath);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
