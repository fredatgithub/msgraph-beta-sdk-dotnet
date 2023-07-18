using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DirectoryAudit : Entity, IParsable {
        /// <summary>Indicates the date and time the activity was performed. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("activityDateTime"); }
            set { BackingStore?.Set("activityDateTime", value); }
        }
        /// <summary>Indicates the activity name or the operation name (E.g. &apos;Create User&apos;, &apos;Add member to group&apos;). For a list of activities logged, refer to Azure AD audit log categories and activities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityDisplayName {
            get { return BackingStore?.Get<string?>("activityDisplayName"); }
            set { BackingStore?.Set("activityDisplayName", value); }
        }
#nullable restore
#else
        public string ActivityDisplayName {
            get { return BackingStore?.Get<string>("activityDisplayName"); }
            set { BackingStore?.Set("activityDisplayName", value); }
        }
#endif
        /// <summary>Indicates additional details on the activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValue>? AdditionalDetails {
            get { return BackingStore?.Get<List<KeyValue>?>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
#nullable restore
#else
        public List<KeyValue> AdditionalDetails {
            get { return BackingStore?.Get<List<KeyValue>>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
#endif
        /// <summary>Indicates which resource category that&apos;s targeted by the activity. For example: UserManagement, GroupManagement, ApplicationManagement, RoleManagement. For a list of categories for activities logged, refer to Azure AD audit log categories and activities.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category {
            get { return BackingStore?.Get<string?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#nullable restore
#else
        public string Category {
            get { return BackingStore?.Get<string>("category"); }
            set { BackingStore?.Set("category", value); }
        }
#endif
        /// <summary>Indicates a unique ID that helps correlate activities that span across various services. Can be used to trace logs across services.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>The initiatedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AuditActivityInitiator? InitiatedBy {
            get { return BackingStore?.Get<AuditActivityInitiator?>("initiatedBy"); }
            set { BackingStore?.Set("initiatedBy", value); }
        }
#nullable restore
#else
        public AuditActivityInitiator InitiatedBy {
            get { return BackingStore?.Get<AuditActivityInitiator>("initiatedBy"); }
            set { BackingStore?.Set("initiatedBy", value); }
        }
#endif
        /// <summary>Indicates information on which service initiated the activity (For example: Self-service Password Management, Core Directory, B2C, Invited Users, Microsoft Identity Manager, Privileged Identity Management.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LoggedByService {
            get { return BackingStore?.Get<string?>("loggedByService"); }
            set { BackingStore?.Set("loggedByService", value); }
        }
#nullable restore
#else
        public string LoggedByService {
            get { return BackingStore?.Get<string>("loggedByService"); }
            set { BackingStore?.Set("loggedByService", value); }
        }
#endif
        /// <summary>Indicates the type of operation that was performed. The possible values include but are not limited to the following: Add, Assign, Update, Unassign, and Delete.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperationType {
            get { return BackingStore?.Get<string?>("operationType"); }
            set { BackingStore?.Set("operationType", value); }
        }
#nullable restore
#else
        public string OperationType {
            get { return BackingStore?.Get<string>("operationType"); }
            set { BackingStore?.Set("operationType", value); }
        }
#endif
        /// <summary>Indicates the result of the activity. Possible values are: success, failure, timeout, unknownFutureValue.</summary>
        public OperationResult? Result {
            get { return BackingStore?.Get<OperationResult?>("result"); }
            set { BackingStore?.Set("result", value); }
        }
        /// <summary>Indicates the reason for failure if the result is failure or timeout.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResultReason {
            get { return BackingStore?.Get<string?>("resultReason"); }
            set { BackingStore?.Set("resultReason", value); }
        }
#nullable restore
#else
        public string ResultReason {
            get { return BackingStore?.Get<string>("resultReason"); }
            set { BackingStore?.Set("resultReason", value); }
        }
#endif
        /// <summary>Information about the resource that changed due to the activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TargetResource>? TargetResources {
            get { return BackingStore?.Get<List<TargetResource>?>("targetResources"); }
            set { BackingStore?.Set("targetResources", value); }
        }
#nullable restore
#else
        public List<TargetResource> TargetResources {
            get { return BackingStore?.Get<List<TargetResource>>("targetResources"); }
            set { BackingStore?.Set("targetResources", value); }
        }
#endif
        /// <summary>Type of user agent used by a user in the activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserAgent {
            get { return BackingStore?.Get<string?>("userAgent"); }
            set { BackingStore?.Set("userAgent", value); }
        }
#nullable restore
#else
        public string UserAgent {
            get { return BackingStore?.Get<string>("userAgent"); }
            set { BackingStore?.Set("userAgent", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DirectoryAudit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryAudit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"activityDisplayName", n => { ActivityDisplayName = n.GetStringValue(); } },
                {"additionalDetails", n => { AdditionalDetails = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"category", n => { Category = n.GetStringValue(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"initiatedBy", n => { InitiatedBy = n.GetObjectValue<AuditActivityInitiator>(AuditActivityInitiator.CreateFromDiscriminatorValue); } },
                {"loggedByService", n => { LoggedByService = n.GetStringValue(); } },
                {"operationType", n => { OperationType = n.GetStringValue(); } },
                {"result", n => { Result = n.GetEnumValue<OperationResult>(); } },
                {"resultReason", n => { ResultReason = n.GetStringValue(); } },
                {"targetResources", n => { TargetResources = n.GetCollectionOfObjectValues<TargetResource>(TargetResource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userAgent", n => { UserAgent = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("activityDisplayName", ActivityDisplayName);
            writer.WriteCollectionOfObjectValues<KeyValue>("additionalDetails", AdditionalDetails);
            writer.WriteStringValue("category", Category);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteObjectValue<AuditActivityInitiator>("initiatedBy", InitiatedBy);
            writer.WriteStringValue("loggedByService", LoggedByService);
            writer.WriteStringValue("operationType", OperationType);
            writer.WriteEnumValue<OperationResult>("result", Result);
            writer.WriteStringValue("resultReason", ResultReason);
            writer.WriteCollectionOfObjectValues<TargetResource>("targetResources", TargetResources);
            writer.WriteStringValue("userAgent", UserAgent);
        }
    }
}
