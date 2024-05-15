// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance
{
    #pragma warning disable CS1591
    public class LifecycleManagementSettings : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The emailSettings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.EmailSettings? EmailSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EmailSettings?>("emailSettings"); }
            set { BackingStore?.Set("emailSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.EmailSettings EmailSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EmailSettings>("emailSettings"); }
            set { BackingStore?.Set("emailSettings", value); }
        }
#endif
        /// <summary>The interval in hours at which all workflows running in the tenant should be scheduled for execution. This interval has a minimum value of 1 and a maximum value of 24. The default value is 3 hours.</summary>
        public int? WorkflowScheduleIntervalInHours
        {
            get { return BackingStore?.Get<int?>("workflowScheduleIntervalInHours"); }
            set { BackingStore?.Set("workflowScheduleIntervalInHours", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="LifecycleManagementSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new LifecycleManagementSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LifecycleManagementSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "emailSettings", n => { EmailSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.EmailSettings>(Microsoft.Graph.Beta.Models.EmailSettings.CreateFromDiscriminatorValue); } },
                { "workflowScheduleIntervalInHours", n => { WorkflowScheduleIntervalInHours = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.EmailSettings>("emailSettings", EmailSettings);
            writer.WriteIntValue("workflowScheduleIntervalInHours", WorkflowScheduleIntervalInHours);
        }
    }
}
