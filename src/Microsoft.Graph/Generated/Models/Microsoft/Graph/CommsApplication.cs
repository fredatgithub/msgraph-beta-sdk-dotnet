using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the commsApplication singleton.</summary>
    public class CommsApplication : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<Call> Calls { get; set; }
        public List<OnlineMeeting> OnlineMeetings { get; set; }
        /// <summary>
        /// Instantiates a new CommsApplication and sets the default values.
        /// </summary>
        public CommsApplication() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CommsApplication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommsApplication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"calls", (o,n) => { (o as CommsApplication).Calls = n.GetCollectionOfObjectValues<Call>(Call.CreateFromDiscriminatorValue).ToList(); } },
                {"onlineMeetings", (o,n) => { (o as CommsApplication).OnlineMeetings = n.GetCollectionOfObjectValues<OnlineMeeting>(OnlineMeeting.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Call>("calls", Calls);
            writer.WriteCollectionOfObjectValues<OnlineMeeting>("onlineMeetings", OnlineMeetings);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
