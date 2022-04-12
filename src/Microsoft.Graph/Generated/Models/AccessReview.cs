using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AccessReview : Entity, IParsable {
        /// <summary>The business flow template identifier. Required on create.  This value is case sensitive.</summary>
        public string BusinessFlowTemplateId { get; set; }
        /// <summary>The user who created this review.</summary>
        public UserIdentity CreatedBy { get; set; }
        /// <summary>The collection of decisions for this access review.</summary>
        public List<AccessReviewDecision> Decisions { get; set; }
        /// <summary>The description provided by the access review creator, to show to the reviewers.</summary>
        public string Description { get; set; }
        /// <summary>The access review name. Required on create.</summary>
        public string DisplayName { get; set; }
        /// <summary>The DateTime when the review is scheduled to end. This must be at least one day later than the start date.  Required on create.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The collection of access reviews instances past, present and future, if this object is a recurring access review.</summary>
        public List<AccessReview> Instances { get; set; }
        /// <summary>The collection of decisions for the caller, if the caller is a reviewer.</summary>
        public List<AccessReviewDecision> MyDecisions { get; set; }
        /// <summary>The object for which the access reviews is reviewing the access rights assignments. This can be the group for the review of memberships of users in a group, or the app for a review of assignments of users to an application. Required on create.</summary>
        public Identity ReviewedEntity { get; set; }
        /// <summary>The collection of reviewers for an access review, if access review reviewerType is of type delegated.</summary>
        public List<AccessReviewReviewer> Reviewers { get; set; }
        /// <summary>The relationship type of reviewer to the target object, one of self, delegated or entityOwners. Required on create.</summary>
        public string ReviewerType { get; set; }
        /// <summary>The settings of an accessReview, see type definition below.</summary>
        public AccessReviewSettings Settings { get; set; }
        /// <summary>The DateTime when the review is scheduled to be start.  This could be a date in the future.  Required on create.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>This read-only field specifies the status of an accessReview. The typical states include Initializing, NotStarted, Starting,InProgress, Completing, Completed, AutoReviewing, and AutoReviewed.</summary>
        public string Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessReview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"businessFlowTemplateId", n => { BusinessFlowTemplateId = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"decisions", n => { Decisions = n.GetCollectionOfObjectValues<AccessReviewDecision>(AccessReviewDecision.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"instances", n => { Instances = n.GetCollectionOfObjectValues<AccessReview>(AccessReview.CreateFromDiscriminatorValue).ToList(); } },
                {"myDecisions", n => { MyDecisions = n.GetCollectionOfObjectValues<AccessReviewDecision>(AccessReviewDecision.CreateFromDiscriminatorValue).ToList(); } },
                {"reviewedEntity", n => { ReviewedEntity = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"reviewers", n => { Reviewers = n.GetCollectionOfObjectValues<AccessReviewReviewer>(AccessReviewReviewer.CreateFromDiscriminatorValue).ToList(); } },
                {"reviewerType", n => { ReviewerType = n.GetStringValue(); } },
                {"settings", n => { Settings = n.GetObjectValue<AccessReviewSettings>(AccessReviewSettings.CreateFromDiscriminatorValue); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("businessFlowTemplateId", BusinessFlowTemplateId);
            writer.WriteObjectValue<UserIdentity>("createdBy", CreatedBy);
            writer.WriteCollectionOfObjectValues<AccessReviewDecision>("decisions", Decisions);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteCollectionOfObjectValues<AccessReview>("instances", Instances);
            writer.WriteCollectionOfObjectValues<AccessReviewDecision>("myDecisions", MyDecisions);
            writer.WriteObjectValue<Identity>("reviewedEntity", ReviewedEntity);
            writer.WriteCollectionOfObjectValues<AccessReviewReviewer>("reviewers", Reviewers);
            writer.WriteStringValue("reviewerType", ReviewerType);
            writer.WriteObjectValue<AccessReviewSettings>("settings", Settings);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
        }
    }
}
