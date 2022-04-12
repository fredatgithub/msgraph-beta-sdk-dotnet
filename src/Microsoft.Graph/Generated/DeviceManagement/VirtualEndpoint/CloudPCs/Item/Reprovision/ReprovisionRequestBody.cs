using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Reprovision {
    /// <summary>Provides operations to call the reprovision method.</summary>
    public class ReprovisionRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The osVersion property</summary>
        public CloudPcOperatingSystem? OsVersion { get; set; }
        /// <summary>The userAccountType property</summary>
        public CloudPcUserAccountType? UserAccountType { get; set; }
        /// <summary>
        /// Instantiates a new reprovisionRequestBody and sets the default values.
        /// </summary>
        public ReprovisionRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ReprovisionRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReprovisionRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"osVersion", n => { OsVersion = n.GetEnumValue<CloudPcOperatingSystem>(); } },
                {"userAccountType", n => { UserAccountType = n.GetEnumValue<CloudPcUserAccountType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<CloudPcOperatingSystem>("osVersion", OsVersion);
            writer.WriteEnumValue<CloudPcUserAccountType>("userAccountType", UserAccountType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
