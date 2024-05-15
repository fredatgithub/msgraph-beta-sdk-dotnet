// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Workbook.Functions.WorkDay
{
    #pragma warning disable CS1591
    public class WorkDayPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The days property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Days
        {
            get { return BackingStore?.Get<Json?>("days"); }
            set { BackingStore?.Set("days", value); }
        }
#nullable restore
#else
        public Json Days
        {
            get { return BackingStore?.Get<Json>("days"); }
            set { BackingStore?.Set("days", value); }
        }
#endif
        /// <summary>The holidays property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Holidays
        {
            get { return BackingStore?.Get<Json?>("holidays"); }
            set { BackingStore?.Set("holidays", value); }
        }
#nullable restore
#else
        public Json Holidays
        {
            get { return BackingStore?.Get<Json>("holidays"); }
            set { BackingStore?.Set("holidays", value); }
        }
#endif
        /// <summary>The startDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? StartDate
        {
            get { return BackingStore?.Get<Json?>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
#nullable restore
#else
        public Json StartDate
        {
            get { return BackingStore?.Get<Json>("startDate"); }
            set { BackingStore?.Set("startDate", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="WorkDayPostRequestBody"/> and sets the default values.
        /// </summary>
        public WorkDayPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="WorkDayPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkDayPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkDayPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "days", n => { Days = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "holidays", n => { Holidays = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                { "startDate", n => { StartDate = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("days", Days);
            writer.WriteObjectValue<Json>("holidays", Holidays);
            writer.WriteObjectValue<Json>("startDate", StartDate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
