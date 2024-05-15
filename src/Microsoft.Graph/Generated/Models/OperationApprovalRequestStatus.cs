// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Indicates the status of the Approval Request. The status of a request will change when an action is successfully performed on it, such as when it is `approved` or `rejected`, or when the request&apos;s expiration DateTime passes and the result is `expired`.</summary>
    public enum OperationApprovalRequestStatus
    {
        /// <summary>Default. Indicates that the request approval status is unknown, and that the status has not been assigned to the approval request.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates that the approval request needs approval before the operation can be completed.</summary>
        [EnumMember(Value = "needsApproval")]
        NeedsApproval,
        /// <summary>Indicates that the approval request has been approved. The operation can now be completed.</summary>
        [EnumMember(Value = "approved")]
        Approved,
        /// <summary>Indicates that the approval request has been rejected. No further action can be taken to complete the operation or to modify the request.</summary>
        [EnumMember(Value = "rejected")]
        Rejected,
        /// <summary>Indicates that the approval request has been cancelled by the request&apos;s requestor. No further action can be taken to complete the operation or to modify the request.</summary>
        [EnumMember(Value = "cancelled")]
        Cancelled,
        /// <summary>Indicates that the approval request has been completed. This status is feature agnostic and does not indicate success or failure of the operation. No further action is necessary for the operation or to modify the request.</summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>Indicates that the approval request has expired. No further action can be taken to complete the operation or to modify the request. A new approval request must be made and approved in order to complete the operation.</summary>
        [EnumMember(Value = "expired")]
        Expired,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
