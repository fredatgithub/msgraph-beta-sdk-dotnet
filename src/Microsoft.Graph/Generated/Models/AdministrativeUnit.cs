// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AdministrativeUnit : DirectoryObject, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The collection of open extensions defined for this administrative unit. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Extension>? Extensions
        {
            get { return BackingStore?.Get<List<Extension>?>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#nullable restore
#else
        public List<Extension> Extensions
        {
            get { return BackingStore?.Get<List<Extension>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#endif
        /// <summary>The isMemberManagementRestricted property</summary>
        public bool? IsMemberManagementRestricted
        {
            get { return BackingStore?.Get<bool?>("isMemberManagementRestricted"); }
            set { BackingStore?.Set("isMemberManagementRestricted", value); }
        }
        /// <summary>Users and groups that are members of this administrative unit. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? Members
        {
            get { return BackingStore?.Get<List<DirectoryObject>?>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#nullable restore
#else
        public List<DirectoryObject> Members
        {
            get { return BackingStore?.Get<List<DirectoryObject>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
#endif
        /// <summary>The membershipRule property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembershipRule
        {
            get { return BackingStore?.Get<string?>("membershipRule"); }
            set { BackingStore?.Set("membershipRule", value); }
        }
#nullable restore
#else
        public string MembershipRule
        {
            get { return BackingStore?.Get<string>("membershipRule"); }
            set { BackingStore?.Set("membershipRule", value); }
        }
#endif
        /// <summary>The membershipRuleProcessingState property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembershipRuleProcessingState
        {
            get { return BackingStore?.Get<string?>("membershipRuleProcessingState"); }
            set { BackingStore?.Set("membershipRuleProcessingState", value); }
        }
#nullable restore
#else
        public string MembershipRuleProcessingState
        {
            get { return BackingStore?.Get<string>("membershipRuleProcessingState"); }
            set { BackingStore?.Set("membershipRuleProcessingState", value); }
        }
#endif
        /// <summary>The membershipType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembershipType
        {
            get { return BackingStore?.Get<string?>("membershipType"); }
            set { BackingStore?.Set("membershipType", value); }
        }
#nullable restore
#else
        public string MembershipType
        {
            get { return BackingStore?.Get<string>("membershipType"); }
            set { BackingStore?.Set("membershipType", value); }
        }
#endif
        /// <summary>Scoped-role members of this administrative unit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScopedRoleMembership>? ScopedRoleMembers
        {
            get { return BackingStore?.Get<List<ScopedRoleMembership>?>("scopedRoleMembers"); }
            set { BackingStore?.Set("scopedRoleMembers", value); }
        }
#nullable restore
#else
        public List<ScopedRoleMembership> ScopedRoleMembers
        {
            get { return BackingStore?.Get<List<ScopedRoleMembership>>("scopedRoleMembers"); }
            set { BackingStore?.Set("scopedRoleMembers", value); }
        }
#endif
        /// <summary>The visibility property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Visibility
        {
            get { return BackingStore?.Get<string?>("visibility"); }
            set { BackingStore?.Set("visibility", value); }
        }
#nullable restore
#else
        public string Visibility
        {
            get { return BackingStore?.Get<string>("visibility"); }
            set { BackingStore?.Set("visibility", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="AdministrativeUnit"/> and sets the default values.
        /// </summary>
        public AdministrativeUnit() : base()
        {
            OdataType = "#microsoft.graph.administrativeUnit";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AdministrativeUnit"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AdministrativeUnit CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AdministrativeUnit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                { "isMemberManagementRestricted", n => { IsMemberManagementRestricted = n.GetBoolValue(); } },
                { "members", n => { Members = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                { "membershipRule", n => { MembershipRule = n.GetStringValue(); } },
                { "membershipRuleProcessingState", n => { MembershipRuleProcessingState = n.GetStringValue(); } },
                { "membershipType", n => { MembershipType = n.GetStringValue(); } },
                { "scopedRoleMembers", n => { ScopedRoleMembers = n.GetCollectionOfObjectValues<ScopedRoleMembership>(ScopedRoleMembership.CreateFromDiscriminatorValue)?.ToList(); } },
                { "visibility", n => { Visibility = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteBoolValue("isMemberManagementRestricted", IsMemberManagementRestricted);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("members", Members);
            writer.WriteStringValue("membershipRule", MembershipRule);
            writer.WriteStringValue("membershipRuleProcessingState", MembershipRuleProcessingState);
            writer.WriteStringValue("membershipType", MembershipType);
            writer.WriteCollectionOfObjectValues<ScopedRoleMembership>("scopedRoleMembers", ScopedRoleMembers);
            writer.WriteStringValue("visibility", Visibility);
        }
    }
}
