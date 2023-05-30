using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum UserType {
        [EnumMember(Value = "member")]
        Member,
        [EnumMember(Value = "guest")]
        Guest,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
