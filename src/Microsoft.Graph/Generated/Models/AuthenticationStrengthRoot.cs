using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AuthenticationStrengthRoot : Entity, IParsable {
        /// <summary>The authenticationCombinations property</summary>
        public List<string> AuthenticationCombinations {
            get { return BackingStore?.Get<List<string>>("authenticationCombinations"); }
            set { BackingStore?.Set("authenticationCombinations", value); }
        }
        /// <summary>The authenticationMethodModes property</summary>
        public List<AuthenticationMethodModeDetail> AuthenticationMethodModes {
            get { return BackingStore?.Get<List<AuthenticationMethodModeDetail>>("authenticationMethodModes"); }
            set { BackingStore?.Set("authenticationMethodModes", value); }
        }
        /// <summary>The policies property</summary>
        public List<AuthenticationStrengthPolicy> Policies {
            get { return BackingStore?.Get<List<AuthenticationStrengthPolicy>>("policies"); }
            set { BackingStore?.Set("policies", value); }
        }
        /// <summary>
        /// Instantiates a new AuthenticationStrengthRoot and sets the default values.
        /// </summary>
        public AuthenticationStrengthRoot() : base() {
            OdataType = "#microsoft.graph.authenticationStrengthRoot";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AuthenticationStrengthRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationStrengthRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationCombinations", n => { AuthenticationCombinations = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"authenticationMethodModes", n => { AuthenticationMethodModes = n.GetCollectionOfObjectValues<AuthenticationMethodModeDetail>(AuthenticationMethodModeDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"policies", n => { Policies = n.GetCollectionOfObjectValues<AuthenticationStrengthPolicy>(AuthenticationStrengthPolicy.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("authenticationCombinations", AuthenticationCombinations);
            writer.WriteCollectionOfObjectValues<AuthenticationMethodModeDetail>("authenticationMethodModes", AuthenticationMethodModes);
            writer.WriteCollectionOfObjectValues<AuthenticationStrengthPolicy>("policies", Policies);
        }
    }
}
