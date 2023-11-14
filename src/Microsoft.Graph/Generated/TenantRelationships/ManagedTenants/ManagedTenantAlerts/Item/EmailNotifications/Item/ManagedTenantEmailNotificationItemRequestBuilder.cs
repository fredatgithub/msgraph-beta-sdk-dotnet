// <auto-generated/>
using Microsoft.Graph.Beta.Models.ManagedTenants;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.TenantRelationships.ManagedTenants.ManagedTenantAlerts.Item.EmailNotifications.Item {
    /// <summary>
    /// Provides operations to manage the emailNotifications property of the microsoft.graph.managedTenants.managedTenantAlert entity.
    /// </summary>
    public class ManagedTenantEmailNotificationItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ManagedTenantEmailNotificationItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedTenantEmailNotificationItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships/managedTenants/managedTenantAlerts/{managedTenantAlert%2Did}/emailNotifications/{managedTenantEmailNotification%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ManagedTenantEmailNotificationItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ManagedTenantEmailNotificationItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/tenantRelationships/managedTenants/managedTenantAlerts/{managedTenantAlert%2Did}/emailNotifications/{managedTenantEmailNotification%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Get emailNotifications from tenantRelationships
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ManagedTenantEmailNotification?> GetAsync(Action<ManagedTenantEmailNotificationItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ManagedTenantEmailNotification> GetAsync(Action<ManagedTenantEmailNotificationItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ManagedTenantEmailNotification>(requestInfo, ManagedTenantEmailNotification.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get emailNotifications from tenantRelationships
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ManagedTenantEmailNotificationItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ManagedTenantEmailNotificationItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new ManagedTenantEmailNotificationItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ManagedTenantEmailNotificationItemRequestBuilder WithUrl(string rawUrl) {
            return new ManagedTenantEmailNotificationItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get emailNotifications from tenantRelationships
        /// </summary>
        public class ManagedTenantEmailNotificationItemRequestBuilderGetQueryParameters {
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
        public class ManagedTenantEmailNotificationItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ManagedTenantEmailNotificationItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ManagedTenantEmailNotificationItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new ManagedTenantEmailNotificationItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ManagedTenantEmailNotificationItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
