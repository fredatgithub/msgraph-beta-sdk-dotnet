using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TargettedUserType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "clicked")]
        Clicked,
        [EnumMember(Value = "compromised")]
        Compromised,
        [EnumMember(Value = "allUsers")]
        AllUsers,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
