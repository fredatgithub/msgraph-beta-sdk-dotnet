// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class OnAuthenticationMethodLoadStartListener : AuthenticationEventListener, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Required. Configuration for what to invoke if the event resolves to this listener. This lets us define potential handler configurations per-event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnAuthenticationMethodLoadStartHandler? Handler
        {
            get { return BackingStore?.Get<OnAuthenticationMethodLoadStartHandler?>("handler"); }
            set { BackingStore?.Set("handler", value); }
        }
#nullable restore
#else
        public OnAuthenticationMethodLoadStartHandler Handler
        {
            get { return BackingStore?.Get<OnAuthenticationMethodLoadStartHandler>("handler"); }
            set { BackingStore?.Set("handler", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="OnAuthenticationMethodLoadStartListener"/> and sets the default values.
        /// </summary>
        public OnAuthenticationMethodLoadStartListener() : base()
        {
            OdataType = "#microsoft.graph.onAuthenticationMethodLoadStartListener";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="OnAuthenticationMethodLoadStartListener"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnAuthenticationMethodLoadStartListener CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnAuthenticationMethodLoadStartListener();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "handler", n => { Handler = n.GetObjectValue<OnAuthenticationMethodLoadStartHandler>(OnAuthenticationMethodLoadStartHandler.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<OnAuthenticationMethodLoadStartHandler>("handler", Handler);
        }
    }
}
