// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class CalculatedColumn : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>For dateTime output types, the format of the value. Possible values are: dateOnly or dateTime.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Format
        {
            get { return BackingStore?.Get<string?>("format"); }
            set { BackingStore?.Set("format", value); }
        }
#nullable restore
#else
        public string Format
        {
            get { return BackingStore?.Get<string>("format"); }
            set { BackingStore?.Set("format", value); }
        }
#endif
        /// <summary>The formula used to compute the value for this column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Formula
        {
            get { return BackingStore?.Get<string?>("formula"); }
            set { BackingStore?.Set("formula", value); }
        }
#nullable restore
#else
        public string Formula
        {
            get { return BackingStore?.Get<string>("formula"); }
            set { BackingStore?.Set("formula", value); }
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
        /// <summary>The output type used to format values in this column. Possible values are: boolean, currency, dateTime, number, or text.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OutputType
        {
            get { return BackingStore?.Get<string?>("outputType"); }
            set { BackingStore?.Set("outputType", value); }
        }
#nullable restore
#else
        public string OutputType
        {
            get { return BackingStore?.Get<string>("outputType"); }
            set { BackingStore?.Set("outputType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="CalculatedColumn"/> and sets the default values.
        /// </summary>
        public CalculatedColumn()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="CalculatedColumn"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CalculatedColumn CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CalculatedColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "format", n => { Format = n.GetStringValue(); } },
                { "formula", n => { Formula = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "outputType", n => { OutputType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("format", Format);
            writer.WriteStringValue("formula", Formula);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("outputType", OutputType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
