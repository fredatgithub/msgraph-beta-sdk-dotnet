using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TrainingCompletionDuration {
        [EnumMember(Value = "week")]
        Week,
        [EnumMember(Value = "fortnite")]
        Fortnite,
        [EnumMember(Value = "month")]
        Month,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
