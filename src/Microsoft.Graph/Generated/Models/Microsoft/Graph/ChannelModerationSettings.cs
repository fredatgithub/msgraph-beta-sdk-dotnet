using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class ChannelModerationSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether bots are allowed to post messages.</summary>
        public bool? AllowNewMessageFromBots { get; set; }
        /// <summary>Indicates whether connectors are allowed to post messages.</summary>
        public bool? AllowNewMessageFromConnectors { get; set; }
        /// <summary>Indicates who is allowed to reply to the teams channel. Possible values are: everyone, authorAndModerators, unknownFutureValue.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ReplyRestriction? ReplyRestriction { get; set; }
        /// <summary>Indicates who is allowed to post messages to teams channel. Possible values are: everyone, everyoneExceptGuests, moderators, unknownFutureValue.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.UserNewMessageRestriction? UserNewMessageRestriction { get; set; }
        /// <summary>
        /// Instantiates a new channelModerationSettings and sets the default values.
        /// </summary>
        public ChannelModerationSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ChannelModerationSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChannelModerationSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"allowNewMessageFromBots", (o,n) => { (o as ChannelModerationSettings).AllowNewMessageFromBots = n.GetBoolValue(); } },
                {"allowNewMessageFromConnectors", (o,n) => { (o as ChannelModerationSettings).AllowNewMessageFromConnectors = n.GetBoolValue(); } },
                {"replyRestriction", (o,n) => { (o as ChannelModerationSettings).ReplyRestriction = n.GetEnumValue<ReplyRestriction>(); } },
                {"userNewMessageRestriction", (o,n) => { (o as ChannelModerationSettings).UserNewMessageRestriction = n.GetEnumValue<UserNewMessageRestriction>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowNewMessageFromBots", AllowNewMessageFromBots);
            writer.WriteBoolValue("allowNewMessageFromConnectors", AllowNewMessageFromConnectors);
            writer.WriteEnumValue<ReplyRestriction>("replyRestriction", ReplyRestriction);
            writer.WriteEnumValue<UserNewMessageRestriction>("userNewMessageRestriction", UserNewMessageRestriction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
