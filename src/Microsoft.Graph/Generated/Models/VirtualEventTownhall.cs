// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class VirtualEventTownhall : VirtualEvent, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The audience to whom the town hall is visible. Possible values are: everyone, organization, unknownFutureValue.</summary>
        public MeetingAudience? Audience
        {
            get { return BackingStore?.Get<MeetingAudience?>("audience"); }
            set { BackingStore?.Set("audience", value); }
        }
        /// <summary>Identity information of the coorganizers of the town hall.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CommunicationsUserIdentity>? CoOrganizers
        {
            get { return BackingStore?.Get<List<CommunicationsUserIdentity>?>("coOrganizers"); }
            set { BackingStore?.Set("coOrganizers", value); }
        }
#nullable restore
#else
        public List<CommunicationsUserIdentity> CoOrganizers
        {
            get { return BackingStore?.Get<List<CommunicationsUserIdentity>>("coOrganizers"); }
            set { BackingStore?.Set("coOrganizers", value); }
        }
#endif
        /// <summary>The attendees invited to the town hall. The supported identites are: communicationsUserIdentity and communicationsGuestIdentity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Identity>? InvitedAttendees
        {
            get { return BackingStore?.Get<List<Identity>?>("invitedAttendees"); }
            set { BackingStore?.Set("invitedAttendees", value); }
        }
#nullable restore
#else
        public List<Identity> InvitedAttendees
        {
            get { return BackingStore?.Get<List<Identity>>("invitedAttendees"); }
            set { BackingStore?.Set("invitedAttendees", value); }
        }
#endif
        /// <summary>Indicates whether the town hall is only open to invited people and groups within your organization. The isInviteOnly property can only be true if the value of the audience property is set to organization.</summary>
        public bool? IsInviteOnly
        {
            get { return BackingStore?.Get<bool?>("isInviteOnly"); }
            set { BackingStore?.Set("isInviteOnly", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="VirtualEventTownhall"/> and sets the default values.
        /// </summary>
        public VirtualEventTownhall() : base()
        {
            OdataType = "#microsoft.graph.virtualEventTownhall";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="VirtualEventTownhall"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEventTownhall CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEventTownhall();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "audience", n => { Audience = n.GetEnumValue<MeetingAudience>(); } },
                { "coOrganizers", n => { CoOrganizers = n.GetCollectionOfObjectValues<CommunicationsUserIdentity>(CommunicationsUserIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                { "invitedAttendees", n => { InvitedAttendees = n.GetCollectionOfObjectValues<Identity>(Identity.CreateFromDiscriminatorValue)?.ToList(); } },
                { "isInviteOnly", n => { IsInviteOnly = n.GetBoolValue(); } },
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
            writer.WriteEnumValue<MeetingAudience>("audience", Audience);
            writer.WriteCollectionOfObjectValues<CommunicationsUserIdentity>("coOrganizers", CoOrganizers);
            writer.WriteCollectionOfObjectValues<Identity>("invitedAttendees", InvitedAttendees);
            writer.WriteBoolValue("isInviteOnly", IsInviteOnly);
        }
    }
}
