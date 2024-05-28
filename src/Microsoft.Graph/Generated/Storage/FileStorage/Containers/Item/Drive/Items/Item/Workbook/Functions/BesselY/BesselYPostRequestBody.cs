// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Storage.FileStorage.Containers.Item.Drive.Items.Item.Workbook.Functions.BesselY
{
    #pragma warning disable CS1591
    public class BesselYPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The n property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? N
        {
            get { return BackingStore?.Get<Json?>("n"); }
            set { BackingStore?.Set("n", value); }
        }
#nullable restore
#else
        public Json N
        {
            get { return BackingStore?.Get<Json>("n"); }
            set { BackingStore?.Set("n", value); }
        }
#endif
        /// <summary>The x property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? X
        {
            get { return BackingStore?.Get<Json?>("x"); }
            set { BackingStore?.Set("x", value); }
        }
#nullable restore
#else
        public Json X
        {
            get { return BackingStore?.Get<Json>("x"); }
            set { BackingStore?.Set("x", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="BesselYPostRequestBody"/> and sets the default values.
        /// </summary>
        public BesselYPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="BesselYPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BesselYPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BesselYPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "n", n => { N = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "x", n => { X = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("n", N);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
