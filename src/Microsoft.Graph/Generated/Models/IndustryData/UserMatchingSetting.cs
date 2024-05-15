// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IndustryData
{
    #pragma warning disable CS1591
    public class UserMatchingSetting : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The RefUserMatchTarget for matching a user from the source with a Microsoft Entra user object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserMatchTargetReferenceValue? MatchTarget
        {
            get { return BackingStore?.Get<UserMatchTargetReferenceValue?>("matchTarget"); }
            set { BackingStore?.Set("matchTarget", value); }
        }
#nullable restore
#else
        public UserMatchTargetReferenceValue MatchTarget
        {
            get { return BackingStore?.Get<UserMatchTargetReferenceValue>("matchTarget"); }
            set { BackingStore?.Set("matchTarget", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The priority order to apply when a user has multiple RefRole codes assigned.</summary>
        public int? PriorityOrder
        {
            get { return BackingStore?.Get<int?>("priorityOrder"); }
            set { BackingStore?.Set("priorityOrder", value); }
        }
        /// <summary>The roleGroup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IndustryData.RoleGroup? RoleGroup
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IndustryData.RoleGroup?>("roleGroup"); }
            set { BackingStore?.Set("roleGroup", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IndustryData.RoleGroup RoleGroup
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IndustryData.RoleGroup>("roleGroup"); }
            set { BackingStore?.Set("roleGroup", value); }
        }
#endif
        /// <summary>The sourceIdentifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentifierTypeReferenceValue? SourceIdentifier
        {
            get { return BackingStore?.Get<IdentifierTypeReferenceValue?>("sourceIdentifier"); }
            set { BackingStore?.Set("sourceIdentifier", value); }
        }
#nullable restore
#else
        public IdentifierTypeReferenceValue SourceIdentifier
        {
            get { return BackingStore?.Get<IdentifierTypeReferenceValue>("sourceIdentifier"); }
            set { BackingStore?.Set("sourceIdentifier", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="UserMatchingSetting"/> and sets the default values.
        /// </summary>
        public UserMatchingSetting()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="UserMatchingSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserMatchingSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserMatchingSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "matchTarget", n => { MatchTarget = n.GetObjectValue<UserMatchTargetReferenceValue>(UserMatchTargetReferenceValue.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "priorityOrder", n => { PriorityOrder = n.GetIntValue(); } },
                { "roleGroup", n => { RoleGroup = n.GetObjectValue<Microsoft.Graph.Beta.Models.IndustryData.RoleGroup>(Microsoft.Graph.Beta.Models.IndustryData.RoleGroup.CreateFromDiscriminatorValue); } },
                { "sourceIdentifier", n => { SourceIdentifier = n.GetObjectValue<IdentifierTypeReferenceValue>(IdentifierTypeReferenceValue.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UserMatchTargetReferenceValue>("matchTarget", MatchTarget);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("priorityOrder", PriorityOrder);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IndustryData.RoleGroup>("roleGroup", RoleGroup);
            writer.WriteObjectValue<IdentifierTypeReferenceValue>("sourceIdentifier", SourceIdentifier);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
