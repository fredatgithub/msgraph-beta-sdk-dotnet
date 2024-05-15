// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class AnalyzedEmailAttachment : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The detonation details of the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.DetonationDetails? DetonationDetails
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetonationDetails?>("detonationDetails"); }
            set { BackingStore?.Set("detonationDetails", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.DetonationDetails DetonationDetails
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DetonationDetails>("detonationDetails"); }
            set { BackingStore?.Set("detonationDetails", value); }
        }
#endif
        /// <summary>The name of the attachment in the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName
        {
            get { return BackingStore?.Get<string?>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#nullable restore
#else
        public string FileName
        {
            get { return BackingStore?.Get<string>("fileName"); }
            set { BackingStore?.Set("fileName", value); }
        }
#endif
        /// <summary>The type of the attachment in the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileType
        {
            get { return BackingStore?.Get<string?>("fileType"); }
            set { BackingStore?.Set("fileType", value); }
        }
#nullable restore
#else
        public string FileType
        {
            get { return BackingStore?.Get<string>("fileType"); }
            set { BackingStore?.Set("fileType", value); }
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
        /// <summary>The SHA256 file hash of the attachment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha256
        {
            get { return BackingStore?.Get<string?>("sha256"); }
            set { BackingStore?.Set("sha256", value); }
        }
#nullable restore
#else
        public string Sha256
        {
            get { return BackingStore?.Get<string>("sha256"); }
            set { BackingStore?.Set("sha256", value); }
        }
#endif
        /// <summary>The threat name associated with the threat type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreatName
        {
            get { return BackingStore?.Get<string?>("threatName"); }
            set { BackingStore?.Set("threatName", value); }
        }
#nullable restore
#else
        public string ThreatName
        {
            get { return BackingStore?.Get<string>("threatName"); }
            set { BackingStore?.Set("threatName", value); }
        }
#endif
        /// <summary>The threat type associated with the attachment. The possible values are: unknown, spam, malware, phishing, none, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.ThreatType? ThreatType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ThreatType?>("threatType"); }
            set { BackingStore?.Set("threatType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="AnalyzedEmailAttachment"/> and sets the default values.
        /// </summary>
        public AnalyzedEmailAttachment()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AnalyzedEmailAttachment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AnalyzedEmailAttachment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnalyzedEmailAttachment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "detonationDetails", n => { DetonationDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.DetonationDetails>(Microsoft.Graph.Beta.Models.Security.DetonationDetails.CreateFromDiscriminatorValue); } },
                { "fileName", n => { FileName = n.GetStringValue(); } },
                { "fileType", n => { FileType = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "sha256", n => { Sha256 = n.GetStringValue(); } },
                { "threatName", n => { ThreatName = n.GetStringValue(); } },
                { "threatType", n => { ThreatType = n.GetEnumValue<ThreatType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.DetonationDetails>("detonationDetails", DetonationDetails);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteStringValue("fileType", FileType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sha256", Sha256);
            writer.WriteStringValue("threatName", ThreatName);
            writer.WriteEnumValue<ThreatType>("threatType", ThreatType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
