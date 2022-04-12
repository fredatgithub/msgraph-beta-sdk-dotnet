using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class TenantTag : Entity, IParsable {
        /// <summary>The identifier for the account that created the tenant tag. Required. Read-only.</summary>
        public string CreatedByUserId { get; set; }
        /// <summary>The date and time when the tenant tag was created. Required. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The date and time when the tenant tag was deleted. Required. Read-only.</summary>
        public DateTimeOffset? DeletedDateTime { get; set; }
        /// <summary>The description for the tenant tag. Optional. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the tenant tag. Required. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The identifier for the account that lasted on the tenant tag. Optional. Read-only.</summary>
        public string LastActionByUserId { get; set; }
        /// <summary>The date and time the last action was performed against the tenant tag. Optional. Read-only.</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>The collection of managed tenants associated with the tenant tag. Optional.</summary>
        public List<TenantInfo> Tenants { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TenantTag CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantTag();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdByUserId", n => { CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastActionByUserId", n => { LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"tenants", n => { Tenants = n.GetCollectionOfObjectValues<TenantInfo>(TenantInfo.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteCollectionOfObjectValues<TenantInfo>("tenants", Tenants);
        }
    }
}
