// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Drive.Items.Item.Workbook.Functions.PriceMat
{
    #pragma warning disable CS1591
    public class PriceMatPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The basis property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Basis
        {
            get { return BackingStore?.Get<Json?>("basis"); }
            set { BackingStore?.Set("basis", value); }
        }
#nullable restore
#else
        public Json Basis
        {
            get { return BackingStore?.Get<Json>("basis"); }
            set { BackingStore?.Set("basis", value); }
        }
#endif
        /// <summary>The issue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Issue
        {
            get { return BackingStore?.Get<Json?>("issue"); }
            set { BackingStore?.Set("issue", value); }
        }
#nullable restore
#else
        public Json Issue
        {
            get { return BackingStore?.Get<Json>("issue"); }
            set { BackingStore?.Set("issue", value); }
        }
#endif
        /// <summary>The maturity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Maturity
        {
            get { return BackingStore?.Get<Json?>("maturity"); }
            set { BackingStore?.Set("maturity", value); }
        }
#nullable restore
#else
        public Json Maturity
        {
            get { return BackingStore?.Get<Json>("maturity"); }
            set { BackingStore?.Set("maturity", value); }
        }
#endif
        /// <summary>The rate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Rate
        {
            get { return BackingStore?.Get<Json?>("rate"); }
            set { BackingStore?.Set("rate", value); }
        }
#nullable restore
#else
        public Json Rate
        {
            get { return BackingStore?.Get<Json>("rate"); }
            set { BackingStore?.Set("rate", value); }
        }
#endif
        /// <summary>The settlement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Settlement
        {
            get { return BackingStore?.Get<Json?>("settlement"); }
            set { BackingStore?.Set("settlement", value); }
        }
#nullable restore
#else
        public Json Settlement
        {
            get { return BackingStore?.Get<Json>("settlement"); }
            set { BackingStore?.Set("settlement", value); }
        }
#endif
        /// <summary>The yld property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Yld
        {
            get { return BackingStore?.Get<Json?>("yld"); }
            set { BackingStore?.Set("yld", value); }
        }
#nullable restore
#else
        public Json Yld
        {
            get { return BackingStore?.Get<Json>("yld"); }
            set { BackingStore?.Set("yld", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PriceMatPostRequestBody"/> and sets the default values.
        /// </summary>
        public PriceMatPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PriceMatPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PriceMatPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PriceMatPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "basis", n => { Basis = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "issue", n => { Issue = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "maturity", n => { Maturity = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "rate", n => { Rate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "settlement", n => { Settlement = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "yld", n => { Yld = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("issue", Issue);
            writer.WriteObjectValue<Json>("maturity", Maturity);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteObjectValue<Json>("yld", Yld);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
