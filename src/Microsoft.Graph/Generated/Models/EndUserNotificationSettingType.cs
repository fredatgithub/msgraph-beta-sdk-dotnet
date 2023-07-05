using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum EndUserNotificationSettingType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "noTraining")]
        NoTraining,
        [EnumMember(Value = "trainingSelected")]
        TrainingSelected,
        [EnumMember(Value = "noNotification")]
        NoNotification,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
