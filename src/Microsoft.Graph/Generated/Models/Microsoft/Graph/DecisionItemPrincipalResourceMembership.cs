using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DecisionItemPrincipalResourceMembership : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DecisionItemPrincipalResourceMembershipType? MembershipType { get; set; }
        /// <summary>
        /// Instantiates a new decisionItemPrincipalResourceMembership and sets the default values.
        /// </summary>
        public DecisionItemPrincipalResourceMembership() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DecisionItemPrincipalResourceMembership CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DecisionItemPrincipalResourceMembership();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"membershipType", (o,n) => { (o as DecisionItemPrincipalResourceMembership).MembershipType = n.GetEnumValue<DecisionItemPrincipalResourceMembershipType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DecisionItemPrincipalResourceMembershipType>("membershipType", MembershipType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
