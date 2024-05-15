// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [Flags]
    #pragma warning disable CS1591
    public enum UserMailboxSetting
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "junkMailDeletion")]
        #pragma warning disable CS1591
        JunkMailDeletion = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "isFromAddressInAddressBook")]
        #pragma warning disable CS1591
        IsFromAddressInAddressBook = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "isFromAddressInAddressSafeList")]
        #pragma warning disable CS1591
        IsFromAddressInAddressSafeList = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "isFromAddressInAddressBlockList")]
        #pragma warning disable CS1591
        IsFromAddressInAddressBlockList = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "isFromAddressInAddressImplicitSafeList")]
        #pragma warning disable CS1591
        IsFromAddressInAddressImplicitSafeList = 32,
        #pragma warning restore CS1591
        [EnumMember(Value = "isFromAddressInAddressImplicitJunkList")]
        #pragma warning disable CS1591
        IsFromAddressInAddressImplicitJunkList = 64,
        #pragma warning restore CS1591
        [EnumMember(Value = "isFromDomainInDomainSafeList")]
        #pragma warning disable CS1591
        IsFromDomainInDomainSafeList = 128,
        #pragma warning restore CS1591
        [EnumMember(Value = "isFromDomainInDomainBlockList")]
        #pragma warning disable CS1591
        IsFromDomainInDomainBlockList = 256,
        #pragma warning restore CS1591
        [EnumMember(Value = "isRecipientInRecipientSafeList")]
        #pragma warning disable CS1591
        IsRecipientInRecipientSafeList = 512,
        #pragma warning restore CS1591
        [EnumMember(Value = "customRule")]
        #pragma warning disable CS1591
        CustomRule = 1024,
        #pragma warning restore CS1591
        [EnumMember(Value = "junkMailRule")]
        #pragma warning disable CS1591
        JunkMailRule = 2048,
        #pragma warning restore CS1591
        [EnumMember(Value = "senderPraPresent")]
        #pragma warning disable CS1591
        SenderPraPresent = 4096,
        #pragma warning restore CS1591
        [EnumMember(Value = "fromFirstTimeSender")]
        #pragma warning disable CS1591
        FromFirstTimeSender = 8192,
        #pragma warning restore CS1591
        [EnumMember(Value = "exclusive")]
        #pragma warning disable CS1591
        Exclusive = 16384,
        #pragma warning restore CS1591
        [EnumMember(Value = "priorSeenPass")]
        #pragma warning disable CS1591
        PriorSeenPass = 32768,
        #pragma warning restore CS1591
        [EnumMember(Value = "senderAuthenticationSucceeded")]
        #pragma warning disable CS1591
        SenderAuthenticationSucceeded = 65536,
        #pragma warning restore CS1591
        [EnumMember(Value = "isJunkMailRuleEnabled")]
        #pragma warning disable CS1591
        IsJunkMailRuleEnabled = 131072,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue = 262144,
        #pragma warning restore CS1591
    }
}
