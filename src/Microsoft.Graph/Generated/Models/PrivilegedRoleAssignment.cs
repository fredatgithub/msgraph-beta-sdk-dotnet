using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PrivilegedRoleAssignment : Entity, IParsable {
        /// <summary>The UTC DateTime when the temporary privileged role assignment will be expired. For permanent role assignment, the value is null.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>true if the role assignment is activated. false if the role assignment is deactivated.</summary>
        public bool? IsElevated { get; set; }
        /// <summary>Result message set by the service.</summary>
        public string ResultMessage { get; set; }
        /// <summary>Role identifier. In GUID string format.</summary>
        public string RoleId { get; set; }
        /// <summary>Read-only. Nullable. The associated role information.</summary>
        public PrivilegedRole RoleInfo { get; set; }
        /// <summary>User identifier. In GUID string format.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrivilegedRoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedRoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"isElevated", n => { IsElevated = n.GetBoolValue(); } },
                {"resultMessage", n => { ResultMessage = n.GetStringValue(); } },
                {"roleId", n => { RoleId = n.GetStringValue(); } },
                {"roleInfo", n => { RoleInfo = n.GetObjectValue<PrivilegedRole>(PrivilegedRole.CreateFromDiscriminatorValue); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteBoolValue("isElevated", IsElevated);
            writer.WriteStringValue("resultMessage", ResultMessage);
            writer.WriteStringValue("roleId", RoleId);
            writer.WriteObjectValue<PrivilegedRole>("roleInfo", RoleInfo);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
