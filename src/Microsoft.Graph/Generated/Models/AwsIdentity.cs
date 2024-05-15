// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AwsIdentity : AuthorizationSystemIdentity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Instantiates a new <see cref="AwsIdentity"/> and sets the default values.
        /// </summary>
        public AwsIdentity() : base()
        {
            OdataType = "#microsoft.graph.awsIdentity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AwsIdentity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AwsIdentity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.awsAccessKey" => new AwsAccessKey(),
                "#microsoft.graph.awsEc2Instance" => new AwsEc2Instance(),
                "#microsoft.graph.awsGroup" => new AwsGroup(),
                "#microsoft.graph.awsLambda" => new AwsLambda(),
                "#microsoft.graph.awsRole" => new AwsRole(),
                "#microsoft.graph.awsUser" => new AwsUser(),
                _ => new AwsIdentity(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
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
        }
    }
}
