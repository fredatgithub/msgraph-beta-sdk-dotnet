// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Device Management Autopilot Event.
    /// </summary>
    public partial class DeviceManagementAutopilotEvent : Entity
    {
    
		///<summary>
		/// The DeviceManagementAutopilotEvent constructor
		///</summary>
        public DeviceManagementAutopilotEvent()
        {
            this.ODataType = "microsoft.graph.deviceManagementAutopilotEvent";
        }
	
        /// <summary>
        /// Gets or sets account setup duration.
        /// Time spent in user ESP.
        /// </summary>
        [JsonPropertyName("accountSetupDuration")]
        public Duration AccountSetupDuration { get; set; }
    
        /// <summary>
        /// Gets or sets account setup status.
        /// Deployment status for the enrollment status page account setup phase. Possible values are: unknown, success, inProgress, failure, successWithTimeout, notAttempted, disabled.
        /// </summary>
        [JsonPropertyName("accountSetupStatus")]
        public WindowsAutopilotDeploymentState? AccountSetupStatus { get; set; }
    
        /// <summary>
        /// Gets or sets deployment duration.
        /// Autopilot deployment duration including enrollment.
        /// </summary>
        [JsonPropertyName("deploymentDuration")]
        public Duration DeploymentDuration { get; set; }
    
        /// <summary>
        /// Gets or sets deployment end date time.
        /// Deployment end time.
        /// </summary>
        [JsonPropertyName("deploymentEndDateTime")]
        public DateTimeOffset? DeploymentEndDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets deployment start date time.
        /// Deployment start time.
        /// </summary>
        [JsonPropertyName("deploymentStartDateTime")]
        public DateTimeOffset? DeploymentStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets deployment state.
        /// Deployment state like Success, Failure, InProgress, SuccessWithTimeout. Possible values are: unknown, success, inProgress, failure, successWithTimeout, notAttempted, disabled.
        /// </summary>
        [JsonPropertyName("deploymentState")]
        public WindowsAutopilotDeploymentState? DeploymentState { get; set; }
    
        /// <summary>
        /// Gets or sets deployment total duration.
        /// Total deployment duration from enrollment to Desktop screen.
        /// </summary>
        [JsonPropertyName("deploymentTotalDuration")]
        public Duration DeploymentTotalDuration { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// Device id associated with the object
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device preparation duration.
        /// Time spent in device enrollment.
        /// </summary>
        [JsonPropertyName("devicePreparationDuration")]
        public Duration DevicePreparationDuration { get; set; }
    
        /// <summary>
        /// Gets or sets device registered date time.
        /// Device registration date.
        /// </summary>
        [JsonPropertyName("deviceRegisteredDateTime")]
        public DateTimeOffset? DeviceRegisteredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device serial number.
        /// Device serial number.
        /// </summary>
        [JsonPropertyName("deviceSerialNumber")]
        public string DeviceSerialNumber { get; set; }
    
        /// <summary>
        /// Gets or sets device setup duration.
        /// Time spent in device ESP.
        /// </summary>
        [JsonPropertyName("deviceSetupDuration")]
        public Duration DeviceSetupDuration { get; set; }
    
        /// <summary>
        /// Gets or sets device setup status.
        /// Deployment status for the enrollment status page device setup phase. Possible values are: unknown, success, inProgress, failure, successWithTimeout, notAttempted, disabled.
        /// </summary>
        [JsonPropertyName("deviceSetupStatus")]
        public WindowsAutopilotDeploymentState? DeviceSetupStatus { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment failure details.
        /// Enrollment failure details.
        /// </summary>
        [JsonPropertyName("enrollmentFailureDetails")]
        public string EnrollmentFailureDetails { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment start date time.
        /// Device enrollment start date.
        /// </summary>
        [JsonPropertyName("enrollmentStartDateTime")]
        public DateTimeOffset? EnrollmentStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment state.
        /// Enrollment state like Enrolled, Failed. Possible values are: unknown, enrolled, pendingReset, failed, notContacted, blocked.
        /// </summary>
        [JsonPropertyName("enrollmentState")]
        public EnrollmentState? EnrollmentState { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment type.
        /// Enrollment type. Possible values are: unknown, azureADJoinedWithAutopilotProfile, offlineDomainJoined, azureADJoinedUsingDeviceAuthWithAutopilotProfile, azureADJoinedUsingDeviceAuthWithoutAutopilotProfile, azureADJoinedWithOfflineAutopilotProfile, azureADJoinedWithWhiteGlove, offlineDomainJoinedWithWhiteGlove, offlineDomainJoinedWithOfflineAutopilotProfile.
        /// </summary>
        [JsonPropertyName("enrollmentType")]
        public WindowsAutopilotEnrollmentType? EnrollmentType { get; set; }
    
        /// <summary>
        /// Gets or sets event date time.
        /// Time when the event occurred .
        /// </summary>
        [JsonPropertyName("eventDateTime")]
        public DateTimeOffset? EventDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets managed device name.
        /// Managed device name.
        /// </summary>
        [JsonPropertyName("managedDeviceName")]
        public string ManagedDeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// Device operating system version.
        /// </summary>
        [JsonPropertyName("osVersion")]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets targeted app count.
        /// Count of applications targeted.
        /// </summary>
        [JsonPropertyName("targetedAppCount")]
        public Int32? TargetedAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets targeted policy count.
        /// Count of policies targeted.
        /// </summary>
        [JsonPropertyName("targetedPolicyCount")]
        public Int32? TargetedPolicyCount { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User principal name used to enroll the device.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets windows10enrollment completion page configuration display name.
        /// Enrollment Status Page profile name
        /// </summary>
        [JsonPropertyName("windows10EnrollmentCompletionPageConfigurationDisplayName")]
        public string Windows10EnrollmentCompletionPageConfigurationDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets windows10enrollment completion page configuration id.
        /// Enrollment Status Page profile ID
        /// </summary>
        [JsonPropertyName("windows10EnrollmentCompletionPageConfigurationId")]
        public string Windows10EnrollmentCompletionPageConfigurationId { get; set; }
    
        /// <summary>
        /// Gets or sets windows autopilot deployment profile display name.
        /// Autopilot profile name.
        /// </summary>
        [JsonPropertyName("windowsAutopilotDeploymentProfileDisplayName")]
        public string WindowsAutopilotDeploymentProfileDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets policy status details.
        /// Policy and application status details for this device.
        /// </summary>
        [JsonPropertyName("policyStatusDetails")]
        public IDeviceManagementAutopilotEventPolicyStatusDetailsCollectionPage PolicyStatusDetails { get; set; }
    
    }
}

