using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.DeviceAppManagement.MobileApps.GetMobileAppCountWithStatus {
    /// <summary>
    /// Provides operations to call the getMobileAppCount method.
    /// </summary>
    public class GetMobileAppCountWithStatusRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new GetMobileAppCountWithStatusRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="status">Usage: status=&apos;{status}&apos;</param>
        public GetMobileAppCountWithStatusRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string status = "") : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps/getMobileAppCount(status='{status}')", pathParameters) {
            if (!string.IsNullOrWhiteSpace(status)) PathParameters.Add("status", status);
        }
        /// <summary>
        /// Instantiates a new GetMobileAppCountWithStatusRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetMobileAppCountWithStatusRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceAppManagement/mobileApps/getMobileAppCount(status='{status}')", rawUrl) {
        }
        /// <summary>
        /// Invoke function getMobileAppCount
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<GetMobileAppCountWithStatusResponse?> GetAsync(Action<GetMobileAppCountWithStatusRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<GetMobileAppCountWithStatusResponse> GetAsync(Action<GetMobileAppCountWithStatusRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GetMobileAppCountWithStatusResponse>(requestInfo, GetMobileAppCountWithStatusResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Invoke function getMobileAppCount
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<GetMobileAppCountWithStatusRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<GetMobileAppCountWithStatusRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GetMobileAppCountWithStatusRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class GetMobileAppCountWithStatusRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new getMobileAppCountWithStatusRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetMobileAppCountWithStatusRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
