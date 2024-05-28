// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Drive.Items.Item.Workbook.Functions.CumIPmt
{
    #pragma warning disable CS1591
    public class CumIPmtPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The endPeriod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? EndPeriod
        {
            get { return BackingStore?.Get<Json?>("endPeriod"); }
            set { BackingStore?.Set("endPeriod", value); }
        }
#nullable restore
#else
        public Json EndPeriod
        {
            get { return BackingStore?.Get<Json>("endPeriod"); }
            set { BackingStore?.Set("endPeriod", value); }
        }
#endif
        /// <summary>The nper property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Nper
        {
            get { return BackingStore?.Get<Json?>("nper"); }
            set { BackingStore?.Set("nper", value); }
        }
#nullable restore
#else
        public Json Nper
        {
            get { return BackingStore?.Get<Json>("nper"); }
            set { BackingStore?.Set("nper", value); }
        }
#endif
        /// <summary>The pv property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Pv
        {
            get { return BackingStore?.Get<Json?>("pv"); }
            set { BackingStore?.Set("pv", value); }
        }
#nullable restore
#else
        public Json Pv
        {
            get { return BackingStore?.Get<Json>("pv"); }
            set { BackingStore?.Set("pv", value); }
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
        /// <summary>The startPeriod property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? StartPeriod
        {
            get { return BackingStore?.Get<Json?>("startPeriod"); }
            set { BackingStore?.Set("startPeriod", value); }
        }
#nullable restore
#else
        public Json StartPeriod
        {
            get { return BackingStore?.Get<Json>("startPeriod"); }
            set { BackingStore?.Set("startPeriod", value); }
        }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Type
        {
            get { return BackingStore?.Get<Json?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public Json Type
        {
            get { return BackingStore?.Get<Json>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CumIPmtPostRequestBody"/> and sets the default values.
        /// </summary>
        public CumIPmtPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CumIPmtPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CumIPmtPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CumIPmtPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "endPeriod", n => { EndPeriod = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "nper", n => { Nper = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "pv", n => { Pv = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "rate", n => { Rate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "startPeriod", n => { StartPeriod = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("endPeriod", EndPeriod);
            writer.WriteObjectValue<Json>("nper", Nper);
            writer.WriteObjectValue<Json>("pv", Pv);
            writer.WriteObjectValue<Json>("rate", Rate);
            writer.WriteObjectValue<Json>("startPeriod", StartPeriod);
            writer.WriteObjectValue<Json>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
