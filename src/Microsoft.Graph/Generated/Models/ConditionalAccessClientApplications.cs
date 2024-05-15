// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ConditionalAccessClientApplications : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Service principal IDs excluded from the policy scope.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludeServicePrincipals
        {
            get { return BackingStore?.Get<List<string>?>("excludeServicePrincipals"); }
            set { BackingStore?.Set("excludeServicePrincipals", value); }
        }
#nullable restore
#else
        public List<string> ExcludeServicePrincipals
        {
            get { return BackingStore?.Get<List<string>>("excludeServicePrincipals"); }
            set { BackingStore?.Set("excludeServicePrincipals", value); }
        }
#endif
        /// <summary>Service principal IDs included in the policy scope, or ServicePrincipalsInMyTenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IncludeServicePrincipals
        {
            get { return BackingStore?.Get<List<string>?>("includeServicePrincipals"); }
            set { BackingStore?.Set("includeServicePrincipals", value); }
        }
#nullable restore
#else
        public List<string> IncludeServicePrincipals
        {
            get { return BackingStore?.Get<List<string>>("includeServicePrincipals"); }
            set { BackingStore?.Set("includeServicePrincipals", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Filter that defines the dynamic-servicePrincipal-syntax rule to include/exclude service principals. A filter can use custom security attributes to include/exclude service principals.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessFilter? ServicePrincipalFilter
        {
            get { return BackingStore?.Get<ConditionalAccessFilter?>("servicePrincipalFilter"); }
            set { BackingStore?.Set("servicePrincipalFilter", value); }
        }
#nullable restore
#else
        public ConditionalAccessFilter ServicePrincipalFilter
        {
            get { return BackingStore?.Get<ConditionalAccessFilter>("servicePrincipalFilter"); }
            set { BackingStore?.Set("servicePrincipalFilter", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ConditionalAccessClientApplications"/> and sets the default values.
        /// </summary>
        public ConditionalAccessClientApplications()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ConditionalAccessClientApplications"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessClientApplications CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessClientApplications();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "excludeServicePrincipals", n => { ExcludeServicePrincipals = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "includeServicePrincipals", n => { IncludeServicePrincipals = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "servicePrincipalFilter", n => { ServicePrincipalFilter = n.GetObjectValue<ConditionalAccessFilter>(ConditionalAccessFilter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("excludeServicePrincipals", ExcludeServicePrincipals);
            writer.WriteCollectionOfPrimitiveValues<string>("includeServicePrincipals", IncludeServicePrincipals);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<ConditionalAccessFilter>("servicePrincipalFilter", ServicePrincipalFilter);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
