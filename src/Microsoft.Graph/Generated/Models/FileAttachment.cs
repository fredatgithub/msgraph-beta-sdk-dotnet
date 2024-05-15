// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class FileAttachment : Attachment, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The base64-encoded contents of the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? ContentBytes
        {
            get { return BackingStore?.Get<byte[]?>("contentBytes"); }
            set { BackingStore?.Set("contentBytes", value); }
        }
#nullable restore
#else
        public byte[] ContentBytes
        {
            get { return BackingStore?.Get<byte[]>("contentBytes"); }
            set { BackingStore?.Set("contentBytes", value); }
        }
#endif
        /// <summary>The ID of the attachment in the Exchange store.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentId
        {
            get { return BackingStore?.Get<string?>("contentId"); }
            set { BackingStore?.Set("contentId", value); }
        }
#nullable restore
#else
        public string ContentId
        {
            get { return BackingStore?.Get<string>("contentId"); }
            set { BackingStore?.Set("contentId", value); }
        }
#endif
        /// <summary>Don&apos;t use this property as it isn&apos;t supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentLocation
        {
            get { return BackingStore?.Get<string?>("contentLocation"); }
            set { BackingStore?.Set("contentLocation", value); }
        }
#nullable restore
#else
        public string ContentLocation
        {
            get { return BackingStore?.Get<string>("contentLocation"); }
            set { BackingStore?.Set("contentLocation", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="FileAttachment"/> and sets the default values.
        /// </summary>
        public FileAttachment() : base()
        {
            OdataType = "#microsoft.graph.fileAttachment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="FileAttachment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FileAttachment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileAttachment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "contentBytes", n => { ContentBytes = n.GetByteArrayValue(); } },
                { "contentId", n => { ContentId = n.GetStringValue(); } },
                { "contentLocation", n => { ContentLocation = n.GetStringValue(); } },
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
            writer.WriteByteArrayValue("contentBytes", ContentBytes);
            writer.WriteStringValue("contentId", ContentId);
            writer.WriteStringValue("contentLocation", ContentLocation);
        }
    }
}
