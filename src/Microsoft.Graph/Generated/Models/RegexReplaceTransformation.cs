// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class RegexReplaceTransformation : CustomClaimTransformation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The additionalAttributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SourcedAttribute>? AdditionalAttributes
        {
            get { return BackingStore?.Get<List<SourcedAttribute>?>("additionalAttributes"); }
            set { BackingStore?.Set("additionalAttributes", value); }
        }
#nullable restore
#else
        public List<SourcedAttribute> AdditionalAttributes
        {
            get { return BackingStore?.Get<List<SourcedAttribute>>("additionalAttributes"); }
            set { BackingStore?.Set("additionalAttributes", value); }
        }
#endif
        /// <summary>The regex property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Regex
        {
            get { return BackingStore?.Get<string?>("regex"); }
            set { BackingStore?.Set("regex", value); }
        }
#nullable restore
#else
        public string Regex
        {
            get { return BackingStore?.Get<string>("regex"); }
            set { BackingStore?.Set("regex", value); }
        }
#endif
        /// <summary>The replacement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Replacement
        {
            get { return BackingStore?.Get<string?>("replacement"); }
            set { BackingStore?.Set("replacement", value); }
        }
#nullable restore
#else
        public string Replacement
        {
            get { return BackingStore?.Get<string>("replacement"); }
            set { BackingStore?.Set("replacement", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="RegexReplaceTransformation"/> and sets the default values.
        /// </summary>
        public RegexReplaceTransformation() : base()
        {
            OdataType = "#microsoft.graph.regexReplaceTransformation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="RegexReplaceTransformation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RegexReplaceTransformation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RegexReplaceTransformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "additionalAttributes", n => { AdditionalAttributes = n.GetCollectionOfObjectValues<SourcedAttribute>(SourcedAttribute.CreateFromDiscriminatorValue)?.ToList(); } },
                { "regex", n => { Regex = n.GetStringValue(); } },
                { "replacement", n => { Replacement = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<SourcedAttribute>("additionalAttributes", AdditionalAttributes);
            writer.WriteStringValue("regex", Regex);
            writer.WriteStringValue("replacement", Replacement);
        }
    }
}
