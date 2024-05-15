// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class EducationAssignmentPointsGradeType : EducationAssignmentGradeType, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Max points possible for this assignment.</summary>
        public float? MaxPoints
        {
            get { return BackingStore?.Get<float?>("maxPoints"); }
            set { BackingStore?.Set("maxPoints", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="EducationAssignmentPointsGradeType"/> and sets the default values.
        /// </summary>
        public EducationAssignmentPointsGradeType() : base()
        {
            OdataType = "#microsoft.graph.educationAssignmentPointsGradeType";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EducationAssignmentPointsGradeType"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationAssignmentPointsGradeType CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationAssignmentPointsGradeType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "maxPoints", n => { MaxPoints = n.GetFloatValue(); } },
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
            writer.WriteFloatValue("maxPoints", MaxPoints);
        }
    }
}
