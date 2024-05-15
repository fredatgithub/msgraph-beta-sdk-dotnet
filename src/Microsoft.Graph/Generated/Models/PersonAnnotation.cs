// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class PersonAnnotation : ItemFacet, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Contains the detail of the note itself.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Detail
        {
            get { return BackingStore?.Get<ItemBody?>("detail"); }
            set { BackingStore?.Set("detail", value); }
        }
#nullable restore
#else
        public ItemBody Detail
        {
            get { return BackingStore?.Get<ItemBody>("detail"); }
            set { BackingStore?.Set("detail", value); }
        }
#endif
        /// <summary>Contains a friendly name for the note.</summary>
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
        /// <summary>The thumbnailUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbnailUrl
        {
            get { return BackingStore?.Get<string?>("thumbnailUrl"); }
            set { BackingStore?.Set("thumbnailUrl", value); }
        }
#nullable restore
#else
        public string ThumbnailUrl
        {
            get { return BackingStore?.Get<string>("thumbnailUrl"); }
            set { BackingStore?.Set("thumbnailUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PersonAnnotation"/> and sets the default values.
        /// </summary>
        public PersonAnnotation() : base()
        {
            OdataType = "#microsoft.graph.personAnnotation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PersonAnnotation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PersonAnnotation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PersonAnnotation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "detail", n => { Detail = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "thumbnailUrl", n => { ThumbnailUrl = n.GetStringValue(); } },
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
            writer.WriteObjectValue<ItemBody>("detail", Detail);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("thumbnailUrl", ThumbnailUrl);
        }
    }
}
