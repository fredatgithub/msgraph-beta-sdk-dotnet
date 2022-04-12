using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.DeleteUserFromSharedAppleDevice {
    /// <summary>Provides operations to call the deleteUserFromSharedAppleDevice method.</summary>
    public class DeleteUserFromSharedAppleDeviceRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The userPrincipalName property</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Instantiates a new deleteUserFromSharedAppleDeviceRequestBody and sets the default values.
        /// </summary>
        public DeleteUserFromSharedAppleDeviceRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeleteUserFromSharedAppleDeviceRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeleteUserFromSharedAppleDeviceRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
