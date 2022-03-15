using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the provisionOnDemand method.</summary>
    public class SynchronizationLinkedObjects : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public SynchronizationJobSubject Manager { get; set; }
        public List<SynchronizationJobSubject> Members { get; set; }
        public List<SynchronizationJobSubject> Owners { get; set; }
        /// <summary>
        /// Instantiates a new synchronizationLinkedObjects and sets the default values.
        /// </summary>
        public SynchronizationLinkedObjects() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SynchronizationLinkedObjects CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationLinkedObjects();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"manager", (o,n) => { (o as SynchronizationLinkedObjects).Manager = n.GetObjectValue<SynchronizationJobSubject>(SynchronizationJobSubject.CreateFromDiscriminatorValue); } },
                {"members", (o,n) => { (o as SynchronizationLinkedObjects).Members = n.GetCollectionOfObjectValues<SynchronizationJobSubject>(SynchronizationJobSubject.CreateFromDiscriminatorValue).ToList(); } },
                {"owners", (o,n) => { (o as SynchronizationLinkedObjects).Owners = n.GetCollectionOfObjectValues<SynchronizationJobSubject>(SynchronizationJobSubject.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<SynchronizationJobSubject>("manager", Manager);
            writer.WriteCollectionOfObjectValues<SynchronizationJobSubject>("members", Members);
            writer.WriteCollectionOfObjectValues<SynchronizationJobSubject>("owners", Owners);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
