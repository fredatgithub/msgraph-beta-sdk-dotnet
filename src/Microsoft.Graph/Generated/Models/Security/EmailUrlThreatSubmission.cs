// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class EmailUrlThreatSubmission : EmailThreatSubmission, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies the url of the message to be submitted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MessageUrl
        {
            get { return BackingStore?.Get<string?>("messageUrl"); }
            set { BackingStore?.Set("messageUrl", value); }
        }
#nullable restore
#else
        public string MessageUrl
        {
            get { return BackingStore?.Get<string>("messageUrl"); }
            set { BackingStore?.Set("messageUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="EmailUrlThreatSubmission"/> and sets the default values.
        /// </summary>
        public EmailUrlThreatSubmission() : base()
        {
            OdataType = "#microsoft.graph.security.emailUrlThreatSubmission";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EmailUrlThreatSubmission"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EmailUrlThreatSubmission CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmailUrlThreatSubmission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "messageUrl", n => { MessageUrl = n.GetStringValue(); } },
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
            writer.WriteStringValue("messageUrl", MessageUrl);
        }
    }
}
