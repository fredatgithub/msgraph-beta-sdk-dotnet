using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class EducationalActivity : ItemFacet, IParsable {
        /// <summary>The month and year the user graduated or completed the activity.</summary>
        public Date? CompletionMonthYear { get; set; }
        /// <summary>The month and year the user completed the educational activity referenced.</summary>
        public Date? EndMonthYear { get; set; }
        public InstitutionData Institution { get; set; }
        public EducationalActivityDetail Program { get; set; }
        /// <summary>The month and year the user commenced the activity referenced.</summary>
        public Date? StartMonthYear { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EducationalActivity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationalActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"completionMonthYear", (o,n) => { (o as EducationalActivity).CompletionMonthYear = n.GetDateValue(); } },
                {"endMonthYear", (o,n) => { (o as EducationalActivity).EndMonthYear = n.GetDateValue(); } },
                {"institution", (o,n) => { (o as EducationalActivity).Institution = n.GetObjectValue<InstitutionData>(InstitutionData.CreateFromDiscriminatorValue); } },
                {"program", (o,n) => { (o as EducationalActivity).Program = n.GetObjectValue<EducationalActivityDetail>(EducationalActivityDetail.CreateFromDiscriminatorValue); } },
                {"startMonthYear", (o,n) => { (o as EducationalActivity).StartMonthYear = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateValue("completionMonthYear", CompletionMonthYear);
            writer.WriteDateValue("endMonthYear", EndMonthYear);
            writer.WriteObjectValue<InstitutionData>("institution", Institution);
            writer.WriteObjectValue<EducationalActivityDetail>("program", Program);
            writer.WriteDateValue("startMonthYear", StartMonthYear);
        }
    }
}
