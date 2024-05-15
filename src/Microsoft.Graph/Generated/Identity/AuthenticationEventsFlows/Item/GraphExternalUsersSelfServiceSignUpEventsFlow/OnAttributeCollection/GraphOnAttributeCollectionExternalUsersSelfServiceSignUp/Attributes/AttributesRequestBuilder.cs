// <auto-generated/>
using Microsoft.Graph.Beta.Identity.AuthenticationEventsFlows.Item.GraphExternalUsersSelfServiceSignUpEventsFlow.OnAttributeCollection.GraphOnAttributeCollectionExternalUsersSelfServiceSignUp.Attributes.Count;
using Microsoft.Graph.Beta.Identity.AuthenticationEventsFlows.Item.GraphExternalUsersSelfServiceSignUpEventsFlow.OnAttributeCollection.GraphOnAttributeCollectionExternalUsersSelfServiceSignUp.Attributes.Item;
using Microsoft.Graph.Beta.Identity.AuthenticationEventsFlows.Item.GraphExternalUsersSelfServiceSignUpEventsFlow.OnAttributeCollection.GraphOnAttributeCollectionExternalUsersSelfServiceSignUp.Attributes.Ref;
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
namespace Microsoft.Graph.Beta.Identity.AuthenticationEventsFlows.Item.GraphExternalUsersSelfServiceSignUpEventsFlow.OnAttributeCollection.GraphOnAttributeCollectionExternalUsersSelfServiceSignUp.Attributes
{
    /// <summary>
    /// Provides operations to manage the attributes property of the microsoft.graph.onAttributeCollectionExternalUsersSelfServiceSignUp entity.
    /// </summary>
    public class AttributesRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public CountRequestBuilder Count
        {
            get => new CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of identityContainer entities.</summary>
        public RefRequestBuilder Ref
        {
            get => new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Microsoft.Graph.Beta.identity.authenticationEventsFlows.item.graphExternalUsersSelfServiceSignUpEventsFlow.onAttributeCollection.graphOnAttributeCollectionExternalUsersSelfServiceSignUp.attributes.item collection</summary>
        /// <param name="position">The unique identifier of identityUserFlowAttribute</param>
        /// <returns>A <see cref="IdentityUserFlowAttributeItemRequestBuilder"/></returns>
        public IdentityUserFlowAttributeItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("identityUserFlowAttribute%2Did", position);
                return new IdentityUserFlowAttributeItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="AttributesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AttributesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/authenticationEventsFlows/{authenticationEventsFlow%2Did}/graph.externalUsersSelfServiceSignUpEventsFlow/onAttributeCollection/graph.onAttributeCollectionExternalUsersSelfServiceSignUp/attributes{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="AttributesRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AttributesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/authenticationEventsFlows/{authenticationEventsFlow%2Did}/graph.externalUsersSelfServiceSignUpEventsFlow/onAttributeCollection/graph.onAttributeCollectionExternalUsersSelfServiceSignUp/attributes{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Get an identityUserFlowAttribute collection associated with an external identities self-service sign up user flow that&apos;s represented by an externalUsersSelfServiceSignupEventsFlow object. These are the attributes that are collected from the user during the authentication experience that&apos;s defined by the user flow.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/onattributecollectionexternalusersselfservicesignup-list-attributes?view=graph-rest-beta" />
        /// </summary>
        /// <returns>A <see cref="IdentityUserFlowAttributeCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<IdentityUserFlowAttributeCollectionResponse?> GetAsync(Action<RequestConfiguration<AttributesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<IdentityUserFlowAttributeCollectionResponse> GetAsync(Action<RequestConfiguration<AttributesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<IdentityUserFlowAttributeCollectionResponse>(requestInfo, IdentityUserFlowAttributeCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get an identityUserFlowAttribute collection associated with an external identities self-service sign up user flow that&apos;s represented by an externalUsersSelfServiceSignupEventsFlow object. These are the attributes that are collected from the user during the authentication experience that&apos;s defined by the user flow.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AttributesRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AttributesRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="AttributesRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public AttributesRequestBuilder WithUrl(string rawUrl)
        {
            return new AttributesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get an identityUserFlowAttribute collection associated with an external identities self-service sign up user flow that&apos;s represented by an externalUsersSelfServiceSignupEventsFlow object. These are the attributes that are collected from the user during the authentication experience that&apos;s defined by the user flow.
        /// </summary>
        public class AttributesRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class AttributesRequestBuilderGetRequestConfiguration : RequestConfiguration<AttributesRequestBuilderGetQueryParameters>
        {
        }
    }
}
