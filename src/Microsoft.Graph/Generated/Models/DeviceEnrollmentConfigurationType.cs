// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Describes the TemplateFamily for the Template entity</summary>
    public enum DeviceEnrollmentConfigurationType
    {
        /// <summary>Default. Set to unknown if the configuration type cannot be determined.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates that configuration is of type limit which refers to number of devices a user is allowed to enroll.</summary>
        [EnumMember(Value = "limit")]
        Limit,
        /// <summary>Indicates that configuration is of type platform restriction which refers to types of devices a user is allowed to enroll.</summary>
        [EnumMember(Value = "platformRestrictions")]
        PlatformRestrictions,
        /// <summary>Indicates that configuration is of type Windows Hello which refers to authentication method devices would use.</summary>
        [EnumMember(Value = "windowsHelloForBusiness")]
        WindowsHelloForBusiness,
        /// <summary>Indicates that configuration is of type default limit which refers to types of devices a user is allowed to enroll by default.</summary>
        [EnumMember(Value = "defaultLimit")]
        DefaultLimit,
        /// <summary>Indicates that configuration is of type default platform restriction which refers to types of devices a user is allowed to enroll by default.</summary>
        [EnumMember(Value = "defaultPlatformRestrictions")]
        DefaultPlatformRestrictions,
        /// <summary>Indicates that configuration is of type default Windows Hello which refers to authentication method devices would use by default.</summary>
        [EnumMember(Value = "defaultWindowsHelloForBusiness")]
        DefaultWindowsHelloForBusiness,
        /// <summary>Indicates that configuration is of type default Enrollment status page which refers to startup page displayed during OOBE in Autopilot devices by default.</summary>
        [EnumMember(Value = "defaultWindows10EnrollmentCompletionPageConfiguration")]
        DefaultWindows10EnrollmentCompletionPageConfiguration,
        /// <summary>Indicates that configuration is of type Enrollment status page which refers to startup page displayed during OOBE in Autopilot devices.</summary>
        [EnumMember(Value = "windows10EnrollmentCompletionPageConfiguration")]
        Windows10EnrollmentCompletionPageConfiguration,
        /// <summary>Indicates that configuration is of type Comanagement Authority which refers to policies applied to Co-Managed devices.</summary>
        [EnumMember(Value = "deviceComanagementAuthorityConfiguration")]
        DeviceComanagementAuthorityConfiguration,
        /// <summary>Indicates that configuration is of type single platform restriction which refers to types of devices a user is allowed to enroll.</summary>
        [EnumMember(Value = "singlePlatformRestriction")]
        SinglePlatformRestriction,
        /// <summary>Unknown future value</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        /// <summary>Indicates that configuration is of type Enrollment Notification which refers to types of notification a user receives during enrollment.</summary>
        [EnumMember(Value = "enrollmentNotificationsConfiguration")]
        EnrollmentNotificationsConfiguration,
    }
}
