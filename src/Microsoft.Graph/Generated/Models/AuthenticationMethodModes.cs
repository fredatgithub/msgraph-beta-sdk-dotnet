// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [Flags]
    #pragma warning disable CS1591
    public enum AuthenticationMethodModes
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "password")]
        #pragma warning disable CS1591
        Password = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "voice")]
        #pragma warning disable CS1591
        Voice = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "hardwareOath")]
        #pragma warning disable CS1591
        HardwareOath = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "softwareOath")]
        #pragma warning disable CS1591
        SoftwareOath = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "sms")]
        #pragma warning disable CS1591
        Sms = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "fido2")]
        #pragma warning disable CS1591
        Fido2 = 32,
        #pragma warning restore CS1591
        [EnumMember(Value = "windowsHelloForBusiness")]
        #pragma warning disable CS1591
        WindowsHelloForBusiness = 64,
        #pragma warning restore CS1591
        [EnumMember(Value = "microsoftAuthenticatorPush")]
        #pragma warning disable CS1591
        MicrosoftAuthenticatorPush = 128,
        #pragma warning restore CS1591
        [EnumMember(Value = "deviceBasedPush")]
        #pragma warning disable CS1591
        DeviceBasedPush = 256,
        #pragma warning restore CS1591
        [EnumMember(Value = "temporaryAccessPassOneTime")]
        #pragma warning disable CS1591
        TemporaryAccessPassOneTime = 512,
        #pragma warning restore CS1591
        [EnumMember(Value = "temporaryAccessPassMultiUse")]
        #pragma warning disable CS1591
        TemporaryAccessPassMultiUse = 1024,
        #pragma warning restore CS1591
        [EnumMember(Value = "email")]
        #pragma warning disable CS1591
        Email = 2048,
        #pragma warning restore CS1591
        [EnumMember(Value = "x509CertificateSingleFactor")]
        #pragma warning disable CS1591
        X509CertificateSingleFactor = 4096,
        #pragma warning restore CS1591
        [EnumMember(Value = "x509CertificateMultiFactor")]
        #pragma warning disable CS1591
        X509CertificateMultiFactor = 8192,
        #pragma warning restore CS1591
        [EnumMember(Value = "federatedSingleFactor")]
        #pragma warning disable CS1591
        FederatedSingleFactor = 16384,
        #pragma warning restore CS1591
        [EnumMember(Value = "federatedMultiFactor")]
        #pragma warning disable CS1591
        FederatedMultiFactor = 32768,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue = 65536,
        #pragma warning restore CS1591
    }
}
