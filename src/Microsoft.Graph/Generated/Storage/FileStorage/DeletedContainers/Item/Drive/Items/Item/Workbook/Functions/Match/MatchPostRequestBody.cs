// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Storage.FileStorage.DeletedContainers.Item.Drive.Items.Item.Workbook.Functions.Match
{
    #pragma warning disable CS1591
    public class MatchPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The lookupArray property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? LookupArray
        {
            get { return BackingStore?.Get<Json?>("lookupArray"); }
            set { BackingStore?.Set("lookupArray", value); }
        }
#nullable restore
#else
        public Json LookupArray
        {
            get { return BackingStore?.Get<Json>("lookupArray"); }
            set { BackingStore?.Set("lookupArray", value); }
        }
#endif
        /// <summary>The lookupValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? LookupValue
        {
            get { return BackingStore?.Get<Json?>("lookupValue"); }
            set { BackingStore?.Set("lookupValue", value); }
        }
#nullable restore
#else
        public Json LookupValue
        {
            get { return BackingStore?.Get<Json>("lookupValue"); }
            set { BackingStore?.Set("lookupValue", value); }
        }
#endif
        /// <summary>The matchType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? MatchType
        {
            get { return BackingStore?.Get<Json?>("matchType"); }
            set { BackingStore?.Set("matchType", value); }
        }
#nullable restore
#else
        public Json MatchType
        {
            get { return BackingStore?.Get<Json>("matchType"); }
            set { BackingStore?.Set("matchType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="MatchPostRequestBody"/> and sets the default values.
        /// </summary>
        public MatchPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MatchPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MatchPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MatchPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "lookupArray", n => { LookupArray = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "lookupValue", n => { LookupValue = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "matchType", n => { MatchType = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("lookupArray", LookupArray);
            writer.WriteObjectValue<Json>("lookupValue", LookupValue);
            writer.WriteObjectValue<Json>("matchType", MatchType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
