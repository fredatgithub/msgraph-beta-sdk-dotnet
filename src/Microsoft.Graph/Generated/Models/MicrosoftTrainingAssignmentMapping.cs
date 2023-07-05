using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftTrainingAssignmentMapping : TrainingSetting, IParsable {
        /// <summary>The assignedTo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TrainingAssignedTo?>? AssignedTo {
            get { return BackingStore?.Get<List<TrainingAssignedTo?>?>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#nullable restore
#else
        public List<TrainingAssignedTo?> AssignedTo {
            get { return BackingStore?.Get<List<TrainingAssignedTo?>>("assignedTo"); }
            set { BackingStore?.Set("assignedTo", value); }
        }
#endif
        /// <summary>The training property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Training? Training {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Training?>("training"); }
            set { BackingStore?.Set("training", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Training Training {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Training>("training"); }
            set { BackingStore?.Set("training", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new microsoftTrainingAssignmentMapping and sets the default values.
        /// </summary>
        public MicrosoftTrainingAssignmentMapping() : base() {
            OdataType = "#microsoft.graph.microsoftTrainingAssignmentMapping";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftTrainingAssignmentMapping CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftTrainingAssignmentMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedTo", n => { AssignedTo = n.GetCollectionOfEnumValues<TrainingAssignedTo>()?.ToList(); } },
                {"training", n => { Training = n.GetObjectValue<Microsoft.Graph.Beta.Models.Training>(Microsoft.Graph.Beta.Models.Training.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfEnumValues<TrainingAssignedTo>("assignedTo", AssignedTo);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Training>("training", Training);
        }
    }
}
