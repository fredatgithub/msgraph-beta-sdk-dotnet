using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum TrainingAvailabilityStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "notAvailable")]
        NotAvailable,
        [EnumMember(Value = "available")]
        Available,
        [EnumMember(Value = "archive")]
        Archive,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
