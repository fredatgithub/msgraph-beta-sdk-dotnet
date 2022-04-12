using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RoleAssignment : Entity, IParsable {
        /// <summary>Description of the Role Assignment.</summary>
        public string Description { get; set; }
        /// <summary>The display or friendly name of the role Assignment.</summary>
        public string DisplayName { get; set; }
        /// <summary>List of ids of role scope member security groups.  These are IDs from Azure Active Directory.</summary>
        public List<string> ResourceScopes { get; set; }
        /// <summary>Role definition this assignment is part of.</summary>
        public Microsoft.Graph.Beta.Models.RoleDefinition RoleDefinition { get; set; }
        /// <summary>List of ids of role scope member security groups.  These are IDs from Azure Active Directory.</summary>
        public List<string> ScopeMembers { get; set; }
        /// <summary>Specifies the type of scope for a Role Assignment. Default type &apos;ResourceScope&apos; allows assignment of ResourceScopes. For &apos;AllDevices&apos;, &apos;AllLicensedUsers&apos;, and &apos;AllDevicesAndLicensedUsers&apos;, the ResourceScopes property should be left empty. Possible values are: resourceScope, allDevices, allLicensedUsers, allDevicesAndLicensedUsers.</summary>
        public RoleAssignmentScopeType? ScopeType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"resourceScopes", n => { ResourceScopes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"roleDefinition", n => { RoleDefinition = n.GetObjectValue<Microsoft.Graph.Beta.Models.RoleDefinition>(Microsoft.Graph.Beta.Models.RoleDefinition.CreateFromDiscriminatorValue); } },
                {"scopeMembers", n => { ScopeMembers = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"scopeType", n => { ScopeType = n.GetEnumValue<RoleAssignmentScopeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("resourceScopes", ResourceScopes);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.RoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteCollectionOfPrimitiveValues<string>("scopeMembers", ScopeMembers);
            writer.WriteEnumValue<RoleAssignmentScopeType>("scopeType", ScopeType);
        }
    }
}
