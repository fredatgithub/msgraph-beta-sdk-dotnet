using Microsoft.Graph.Beta.Identity.ApiConnectors;
using Microsoft.Graph.Beta.Identity.AuthenticationEventListeners;
using Microsoft.Graph.Beta.Identity.B2cUserFlows;
using Microsoft.Graph.Beta.Identity.B2xUserFlows;
using Microsoft.Graph.Beta.Identity.ConditionalAccess;
using Microsoft.Graph.Beta.Identity.ContinuousAccessEvaluationPolicy;
using Microsoft.Graph.Beta.Identity.CustomAuthenticationExtensions;
using Microsoft.Graph.Beta.Identity.IdentityProviders;
using Microsoft.Graph.Beta.Identity.UserFlowAttributes;
using Microsoft.Graph.Beta.Identity.UserFlows;
using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.Identity {
    /// <summary>
    /// Provides operations to manage the identityContainer singleton.
    /// </summary>
    public class IdentityRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the apiConnectors property of the microsoft.graph.identityContainer entity.</summary>
        public ApiConnectorsRequestBuilder ApiConnectors { get =>
            new ApiConnectorsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the authenticationEventListeners property of the microsoft.graph.identityContainer entity.</summary>
        public AuthenticationEventListenersRequestBuilder AuthenticationEventListeners { get =>
            new AuthenticationEventListenersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the b2cUserFlows property of the microsoft.graph.identityContainer entity.</summary>
        public B2cUserFlowsRequestBuilder B2cUserFlows { get =>
            new B2cUserFlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the b2xUserFlows property of the microsoft.graph.identityContainer entity.</summary>
        public B2xUserFlowsRequestBuilder B2xUserFlows { get =>
            new B2xUserFlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the conditionalAccess property of the microsoft.graph.identityContainer entity.</summary>
        public ConditionalAccessRequestBuilder ConditionalAccess { get =>
            new ConditionalAccessRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the continuousAccessEvaluationPolicy property of the microsoft.graph.identityContainer entity.</summary>
        public ContinuousAccessEvaluationPolicyRequestBuilder ContinuousAccessEvaluationPolicy { get =>
            new ContinuousAccessEvaluationPolicyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the customAuthenticationExtensions property of the microsoft.graph.identityContainer entity.</summary>
        public CustomAuthenticationExtensionsRequestBuilder CustomAuthenticationExtensions { get =>
            new CustomAuthenticationExtensionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the identityProviders property of the microsoft.graph.identityContainer entity.</summary>
        public IdentityProvidersRequestBuilder IdentityProviders { get =>
            new IdentityProvidersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userFlowAttributes property of the microsoft.graph.identityContainer entity.</summary>
        public UserFlowAttributesRequestBuilder UserFlowAttributes { get =>
            new UserFlowAttributesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the userFlows property of the microsoft.graph.identityContainer entity.</summary>
        public UserFlowsRequestBuilder UserFlows { get =>
            new UserFlowsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new IdentityRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new IdentityRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Get identity
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<IdentityContainer?> GetAsync(Action<IdentityRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<IdentityContainer> GetAsync(Action<IdentityRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<IdentityContainer>(requestInfo, IdentityContainer.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Update identity
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<IdentityContainer?> PatchAsync(IdentityContainer body, Action<IdentityRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<IdentityContainer> PatchAsync(IdentityContainer body, Action<IdentityRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<IdentityContainer>(requestInfo, IdentityContainer.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get identity
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<IdentityRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<IdentityRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new IdentityRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update identity
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(IdentityContainer body, Action<IdentityRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(IdentityContainer body, Action<IdentityRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new IdentityRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get identity
        /// </summary>
        public class IdentityRequestBuilderGetQueryParameters {
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
        public class IdentityRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public IdentityRequestBuilderGetQueryParameters QueryParameters { get; set; } = new IdentityRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new identityRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public IdentityRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class IdentityRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new identityRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public IdentityRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
