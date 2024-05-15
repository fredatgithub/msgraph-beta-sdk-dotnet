// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class TrainingReminderNotification : BaseEndUserNotification, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Configurable frequency for the reminder email introduced during simulation creation. Possible values are: unknown, weekly, biWeekly, unknownFutureValue.</summary>
        public NotificationDeliveryFrequency? DeliveryFrequency
        {
            get { return BackingStore?.Get<NotificationDeliveryFrequency?>("deliveryFrequency"); }
            set { BackingStore?.Set("deliveryFrequency", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="TrainingReminderNotification"/> and sets the default values.
        /// </summary>
        public TrainingReminderNotification() : base()
        {
            OdataType = "#microsoft.graph.trainingReminderNotification";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TrainingReminderNotification"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TrainingReminderNotification CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TrainingReminderNotification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deliveryFrequency", n => { DeliveryFrequency = n.GetEnumValue<NotificationDeliveryFrequency>(); } },
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
            writer.WriteEnumValue<NotificationDeliveryFrequency>("deliveryFrequency", DeliveryFrequency);
        }
    }
}
