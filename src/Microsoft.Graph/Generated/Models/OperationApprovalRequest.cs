// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The OperationApprovalRequest entity encompasses the operation an admin wishes to perform and is requesting approval to complete. It contains the detail of the operation one wishes to perform, user metadata of the requestor, and a justification for the change. It allows for several operations for both the requestor and the potential approver to either approve, deny, or cancel the request and a response justification to provide information for the decision.
    /// </summary>
    public class OperationApprovalRequest : Entity, IParsable
    {
        /// <summary>Indicates the justification for approving or rejecting the request. Maximum length of justification is 1024 characters. For example: &apos;Approved per Change 23423 - needed for Feb 2023 application baseline updates.&apos; Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApprovalJustification
        {
            get { return BackingStore?.Get<string?>("approvalJustification"); }
            set { BackingStore?.Set("approvalJustification", value); }
        }
#nullable restore
#else
        public string ApprovalJustification
        {
            get { return BackingStore?.Get<string>("approvalJustification"); }
            set { BackingStore?.Set("approvalJustification", value); }
        }
#endif
        /// <summary>The identity of the approver as an Identity Set. Optionally contains the application ID, the device ID and the User ID. See information about this type here: https://learn.microsoft.com/graph/api/resources/identityset?view=graph-rest-1.0. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Approver
        {
            get { return BackingStore?.Get<IdentitySet?>("approver"); }
            set { BackingStore?.Set("approver", value); }
        }
#nullable restore
#else
        public IdentitySet Approver
        {
            get { return BackingStore?.Get<IdentitySet>("approver"); }
            set { BackingStore?.Set("approver", value); }
        }
#endif
        /// <summary>Indicates the DateTime when any action on the approval request is no longer permitted. The value cannot be modified and is automatically populated when the request is created using expiration offset values defined in the service controllers. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Returned by default. Read-only. This property is read-only.</summary>
        public DateTimeOffset? ExpirationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Indicates the last DateTime that the request was modified. The value cannot be modified and is automatically populated whenever values in the request are updated. For example, when the &apos;status&apos; property changes from needsApproval to approved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Returned by default. Read-only. This property is read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Indicates the DateTime that the request was made. The value cannot be modified and is automatically populated when the request is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Returned by default. Read-only. This property is read-only.</summary>
        public DateTimeOffset? RequestDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("requestDateTime"); }
            set { BackingStore?.Set("requestDateTime", value); }
        }
        /// <summary>Indicates the justification for creating the request. Maximum length of justification is 1024 characters. For example: &apos;Needed for Feb 2023 application baseline updates.&apos; Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestJustification
        {
            get { return BackingStore?.Get<string?>("requestJustification"); }
            set { BackingStore?.Set("requestJustification", value); }
        }
#nullable restore
#else
        public string RequestJustification
        {
            get { return BackingStore?.Get<string>("requestJustification"); }
            set { BackingStore?.Set("requestJustification", value); }
        }
#endif
        /// <summary>The identity of the requestor as an Identity Set. Optionally contains the application ID, the device ID and the User ID. See information about this type here: https://learn.microsoft.com/graph/api/resources/identityset?view=graph-rest-1.0. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Requestor
        {
            get { return BackingStore?.Get<IdentitySet?>("requestor"); }
            set { BackingStore?.Set("requestor", value); }
        }
#nullable restore
#else
        public IdentitySet Requestor
        {
            get { return BackingStore?.Get<IdentitySet>("requestor"); }
            set { BackingStore?.Set("requestor", value); }
        }
#endif
        /// <summary>Indicates the approval policy types required by the request in order for the request to be approved or rejected. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OperationApprovalPolicyType?>? RequiredOperationApprovalPolicyTypes
        {
            get { return BackingStore?.Get<List<OperationApprovalPolicyType?>?>("requiredOperationApprovalPolicyTypes"); }
            set { BackingStore?.Set("requiredOperationApprovalPolicyTypes", value); }
        }
#nullable restore
#else
        public List<OperationApprovalPolicyType?> RequiredOperationApprovalPolicyTypes
        {
            get { return BackingStore?.Get<List<OperationApprovalPolicyType?>>("requiredOperationApprovalPolicyTypes"); }
            set { BackingStore?.Set("requiredOperationApprovalPolicyTypes", value); }
        }
#endif
        /// <summary>Indicates the status of the Approval Request. The status of a request will change when an action is successfully performed on it, such as when it is `approved` or `rejected`, or when the request&apos;s expiration DateTime passes and the result is `expired`.</summary>
        public OperationApprovalRequestStatus? Status
        {
            get { return BackingStore?.Get<OperationApprovalRequestStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OperationApprovalRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OperationApprovalRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OperationApprovalRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "approvalJustification", n => { ApprovalJustification = n.GetStringValue(); } },
                { "approver", n => { Approver = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "requestDateTime", n => { RequestDateTime = n.GetDateTimeOffsetValue(); } },
                { "requestJustification", n => { RequestJustification = n.GetStringValue(); } },
                { "requestor", n => { Requestor = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                { "requiredOperationApprovalPolicyTypes", n => { RequiredOperationApprovalPolicyTypes = n.GetCollectionOfEnumValues<OperationApprovalPolicyType>()?.ToList(); } },
                { "status", n => { Status = n.GetEnumValue<OperationApprovalRequestStatus>(); } },
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
            writer.WriteEnumValue<OperationApprovalRequestStatus>("status", Status);
        }
    }
}
