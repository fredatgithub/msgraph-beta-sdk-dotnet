// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ProtectSite : LabelActionBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessType property</summary>
        public SiteAccessType? AccessType
        {
            get { return BackingStore?.Get<SiteAccessType?>("accessType"); }
            set { BackingStore?.Set("accessType", value); }
        }
        /// <summary>The conditionalAccessProtectionLevelId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConditionalAccessProtectionLevelId
        {
            get { return BackingStore?.Get<string?>("conditionalAccessProtectionLevelId"); }
            set { BackingStore?.Set("conditionalAccessProtectionLevelId", value); }
        }
#nullable restore
#else
        public string ConditionalAccessProtectionLevelId
        {
            get { return BackingStore?.Get<string>("conditionalAccessProtectionLevelId"); }
            set { BackingStore?.Set("conditionalAccessProtectionLevelId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ProtectSite"/> and sets the default values.
        /// </summary>
        public ProtectSite() : base()
        {
            OdataType = "#microsoft.graph.protectSite";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ProtectSite"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProtectSite CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProtectSite();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessType", n => { AccessType = n.GetEnumValue<SiteAccessType>(); } },
                { "conditionalAccessProtectionLevelId", n => { ConditionalAccessProtectionLevelId = n.GetStringValue(); } },
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
            writer.WriteEnumValue<SiteAccessType>("accessType", AccessType);
            writer.WriteStringValue("conditionalAccessProtectionLevelId", ConditionalAccessProtectionLevelId);
        }
    }
}
