using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DeviceAppManagement.IosLobAppProvisioningConfigurations.Item.Assign {
    /// <summary>Provides operations to call the assign method.</summary>
    public class AssignRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<MobileAppProvisioningConfigGroupAssignment> AppProvisioningConfigurationGroupAssignments { get; set; }
        public List<IosLobAppProvisioningConfigurationAssignment> IOSLobAppProvisioningConfigAssignments { get; set; }
        /// <summary>
        /// Instantiates a new assignRequestBody and sets the default values.
        /// </summary>
        public AssignRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AssignRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"appProvisioningConfigurationGroupAssignments", (o,n) => { (o as AssignRequestBody).AppProvisioningConfigurationGroupAssignments = n.GetCollectionOfObjectValues<MobileAppProvisioningConfigGroupAssignment>(MobileAppProvisioningConfigGroupAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"iOSLobAppProvisioningConfigAssignments", (o,n) => { (o as AssignRequestBody).IOSLobAppProvisioningConfigAssignments = n.GetCollectionOfObjectValues<IosLobAppProvisioningConfigurationAssignment>(IosLobAppProvisioningConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<MobileAppProvisioningConfigGroupAssignment>("appProvisioningConfigurationGroupAssignments", AppProvisioningConfigurationGroupAssignments);
            writer.WriteCollectionOfObjectValues<IosLobAppProvisioningConfigurationAssignment>("iOSLobAppProvisioningConfigAssignments", IOSLobAppProvisioningConfigAssignments);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
