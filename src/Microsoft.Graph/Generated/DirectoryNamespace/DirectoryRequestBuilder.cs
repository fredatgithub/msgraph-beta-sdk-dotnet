// <auto-generated/>
using Microsoft.Graph.Beta.DirectoryNamespace.AdministrativeUnits;
using Microsoft.Graph.Beta.DirectoryNamespace.AttributeSets;
using Microsoft.Graph.Beta.DirectoryNamespace.CertificateAuthorities;
using Microsoft.Graph.Beta.DirectoryNamespace.CustomSecurityAttributeDefinitions;
using Microsoft.Graph.Beta.DirectoryNamespace.DeletedItems;
using Microsoft.Graph.Beta.DirectoryNamespace.DeviceLocalCredentials;
using Microsoft.Graph.Beta.DirectoryNamespace.FeatureRolloutPolicies;
using Microsoft.Graph.Beta.DirectoryNamespace.FederationConfigurations;
using Microsoft.Graph.Beta.DirectoryNamespace.ImpactedResources;
using Microsoft.Graph.Beta.DirectoryNamespace.InboundSharedUserProfiles;
using Microsoft.Graph.Beta.DirectoryNamespace.OnPremisesSynchronization;
using Microsoft.Graph.Beta.DirectoryNamespace.OutboundSharedUserProfiles;
using Microsoft.Graph.Beta.DirectoryNamespace.Recommendations;
using Microsoft.Graph.Beta.DirectoryNamespace.SharedEmailDomains;
using Microsoft.Graph.Beta.DirectoryNamespace.Subscriptions;
using Microsoft.Graph.Beta.DirectoryNamespace.SubscriptionsWithCommerceSubscriptionId;
using Microsoft.Graph.Beta.DirectoryNamespace.SubscriptionsWithOcpSubscriptionId;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DirectoryNamespace {
    /// <summary>
    /// Provides operations to manage the directory singleton.
    /// </summary>
    public class DirectoryRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the administrativeUnits property of the microsoft.graph.directory entity.</summary>
        public AdministrativeUnitsRequestBuilder AdministrativeUnits { get =>
            new AdministrativeUnitsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the attributeSets property of the microsoft.graph.directory entity.</summary>
        public AttributeSetsRequestBuilder AttributeSets { get =>
            new AttributeSetsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the certificateAuthorities property of the microsoft.graph.directory entity.</summary>
        public CertificateAuthoritiesRequestBuilder CertificateAuthorities { get =>
            new CertificateAuthoritiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the customSecurityAttributeDefinitions property of the microsoft.graph.directory entity.</summary>
        public CustomSecurityAttributeDefinitionsRequestBuilder CustomSecurityAttributeDefinitions { get =>
            new CustomSecurityAttributeDefinitionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deletedItems property of the microsoft.graph.directory entity.</summary>
        public DeletedItemsRequestBuilder DeletedItems { get =>
            new DeletedItemsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deviceLocalCredentials property of the microsoft.graph.directory entity.</summary>
        public DeviceLocalCredentialsRequestBuilder DeviceLocalCredentials { get =>
            new DeviceLocalCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the featureRolloutPolicies property of the microsoft.graph.directory entity.</summary>
        public FeatureRolloutPoliciesRequestBuilder FeatureRolloutPolicies { get =>
            new FeatureRolloutPoliciesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the federationConfigurations property of the microsoft.graph.directory entity.</summary>
        public FederationConfigurationsRequestBuilder FederationConfigurations { get =>
            new FederationConfigurationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the impactedResources property of the microsoft.graph.directory entity.</summary>
        public ImpactedResourcesRequestBuilder ImpactedResources { get =>
            new ImpactedResourcesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the inboundSharedUserProfiles property of the microsoft.graph.directory entity.</summary>
        public InboundSharedUserProfilesRequestBuilder InboundSharedUserProfiles { get =>
            new InboundSharedUserProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onPremisesSynchronization property of the microsoft.graph.directory entity.</summary>
        public OnPremisesSynchronizationRequestBuilder OnPremisesSynchronization { get =>
            new OnPremisesSynchronizationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the outboundSharedUserProfiles property of the microsoft.graph.directory entity.</summary>
        public OutboundSharedUserProfilesRequestBuilder OutboundSharedUserProfiles { get =>
            new OutboundSharedUserProfilesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the recommendations property of the microsoft.graph.directory entity.</summary>
        public RecommendationsRequestBuilder Recommendations { get =>
            new RecommendationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the sharedEmailDomains property of the microsoft.graph.directory entity.</summary>
        public SharedEmailDomainsRequestBuilder SharedEmailDomains { get =>
            new SharedEmailDomainsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the subscriptions property of the microsoft.graph.directory entity.</summary>
        public SubscriptionsRequestBuilder Subscriptions { get =>
            new SubscriptionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new DirectoryRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directory{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DirectoryRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/directory{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Get directory
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DirectoryObject1?> GetAsync(Action<RequestConfiguration<DirectoryRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<DirectoryObject1> GetAsync(Action<RequestConfiguration<DirectoryRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DirectoryObject1>(requestInfo, DirectoryObject1.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update directory
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<DirectoryObject1?> PatchAsync(DirectoryObject1 body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<DirectoryObject1> PatchAsync(DirectoryObject1 body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<DirectoryObject1>(requestInfo, DirectoryObject1.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to manage the subscriptions property of the microsoft.graph.directory entity.
        /// </summary>
        /// <param name="commerceSubscriptionId">Alternate key of companySubscription</param>
        public SubscriptionsWithCommerceSubscriptionIdRequestBuilder SubscriptionsWithCommerceSubscriptionId(string commerceSubscriptionId) {
            if(string.IsNullOrEmpty(commerceSubscriptionId)) throw new ArgumentNullException(nameof(commerceSubscriptionId));
            return new SubscriptionsWithCommerceSubscriptionIdRequestBuilder(PathParameters, RequestAdapter, commerceSubscriptionId);
        }
        /// <summary>
        /// Provides operations to manage the subscriptions property of the microsoft.graph.directory entity.
        /// </summary>
        /// <param name="ocpSubscriptionId">Alternate key of companySubscription</param>
        public SubscriptionsWithOcpSubscriptionIdRequestBuilder SubscriptionsWithOcpSubscriptionId(string ocpSubscriptionId) {
            if(string.IsNullOrEmpty(ocpSubscriptionId)) throw new ArgumentNullException(nameof(ocpSubscriptionId));
            return new SubscriptionsWithOcpSubscriptionIdRequestBuilder(PathParameters, RequestAdapter, ocpSubscriptionId);
        }
        /// <summary>
        /// Get directory
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DirectoryRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DirectoryRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update directory
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(DirectoryObject1 body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(DirectoryObject1 body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DirectoryRequestBuilder WithUrl(string rawUrl) {
            return new DirectoryRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get directory
        /// </summary>
        public class DirectoryRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DirectoryRequestBuilderGetRequestConfiguration : RequestConfiguration<DirectoryRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DirectoryRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
