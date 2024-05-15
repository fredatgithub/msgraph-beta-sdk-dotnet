// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class PermissionGrantPolicy : PolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Condition sets that are excluded in this permission grant policy. Automatically expanded on GET.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PermissionGrantConditionSet>? Excludes
        {
            get { return BackingStore?.Get<List<PermissionGrantConditionSet>?>("excludes"); }
            set { BackingStore?.Set("excludes", value); }
        }
#nullable restore
#else
        public List<PermissionGrantConditionSet> Excludes
        {
            get { return BackingStore?.Get<List<PermissionGrantConditionSet>>("excludes"); }
            set { BackingStore?.Set("excludes", value); }
        }
#endif
        /// <summary>Condition sets that are included in this permission grant policy. Automatically expanded on GET.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PermissionGrantConditionSet>? Includes
        {
            get { return BackingStore?.Get<List<PermissionGrantConditionSet>?>("includes"); }
            set { BackingStore?.Set("includes", value); }
        }
#nullable restore
#else
        public List<PermissionGrantConditionSet> Includes
        {
            get { return BackingStore?.Get<List<PermissionGrantConditionSet>>("includes"); }
            set { BackingStore?.Set("includes", value); }
        }
#endif
        /// <summary>The resource type the pre-approval policy applies to. Possible values: team for groups and teams, chat for chats, tenant for all supported resources in the tenant. Required.</summary>
        public Microsoft.Graph.Beta.Models.ResourceScopeType? ResourceScopeType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResourceScopeType?>("resourceScopeType"); }
            set { BackingStore?.Set("resourceScopeType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="PermissionGrantPolicy"/> and sets the default values.
        /// </summary>
        public PermissionGrantPolicy() : base()
        {
            OdataType = "#microsoft.graph.permissionGrantPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PermissionGrantPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PermissionGrantPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PermissionGrantPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "excludes", n => { Excludes = n.GetCollectionOfObjectValues<PermissionGrantConditionSet>(PermissionGrantConditionSet.CreateFromDiscriminatorValue)?.ToList(); } },
                { "includes", n => { Includes = n.GetCollectionOfObjectValues<PermissionGrantConditionSet>(PermissionGrantConditionSet.CreateFromDiscriminatorValue)?.ToList(); } },
                { "resourceScopeType", n => { ResourceScopeType = n.GetEnumValue<ResourceScopeType>(); } },
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
            writer.WriteCollectionOfObjectValues<PermissionGrantConditionSet>("excludes", Excludes);
            writer.WriteCollectionOfObjectValues<PermissionGrantConditionSet>("includes", Includes);
            writer.WriteEnumValue<ResourceScopeType>("resourceScopeType", ResourceScopeType);
        }
    }
}
