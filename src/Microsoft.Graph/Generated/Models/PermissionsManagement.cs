// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class PermissionsManagement : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents a change event of the scheduledPermissionsRequest entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PermissionsRequestChange>? PermissionsRequestChanges
        {
            get { return BackingStore?.Get<List<PermissionsRequestChange>?>("permissionsRequestChanges"); }
            set { BackingStore?.Set("permissionsRequestChanges", value); }
        }
#nullable restore
#else
        public List<PermissionsRequestChange> PermissionsRequestChanges
        {
            get { return BackingStore?.Get<List<PermissionsRequestChange>>("permissionsRequestChanges"); }
            set { BackingStore?.Set("permissionsRequestChanges", value); }
        }
#endif
        /// <summary>The scheduledPermissionsApprovals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Approval>? ScheduledPermissionsApprovals
        {
            get { return BackingStore?.Get<List<Approval>?>("scheduledPermissionsApprovals"); }
            set { BackingStore?.Set("scheduledPermissionsApprovals", value); }
        }
#nullable restore
#else
        public List<Approval> ScheduledPermissionsApprovals
        {
            get { return BackingStore?.Get<List<Approval>>("scheduledPermissionsApprovals"); }
            set { BackingStore?.Set("scheduledPermissionsApprovals", value); }
        }
#endif
        /// <summary>Represents a permissions request that Permissions Management uses to manage permissions for an identity on resources in the authorization system. This request can be granted, rejected or canceled by identities in Permissions Management.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScheduledPermissionsRequest>? ScheduledPermissionsRequests
        {
            get { return BackingStore?.Get<List<ScheduledPermissionsRequest>?>("scheduledPermissionsRequests"); }
            set { BackingStore?.Set("scheduledPermissionsRequests", value); }
        }
#nullable restore
#else
        public List<ScheduledPermissionsRequest> ScheduledPermissionsRequests
        {
            get { return BackingStore?.Get<List<ScheduledPermissionsRequest>>("scheduledPermissionsRequests"); }
            set { BackingStore?.Set("scheduledPermissionsRequests", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PermissionsManagement"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PermissionsManagement CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PermissionsManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "permissionsRequestChanges", n => { PermissionsRequestChanges = n.GetCollectionOfObjectValues<PermissionsRequestChange>(PermissionsRequestChange.CreateFromDiscriminatorValue)?.ToList(); } },
                { "scheduledPermissionsApprovals", n => { ScheduledPermissionsApprovals = n.GetCollectionOfObjectValues<Approval>(Approval.CreateFromDiscriminatorValue)?.ToList(); } },
                { "scheduledPermissionsRequests", n => { ScheduledPermissionsRequests = n.GetCollectionOfObjectValues<ScheduledPermissionsRequest>(ScheduledPermissionsRequest.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<PermissionsRequestChange>("permissionsRequestChanges", PermissionsRequestChanges);
            writer.WriteCollectionOfObjectValues<Approval>("scheduledPermissionsApprovals", ScheduledPermissionsApprovals);
            writer.WriteCollectionOfObjectValues<ScheduledPermissionsRequest>("scheduledPermissionsRequests", ScheduledPermissionsRequests);
        }
    }
}
