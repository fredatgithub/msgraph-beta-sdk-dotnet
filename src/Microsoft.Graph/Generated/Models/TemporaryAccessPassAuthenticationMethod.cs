// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class TemporaryAccessPassAuthenticationMethod : AuthenticationMethod, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The date and time when the Temporary Access Pass was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Determines whether the pass is limited to a one-time use. If true, the pass can be used once; if false, the pass can be used multiple times within the Temporary Access Pass lifetime.</summary>
        public bool? IsUsableOnce
        {
            get { return BackingStore?.Get<bool?>("isUsableOnce"); }
            set { BackingStore?.Set("isUsableOnce", value); }
        }
        /// <summary>The lifetime of the Temporary Access Pass in minutes starting at startDateTime. Must be between 10 and 43200 inclusive (equivalent to 30 days).</summary>
        public int? LifetimeInMinutes
        {
            get { return BackingStore?.Get<int?>("lifetimeInMinutes"); }
            set { BackingStore?.Set("lifetimeInMinutes", value); }
        }
        /// <summary>The date and time when the Temporary Access Pass becomes available to use and when isUsable is true is enforced.</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The Temporary Access Pass used to authenticate. Returned only on creation of a new temporaryAccessPassAuthenticationMethod object; Hidden in subsequent read operations and returned as null with GET.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemporaryAccessPass
        {
            get { return BackingStore?.Get<string?>("temporaryAccessPass"); }
            set { BackingStore?.Set("temporaryAccessPass", value); }
        }
#nullable restore
#else
        public string TemporaryAccessPass
        {
            get { return BackingStore?.Get<string>("temporaryAccessPass"); }
            set { BackingStore?.Set("temporaryAccessPass", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TemporaryAccessPassAuthenticationMethod"/> and sets the default values.
        /// </summary>
        public TemporaryAccessPassAuthenticationMethod() : base()
        {
            OdataType = "#microsoft.graph.temporaryAccessPassAuthenticationMethod";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TemporaryAccessPassAuthenticationMethod"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TemporaryAccessPassAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TemporaryAccessPassAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "isUsableOnce", n => { IsUsableOnce = n.GetBoolValue(); } },
                { "lifetimeInMinutes", n => { LifetimeInMinutes = n.GetIntValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "temporaryAccessPass", n => { TemporaryAccessPass = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteBoolValue("isUsableOnce", IsUsableOnce);
            writer.WriteIntValue("lifetimeInMinutes", LifetimeInMinutes);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("temporaryAccessPass", TemporaryAccessPass);
        }
    }
}
