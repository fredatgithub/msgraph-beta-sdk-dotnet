using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class AttackSimulationRoot : Entity, IParsable {
        /// <summary>The endUserNotifications property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EndUserNotification>? EndUserNotifications {
            get { return BackingStore?.Get<List<EndUserNotification>?>("endUserNotifications"); }
            set { BackingStore?.Set("endUserNotifications", value); }
        }
#nullable restore
#else
        public List<EndUserNotification> EndUserNotifications {
            get { return BackingStore?.Get<List<EndUserNotification>>("endUserNotifications"); }
            set { BackingStore?.Set("endUserNotifications", value); }
        }
#endif
        /// <summary>The landingPages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LandingPage>? LandingPages {
            get { return BackingStore?.Get<List<LandingPage>?>("landingPages"); }
            set { BackingStore?.Set("landingPages", value); }
        }
#nullable restore
#else
        public List<LandingPage> LandingPages {
            get { return BackingStore?.Get<List<LandingPage>>("landingPages"); }
            set { BackingStore?.Set("landingPages", value); }
        }
#endif
        /// <summary>The loginPages property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LoginPage>? LoginPages {
            get { return BackingStore?.Get<List<LoginPage>?>("loginPages"); }
            set { BackingStore?.Set("loginPages", value); }
        }
#nullable restore
#else
        public List<LoginPage> LoginPages {
            get { return BackingStore?.Get<List<LoginPage>>("loginPages"); }
            set { BackingStore?.Set("loginPages", value); }
        }
#endif
        /// <summary>Represents an attack simulation training operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttackSimulationOperation>? Operations {
            get { return BackingStore?.Get<List<AttackSimulationOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<AttackSimulationOperation> Operations {
            get { return BackingStore?.Get<List<AttackSimulationOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>Represents an attack simulation training campaign payload in a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Payload>? Payloads {
            get { return BackingStore?.Get<List<Payload>?>("payloads"); }
            set { BackingStore?.Set("payloads", value); }
        }
#nullable restore
#else
        public List<Payload> Payloads {
            get { return BackingStore?.Get<List<Payload>>("payloads"); }
            set { BackingStore?.Set("payloads", value); }
        }
#endif
        /// <summary>Represents simulation automation created to run on a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimulationAutomation>? SimulationAutomations {
            get { return BackingStore?.Get<List<SimulationAutomation>?>("simulationAutomations"); }
            set { BackingStore?.Set("simulationAutomations", value); }
        }
#nullable restore
#else
        public List<SimulationAutomation> SimulationAutomations {
            get { return BackingStore?.Get<List<SimulationAutomation>>("simulationAutomations"); }
            set { BackingStore?.Set("simulationAutomations", value); }
        }
#endif
        /// <summary>Represents an attack simulation training campaign in a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Simulation>? Simulations {
            get { return BackingStore?.Get<List<Simulation>?>("simulations"); }
            set { BackingStore?.Set("simulations", value); }
        }
#nullable restore
#else
        public List<Simulation> Simulations {
            get { return BackingStore?.Get<List<Simulation>>("simulations"); }
            set { BackingStore?.Set("simulations", value); }
        }
#endif
        /// <summary>The trainings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Training>? Trainings {
            get { return BackingStore?.Get<List<Training>?>("trainings"); }
            set { BackingStore?.Set("trainings", value); }
        }
#nullable restore
#else
        public List<Training> Trainings {
            get { return BackingStore?.Get<List<Training>>("trainings"); }
            set { BackingStore?.Set("trainings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AttackSimulationRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"endUserNotifications", n => { EndUserNotifications = n.GetCollectionOfObjectValues<EndUserNotification>(EndUserNotification.CreateFromDiscriminatorValue)?.ToList(); } },
                {"landingPages", n => { LandingPages = n.GetCollectionOfObjectValues<LandingPage>(LandingPage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"loginPages", n => { LoginPages = n.GetCollectionOfObjectValues<LoginPage>(LoginPage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<AttackSimulationOperation>(AttackSimulationOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"payloads", n => { Payloads = n.GetCollectionOfObjectValues<Payload>(Payload.CreateFromDiscriminatorValue)?.ToList(); } },
                {"simulationAutomations", n => { SimulationAutomations = n.GetCollectionOfObjectValues<SimulationAutomation>(SimulationAutomation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"simulations", n => { Simulations = n.GetCollectionOfObjectValues<Simulation>(Simulation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"trainings", n => { Trainings = n.GetCollectionOfObjectValues<Training>(Training.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<EndUserNotification>("endUserNotifications", EndUserNotifications);
            writer.WriteCollectionOfObjectValues<LandingPage>("landingPages", LandingPages);
            writer.WriteCollectionOfObjectValues<LoginPage>("loginPages", LoginPages);
            writer.WriteCollectionOfObjectValues<AttackSimulationOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Payload>("payloads", Payloads);
            writer.WriteCollectionOfObjectValues<SimulationAutomation>("simulationAutomations", SimulationAutomations);
            writer.WriteCollectionOfObjectValues<Simulation>("simulations", Simulations);
            writer.WriteCollectionOfObjectValues<Training>("trainings", Trainings);
        }
    }
}
