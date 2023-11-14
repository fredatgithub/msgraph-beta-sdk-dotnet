// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class VirtualEventTownhall : VirtualEvent, IParsable {
        /// <summary>The audience property</summary>
        public MeetingAudience? Audience {
            get { return BackingStore?.Get<MeetingAudience?>("audience"); }
            set { BackingStore?.Set("audience", value); }
        }
        /// <summary>The coOrganizers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CommunicationsUserIdentity>? CoOrganizers {
            get { return BackingStore?.Get<List<CommunicationsUserIdentity>?>("coOrganizers"); }
            set { BackingStore?.Set("coOrganizers", value); }
        }
#nullable restore
#else
        public List<CommunicationsUserIdentity> CoOrganizers {
            get { return BackingStore?.Get<List<CommunicationsUserIdentity>>("coOrganizers"); }
            set { BackingStore?.Set("coOrganizers", value); }
        }
#endif
        /// <summary>The invitedAttendees property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CommunicationsUserIdentity>? InvitedAttendees {
            get { return BackingStore?.Get<List<CommunicationsUserIdentity>?>("invitedAttendees"); }
            set { BackingStore?.Set("invitedAttendees", value); }
        }
#nullable restore
#else
        public List<CommunicationsUserIdentity> InvitedAttendees {
            get { return BackingStore?.Get<List<CommunicationsUserIdentity>>("invitedAttendees"); }
            set { BackingStore?.Set("invitedAttendees", value); }
        }
#endif
        /// <summary>The isInviteOnly property</summary>
        public bool? IsInviteOnly {
            get { return BackingStore?.Get<bool?>("isInviteOnly"); }
            set { BackingStore?.Set("isInviteOnly", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEventTownhall CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEventTownhall();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"audience", n => { Audience = n.GetEnumValue<MeetingAudience>(); } },
                {"coOrganizers", n => { CoOrganizers = n.GetCollectionOfObjectValues<CommunicationsUserIdentity>(CommunicationsUserIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"invitedAttendees", n => { InvitedAttendees = n.GetCollectionOfObjectValues<CommunicationsUserIdentity>(CommunicationsUserIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isInviteOnly", n => { IsInviteOnly = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MeetingAudience>("audience", Audience);
            writer.WriteCollectionOfObjectValues<CommunicationsUserIdentity>("coOrganizers", CoOrganizers);
            writer.WriteCollectionOfObjectValues<CommunicationsUserIdentity>("invitedAttendees", InvitedAttendees);
            writer.WriteBoolValue("isInviteOnly", IsInviteOnly);
        }
    }
}
