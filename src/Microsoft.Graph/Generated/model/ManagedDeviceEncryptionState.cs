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
    /// The type Managed Device Encryption State.
    /// </summary>
    public partial class ManagedDeviceEncryptionState : Entity
    {
    
		///<summary>
		/// The ManagedDeviceEncryptionState constructor
		///</summary>
        public ManagedDeviceEncryptionState()
        {
            this.ODataType = "microsoft.graph.managedDeviceEncryptionState";
        }
	
        /// <summary>
        /// Gets or sets advanced bit locker states.
        /// Advanced BitLocker State. Possible values are: success, noUserConsent, osVolumeUnprotected, osVolumeTpmRequired, osVolumeTpmOnlyRequired, osVolumeTpmPinRequired, osVolumeTpmStartupKeyRequired, osVolumeTpmPinStartupKeyRequired, osVolumeEncryptionMethodMismatch, recoveryKeyBackupFailed, fixedDriveNotEncrypted, fixedDriveEncryptionMethodMismatch, loggedOnUserNonAdmin, windowsRecoveryEnvironmentNotConfigured, tpmNotAvailable, tpmNotReady, networkError.
        /// </summary>
        [JsonPropertyName("advancedBitLockerStates")]
        public AdvancedBitLockerState? AdvancedBitLockerStates { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Device name
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets device type.
        /// Platform of the device. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, blackberry, palm, unknown.
        /// </summary>
        [JsonPropertyName("deviceType")]
        public DeviceTypes? DeviceType { get; set; }
    
        /// <summary>
        /// Gets or sets encryption policy setting state.
        /// Encryption policy setting state. Possible values are: unknown, notApplicable, compliant, remediated, nonCompliant, error, conflict, notAssigned.
        /// </summary>
        [JsonPropertyName("encryptionPolicySettingState")]
        public ComplianceStatus? EncryptionPolicySettingState { get; set; }
    
        /// <summary>
        /// Gets or sets encryption readiness state.
        /// Encryption readiness state. Possible values are: notReady, ready.
        /// </summary>
        [JsonPropertyName("encryptionReadinessState")]
        public EncryptionReadinessState? EncryptionReadinessState { get; set; }
    
        /// <summary>
        /// Gets or sets encryption state.
        /// Device encryption state. Possible values are: notEncrypted, encrypted.
        /// </summary>
        [JsonPropertyName("encryptionState")]
        public EncryptionState? EncryptionState { get; set; }
    
        /// <summary>
        /// Gets or sets file vault states.
        /// FileVault State. Possible values are: success, driveEncryptedByUser, userDeferredEncryption, escrowNotEnabled.
        /// </summary>
        [JsonPropertyName("fileVaultStates")]
        public FileVaultState? FileVaultStates { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// Operating system version of the device
        /// </summary>
        [JsonPropertyName("osVersion")]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets policy details.
        /// Policy Details
        /// </summary>
        [JsonPropertyName("policyDetails")]
        public IEnumerable<EncryptionReportPolicyDetails> PolicyDetails { get; set; }
    
        /// <summary>
        /// Gets or sets tpm specification version.
        /// Device TPM Version
        /// </summary>
        [JsonPropertyName("tpmSpecificationVersion")]
        public string TpmSpecificationVersion { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User name
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
    }
}

