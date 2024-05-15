// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class MultiTenantOrganization : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Date when multitenant organization was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Description of the multitenant organization.</summary>
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
        /// <summary>Display name of the multitenant organization.</summary>
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
        /// <summary>Defines the status of a tenant joining a multitenant organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MultiTenantOrganizationJoinRequestRecord? JoinRequest
        {
            get { return BackingStore?.Get<MultiTenantOrganizationJoinRequestRecord?>("joinRequest"); }
            set { BackingStore?.Set("joinRequest", value); }
        }
#nullable restore
#else
        public MultiTenantOrganizationJoinRequestRecord JoinRequest
        {
            get { return BackingStore?.Get<MultiTenantOrganizationJoinRequestRecord>("joinRequest"); }
            set { BackingStore?.Set("joinRequest", value); }
        }
#endif
        /// <summary>State of the multitenant organization. The possible values are: active, inactive, unknownFutureValue. active indicates the multitenant organization is created. inactive indicates the multitenant organization isn&apos;t created. Read-only.</summary>
        public MultiTenantOrganizationState? State
        {
            get { return BackingStore?.Get<MultiTenantOrganizationState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>Defines tenants added to a multitenant organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MultiTenantOrganizationMember>? Tenants
        {
            get { return BackingStore?.Get<List<MultiTenantOrganizationMember>?>("tenants"); }
            set { BackingStore?.Set("tenants", value); }
        }
#nullable restore
#else
        public List<MultiTenantOrganizationMember> Tenants
        {
            get { return BackingStore?.Get<List<MultiTenantOrganizationMember>>("tenants"); }
            set { BackingStore?.Set("tenants", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MultiTenantOrganization"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MultiTenantOrganization CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MultiTenantOrganization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "joinRequest", n => { JoinRequest = n.GetObjectValue<MultiTenantOrganizationJoinRequestRecord>(MultiTenantOrganizationJoinRequestRecord.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<MultiTenantOrganizationState>(); } },
                { "tenants", n => { Tenants = n.GetCollectionOfObjectValues<MultiTenantOrganizationMember>(MultiTenantOrganizationMember.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<MultiTenantOrganizationJoinRequestRecord>("joinRequest", JoinRequest);
            writer.WriteEnumValue<MultiTenantOrganizationState>("state", State);
            writer.WriteCollectionOfObjectValues<MultiTenantOrganizationMember>("tenants", Tenants);
        }
    }
}
