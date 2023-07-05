using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TrainingAssignedTo {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "allUsers")]
        AllUsers,
        [EnumMember(Value = "clickedPayload")]
        ClickedPayload,
        [EnumMember(Value = "compromised")]
        Compromised,
        [EnumMember(Value = "reportedPhish")]
        ReportedPhish,
        [EnumMember(Value = "readButNotClicked")]
        ReadButNotClicked,
        [EnumMember(Value = "didNothing")]
        DidNothing,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
