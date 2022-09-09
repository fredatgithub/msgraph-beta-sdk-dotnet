using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class ActivityHistoryItem : Entity, IParsable {
        /// <summary>The activeDurationSeconds property</summary>
        public int? ActiveDurationSeconds {
            get { return BackingStore?.Get<int?>("activeDurationSeconds"); }
            set { BackingStore?.Set("activeDurationSeconds", value); }
        }
        /// <summary>The activity property</summary>
        public UserActivity Activity {
            get { return BackingStore?.Get<UserActivity>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The lastActiveDateTime property</summary>
        public DateTimeOffset? LastActiveDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastActiveDateTime"); }
            set { BackingStore?.Set("lastActiveDateTime", value); }
        }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The startedDateTime property</summary>
        public DateTimeOffset? StartedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startedDateTime"); }
            set { BackingStore?.Set("startedDateTime", value); }
        }
        /// <summary>The status property</summary>
        public Microsoft.Graph.Beta.Models.Status? Status {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Status?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The userTimezone property</summary>
        public string UserTimezone {
            get { return BackingStore?.Get<string>("userTimezone"); }
            set { BackingStore?.Set("userTimezone", value); }
        }
        /// <summary>
        /// Instantiates a new activityHistoryItem and sets the default values.
        /// </summary>
        public ActivityHistoryItem() : base() {
            OdataType = "#microsoft.graph.activityHistoryItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ActivityHistoryItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActivityHistoryItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDurationSeconds", n => { ActiveDurationSeconds = n.GetIntValue(); } },
                {"activity", n => { Activity = n.GetObjectValue<UserActivity>(UserActivity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastActiveDateTime", n => { LastActiveDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<Status>(); } },
                {"userTimezone", n => { UserTimezone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeDurationSeconds", ActiveDurationSeconds);
            writer.WriteObjectValue<UserActivity>("activity", Activity);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteDateTimeOffsetValue("lastActiveDateTime", LastActiveDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteEnumValue<Status>("status", Status);
            writer.WriteStringValue("userTimezone", UserTimezone);
        }
    }
}
