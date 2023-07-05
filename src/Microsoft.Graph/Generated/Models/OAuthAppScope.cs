using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum OAuthAppScope {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "readCalendar")]
        ReadCalendar,
        [EnumMember(Value = "readContact")]
        ReadContact,
        [EnumMember(Value = "readMail")]
        ReadMail,
        [EnumMember(Value = "readAllChat")]
        ReadAllChat,
        [EnumMember(Value = "readAllFile")]
        ReadAllFile,
        [EnumMember(Value = "readAndWriteMail")]
        ReadAndWriteMail,
        [EnumMember(Value = "sendMail")]
        SendMail,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
