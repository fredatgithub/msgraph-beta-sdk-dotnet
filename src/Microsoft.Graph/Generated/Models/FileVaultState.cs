// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>FileVault State</summary>
    [Flags]
    public enum FileVaultState
    {
        /// <summary>FileVault State Success</summary>
        [EnumMember(Value = "success")]
        Success = 1,
        /// <summary>FileVault has been enabled by user and is not being managed by policy</summary>
        [EnumMember(Value = "driveEncryptedByUser")]
        DriveEncryptedByUser = 2,
        /// <summary>FileVault policy is successfully installed but user has not started encryption</summary>
        [EnumMember(Value = "userDeferredEncryption")]
        UserDeferredEncryption = 4,
        /// <summary>FileVault recovery key escrow is not enabled</summary>
        [EnumMember(Value = "escrowNotEnabled")]
        EscrowNotEnabled = 8,
    }
}
