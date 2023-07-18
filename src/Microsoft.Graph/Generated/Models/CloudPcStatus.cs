using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum CloudPcStatus {
        [EnumMember(Value = "notProvisioned")]
        NotProvisioned,
        [EnumMember(Value = "provisioning")]
        Provisioning,
        [EnumMember(Value = "provisioned")]
        Provisioned,
        [EnumMember(Value = "inGracePeriod")]
        InGracePeriod,
        [EnumMember(Value = "deprovisioning")]
        Deprovisioning,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "provisionedWithWarnings")]
        ProvisionedWithWarnings,
        [EnumMember(Value = "resizing")]
        Resizing,
        [EnumMember(Value = "restoring")]
        Restoring,
        [EnumMember(Value = "pendingProvision")]
        PendingProvision,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "movingRegion")]
        MovingRegion,
        [EnumMember(Value = "resizePendingLicense")]
        ResizePendingLicense,
        [EnumMember(Value = "updatingSingleSignOn")]
        UpdatingSingleSignOn,
    }
}
