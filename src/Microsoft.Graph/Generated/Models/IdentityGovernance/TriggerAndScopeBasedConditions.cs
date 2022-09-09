using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class TriggerAndScopeBasedConditions : WorkflowExecutionConditions, IParsable {
        /// <summary>Defines who the workflow runs for.</summary>
        public Microsoft.Graph.Beta.Models.SubjectSet Scope {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SubjectSet>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
        /// <summary>What triggers a workflow to run.</summary>
        public WorkflowExecutionTrigger Trigger {
            get { return BackingStore?.Get<WorkflowExecutionTrigger>("trigger"); }
            set { BackingStore?.Set("trigger", value); }
        }
        /// <summary>
        /// Instantiates a new TriggerAndScopeBasedConditions and sets the default values.
        /// </summary>
        public TriggerAndScopeBasedConditions() : base() {
            OdataType = "#microsoft.graph.identityGovernance.triggerAndScopeBasedConditions";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TriggerAndScopeBasedConditions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TriggerAndScopeBasedConditions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"scope", n => { Scope = n.GetObjectValue<Microsoft.Graph.Beta.Models.SubjectSet>(Microsoft.Graph.Beta.Models.SubjectSet.CreateFromDiscriminatorValue); } },
                {"trigger", n => { Trigger = n.GetObjectValue<WorkflowExecutionTrigger>(WorkflowExecutionTrigger.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SubjectSet>("scope", Scope);
            writer.WriteObjectValue<WorkflowExecutionTrigger>("trigger", Trigger);
        }
    }
}
