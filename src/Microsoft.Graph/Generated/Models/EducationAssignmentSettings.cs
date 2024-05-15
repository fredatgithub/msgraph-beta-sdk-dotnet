// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class EducationAssignmentSettings : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The defaultGradingScheme property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationGradingScheme? DefaultGradingScheme
        {
            get { return BackingStore?.Get<EducationGradingScheme?>("defaultGradingScheme"); }
            set { BackingStore?.Set("defaultGradingScheme", value); }
        }
#nullable restore
#else
        public EducationGradingScheme DefaultGradingScheme
        {
            get { return BackingStore?.Get<EducationGradingScheme>("defaultGradingScheme"); }
            set { BackingStore?.Set("defaultGradingScheme", value); }
        }
#endif
        /// <summary>When set, enables users to weight assignments differently when computing a class average grade.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationGradingCategory>? GradingCategories
        {
            get { return BackingStore?.Get<List<EducationGradingCategory>?>("gradingCategories"); }
            set { BackingStore?.Set("gradingCategories", value); }
        }
#nullable restore
#else
        public List<EducationGradingCategory> GradingCategories
        {
            get { return BackingStore?.Get<List<EducationGradingCategory>>("gradingCategories"); }
            set { BackingStore?.Set("gradingCategories", value); }
        }
#endif
        /// <summary>The gradingSchemes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EducationGradingScheme>? GradingSchemes
        {
            get { return BackingStore?.Get<List<EducationGradingScheme>?>("gradingSchemes"); }
            set { BackingStore?.Set("gradingSchemes", value); }
        }
#nullable restore
#else
        public List<EducationGradingScheme> GradingSchemes
        {
            get { return BackingStore?.Get<List<EducationGradingScheme>>("gradingSchemes"); }
            set { BackingStore?.Set("gradingSchemes", value); }
        }
#endif
        /// <summary>Indicates whether turn-in celebration animation will be shown. If true, the animation won&apos;t be shown. The default value is false.</summary>
        public bool? SubmissionAnimationDisabled
        {
            get { return BackingStore?.Get<bool?>("submissionAnimationDisabled"); }
            set { BackingStore?.Set("submissionAnimationDisabled", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="EducationAssignmentSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationAssignmentSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationAssignmentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "defaultGradingScheme", n => { DefaultGradingScheme = n.GetObjectValue<EducationGradingScheme>(EducationGradingScheme.CreateFromDiscriminatorValue); } },
                { "gradingCategories", n => { GradingCategories = n.GetCollectionOfObjectValues<EducationGradingCategory>(EducationGradingCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                { "gradingSchemes", n => { GradingSchemes = n.GetCollectionOfObjectValues<EducationGradingScheme>(EducationGradingScheme.CreateFromDiscriminatorValue)?.ToList(); } },
                { "submissionAnimationDisabled", n => { SubmissionAnimationDisabled = n.GetBoolValue(); } },
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
            writer.WriteObjectValue<EducationGradingScheme>("defaultGradingScheme", DefaultGradingScheme);
            writer.WriteCollectionOfObjectValues<EducationGradingCategory>("gradingCategories", GradingCategories);
            writer.WriteCollectionOfObjectValues<EducationGradingScheme>("gradingSchemes", GradingSchemes);
            writer.WriteBoolValue("submissionAnimationDisabled", SubmissionAnimationDisabled);
        }
    }
}
