using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserTrainingStatusInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Date and time of assignment of the training to the user.</summary>
        public DateTimeOffset? AssignedDateTime { get; set; }
        /// <summary>Date and time of completion of the training by the user.</summary>
        public DateTimeOffset? CompletionDateTime { get; set; }
        /// <summary>Display name of the assigned training.</summary>
        public string DisplayName { get; set; }
        /// <summary>Status of the training assigned to the user. Possible values are: unknown, assigned, inProgress, completed, overdue, unknownFutureValue.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.TrainingStatus? TrainingStatus { get; set; }
        /// <summary>
        /// Instantiates a new userTrainingStatusInfo and sets the default values.
        /// </summary>
        public UserTrainingStatusInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserTrainingStatusInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserTrainingStatusInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"assignedDateTime", (o,n) => { (o as UserTrainingStatusInfo).AssignedDateTime = n.GetDateTimeOffsetValue(); } },
                {"completionDateTime", (o,n) => { (o as UserTrainingStatusInfo).CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as UserTrainingStatusInfo).DisplayName = n.GetStringValue(); } },
                {"trainingStatus", (o,n) => { (o as UserTrainingStatusInfo).TrainingStatus = n.GetEnumValue<TrainingStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("assignedDateTime", AssignedDateTime);
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<TrainingStatus>("trainingStatus", TrainingStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
